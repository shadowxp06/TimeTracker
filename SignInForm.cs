using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SigninLogs_Standalone.Classes;
using GradeReportLib.GradeReport.Core;

namespace SigninLogs_Standalone
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SigninLogs obj = new SigninLogs();
            obj.UserId = -1;
            obj.SignedIn = chkSignedIn.Checked;
            obj.SignInDate = dtSignInDate.Value.Date;
            obj.InTime = dtSignIn.Value;
            obj.OutTime = dtSignOut.Value;
            obj.Insert();
            CoreUtils.ShowMessage("Sign In Logs", "Log Inserted.", CoreEnums.ErrorType.Notice);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
