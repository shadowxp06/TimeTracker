using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigninLogs_Standalone.Classes
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PrintFormObj obj = new PrintFormObj();
            obj.BeginDate = dtSignIn.Value.Date;
            obj.EndDate = dtSignOut.Value.Date;
            obj.UserId = -1;
            obj.Setup();
            obj.Print();
        }
    }
}
