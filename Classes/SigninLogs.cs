using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeReportLib.GradeReport.V3;
using GradeReportLib.GradeReport.Core;
using System.Data;
using System.Text;
/*  5-20-2018: Initial Version 
 
  */
namespace SigninLogs_Standalone.Classes
{
    class SigninLogs : ClassObj
    {
        public int UserId { get; set; }
        public DateTime SignInDate { get; set; }
        public bool SignedIn { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }

        public SigninLogs() : base() {
            BuildParameters();
            m_tableName = "SignInLogs";

            BuildDT();
            BuildModDT();
            m_supressUpdateMessage = true;
            UpdateMessage = "Sign-In Updated.";
        }

        protected override void BuildParameters()
        {
            base.BuildParameters();
            SQLParam sqlparam = new SQLParam();
            sqlparam.Name = "@UserID";
            sqlparam.Type = System.Data.SqlDbType.Int;
            sqlparam.Value = UserId.ToString();
            sqlparam.IntValue = UserId;
            sqlparam.ColumnName = "UserID";
            m_sql.parameters.Add(sqlparam);

            sqlparam = new SQLParam();
            sqlparam.Name = "@SignInDate";
            sqlparam.Type = SqlDbType.Date;
            sqlparam.Value = SignInDate.ToString("yyyy-mm-dd");
            sqlparam.dtValue = SignInDate;
            sqlparam.ColumnName = "SignInDate";
            sqlparam.IncludeInModDT = true;
            m_sql.parameters.Add(sqlparam);

            sqlparam = new SQLParam();
            sqlparam.Name = "@SignedIn";
            sqlparam.Type = SqlDbType.Bit;
            sqlparam.Value = SignedIn.ToString();
            if (SignedIn)
            {
                sqlparam.IntValue = 1;
            }else
            {
                sqlparam.IntValue = 0;
            }
            sqlparam.ColumnName = "SignedIn";
            sqlparam.IncludeInModDT = false;
            m_sql.parameters.Add(sqlparam);

            sqlparam = new SQLParam();
            sqlparam.Name = "@InTime";
            sqlparam.Type = SqlDbType.DateTime;
            sqlparam.Value = InTime.ToString();
            sqlparam.dtValue = InTime;
            sqlparam.ColumnName = "InTime";
            sqlparam.IncludeInModDT = false;
            m_sql.parameters.Add(sqlparam);

            sqlparam = new SQLParam();
            sqlparam.Name = "@OutTime";
            sqlparam.Type = SqlDbType.DateTime;
            sqlparam.Value = OutTime.ToString();
            sqlparam.dtValue = OutTime;
            sqlparam.ColumnName = "OutTime";
            sqlparam.IncludeInModDT = false;
            m_sql.parameters.Add(sqlparam);

            if (m_IncludeIDInParameters)
            {
                sqlparam = new SQLParam();
                sqlparam.Name = "@ID";
                sqlparam.Type = SqlDbType.Int;
                sqlparam.Value = Convert.ToString(ID);
                sqlparam.IntValue = ID;
                sqlparam.ColumnName = m_primarykey;
                sqlparam.IsPrimaryKey = true;
                sqlparam.IncludeInModDT = true;
                m_sql.parameters.Add(sqlparam);

            }
        }

        public override void Read(int id)
        {
            base.Read(id);
            if (m_readdt != null && m_readdt.Rows.Count > 0)
            {
                base.m_id = Convert.ToInt32(m_readdt.Rows[0]["ID"]);
                UserId = Convert.ToInt32(m_readdt.Rows[0]["userid"]);
                SignInDate = Convert.ToDateTime(m_readdt.Rows[0]["signindate"]);
                SignedIn = Convert.ToBoolean(m_readdt.Rows[0]["signedin"]);
                InTime = Convert.ToDateTime(m_readdt.Rows[0]["intime"]);
                OutTime = Convert.ToDateTime(m_readdt.Rows[0]["outtime"]);
            }
        }

        public override global::Newtonsoft.Json.Linq.JObject ExportToJSON()
        {
            throw new NotImplementedException();
        }

        public override void Insert()
        {
            Validate();
            if (!hasErrors)
            {
                DataRow dr = m_dt.NewRow();
                dr["userid"] = UserId;
                dr["signindate"] = SignInDate;
                dr["signedin"] = SignedIn;
                dr["intime"] = InTime;
                dr["outtime"] = OutTime;

                m_dt.Rows.Add(dr);
                BuildParameters();
                m_sql.Insert(m_dt, m_tableName);
            }
        }

        public DataTable GetWorksheet(DateTime StartDate, DateTime EndDate)
        {
            InTime = StartDate;
            OutTime = EndDate;
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(" SELECT * from {0} WHERE ", m_tableName);
            sql.AppendFormat(" signindate between @InTime and @OutTime ");
            BuildParameters();
            return m_sql.ExecuteQuery(sql.ToString());
        }

        public bool IsUserSignedIn(DateTime dt, Int32 UserId)
        {
            SignInDate = dt;
            InTime = DateTime.Now;
            OutTime = DateTime.Now;
            this.UserId = UserId;

            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("SELECT Count(*) from {0} where userid={1} and signindate=@SignInDate and signedin=1", m_tableName, this.UserId);
            BuildParameters();

            DataTable data = m_sql.ExecuteQuery(sql.ToString());
            if (data != null && data.Rows.Count > 0)
            {
                Int32 count = Convert.ToInt32(data.Rows[0][0]);
                if (count > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public void ReadBySignInDate(DateTime dt, Int32 userid)
        {
            SignInDate = dt;
            UserId = userid;

            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("SELECT ID from {0} where userid=@userid and signindate=@SignInDate and signedin=1", m_tableName);
            BuildParameters();

            DataTable data = m_sql.ExecuteQuery(sql.ToString());
            if (data != null && data.Rows.Count > 0)
            {
                if (data.Rows.Count > 1)
                {
                    CoreUtils.ShowMessage("Sign In Logs", "There appears to be more than 1 current sign-in for today's date, please go into Modify and correct this.");
                    return;
                }

                Int32 id = Convert.ToInt32(data.Rows[0][0]);
                if (id > 0)
                {
                    Read(id);
                }
            } 
        }
 
        public override void Validate()
        {
            if (SignInDate == DateTime.MinValue)
            {
                CoreUtils.ShowMessage("Sign In Logs", "Sign In Date is missing.");
                hasErrors = true;
                return;
            }

            if (InTime == DateTime.MinValue)
            {
                CoreUtils.ShowMessage("Sign In Logs", "In Time is missing.");
                hasErrors = true;
                return;
            }

            if (m_isUpdate)
            {
                if (OutTime == DateTime.MinValue)
                {
                    CoreUtils.ShowMessage("Sign In Logs", "Out Time is missing");
                    hasErrors = true;
                    return;
                }
            }
        }
    }
}
