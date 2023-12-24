
namespace MediSync_Project
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.AddToBill = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.avilableStock = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewBilling = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmmount = new System.Windows.Forms.Label();
            this.Printbtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // AddToBill
            // 
            this.AddToBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.AddToBill.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToBill.ForeColor = System.Drawing.Color.White;
            this.AddToBill.Location = new System.Drawing.Point(47, 306);
            this.AddToBill.Name = "AddToBill";
            this.AddToBill.Size = new System.Drawing.Size(145, 29);
            this.AddToBill.TabIndex = 19;
            this.AddToBill.Text = "Add To Bill";
            this.AddToBill.UseVisualStyleBackColor = false;
            this.AddToBill.Click += new System.EventHandler(this.AddToBill_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 46);
            this.label5.TabIndex = 18;
            this.label5.Text = "Billing Form";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Medicine Name";
            // 
            // avilableStock
            // 
            this.avilableStock.AutoSize = true;
            this.avilableStock.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avilableStock.ForeColor = System.Drawing.Color.Black;
            this.avilableStock.Location = new System.Drawing.Point(13, 136);
            this.avilableStock.Name = "avilableStock";
            this.avilableStock.Size = new System.Drawing.Size(89, 21);
            this.avilableStock.TabIndex = 21;
            this.avilableStock.Text = "Avilable Stock";
            this.avilableStock.Visible = false;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(12, 221);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(121, 20);
            this.textBoxQuantity.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Quantity";
            // 
            // dataGridViewBilling
            // 
            this.dataGridViewBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBilling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.MedName,
            this.Quantity,
            this.UnitPrice,
            this.TotalPrice});
            this.dataGridViewBilling.Location = new System.Drawing.Point(256, 9);
            this.dataGridViewBilling.Name = "dataGridViewBilling";
            this.dataGridViewBilling.Size = new System.Drawing.Size(596, 342);
            this.dataGridViewBilling.TabIndex = 23;
            this.dataGridViewBilling.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBilling_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "MedId";
            this.Id.Name = "Id";
            // 
            // MedName
            // 
            this.MedName.HeaderText = "MedName";
            this.MedName.Name = "MedName";
            this.MedName.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // TotalAmmount
            // 
            this.TotalAmmount.AutoSize = true;
            this.TotalAmmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
            this.TotalAmmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.TotalAmmount.Location = new System.Drawing.Point(284, 374);
            this.TotalAmmount.Name = "TotalAmmount";
            this.TotalAmmount.Size = new System.Drawing.Size(304, 46);
            this.TotalAmmount.TabIndex = 24;
            this.TotalAmmount.Text = "Total Ammount";
            // 
            // Printbtn
            // 
            this.Printbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.Printbtn.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Printbtn.ForeColor = System.Drawing.Color.White;
            this.Printbtn.Location = new System.Drawing.Point(647, 391);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.Size = new System.Drawing.Size(168, 29);
            this.Printbtn.TabIndex = 25;
            this.Printbtn.Text = "Print The Bill";
            this.Printbtn.UseVisualStyleBackColor = false;
            this.Printbtn.Click += new System.EventHandler(this.Printbtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.HomeBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Location = new System.Drawing.Point(47, 391);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(145, 29);
            this.HomeBtn.TabIndex = 26;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(891, 491);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.Printbtn);
            this.Controls.Add(this.TotalAmmount);
            this.Controls.Add(this.dataGridViewBilling);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.avilableStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddToBill);
            this.Controls.Add(this.label5);
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddToBill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label avilableStock;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewBilling;
        private System.Windows.Forms.Label TotalAmmount;
        private System.Windows.Forms.Button Printbtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}