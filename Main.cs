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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void cmdSignIn_Click(object sender, EventArgs e)
        {
            SigninLogs signIn = new SigninLogs();
            if (signIn.IsUserSignedIn(DateTime.Now, -1)) {
                signIn.ReadBySignInDate(DateTime.Now, -1);
                signIn.OutTime = DateTime.Now;
                signIn.SignedIn = false;
                signIn.Update();
                CoreUtils.ShowMessage("Sign In Logs", "You are now signed out.", CoreEnums.ErrorType.Notice);
            }else
            {
                signIn.UserId = -1;
                signIn.SignedIn = true;
                signIn.SignInDate = DateTime.Now;
                signIn.InTime = DateTime.Now;
                signIn.OutTime = DateTime.Now;
                signIn.Insert();
                CoreUtils.ShowMessage("Sign In Logs", "You are now signed in.", CoreEnums.ErrorType.Notice);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintForm prt = new PrintForm();
            prt.Show();
        }

        private void cmdAddSignIn_Click(object sender, EventArgs e)
        {
            SignInForm signInFrm = new SignInForm();
            signInFrm.Show();
        }
    }
}
