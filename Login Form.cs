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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Login_FormFormClosing);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if((textBoxUserID.Text.Equals("admin")) && (textBoxPassword.Text.Equals("admin1234")))
            {
                Menu form = new Menu();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid User Name Or Password");
            }
        }

        private void Login_FormFormClosing(object sender, FormClosingEventArgs e)
        {

            System.Windows.Forms.Application.Exit();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
