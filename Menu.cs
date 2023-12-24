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

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }
    }
}
