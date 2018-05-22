using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using GradeReportLib.GradeReport.Core;

namespace SigninLogs_Standalone.Classes
{
    class PrintFormObj
    {
        private SigninLogs sl;
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public Int32 UserId { get; set; }
        protected DataTable dt;
        protected DataTable FormattedDataTable;

        private AcroFields pdfFormFields;
        private PdfReader pdfReader;
        private PdfStamper pdfStamper;

        private String Ecode { get; set; }
        private String Ename { get; set; }

        private DateTime dtBegin1_1;
        private DateTime dtBegin1_2;

        private DateTime dtBegin2_1;
        private DateTime dtBegin2_2;

        private DataRow dtRow;

        private double TotalHoursWeek1 { get; set; }
        private double TotalHoursWeek2 { get; set; }

        public PrintFormObj()
        {
            sl = new SigninLogs();
            dt = new DataTable();
        }

        public void Setup()
        {
            if (sl != null)
            {
                dtBegin1_1 = BeginDate;
                dtBegin2_2 = EndDate;

                dt = sl.GetWorksheet(BeginDate, EndDate);

                Ecode = Convert.ToString(CoreUtils.GetSetting(CoreEnums.Settings.Standalone_Signin_EmployeeCode));
                Ename = Convert.ToString(CoreUtils.GetSetting(CoreEnums.Settings.Standalone_Signin_EmployeeName));

                CalculateDates();
                AddColumns();
            }
        }

        private void AddColumns()
        {
            FormattedDataTable = new DataTable();
            if (FormattedDataTable != null)
            {
                FormattedDataTable.Columns.Add("BeginDate");
                FormattedDataTable.Columns.Add("EndDate");
                FormattedDataTable.Columns.Add("TotalHours_Week1");
                FormattedDataTable.Columns.Add("TotalHours_Week2");

                FormattedDataTable.Columns.Add("Thursday_1");
                FormattedDataTable.Columns.Add("Friday_1");
                FormattedDataTable.Columns.Add("Saturday_1");
                FormattedDataTable.Columns.Add("Sunday_1");
                FormattedDataTable.Columns.Add("Monday_1");
                FormattedDataTable.Columns.Add("Tuesday_1");
                FormattedDataTable.Columns.Add("Wednesday_1");

                FormattedDataTable.Columns.Add("Thursday_2");
                FormattedDataTable.Columns.Add("Friday_2");
                FormattedDataTable.Columns.Add("Saturday_2");
                FormattedDataTable.Columns.Add("Sunday_2");
                FormattedDataTable.Columns.Add("Monday_2");
                FormattedDataTable.Columns.Add("Tuesday_2");
                FormattedDataTable.Columns.Add("Wednesday_2");

                dtRow = FormattedDataTable.NewRow();
                dtRow["BeginDate"] = dtBegin1_1;
                dtRow["EndDate"] = dtBegin2_2;
            }
        }

        private void CalculateDates()
        {
            dtBegin1_2 = dtBegin1_1.AddDays(6);
            dtBegin2_1 = dtBegin2_2.AddDays(-6);
        }

        public void Print()
        {
            try
            {
                String pdfTemp = CoreUtils.GetSetting(CoreEnums.Settings.Standalone_Signin_FormsDir).ToString() + "Blank_Timesheet.pdf";
                String newFile = CoreUtils.GetSetting(CoreEnums.Settings.Standalone_Signin_OutputDir).ToString() + "Timesheet-" + BeginDate.ToString("MM-dd-yyyy") + "-" + EndDate.ToString("MM-dd-yyyy") + ".pdf";

                pdfReader = new PdfReader(pdfTemp);
                pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
                pdfFormFields = pdfStamper.AcroFields;

                pdfFormFields.SetField("EID", Ecode);
                pdfFormFields.SetField("EmpName", Ename);
                pdfFormFields.SetField("PayPeriodEnd", EndDate.ToString("MM-dd-yyyy"));
                pdfFormFields.SetField("Begin1_1", dtBegin1_1.ToString("MM-dd-yyyy"));
                pdfFormFields.SetField("Begin1_2", dtBegin1_2.ToString("MM-dd-yyyy"));
                pdfFormFields.SetField("Begin2_1", dtBegin2_1.ToString("MM-dd-yyyy"));
                pdfFormFields.SetField("Begin2_2", dtBegin2_2.ToString("MM-dd-yyyy"));

                DateTime cBeginDate = BeginDate;

                while (cBeginDate <= EndDate)
                {
                    string RowName = cBeginDate.ToString("dddd") + "_" + WhichWeek(cBeginDate);
                    Double hours = CalculateHours(cBeginDate);

                    if (cBeginDate <= dtBegin1_2)
                    {
                        TotalHoursWeek1 += hours;
                    }else
                    {
                        TotalHoursWeek2 += hours;
                    }

                    pdfFormFields.SetField(RowName, hours.ToString());
                    cBeginDate = cBeginDate.AddDays(1);
                }

                pdfFormFields.SetField("RegTotal1", Convert.ToString(TotalHoursWeek1));
                pdfFormFields.SetField("RegTotal2", Convert.ToString(TotalHoursWeek2));

                FormattedDataTable.Rows.Add(dtRow);
                pdfStamper.Close();
                CoreUtils.ShowMessage("Sign-In Logs", "PDF Printed", CoreEnums.ErrorType.Notice);
            }
            catch(Exception e)
            {
                CoreUtils.ShowMessage("Sign In Logs", e.Message);
            }

        }

        private double CalculateHours(DateTime myDate)
        {
            DataRow[] dr = dt.Select("signindate='" + myDate + "'");
            Double hours = 0;
            
           foreach(DataRow item in dr)
            {
                DateTime dateOne = DateTime.Parse(Convert.ToString(item["intime"]));
                DateTime dateTwo = DateTime.Parse(Convert.ToString(item["outtime"]));
                TimeSpan ts = dateTwo.Subtract(dateOne);

                if (ts.Hours == 0)
                {
                    hours += ts.Minutes / 60;
                }else
                {
                    hours += ts.Hours;
                }
            }

            return hours;
        }

        private Int32 WhichWeek(DateTime dt)
        {
            if (dt < dtBegin2_1)
            {
                return 1;
            }

            return 2;
        }
    }

}
