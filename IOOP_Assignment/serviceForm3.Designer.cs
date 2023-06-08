namespace IOOP_Assignment
{
    partial class frmReport
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
            this.reportList = new System.Windows.Forms.ListBox();
            this.monthCmb = new System.Windows.Forms.ComboBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportList
            // 
            this.reportList.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportList.FormattingEnabled = true;
            this.reportList.ItemHeight = 20;
            this.reportList.Items.AddRange(new object[] {
            "Service Report"});
            this.reportList.Location = new System.Drawing.Point(350, 64);
            this.reportList.Name = "reportList";
            this.reportList.Size = new System.Drawing.Size(328, 284);
            this.reportList.TabIndex = 0;
            // 
            // monthCmb
            // 
            this.monthCmb.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthCmb.FormattingEnabled = true;
            this.monthCmb.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthCmb.Location = new System.Drawing.Point(59, 64);
            this.monthCmb.Name = "monthCmb";
            this.monthCmb.Size = new System.Drawing.Size(151, 28);
            this.monthCmb.TabIndex = 1;
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.generateBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateBtn.Location = new System.Drawing.Point(276, 404);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(108, 34);
            this.generateBtn.TabIndex = 2;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(733, 481);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.monthCmb);
            this.Controls.Add(this.reportList);
            this.Name = "frmReport";
            this.Text = "Service Report";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox reportList;
        private ComboBox monthCmb;
        private Button generateBtn;
    }
}