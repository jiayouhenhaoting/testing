namespace IOOP_Assignment
{
    partial class frmAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.technicianReceptionistBtn = new System.Windows.Forms.Button();
            this.serviceBtn = new System.Windows.Forms.Button();
            this.incomeBtn = new System.Windows.Forms.Button();
            this.technicianLbl = new System.Windows.Forms.Label();
            this.reportLbl = new System.Windows.Forms.Label();
            this.incomeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // technicianReceptionistBtn
            // 
            this.technicianReceptionistBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.technicianReceptionistBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.technicianReceptionistBtn.Location = new System.Drawing.Point(71, 56);
            this.technicianReceptionistBtn.Name = "technicianReceptionistBtn";
            this.technicianReceptionistBtn.Size = new System.Drawing.Size(120, 109);
            this.technicianReceptionistBtn.TabIndex = 1;
            this.technicianReceptionistBtn.Text = "Register New Technician/ Receptionist";
            this.technicianReceptionistBtn.UseVisualStyleBackColor = false;
            this.technicianReceptionistBtn.Click += new System.EventHandler(this.technicianBtn_Click);
            // 
            // serviceBtn
            // 
            this.serviceBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.serviceBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serviceBtn.Location = new System.Drawing.Point(71, 228);
            this.serviceBtn.Name = "serviceBtn";
            this.serviceBtn.Size = new System.Drawing.Size(120, 77);
            this.serviceBtn.TabIndex = 3;
            this.serviceBtn.Text = "Service Report";
            this.serviceBtn.UseVisualStyleBackColor = false;
            this.serviceBtn.Click += new System.EventHandler(this.serviceBtn_Click);
            // 
            // incomeBtn
            // 
            this.incomeBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.incomeBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incomeBtn.Location = new System.Drawing.Point(71, 378);
            this.incomeBtn.Name = "incomeBtn";
            this.incomeBtn.Size = new System.Drawing.Size(120, 71);
            this.incomeBtn.TabIndex = 4;
            this.incomeBtn.Text = "Total Income";
            this.incomeBtn.UseVisualStyleBackColor = false;
            this.incomeBtn.Click += new System.EventHandler(this.incomeBtn_Click);
            // 
            // technicianLbl
            // 
            this.technicianLbl.AutoSize = true;
            this.technicianLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.technicianLbl.Location = new System.Drawing.Point(218, 103);
            this.technicianLbl.Name = "technicianLbl";
            this.technicianLbl.Size = new System.Drawing.Size(299, 20);
            this.technicianLbl.TabIndex = 5;
            this.technicianLbl.Text = "To register new technician/ receptionist";
            this.technicianLbl.Click += new System.EventHandler(this.technicianLbl_Click);
            // 
            // reportLbl
            // 
            this.reportLbl.AutoSize = true;
            this.reportLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.reportLbl.Location = new System.Drawing.Point(218, 256);
            this.reportLbl.Name = "reportLbl";
            this.reportLbl.Size = new System.Drawing.Size(241, 20);
            this.reportLbl.TabIndex = 7;
            this.reportLbl.Text = "View the monthly service report";
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.incomeLbl.Location = new System.Drawing.Point(218, 401);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(231, 20);
            this.incomeLbl.TabIndex = 8;
            this.incomeLbl.Text = "View the monthly total income";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(785, 505);
            this.Controls.Add(this.incomeLbl);
            this.Controls.Add(this.reportLbl);
            this.Controls.Add(this.technicianLbl);
            this.Controls.Add(this.incomeBtn);
            this.Controls.Add(this.serviceBtn);
            this.Controls.Add(this.technicianReceptionistBtn);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button technicianReceptionistBtn;
        private Button serviceBtn;
        private Button incomeBtn;
        private Label technicianLbl;
        private Label reportLbl;
        private Label incomeLbl;
    }
}