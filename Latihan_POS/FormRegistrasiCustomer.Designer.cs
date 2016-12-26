namespace Latihan_POS
{
    partial class FormRegistrasiCustomer
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamCustomer = new System.Windows.Forms.TextBox();
            this.txtAlamatCustomer = new System.Windows.Forms.TextBox();
            this.txtNoHp = new System.Windows.Forms.TextBox();
            this.txtSimpan = new System.Windows.Forms.Button();
            this.txtReset = new System.Windows.Forms.Button();
            this.txtKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alamat Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. HP";
            // 
            // txtNamCustomer
            // 
            this.txtNamCustomer.Location = new System.Drawing.Point(135, 48);
            this.txtNamCustomer.Name = "txtNamCustomer";
            this.txtNamCustomer.Size = new System.Drawing.Size(176, 20);
            this.txtNamCustomer.TabIndex = 3;
            // 
            // txtAlamatCustomer
            // 
            this.txtAlamatCustomer.Location = new System.Drawing.Point(135, 87);
            this.txtAlamatCustomer.Name = "txtAlamatCustomer";
            this.txtAlamatCustomer.Size = new System.Drawing.Size(176, 20);
            this.txtAlamatCustomer.TabIndex = 4;
            // 
            // txtNoHp
            // 
            this.txtNoHp.Location = new System.Drawing.Point(135, 128);
            this.txtNoHp.Name = "txtNoHp";
            this.txtNoHp.Size = new System.Drawing.Size(176, 20);
            this.txtNoHp.TabIndex = 5;
            // 
            // txtSimpan
            // 
            this.txtSimpan.Location = new System.Drawing.Point(28, 186);
            this.txtSimpan.Name = "txtSimpan";
            this.txtSimpan.Size = new System.Drawing.Size(75, 23);
            this.txtSimpan.TabIndex = 6;
            this.txtSimpan.Text = "Simpan";
            this.txtSimpan.UseVisualStyleBackColor = true;
            this.txtSimpan.Click += new System.EventHandler(this.txtSimpan_Click);
            // 
            // txtReset
            // 
            this.txtReset.Location = new System.Drawing.Point(166, 186);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(75, 23);
            this.txtReset.TabIndex = 7;
            this.txtReset.Text = "Reset";
            this.txtReset.UseVisualStyleBackColor = true;
            this.txtReset.Click += new System.EventHandler(this.txtReset_Click);
            // 
            // txtKeluar
            // 
            this.txtKeluar.Location = new System.Drawing.Point(314, 186);
            this.txtKeluar.Name = "txtKeluar";
            this.txtKeluar.Size = new System.Drawing.Size(75, 23);
            this.txtKeluar.TabIndex = 8;
            this.txtKeluar.Text = "Keluar";
            this.txtKeluar.UseVisualStyleBackColor = true;
            this.txtKeluar.Click += new System.EventHandler(this.txtKeluar_Click);
            // 
            // FormRegistrasiCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 279);
            this.Controls.Add(this.txtKeluar);
            this.Controls.Add(this.txtReset);
            this.Controls.Add(this.txtSimpan);
            this.Controls.Add(this.txtNoHp);
            this.Controls.Add(this.txtAlamatCustomer);
            this.Controls.Add(this.txtNamCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistrasiCustomer";
            this.Text = "FormRegistrasiCustomer";
            this.Load += new System.EventHandler(this.FormRegistrasiCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamCustomer;
        private System.Windows.Forms.TextBox txtAlamatCustomer;
        private System.Windows.Forms.TextBox txtNoHp;
        private System.Windows.Forms.Button txtSimpan;
        private System.Windows.Forms.Button txtReset;
        private System.Windows.Forms.Button txtKeluar;
    }
}