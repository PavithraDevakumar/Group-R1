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
    public partial class Billing : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pavit\OneDrive\Desktop\MediSync_Project\bin\Resources\MedStock_db.mdf;Integrated Security=True;Connect Timeout=30");
        public void populatecombobox() 
        {
            String sql = "select * from Med_Table1";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rdr;
            try 
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("MedicineName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboBox1.ValueMember = "MedicineName";
                comboBox1.DataSource = dt;
                con.Close();
            }
            catch 
            {

            }
        }
       int x, unitp;
        public void fetchQty()
        {
            con.Open();
            string mysql = "Select * from Med_Table1 where MedicineName='" + comboBox1.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(mysql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                x = Convert.ToInt32(dr["Quantity"].ToString());
                unitp = Convert.ToInt32(dr["SPrice"].ToString());
                avilableStock.Text = "Available stock is " + dr["Quantity"].ToString();
                avilableStock.Visible = true;
            }
            con.Close();
        }

        public void updateMedicine()
        {
            con.Open();
            int newQty = x - Convert.ToInt32(textBoxQuantity.Text);
            String Myquery = "UPDATE Med_Table1 SET Quantity =" + newQty + " WHERE MedicineName='" + comboBox1.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(Myquery, con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Medicine updated successfully!");
            con.Close();
        } 
        public Billing()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Billing_FormClosing);
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            populatecombobox();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchQty();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int GrdTotal = 0;

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        private void dataGridViewBilling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        Bitmap bitmap;
        private void Printbtn_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawImage(bitmap, 0, 0);

        }

        private void AddToBill_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (textBoxQuantity.Text == "" || Convert.ToInt32(textBoxQuantity.Text) > x)
            {
                MessageBox.Show("No enough stock. Please check available stock");
            }
            else
            {
                int total = Convert.ToInt32(textBoxQuantity.Text) * unitp;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewBilling);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = comboBox1.SelectedValue.ToString();
                newRow.Cells[2].Value = textBoxQuantity.Text;
                newRow.Cells[3].Value = unitp;
                newRow.Cells[4].Value = unitp * Convert.ToInt32(textBoxQuantity.Text);
                dataGridViewBilling.Rows.Add(newRow);
                GrdTotal = GrdTotal + total;
                TotalAmmount.Text = "Rs. " + GrdTotal;
                updateMedicine();
            }
        }
        private void Billing_FormClosing(object sender, FormClosingEventArgs e)
        {

            System.Windows.Forms.Application.Exit();
        }
    }
}
