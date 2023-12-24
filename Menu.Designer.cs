
namespace MediSync_Project
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Billing = new System.Windows.Forms.Label();
            this.Medicine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Billing
            // 
            this.Billing.AutoSize = true;
            this.Billing.BackColor = System.Drawing.Color.Transparent;
            this.Billing.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billing.ForeColor = System.Drawing.Color.Transparent;
            this.Billing.Location = new System.Drawing.Point(527, 184);
            this.Billing.Name = "Billing";
            this.Billing.Size = new System.Drawing.Size(121, 44);
            this.Billing.TabIndex = 4;
            this.Billing.Text = "Billing";
            this.Billing.Click += new System.EventHandler(this.Billing_Click);
            // 
            // Medicine
            // 
            this.Medicine.AutoSize = true;
            this.Medicine.BackColor = System.Drawing.Color.Transparent;
            this.Medicine.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medicine.ForeColor = System.Drawing.Color.Transparent;
            this.Medicine.Location = new System.Drawing.Point(132, 184);
            this.Medicine.Name = "Medicine";
            this.Medicine.Size = new System.Drawing.Size(283, 44);
            this.Medicine.TabIndex = 3;
            this.Medicine.Text = "Medicine Stock";
            this.Medicine.Click += new System.EventHandler(this.Medicine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 87);
            this.label1.TabIndex = 2;
            this.label1.Text = "Main Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Billing);
            this.Controls.Add(this.Medicine);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Billing;
        private System.Windows.Forms.Label Medicine;
        private System.Windows.Forms.Label label1;
    }
}