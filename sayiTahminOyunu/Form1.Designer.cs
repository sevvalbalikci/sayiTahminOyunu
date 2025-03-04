namespace sayiTahminOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnBaslat = new Button();
            txtSayi = new TextBox();
            btnTahmin = new Button();
            lblSonuc = new Label();
            lblHak = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(101, 42);
            label1.Name = "label1";
            label1.Size = new Size(462, 65);
            label1.TabIndex = 0;
            label1.Text = "Sayı Tahmin Oyunu";
            // 
            // btnBaslat
            // 
            btnBaslat.BackColor = Color.SeaShell;
            btnBaslat.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBaslat.ForeColor = Color.DarkOrange;
            btnBaslat.Location = new Point(178, 137);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(296, 53);
            btnBaslat.TabIndex = 1;
            btnBaslat.Text = "Oyunu Başlat";
            btnBaslat.UseVisualStyleBackColor = false;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // txtSayi
            // 
            txtSayi.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSayi.Location = new Point(66, 249);
            txtSayi.Name = "txtSayi";
            txtSayi.Size = new Size(317, 50);
            txtSayi.TabIndex = 2;
            // 
            // btnTahmin
            // 
            btnTahmin.BackColor = Color.SeaShell;
            btnTahmin.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTahmin.ForeColor = Color.DarkOrange;
            btnTahmin.Location = new Point(415, 244);
            btnTahmin.Name = "btnTahmin";
            btnTahmin.Size = new Size(200, 55);
            btnTahmin.TabIndex = 3;
            btnTahmin.Text = "Tahmin Et";
            btnTahmin.UseVisualStyleBackColor = false;
            btnTahmin.Click += btnTahmin_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSonuc.ForeColor = Color.DarkOrange;
            lblSonuc.Location = new Point(66, 408);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(82, 30);
            lblSonuc.TabIndex = 4;
            lblSonuc.Text = "Sonuç :";
            // 
            // lblHak
            // 
            lblHak.AutoSize = true;
            lblHak.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHak.ForeColor = Color.DarkOrange;
            lblHak.Location = new Point(66, 356);
            lblHak.Name = "lblHak";
            lblHak.Size = new Size(119, 30);
            lblHak.TabIndex = 5;
            lblHak.Text = "Kalan Hak :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 520);
            Controls.Add(lblHak);
            Controls.Add(lblSonuc);
            Controls.Add(btnTahmin);
            Controls.Add(txtSayi);
            Controls.Add(btnBaslat);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBaslat;
        private TextBox txtSayi;
        private Button btnTahmin;
        private Label lblSonuc;
        private Label lblHak;
    }
}
