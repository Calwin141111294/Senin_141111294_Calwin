namespace Latihan_POS
{
    partial class FormPenjualan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaCust = new System.Windows.Forms.TextBox();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJual = new System.Windows.Forms.Button();
            this.cmbJumlah = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtHargaBarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPenjualan = new System.Windows.Forms.DataGridView();
            this.ID_Barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaakhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Barang";
            // 
            // txtNamaCust
            // 
            this.txtNamaCust.Location = new System.Drawing.Point(171, 24);
            this.txtNamaCust.Name = "txtNamaCust";
            this.txtNamaCust.Size = new System.Drawing.Size(184, 20);
            this.txtNamaCust.TabIndex = 2;
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.Location = new System.Drawing.Point(171, 66);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(184, 20);
            this.txtKodeBarang.TabIndex = 3;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(381, 23);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(247, 64);
            this.btnCari.TabIndex = 6;
            this.btnCari.Text = "Cari Barang";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnJual);
            this.panel1.Controls.Add(this.cmbJumlah);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNamaBarang);
            this.panel1.Controls.Add(this.txtHargaBarang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(49, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 137);
            this.panel1.TabIndex = 14;
            // 
            // btnJual
            // 
            this.btnJual.Location = new System.Drawing.Point(107, 97);
            this.btnJual.Name = "btnJual";
            this.btnJual.Size = new System.Drawing.Size(184, 23);
            this.btnJual.TabIndex = 20;
            this.btnJual.Text = "Confirm";
            this.btnJual.UseVisualStyleBackColor = true;
            this.btnJual.Click += new System.EventHandler(this.btnJual_Click);
            // 
            // cmbJumlah
            // 
            this.cmbJumlah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJumlah.FormattingEnabled = true;
            this.cmbJumlah.Location = new System.Drawing.Point(107, 56);
            this.cmbJumlah.Name = "cmbJumlah";
            this.cmbJumlah.Size = new System.Drawing.Size(184, 21);
            this.cmbJumlah.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Jumlah";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nama Barang";
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(107, 17);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.ReadOnly = true;
            this.txtNamaBarang.Size = new System.Drawing.Size(184, 20);
            this.txtNamaBarang.TabIndex = 16;
            // 
            // txtHargaBarang
            // 
            this.txtHargaBarang.Location = new System.Drawing.Point(380, 17);
            this.txtHargaBarang.Name = "txtHargaBarang";
            this.txtHargaBarang.ReadOnly = true;
            this.txtHargaBarang.Size = new System.Drawing.Size(184, 20);
            this.txtHargaBarang.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Harga";
            // 
            // dgvPenjualan
            // 
            this.dgvPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenjualan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Barang,
            this.Nama,
            this.NamaCu,
            this.jumlahBeli,
            this.harga,
            this.hargaakhir,
            this.waktu});
            this.dgvPenjualan.Location = new System.Drawing.Point(22, 266);
            this.dgvPenjualan.Name = "dgvPenjualan";
            this.dgvPenjualan.Size = new System.Drawing.Size(681, 252);
            this.dgvPenjualan.TabIndex = 15;
            // 
            // ID_Barang
            // 
            this.ID_Barang.HeaderText = "ID";
            this.ID_Barang.Name = "ID_Barang";
            this.ID_Barang.ReadOnly = true;
            this.ID_Barang.Visible = false;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "NamaBarang";
            this.Nama.Name = "Nama";
            // 
            // NamaCu
            // 
            this.NamaCu.HeaderText = "NamaCustomer";
            this.NamaCu.Name = "NamaCu";
            // 
            // jumlahBeli
            // 
            this.jumlahBeli.HeaderText = "Jumlah Beli";
            this.jumlahBeli.Name = "jumlahBeli";
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga / Unit";
            this.harga.Name = "harga";
            // 
            // hargaakhir
            // 
            this.hargaakhir.HeaderText = "Harga Akhir";
            this.hargaakhir.Name = "hargaakhir";
            // 
            // waktu
            // 
            this.waktu.HeaderText = "Waktu Beli";
            this.waktu.Name = "waktu";
            this.waktu.Width = 140;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total Penjualan";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHarga.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.Location = new System.Drawing.Point(425, 526);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(56, 23);
            this.lblHarga.TabIndex = 17;
            this.lblHarga.Text = "label";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvPenjualan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtKodeBarang);
            this.Controls.Add(this.txtNamaCust);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPenjualan";
            this.Text = "FormJual";
            this.Load += new System.EventHandler(this.FormJual_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamaCust;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJual;
        private System.Windows.Forms.ComboBox cmbJumlah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtHargaBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPenjualan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaakhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Button button1;
    }
}