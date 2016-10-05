namespace Latihan_2_1
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
            this.MonthCalender = new System.Windows.Forms.MonthCalendar();
            this.tanggal = new System.Windows.Forms.ComboBox();
            this.Bulan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tambah = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.hapusBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MonthCalender
            // 
            this.MonthCalender.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.MonthCalender.Location = new System.Drawing.Point(64, 126);
            this.MonthCalender.Name = "MonthCalender";
            this.MonthCalender.TabIndex = 0;
            this.MonthCalender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalender_DateChanged);
            // 
            // tanggal
            // 
            this.tanggal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tanggal.FormattingEnabled = true;
            this.tanggal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.tanggal.Location = new System.Drawing.Point(94, 65);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(121, 21);
            this.tanggal.TabIndex = 1;
            // 
            // Bulan
            // 
            this.Bulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Bulan.FormattingEnabled = true;
            this.Bulan.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.Bulan.Location = new System.Drawing.Point(278, 65);
            this.Bulan.Name = "Bulan";
            this.Bulan.Size = new System.Drawing.Size(121, 21);
            this.Bulan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tanggal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bulan";
            // 
            // Tambah
            // 
            this.Tambah.Location = new System.Drawing.Point(419, 63);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(75, 23);
            this.Tambah.TabIndex = 5;
            this.Tambah.Text = "Tambah";
            this.Tambah.UseVisualStyleBackColor = true;
            this.Tambah.Click += new System.EventHandler(this.button1_Click);
            // 
            // hapusBtn
            // 
            this.hapusBtn.Location = new System.Drawing.Point(420, 93);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(75, 23);
            this.hapusBtn.TabIndex = 6;
            this.hapusBtn.Text = "hapus";
            this.hapusBtn.UseVisualStyleBackColor = true;
            this.hapusBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 479);
            this.Controls.Add(this.hapusBtn);
            this.Controls.Add(this.Tambah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bulan);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.MonthCalender);
            this.Name = "Form1";
            this.Text = "Latihan 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar MonthCalender;
        private System.Windows.Forms.ComboBox tanggal;
        private System.Windows.Forms.ComboBox Bulan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Tambah;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button hapusBtn;
    }
}

