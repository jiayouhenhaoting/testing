namespace IOOP_Assignment
{
    partial class frmIncome
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
            this.monthCmb = new System.Windows.Forms.ComboBox();
            this.incomeList = new System.Windows.Forms.ListBox();
            this.totalIncomeLbl = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.displayLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.monthCmb.Location = new System.Drawing.Point(81, 74);
            this.monthCmb.Name = "monthCmb";
            this.monthCmb.Size = new System.Drawing.Size(151, 28);
            this.monthCmb.TabIndex = 0;
            // 
            // incomeList
            // 
            this.incomeList.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incomeList.FormattingEnabled = true;
            this.incomeList.ItemHeight = 20;
            this.incomeList.Items.AddRange(new object[] {
            "Each Income"});
            this.incomeList.Location = new System.Drawing.Point(340, 74);
            this.incomeList.Name = "incomeList";
            this.incomeList.Size = new System.Drawing.Size(345, 264);
            this.incomeList.TabIndex = 1;
            // 
            // totalIncomeLbl
            // 
            this.totalIncomeLbl.AutoSize = true;
            this.totalIncomeLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalIncomeLbl.Location = new System.Drawing.Point(81, 388);
            this.totalIncomeLbl.Name = "totalIncomeLbl";
            this.totalIncomeLbl.Size = new System.Drawing.Size(109, 20);
            this.totalIncomeLbl.TabIndex = 2;
            this.totalIncomeLbl.Text = "Total Income:";
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.generateBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generateBtn.Location = new System.Drawing.Point(267, 429);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(107, 35);
            this.generateBtn.TabIndex = 3;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // displayLbl
            // 
            this.displayLbl.AutoSize = true;
            this.displayLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayLbl.Location = new System.Drawing.Point(196, 388);
            this.displayLbl.Name = "displayLbl";
            this.displayLbl.Size = new System.Drawing.Size(0, 20);
            this.displayLbl.TabIndex = 4;
            this.displayLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(697, 512);
            this.Controls.Add(this.displayLbl);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.totalIncomeLbl);
            this.Controls.Add(this.incomeList);
            this.Controls.Add(this.monthCmb);
            this.Name = "frmIncome";
            this.Text = "Total Income";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox monthCmb;
        private ListBox incomeList;
        private Label totalIncomeLbl;
        private Button generateBtn;
        private Label displayLbl;
    }
}