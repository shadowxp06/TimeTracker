namespace SigninLogs_Standalone
{
    partial class SignInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtSignOut = new System.Windows.Forms.DateTimePicker();
            this.dtSignIn = new System.Windows.Forms.DateTimePicker();
            this.dtSignInDate = new System.Windows.Forms.DateTimePicker();
            this.chkSignedIn = new System.Windows.Forms.CheckBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtSignOut
            // 
            this.dtSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtSignOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtSignOut.Location = new System.Drawing.Point(170, 144);
            this.dtSignOut.Name = "dtSignOut";
            this.dtSignOut.Size = new System.Drawing.Size(218, 26);
            this.dtSignOut.TabIndex = 69;
            // 
            // dtSignIn
            // 
            this.dtSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtSignIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtSignIn.Location = new System.Drawing.Point(170, 92);
            this.dtSignIn.Name = "dtSignIn";
            this.dtSignIn.Size = new System.Drawing.Size(218, 26);
            this.dtSignIn.TabIndex = 68;
            // 
            // dtSignInDate
            // 
            this.dtSignInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtSignInDate.Location = new System.Drawing.Point(170, 8);
            this.dtSignInDate.Name = "dtSignInDate";
            this.dtSignInDate.Size = new System.Drawing.Size(218, 26);
            this.dtSignInDate.TabIndex = 67;
            // 
            // chkSignedIn
            // 
            this.chkSignedIn.AutoSize = true;
            this.chkSignedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkSignedIn.Location = new System.Drawing.Point(170, 55);
            this.chkSignedIn.Name = "chkSignedIn";
            this.chkSignedIn.Size = new System.Drawing.Size(15, 14);
            this.chkSignedIn.TabIndex = 66;
            this.chkSignedIn.UseVisualStyleBackColor = true;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(12, 55);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(103, 20);
            this.Label5.TabIndex = 65;
            this.Label5.Text = "Is Signed In?";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Location = new System.Drawing.Point(170, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 37);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOK.Location = new System.Drawing.Point(16, 183);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(138, 37);
            this.btnOK.TabIndex = 63;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(12, 144);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(114, 20);
            this.Label4.TabIndex = 62;
            this.Label4.Text = "Sign-Out Time:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(12, 98);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(102, 20);
            this.Label3.TabIndex = 61;
            this.Label3.Text = "Sign-In Time:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(12, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(103, 20);
            this.Label2.TabIndex = 60;
            this.Label2.Text = "Sign-In Date:";
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 232);
            this.Controls.Add(this.dtSignOut);
            this.Controls.Add(this.dtSignIn);
            this.Controls.Add(this.dtSignInDate);
            this.Controls.Add(this.chkSignedIn);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Name = "SignInForm";
            this.Text = "Timesheet Tracking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker dtSignOut;
        internal System.Windows.Forms.DateTimePicker dtSignIn;
        internal System.Windows.Forms.DateTimePicker dtSignInDate;
        internal System.Windows.Forms.CheckBox chkSignedIn;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
    }
}