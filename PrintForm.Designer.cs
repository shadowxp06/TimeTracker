namespace SigninLogs_Standalone.Classes
{
    partial class PrintForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtSignOut
            // 
            this.dtSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtSignOut.Location = new System.Drawing.Point(100, 58);
            this.dtSignOut.Name = "dtSignOut";
            this.dtSignOut.Size = new System.Drawing.Size(272, 26);
            this.dtSignOut.TabIndex = 69;
            // 
            // dtSignIn
            // 
            this.dtSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtSignIn.Location = new System.Drawing.Point(100, 6);
            this.dtSignIn.Name = "dtSignIn";
            this.dtSignIn.Size = new System.Drawing.Size(272, 26);
            this.dtSignIn.TabIndex = 68;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Location = new System.Drawing.Point(170, 94);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 37);
            this.btnCancel.TabIndex = 67;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOK.Location = new System.Drawing.Point(12, 94);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(138, 37);
            this.btnOK.TabIndex = 66;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(7, 58);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(81, 20);
            this.Label4.TabIndex = 65;
            this.Label4.Text = "End Date:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(7, 12);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(87, 20);
            this.Label3.TabIndex = 64;
            this.Label3.Text = "Start Date:";
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 143);
            this.Controls.Add(this.dtSignOut);
            this.Controls.Add(this.dtSignIn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker dtSignOut;
        internal System.Windows.Forms.DateTimePicker dtSignIn;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
    }
}