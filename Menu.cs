using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediSync_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Menu_FormClosing);
        }

        private void Medicine_Click(object sender, EventArgs e)
        {
            Medicine form = new Medicine();
            form.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Billing_Click(object sender, EventArgs e)
        {
            Billing form1 = new Billing();
            form1.Show();
            this.Hide();
        }

        
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {

            System.Windows.Forms.Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login_Form f1 = new Login_Form();
            f1.Show();
            this.Hide();
        }
    }
}
