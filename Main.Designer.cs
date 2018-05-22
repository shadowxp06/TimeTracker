namespace SigninLogs_Standalone
{
    partial class Main
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.cmdModifySignIn = new System.Windows.Forms.Button();
            this.cmdAddSignIn = new System.Windows.Forms.Button();
            this.cmdSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(174, 102);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(141, 69);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print Form";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmdModifySignIn
            // 
            this.cmdModifySignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModifySignIn.Location = new System.Drawing.Point(12, 102);
            this.cmdModifySignIn.Name = "cmdModifySignIn";
            this.cmdModifySignIn.Size = new System.Drawing.Size(141, 69);
            this.cmdModifySignIn.TabIndex = 6;
            this.cmdModifySignIn.Text = "Modify Sign-In";
            this.cmdModifySignIn.UseVisualStyleBackColor = true;
            // 
            // cmdAddSignIn
            // 
            this.cmdAddSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddSignIn.Location = new System.Drawing.Point(173, 12);
            this.cmdAddSignIn.Name = "cmdAddSignIn";
            this.cmdAddSignIn.Size = new System.Drawing.Size(141, 69);
            this.cmdAddSignIn.TabIndex = 5;
            this.cmdAddSignIn.Text = "Add Sign-In";
            this.cmdAddSignIn.UseVisualStyleBackColor = true;
            this.cmdAddSignIn.Click += new System.EventHandler(this.cmdAddSignIn_Click);
            // 
            // cmdSignIn
            // 
            this.cmdSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSignIn.Location = new System.Drawing.Point(12, 12);
            this.cmdSignIn.Name = "cmdSignIn";
            this.cmdSignIn.Size = new System.Drawing.Size(141, 69);
            this.cmdSignIn.TabIndex = 4;
            this.cmdSignIn.Text = "Sign-In / Sign-Out";
            this.cmdSignIn.UseVisualStyleBackColor = true;
            this.cmdSignIn.Click += new System.EventHandler(this.cmdSignIn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 186);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cmdModifySignIn);
            this.Controls.Add(this.cmdAddSignIn);
            this.Controls.Add(this.cmdSignIn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Timesheet Tracking";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.Button cmdModifySignIn;
        internal System.Windows.Forms.Button cmdAddSignIn;
        internal System.Windows.Forms.Button cmdSignIn;
    }
}

