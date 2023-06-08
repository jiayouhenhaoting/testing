namespace IOOP_Assignment
{
    partial class frmRegTechRecep
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
            this.registerBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.stateLbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.postcodeLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.stateTxt = new System.Windows.Forms.TextBox();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.RichTextBox();
            this.occupationLbl = new System.Windows.Forms.Label();
            this.occupationCmb = new System.Windows.Forms.ComboBox();
            this.displayList = new System.Windows.Forms.ListBox();
            this.phoneTxt = new System.Windows.Forms.MaskedTextBox();
            this.postcodeTxt = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.registerBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerBtn.Location = new System.Drawing.Point(505, 268);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(109, 37);
            this.registerBtn.TabIndex = 1;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.Location = new System.Drawing.Point(63, 52);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(88, 20);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Full Name:";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneLbl.Location = new System.Drawing.Point(63, 105);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(123, 20);
            this.phoneLbl.TabIndex = 3;
            this.phoneLbl.Text = "Phone Number:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressLbl.Location = new System.Drawing.Point(59, 174);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(71, 20);
            this.addressLbl.TabIndex = 4;
            this.addressLbl.Text = "Address:";
            this.addressLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // stateLbl
            // 
            this.stateLbl.AutoSize = true;
            this.stateLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stateLbl.Location = new System.Drawing.Point(63, 328);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(49, 20);
            this.stateLbl.TabIndex = 5;
            this.stateLbl.Text = "State:";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLbl.Location = new System.Drawing.Point(440, 52);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(43, 20);
            this.cityLbl.TabIndex = 6;
            this.cityLbl.Text = "City:";
            // 
            // postcodeLbl
            // 
            this.postcodeLbl.AutoSize = true;
            this.postcodeLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postcodeLbl.Location = new System.Drawing.Point(440, 101);
            this.postcodeLbl.Name = "postcodeLbl";
            this.postcodeLbl.Size = new System.Drawing.Size(79, 20);
            this.postcodeLbl.TabIndex = 7;
            this.postcodeLbl.Text = "Postcode:";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTxt.Location = new System.Drawing.Point(157, 52);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(125, 28);
            this.nameTxt.TabIndex = 8;
            // 
            // stateTxt
            // 
            this.stateTxt.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stateTxt.Location = new System.Drawing.Point(138, 325);
            this.stateTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stateTxt.Name = "stateTxt";
            this.stateTxt.Size = new System.Drawing.Size(125, 28);
            this.stateTxt.TabIndex = 11;
            // 
            // cityTxt
            // 
            this.cityTxt.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityTxt.Location = new System.Drawing.Point(489, 52);
            this.cityTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(125, 28);
            this.cityTxt.TabIndex = 12;
            // 
            // addressTxt
            // 
            this.addressTxt.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressTxt.Location = new System.Drawing.Point(138, 171);
            this.addressTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(176, 135);
            this.addressTxt.TabIndex = 14;
            this.addressTxt.Text = "";
            // 
            // occupationLbl
            // 
            this.occupationLbl.AutoSize = true;
            this.occupationLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.occupationLbl.Location = new System.Drawing.Point(440, 161);
            this.occupationLbl.Name = "occupationLbl";
            this.occupationLbl.Size = new System.Drawing.Size(95, 20);
            this.occupationLbl.TabIndex = 15;
            this.occupationLbl.Text = "Occupation:";
            // 
            // occupationCmb
            // 
            this.occupationCmb.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.occupationCmb.FormattingEnabled = true;
            this.occupationCmb.Items.AddRange(new object[] {
            "Technician",
            "Receptionist"});
            this.occupationCmb.Location = new System.Drawing.Point(541, 158);
            this.occupationCmb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.occupationCmb.Name = "occupationCmb";
            this.occupationCmb.Size = new System.Drawing.Size(151, 28);
            this.occupationCmb.TabIndex = 16;
            this.occupationCmb.SelectedIndexChanged += new System.EventHandler(this.occupationTxt_SelectedIndexChanged);
            // 
            // displayList
            // 
            this.displayList.FormattingEnabled = true;
            this.displayList.ItemHeight = 20;
            this.displayList.Location = new System.Drawing.Point(332, 352);
            this.displayList.Name = "displayList";
            this.displayList.Size = new System.Drawing.Size(623, 204);
            this.displayList.TabIndex = 17;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(192, 102);
            this.phoneTxt.Mask = "0000000000";
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(125, 27);
            this.phoneTxt.TabIndex = 18;
            this.phoneTxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // postcodeTxt
            // 
            this.postcodeTxt.Location = new System.Drawing.Point(525, 98);
            this.postcodeTxt.Mask = "00000";
            this.postcodeTxt.Name = "postcodeTxt";
            this.postcodeTxt.Size = new System.Drawing.Size(125, 27);
            this.postcodeTxt.TabIndex = 19;
            this.postcodeTxt.ValidatingType = typeof(int);
            // 
            // frmRegTechRecep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(776, 469);
            this.Controls.Add(this.postcodeTxt);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.displayList);
            this.Controls.Add(this.occupationCmb);
            this.Controls.Add(this.occupationLbl);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.cityTxt);
            this.Controls.Add(this.stateTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.postcodeLbl);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.stateLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.registerBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRegTechRecep";
            this.Text = "Register New Technician and Receptionist";
            this.Load += new System.EventHandler(this.frmRegTech_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button registerBtn;
        private Label nameLbl;
        private Label phoneLbl;
        private Label addressLbl;
        private Label stateLbl;
        private Label cityLbl;
        private Label postcodeLbl;
        private TextBox nameTxt;
        private TextBox stateTxt;
        private TextBox cityTxt;
        private RichTextBox addressTxt;
        private Label occupationLbl;
        private ComboBox occupationCmb;
        private ListBox displayList;
        private MaskedTextBox phoneTxt;
        private MaskedTextBox postcodeTxt;
    }
}