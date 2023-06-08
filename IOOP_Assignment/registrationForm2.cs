using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class frmRegTechRecep : Form
    {
        
        public frmRegTechRecep()
        {
            InitializeComponent();
        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void occupationTxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRegTech_Load(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            int counter = 0;

            if (nameTxt.Text == "")
            {
                counter = 0;
                MessageBox.Show("please enter the name!");
            }
            else
            {
                counter++;
            }
            if (phoneTxt.Text == "" )
            {
                counter = 0;
                MessageBox.Show("Please enter the phone number!");
            }
            else if(phoneTxt.Text.Length < 9)
            {
                counter = 0;
                MessageBox.Show("Check the phone number if there are less some digit!");
            }
            else
            {
                counter++;
            }
            if (addressTxt.Text == "")
            {
                counter = 0;
                MessageBox.Show("Please enter the address!");
            }
            else
            {
                counter++;
            }
            if (stateTxt.Text == "")
            {
                counter = 0;
                MessageBox.Show("Please enter the state!");
            }
            else
            {
                counter++;
            }
            if (cityTxt.Text == "")
            {
                counter = 0;
                MessageBox.Show("Please enter the city");
            }
            else
            {
                counter++;
            }
            if (postcodeTxt.Text == "")
            {
                counter = 0;
                MessageBox.Show("Please enter the postcode!");
            }
            else
            {
                counter++;
            }

            if (occupationCmb.Text == "")
            {
                counter = 0;
                MessageBox.Show("Please select either technician or receptionist!");
            }
            else
            {
                counter++;
            }
            if (counter == 7)
            {
                Technician tech1 = new Technician(nameTxt.Text, int.Parse(phoneTxt.Text), addressTxt.Text,
                    stateTxt.Text, cityTxt.Text, int.Parse(postcodeTxt.Text), occupationCmb.Text);

                displayList.Items.Add(tech1.printDetails());
            }

            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
