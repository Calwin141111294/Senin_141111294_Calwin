namespace Latihan_POS
{
    partial class FormEdit
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
            this.txtCariKode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBarang = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSimpanBarang = new System.Windows.Forms.Button();
            this.txtHargaJual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHargaAwal = new System.Windows.Forms.TextBox();
            this.txtJumlahBarang = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSupplier = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSimpanSupplier = new System.Windows.Forms.Button();
            this.txtNoHPSupplier = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtKotaSupplier = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAlamatSupplier = new System.Windows.Forms.TextBox();
            this.txtNamaSupplier = new System.Windows.Forms.TextBox();
            this.txtKodeSupplier = new System.Windows.Forms.TextBox();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.btnSimpanCustomer = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNoHpCus = new System.Windows.Forms.TextBox();
            this.txtAlamatCus = new System.Windows.Forms.TextBox();
            this.txtNamaCus = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.cmbCari = new System.Windows.Forms.ComboBox();
            this.Jenis = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlBarang.SuspendLayout();
            this.pnlSupplier.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCariKode
            // 
            this.txtCariKode.Location = new System.Drawing.Point(101, 36);
            this.txtCariKode.Name = "txtCariKode";
            this.txtCariKode.Size = new System.Drawing.Size(201, 20);
            this.txtCariKode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlBarang
            // 
            this.pnlBarang.Controls.Add(this.label19);
            this.pnlBarang.Controls.Add(this.btnSimpanBarang);
            this.pnlBarang.Controls.Add(this.txtHargaJual);
            this.pnlBarang.Controls.Add(this.label8);
            this.pnlBarang.Controls.Add(this.label7);
            this.pnlBarang.Controls.Add(this.label6);
            this.pnlBarang.Controls.Add(this.txtHargaAwal);
            this.pnlBarang.Controls.Add(this.txtJumlahBarang);
            this.pnlBarang.Controls.Add(this.txtNamaBarang);
            this.pnlBarang.Controls.Add(this.txtKodeBarang);
            this.pnlBarang.Controls.Add(this.label5);
            this.pnlBarang.Controls.Add(this.label4);
            this.pnlBarang.Controls.Add(this.label3);
            this.pnlBarang.Controls.Add(this.label2);
            this.pnlBarang.Location = new System.Drawing.Point(42, 147);
            this.pnlBarang.Name = "pnlBarang";
            this.pnlBarang.Size = new System.Drawing.Size(295, 276);
            this.pnlBarang.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(46, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(201, 33);
            this.label19.TabIndex = 16;
            this.label19.Text = "Edit Barang";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSimpanBarang
            // 
            this.btnSimpanBarang.Location = new System.Drawing.Point(103, 222);
            this.btnSimpanBarang.Name = "btnSimpanBarang";
            this.btnSimpanBarang.Size = new System.Drawing.Size(165, 23);
            this.btnSimpanBarang.TabIndex = 12;
            this.btnSimpanBarang.Text = "Simpan";
            this.btnSimpanBarang.UseVisualStyleBackColor = true;
            this.btnSimpanBarang.Click += new System.EventHandler(this.btnSimpanBarang_Click);
            // 
            // txtHargaJual
            // 
            this.txtHargaJual.Location = new System.Drawing.Point(103, 184);
            this.txtHargaJual.Name = "txtHargaJual";
            this.txtHargaJual.Size = new System.Drawing.Size(165, 20);
            this.txtHargaJual.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "HargaJual";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "HargaHPP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Jumlah";
            // 
            // txtHargaAwal
            // 
            this.txtHargaAwal.Location = new System.Drawing.Point(103, 156);
            this.txtHargaAwal.Name = "txtHargaAwal";
            this.txtHargaAwal.Size = new System.Drawing.Size(165, 20);
            this.txtHargaAwal.TabIndex = 7;
            // 
            // txtJumlahBarang
            // 
            this.txtJumlahBarang.Location = new System.Drawing.Point(103, 126);
            this.txtJumlahBarang.Name = "txtJumlahBarang";
            this.txtJumlahBarang.Size = new System.Drawing.Size(165, 20);
            this.txtJumlahBarang.TabIndex = 6;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(103, 94);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(165, 20);
            this.txtNamaBarang.TabIndex = 5;
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.Location = new System.Drawing.Point(103, 64);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.ReadOnly = true;
            this.txtKodeBarang.Size = new System.Drawing.Size(165, 20);
            this.txtKodeBarang.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kode";
            // 
            // pnlSupplier
            // 
            this.pnlSupplier.Controls.Add(this.label17);
            this.pnlSupplier.Controls.Add(this.btnSimpanSupplier);
            this.pnlSupplier.Controls.Add(this.txtNoHPSupplier);
            this.pnlSupplier.Controls.Add(this.label16);
            this.pnlSupplier.Controls.Add(this.txtKotaSupplier);
            this.pnlSupplier.Controls.Add(this.label15);
            this.pnlSupplier.Controls.Add(this.label14);
            this.pnlSupplier.Controls.Add(this.label13);
            this.pnlSupplier.Controls.Add(this.label12);
            this.pnlSupplier.Controls.Add(this.txtAlamatSupplier);
            this.pnlSupplier.Controls.Add(this.txtNamaSupplier);
            this.pnlSupplier.Controls.Add(this.txtKodeSupplier);
            this.pnlSupplier.Location = new System.Drawing.Point(45, 147);
            this.pnlSupplier.Name = "pnlSupplier";
            this.pnlSupplier.Size = new System.Drawing.Size(295, 276);
            this.pnlSupplier.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(56, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(201, 33);
            this.label17.TabIndex = 38;
            this.label17.Text = "Edit Supplier";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSimpanSupplier
            // 
            this.btnSimpanSupplier.Location = new System.Drawing.Point(99, 230);
            this.btnSimpanSupplier.Name = "btnSimpanSupplier";
            this.btnSimpanSupplier.Size = new System.Drawing.Size(163, 23);
            this.btnSimpanSupplier.TabIndex = 37;
            this.btnSimpanSupplier.Text = "Simpan";
            this.btnSimpanSupplier.UseVisualStyleBackColor = true;
            this.btnSimpanSupplier.Click += new System.EventHandler(this.btnSimpanSupplier_Click);
            // 
            // txtNoHPSupplier
            // 
            this.txtNoHPSupplier.Location = new System.Drawing.Point(99, 191);
            this.txtNoHPSupplier.Name = "txtNoHPSupplier";
            this.txtNoHPSupplier.Size = new System.Drawing.Size(163, 20);
            this.txtNoHPSupplier.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 198);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "NoHP";
            // 
            // txtKotaSupplier
            // 
            this.txtKotaSupplier.Location = new System.Drawing.Point(99, 157);
            this.txtKotaSupplier.Name = "txtKotaSupplier";
            this.txtKotaSupplier.Size = new System.Drawing.Size(163, 20);
            this.txtKotaSupplier.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Kota";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Alamat";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Nama";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Kode";
            // 
            // txtAlamatSupplier
            // 
            this.txtAlamatSupplier.Location = new System.Drawing.Point(99, 119);
            this.txtAlamatSupplier.Name = "txtAlamatSupplier";
            this.txtAlamatSupplier.Size = new System.Drawing.Size(163, 20);
            this.txtAlamatSupplier.TabIndex = 29;
            // 
            // txtNamaSupplier
            // 
            this.txtNamaSupplier.Location = new System.Drawing.Point(99, 84);
            this.txtNamaSupplier.Name = "txtNamaSupplier";
            this.txtNamaSupplier.Size = new System.Drawing.Size(163, 20);
            this.txtNamaSupplier.TabIndex = 28;
            // 
            // txtKodeSupplier
            // 
            this.txtKodeSupplier.Location = new System.Drawing.Point(99, 48);
            this.txtKodeSupplier.Name = "txtKodeSupplier";
            this.txtKodeSupplier.ReadOnly = true;
            this.txtKodeSupplier.Size = new System.Drawing.Size(163, 20);
            this.txtKodeSupplier.TabIndex = 27;
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCustomer.Controls.Add(this.btnSimpanCustomer);
            this.pnlCustomer.Controls.Add(this.label18);
            this.pnlCustomer.Controls.Add(this.label11);
            this.pnlCustomer.Controls.Add(this.label10);
            this.pnlCustomer.Controls.Add(this.label9);
            this.pnlCustomer.Controls.Add(this.txtNoHpCus);
            this.pnlCustomer.Controls.Add(this.txtAlamatCus);
            this.pnlCustomer.Controls.Add(this.txtNamaCus);
            this.pnlCustomer.Location = new System.Drawing.Point(48, 135);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(295, 278);
            this.pnlCustomer.TabIndex = 13;
            // 
            // btnSimpanCustomer
            // 
            this.btnSimpanCustomer.Location = new System.Drawing.Point(85, 175);
            this.btnSimpanCustomer.Name = "btnSimpanCustomer";
            this.btnSimpanCustomer.Size = new System.Drawing.Size(157, 31);
            this.btnSimpanCustomer.TabIndex = 6;
            this.btnSimpanCustomer.Text = "Simpan";
            this.btnSimpanCustomer.UseVisualStyleBackColor = true;
            this.btnSimpanCustomer.Click += new System.EventHandler(this.btnSimpanCustomer_Click);
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(53, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(201, 33);
            this.label18.TabIndex = 15;
            this.label18.Text = "Edit Customer";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "NoHp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Alamat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nama";
            // 
            // txtNoHpCus
            // 
            this.txtNoHpCus.Location = new System.Drawing.Point(97, 126);
            this.txtNoHpCus.Name = "txtNoHpCus";
            this.txtNoHpCus.Size = new System.Drawing.Size(157, 20);
            this.txtNoHpCus.TabIndex = 2;
            // 
            // txtAlamatCus
            // 
            this.txtAlamatCus.Location = new System.Drawing.Point(97, 95);
            this.txtAlamatCus.Name = "txtAlamatCus";
            this.txtAlamatCus.Size = new System.Drawing.Size(157, 20);
            this.txtAlamatCus.TabIndex = 1;
            // 
            // txtNamaCus
            // 
            this.txtNamaCus.Location = new System.Drawing.Point(97, 64);
            this.txtNamaCus.Name = "txtNamaCus";
            this.txtNamaCus.ReadOnly = true;
            this.txtNamaCus.Size = new System.Drawing.Size(157, 20);
            this.txtNamaCus.TabIndex = 0;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(69, 106);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(146, 23);
            this.btnCari.TabIndex = 0;
            this.btnCari.Text = "SemogaAkuBeruntung";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // cmbCari
            // 
            this.cmbCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCari.FormattingEnabled = true;
            this.cmbCari.Items.AddRange(new object[] {
            "Barang",
            "Customer",
            "Supplier"});
            this.cmbCari.Location = new System.Drawing.Point(101, 68);
            this.cmbCari.Name = "cmbCari";
            this.cmbCari.Size = new System.Drawing.Size(201, 21);
            this.cmbCari.TabIndex = 3;
            // 
            // Jenis
            // 
            this.Jenis.AutoSize = true;
            this.Jenis.Location = new System.Drawing.Point(31, 76);
            this.Jenis.Name = "Jenis";
            this.Jenis.Size = new System.Drawing.Size(31, 13);
            this.Jenis.TabIndex = 4;
            this.Jenis.Text = "Type";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(232, 106);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 437);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlCustomer);
            this.Controls.Add(this.Jenis);
            this.Controls.Add(this.pnlSupplier);
            this.Controls.Add(this.cmbCari);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.pnlBarang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCariKode);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.pnlBarang.ResumeLayout(false);
            this.pnlBarang.PerformLayout();
            this.pnlSupplier.ResumeLayout(false);
            this.pnlSupplier.PerformLayout();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCariKode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBarang;
        private System.Windows.Forms.Button btnSimpanBarang;
        private System.Windows.Forms.TextBox txtHargaJual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHargaAwal;
        private System.Windows.Forms.TextBox txtJumlahBarang;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.ComboBox cmbCari;
        private System.Windows.Forms.Label Jenis;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Button btnSimpanCustomer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNoHpCus;
        private System.Windows.Forms.TextBox txtAlamatCus;
        private System.Windows.Forms.TextBox txtNamaCus;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel pnlSupplier;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSimpanSupplier;
        private System.Windows.Forms.TextBox txtNoHPSupplier;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtKotaSupplier;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAlamatSupplier;
        private System.Windows.Forms.TextBox txtNamaSupplier;
        private System.Windows.Forms.TextBox txtKodeSupplier;
        private System.Windows.Forms.Button btnBack;
    }
}