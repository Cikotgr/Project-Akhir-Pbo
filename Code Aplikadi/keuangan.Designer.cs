namespace WinFormsApp1
{
    partial class Keuangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keuangan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searcTxt = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TambahBtn = new RJCodeAdvance.RJControls.RJButton();
            this.HapusBtn = new RJCodeAdvance.RJControls.RJButton();
            this.TxtjumlahUang = new RJCodeAdvance.RJControls.RJTextBox();
            this.TxtKeterangan = new RJCodeAdvance.RJControls.RJTextBox();
            this.cmbJenis = new RJCodeAdvance.RJControls.RJComboBox();
            this.cmbAnggota = new RJCodeAdvance.RJControls.RJComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 99);
            this.panel1.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Font = new System.Drawing.Font("SHMUP in the zone", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBtn.Location = new System.Drawing.Point(1197, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(36, 37);
            this.backBtn.TabIndex = 18;
            this.backBtn.Text = "<";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(207, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Keuangan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(760, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // searcTxt
            // 
            this.searcTxt.BackColor = System.Drawing.SystemColors.Window;
            this.searcTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.searcTxt.BorderFocusColor = System.Drawing.Color.Yellow;
            this.searcTxt.BorderRadius = 15;
            this.searcTxt.BorderSize = 2;
            this.searcTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searcTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searcTxt.Location = new System.Drawing.Point(515, 106);
            this.searcTxt.Margin = new System.Windows.Forms.Padding(4);
            this.searcTxt.Multiline = false;
            this.searcTxt.Name = "searcTxt";
            this.searcTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.searcTxt.PasswordChar = false;
            this.searcTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searcTxt.PlaceholderText = "";
            this.searcTxt.Size = new System.Drawing.Size(289, 39);
            this.searcTxt.TabIndex = 17;
            this.searcTxt.Texts = "";
            this.searcTxt.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(31, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jumlah Uang :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(79, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Anggota :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jenis Transaksi :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(48, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Keterangan :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(515, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(663, 505);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // TambahBtn
            // 
            this.TambahBtn.BackColor = System.Drawing.Color.Lime;
            this.TambahBtn.BackgroundColor = System.Drawing.Color.Lime;
            this.TambahBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.TambahBtn.BorderRadius = 15;
            this.TambahBtn.BorderSize = 0;
            this.TambahBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TambahBtn.FlatAppearance.BorderSize = 0;
            this.TambahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TambahBtn.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TambahBtn.ForeColor = System.Drawing.Color.White;
            this.TambahBtn.Location = new System.Drawing.Point(194, 500);
            this.TambahBtn.Name = "TambahBtn";
            this.TambahBtn.Size = new System.Drawing.Size(138, 50);
            this.TambahBtn.TabIndex = 13;
            this.TambahBtn.Text = "Tambah";
            this.TambahBtn.TextColor = System.Drawing.Color.White;
            this.TambahBtn.UseVisualStyleBackColor = false;
            this.TambahBtn.Click += new System.EventHandler(this.TambahBtn_Click);
            // 
            // HapusBtn
            // 
            this.HapusBtn.BackColor = System.Drawing.Color.Red;
            this.HapusBtn.BackgroundColor = System.Drawing.Color.Red;
            this.HapusBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.HapusBtn.BorderRadius = 15;
            this.HapusBtn.BorderSize = 0;
            this.HapusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HapusBtn.FlatAppearance.BorderSize = 0;
            this.HapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HapusBtn.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HapusBtn.ForeColor = System.Drawing.Color.White;
            this.HapusBtn.Location = new System.Drawing.Point(356, 500);
            this.HapusBtn.Name = "HapusBtn";
            this.HapusBtn.Size = new System.Drawing.Size(138, 50);
            this.HapusBtn.TabIndex = 14;
            this.HapusBtn.Text = "Hapus";
            this.HapusBtn.TextColor = System.Drawing.Color.White;
            this.HapusBtn.UseVisualStyleBackColor = false;
            this.HapusBtn.Click += new System.EventHandler(this.HapusBtn_Click);
            // 
            // TxtjumlahUang
            // 
            this.TxtjumlahUang.BackColor = System.Drawing.SystemColors.Window;
            this.TxtjumlahUang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TxtjumlahUang.BorderFocusColor = System.Drawing.Color.Yellow;
            this.TxtjumlahUang.BorderRadius = 15;
            this.TxtjumlahUang.BorderSize = 2;
            this.TxtjumlahUang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtjumlahUang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtjumlahUang.Location = new System.Drawing.Point(194, 297);
            this.TxtjumlahUang.Margin = new System.Windows.Forms.Padding(4);
            this.TxtjumlahUang.Multiline = false;
            this.TxtjumlahUang.Name = "TxtjumlahUang";
            this.TxtjumlahUang.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtjumlahUang.PasswordChar = false;
            this.TxtjumlahUang.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtjumlahUang.PlaceholderText = "";
            this.TxtjumlahUang.Size = new System.Drawing.Size(300, 39);
            this.TxtjumlahUang.TabIndex = 15;
            this.TxtjumlahUang.Texts = "";
            this.TxtjumlahUang.UnderlinedStyle = false;
            this.TxtjumlahUang._TextChanged += new System.EventHandler(this.TxtjumlahUang__TextChanged);
            // 
            // TxtKeterangan
            // 
            this.TxtKeterangan.BackColor = System.Drawing.SystemColors.Window;
            this.TxtKeterangan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TxtKeterangan.BorderFocusColor = System.Drawing.Color.Yellow;
            this.TxtKeterangan.BorderRadius = 15;
            this.TxtKeterangan.BorderSize = 2;
            this.TxtKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtKeterangan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtKeterangan.Location = new System.Drawing.Point(194, 373);
            this.TxtKeterangan.Margin = new System.Windows.Forms.Padding(4);
            this.TxtKeterangan.Multiline = false;
            this.TxtKeterangan.Name = "TxtKeterangan";
            this.TxtKeterangan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtKeterangan.PasswordChar = false;
            this.TxtKeterangan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtKeterangan.PlaceholderText = "";
            this.TxtKeterangan.Size = new System.Drawing.Size(300, 39);
            this.TxtKeterangan.TabIndex = 16;
            this.TxtKeterangan.Texts = "";
            this.TxtKeterangan.UnderlinedStyle = false;
            // 
            // cmbJenis
            // 
            this.cmbJenis.BackColor = System.Drawing.Color.White;
            this.cmbJenis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbJenis.BorderSize = 1;
            this.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbJenis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbJenis.ForeColor = System.Drawing.Color.DimGray;
            this.cmbJenis.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbJenis.ListBackColor = System.Drawing.Color.White;
            this.cmbJenis.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbJenis.Location = new System.Drawing.Point(194, 164);
            this.cmbJenis.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Padding = new System.Windows.Forms.Padding(1);
            this.cmbJenis.Size = new System.Drawing.Size(300, 38);
            this.cmbJenis.TabIndex = 17;
            this.cmbJenis.Texts = "";
            // 
            // cmbAnggota
            // 
            this.cmbAnggota.BackColor = System.Drawing.Color.White;
            this.cmbAnggota.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbAnggota.BorderSize = 1;
            this.cmbAnggota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbAnggota.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAnggota.ForeColor = System.Drawing.Color.DimGray;
            this.cmbAnggota.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbAnggota.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbAnggota.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbAnggota.Location = new System.Drawing.Point(194, 230);
            this.cmbAnggota.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbAnggota.Name = "cmbAnggota";
            this.cmbAnggota.Padding = new System.Windows.Forms.Padding(1);
            this.cmbAnggota.Size = new System.Drawing.Size(300, 38);
            this.cmbAnggota.TabIndex = 18;
            this.cmbAnggota.Texts = "";
            this.cmbAnggota.OnSelectedIndexChanged += new System.EventHandler(this.cmbAnggota_OnSelectedIndexChanged);
            // 
            // Keuangan
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 739);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cmbAnggota);
            this.Controls.Add(this.cmbJenis);
            this.Controls.Add(this.searcTxt);
            this.Controls.Add(this.TxtKeterangan);
            this.Controls.Add(this.TxtjumlahUang);
            this.Controls.Add(this.HapusBtn);
            this.Controls.Add(this.TambahBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Keuangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "keuangan";
            this.Load += new System.EventHandler(this.Keuangan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private RJCodeAdvance.RJControls.RJButton TambahBtn;
        private RJCodeAdvance.RJControls.RJButton HapusBtn;
        private RJCodeAdvance.RJControls.RJTextBox TxtjumlahUang;
        private RJCodeAdvance.RJControls.RJTextBox TxtKeterangan;
        private RJCodeAdvance.RJControls.RJTextBox searcTxt;
        private RJCodeAdvance.RJControls.RJComboBox cmbJenis;
        private RJCodeAdvance.RJControls.RJComboBox cmbAnggota;
        private Label backBtn;
        private PictureBox pictureBox2;
    }
}