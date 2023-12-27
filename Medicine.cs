using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MediSync_Project
{
    
    public partial class Medicine : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pavit\OneDrive\Desktop\MediSync_Project\bin\Resources\MedStock_db.mdf;Integrated Security=True;Connect Timeout=30");
        public Medicine()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Medicine_FormClosing);

        }

        public void populate()
        {
            con.Open();
            string Myquery = "select * from Med_Table1";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (MedName.Text == "" || Bp.Text == "" || Sp.Text == ""
                || Qty.Text == "" || ExpDate.Text == "")
            {
                MessageBox.Show("Missing Some Data...! Fill All Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Med_Table1 values('" + MedName.Text + "','" + Bp.Text
                    + "','" + Sp.Text + "','" + Qty.Text + "','" + ExpDate.Text + "') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Succesfully Aded");
                con.Close();
                populate();
            }

        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                MedName.Text = row.Cells["MedicineName"].Value.ToString();
                Bp.Text = row.Cells["BPrice"].Value.ToString();
                Sp.Text = row.Cells["SPrice"].Value.ToString();
                Qty.Text = row.Cells["Quantity"].Value.ToString();
                ExpDate.Text= row.Cells["ExpireDate"].Value.ToString();
                
            }
            
            
        }

        private void Update_Click(object sender, EventArgs e)
        {
            con.Open();
            string Myquery = "UPDATE Med_Table1 SET BPrice = " + Bp.Text + ",SPrice = "
                + Sp.Text + ",Quantity =" + Qty.Text + ",ExpireDate ='" + ExpDate.Text + "' Where MedicineName='" +
                  MedName.Text + "';";
            SqlCommand cmd = new SqlCommand(Myquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Update Successfully");
            con.Close();
            populate();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MedName.Text == "")
            {
                MessageBox.Show("Wrong Operation..Click on the Medicine to Delete");
            }
            else
            {
                con.Open();
                string query = "Delete from Med_Table1 where MedicineName ='" + MedName.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Delete Successfully");
                con.Close();
                populate();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        private void Billing_Click(object sender, EventArgs e)
        {
            Billing bil = new Billing();
            bil.Show();
            this.Hide();
        }
        

        private void Medicine_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            System.Windows.Forms.Application.Exit();
        }
       
    }
}
