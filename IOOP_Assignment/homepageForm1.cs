namespace IOOP_Assignment
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void technicianLbl_Click(object sender, EventArgs e)
        {

        }

        private void technicianBtn_Click(object sender, EventArgs e)
        {
            frmRegTechRecep f2 = new frmRegTechRecep();
            f2.Show();
        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            frmReport f3 = new frmReport();
            f3.Show();
        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            frmIncome f4 = new frmIncome();
            f4.Show();
        }
    }
}