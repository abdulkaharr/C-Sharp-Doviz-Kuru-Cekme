namespace DovizKuruCekme
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDolarAlıs = new System.Windows.Forms.TextBox();
            this.txtDolarSatıs = new System.Windows.Forms.TextBox();
            this.txtEuroAlıs = new System.Windows.Forms.TextBox();
            this.txtEuroSatıs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtdolar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(877, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnVeri
            // 
            this.btnVeri.Location = new System.Drawing.Point(243, 38);
            this.btnVeri.Name = "btnVeri";
            this.btnVeri.Size = new System.Drawing.Size(138, 38);
            this.btnVeri.TabIndex = 1;
            this.btnVeri.Text = "Verileri Çek";
            this.btnVeri.UseVisualStyleBackColor = true;
            this.btnVeri.Click += new System.EventHandler(this.btnVeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dolar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Euro";
            // 
            // txtDolarAlıs
            // 
            this.txtDolarAlıs.Location = new System.Drawing.Point(76, 38);
            this.txtDolarAlıs.Name = "txtDolarAlıs";
            this.txtDolarAlıs.Size = new System.Drawing.Size(63, 20);
            this.txtDolarAlıs.TabIndex = 3;
            // 
            // txtDolarSatıs
            // 
            this.txtDolarSatıs.Location = new System.Drawing.Point(145, 38);
            this.txtDolarSatıs.Name = "txtDolarSatıs";
            this.txtDolarSatıs.Size = new System.Drawing.Size(63, 20);
            this.txtDolarSatıs.TabIndex = 3;
            // 
            // txtEuroAlıs
            // 
            this.txtEuroAlıs.Location = new System.Drawing.Point(76, 72);
            this.txtEuroAlıs.Name = "txtEuroAlıs";
            this.txtEuroAlıs.Size = new System.Drawing.Size(63, 20);
            this.txtEuroAlıs.TabIndex = 3;
            // 
            // txtEuroSatıs
            // 
            this.txtEuroSatıs.Location = new System.Drawing.Point(145, 72);
            this.txtEuroSatıs.Name = "txtEuroSatıs";
            this.txtEuroSatıs.Size = new System.Drawing.Size(63, 20);
            this.txtEuroSatıs.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(94, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Alış";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(154, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Satış";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(485, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "TL";
            // 
            // txtTL
            // 
            this.txtTL.Location = new System.Drawing.Point(443, 46);
            this.txtTL.Name = "txtTL";
            this.txtTL.Size = new System.Drawing.Size(109, 20);
            this.txtTL.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(586, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Dolar";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(516, 69);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtdolar
            // 
            this.txtdolar.Enabled = false;
            this.txtdolar.Location = new System.Drawing.Point(558, 47);
            this.txtdolar.Name = "txtdolar";
            this.txtdolar.Size = new System.Drawing.Size(109, 20);
            this.txtdolar.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(673, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 491);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtEuroSatıs);
            this.Controls.Add(this.txtDolarSatıs);
            this.Controls.Add(this.txtEuroAlıs);
            this.Controls.Add(this.txtTL);
            this.Controls.Add(this.txtdolar);
            this.Controls.Add(this.txtDolarAlıs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVeri);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDolarAlıs;
        private System.Windows.Forms.TextBox txtDolarSatıs;
        private System.Windows.Forms.TextBox txtEuroAlıs;
        private System.Windows.Forms.TextBox txtEuroSatıs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtdolar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

