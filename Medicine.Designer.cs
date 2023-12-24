
namespace MediSync_Project
{
    partial class Medicine
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.ExpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sp = new System.Windows.Forms.TextBox();
            this.Bp = new System.Windows.Forms.TextBox();
            this.MedName = new System.Windows.Forms.TextBox();
            this.Qty = new System.Windows.Forms.TextBox();
            this.Billing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 467);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.Back.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(38, 391);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(97, 29);
            this.Back.TabIndex = 16;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.Delete.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(220, 320);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(97, 29);
            this.Delete.TabIndex = 17;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.Update.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(117, 320);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(97, 29);
            this.Update.TabIndex = 18;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.Add.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(14, 320);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(97, 29);
            this.Add.TabIndex = 19;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ExpDate
            // 
            this.ExpDate.Location = new System.Drawing.Point(16, 208);
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.Size = new System.Drawing.Size(200, 20);
            this.ExpDate.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.label5.Location = new System.Drawing.Point(16, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 46);
            this.label5.TabIndex = 9;
            this.label5.Text = "Medicine Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Expire Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(183, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Selling Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(183, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Buying Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Medicine Name";
            // 
            // Sp
            // 
            this.Sp.Location = new System.Drawing.Point(12, 138);
            this.Sp.Name = "Sp";
            this.Sp.Size = new System.Drawing.Size(150, 20);
            this.Sp.TabIndex = 5;
            // 
            // Bp
            // 
            this.Bp.Location = new System.Drawing.Point(187, 80);
            this.Bp.Name = "Bp";
            this.Bp.Size = new System.Drawing.Size(128, 20);
            this.Bp.TabIndex = 6;
            // 
            // MedName
            // 
            this.MedName.Location = new System.Drawing.Point(14, 80);
            this.MedName.Name = "MedName";
            this.MedName.Size = new System.Drawing.Size(150, 20);
            this.MedName.TabIndex = 7;
            // 
            // Qty
            // 
            this.Qty.BackColor = System.Drawing.Color.White;
            this.Qty.Location = new System.Drawing.Point(187, 138);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(128, 20);
            this.Qty.TabIndex = 8;
            // 
            // Billing
            // 
            this.Billing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.Billing.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billing.ForeColor = System.Drawing.Color.White;
            this.Billing.Location = new System.Drawing.Point(174, 391);
            this.Billing.Name = "Billing";
            this.Billing.Size = new System.Drawing.Size(97, 29);
            this.Billing.TabIndex = 21;
            this.Billing.Text = "Billing";
            this.Billing.UseVisualStyleBackColor = false;
            this.Billing.Click += new System.EventHandler(this.Billing_Click);
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 491);
            this.Controls.Add(this.Billing);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ExpDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sp);
            this.Controls.Add(this.Bp);
            this.Controls.Add(this.MedName);
            this.Controls.Add(this.Qty);
            this.Name = "Medicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicine";
            this.Load += new System.EventHandler(this.Medicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DateTimePicker ExpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Sp;
        private System.Windows.Forms.TextBox Bp;
        private System.Windows.Forms.TextBox MedName;
        private System.Windows.Forms.TextBox Qty;
        private System.Windows.Forms.Button Billing;
    }
}