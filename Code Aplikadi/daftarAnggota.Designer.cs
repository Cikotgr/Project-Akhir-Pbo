namespace WinFormsApp1
{
    partial class Anggota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anggota));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtnama = new System.Windows.Forms.TextBox();
            this.Txtnim = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Txtrows = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addBtn = new RJCodeAdvance.RJControls.RJButton();
            this.cmbgender = new RJCodeAdvance.RJControls.RJComboBox();
            this.clearBtn = new RJCodeAdvance.RJControls.RJButton();
            this.updateBtn = new RJCodeAdvance.RJControls.RJButton();
            this.cariTxt = new RJCodeAdvance.RJControls.RJTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cekKas = new RJCodeAdvance.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 91);
            this.panel1.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.Font = new System.Drawing.Font("SHMUP in the zone", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBtn.Location = new System.Drawing.Point(990, 13);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(32, 33);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "<";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(187, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daftar Anggota";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(82, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nim :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(51, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender :";
            // 
            // Txtnama
            // 
            this.Txtnama.BackColor = System.Drawing.Color.White;
            this.Txtnama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtnama.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txtnama.Location = new System.Drawing.Point(147, 110);
            this.Txtnama.Name = "Txtnama";
            this.Txtnama.Size = new System.Drawing.Size(260, 27);
            this.Txtnama.TabIndex = 4;
            // 
            // Txtnim
            // 
            this.Txtnim.BackColor = System.Drawing.Color.White;
            this.Txtnim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtnim.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txtnim.Location = new System.Drawing.Point(147, 152);
            this.Txtnim.Name = "Txtnim";
            this.Txtnim.Size = new System.Drawing.Size(260, 27);
            this.Txtnim.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(891, 278);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Txtrows
            // 
            this.Txtrows.AutoSize = true;
            this.Txtrows.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txtrows.ForeColor = System.Drawing.Color.Red;
            this.Txtrows.Location = new System.Drawing.Point(15, 579);
            this.Txtrows.Name = "Txtrows";
            this.Txtrows.Size = new System.Drawing.Size(111, 28);
            this.Txtrows.TabIndex = 13;
            this.Txtrows.Text = "jumlah baris";
            this.Txtrows.Click += new System.EventHandler(this.Txtrows_Click);
            // 
            // panel2
            // 
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(134, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 1);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(139, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 1);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(0, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 1);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(139, 183);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 1);
            this.panel5.TabIndex = 16;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Lime;
            this.addBtn.BackgroundColor = System.Drawing.Color.Lime;
            this.addBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addBtn.BorderRadius = 15;
            this.addBtn.BorderSize = 0;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(439, 124);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(135, 45);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "Tambah";
            this.addBtn.TextColor = System.Drawing.Color.White;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // cmbgender
            // 
            this.cmbgender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbgender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmbgender.BorderSize = 1;
            this.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbgender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbgender.ForeColor = System.Drawing.Color.DimGray;
            this.cmbgender.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbgender.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbgender.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbgender.Location = new System.Drawing.Point(139, 191);
            this.cmbgender.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Padding = new System.Windows.Forms.Padding(1);
            this.cmbgender.Size = new System.Drawing.Size(272, 42);
            this.cmbgender.TabIndex = 18;
            this.cmbgender.Texts = "";
            this.cmbgender.OnSelectedIndexChanged += new System.EventHandler(this.cmbgender_OnSelectedIndexChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.BackgroundColor = System.Drawing.Color.Red;
            this.clearBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.clearBtn.BorderRadius = 15;
            this.clearBtn.BorderSize = 0;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(591, 124);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(135, 45);
            this.clearBtn.TabIndex = 19;
            this.clearBtn.Text = "Hapus ()";
            this.clearBtn.TextColor = System.Drawing.Color.White;
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click_2);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updateBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updateBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateBtn.BorderRadius = 15;
            this.updateBtn.BorderSize = 0;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(744, 124);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(135, 45);
            this.updateBtn.TabIndex = 20;
            this.updateBtn.Text = "Ubah ()";
            this.updateBtn.TextColor = System.Drawing.Color.White;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click_2);
            // 
            // cariTxt
            // 
            this.cariTxt.BackColor = System.Drawing.SystemColors.Window;
            this.cariTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cariTxt.BorderFocusColor = System.Drawing.Color.Yellow;
            this.cariTxt.BorderRadius = 15;
            this.cariTxt.BorderSize = 2;
            this.cariTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cariTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cariTxt.Location = new System.Drawing.Point(506, 194);
            this.cariTxt.Margin = new System.Windows.Forms.Padding(4);
            this.cariTxt.Multiline = false;
            this.cariTxt.Name = "cariTxt";
            this.cariTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cariTxt.PasswordChar = false;
            this.cariTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cariTxt.PlaceholderText = "";
            this.cariTxt.Size = new System.Drawing.Size(432, 39);
            this.cariTxt.TabIndex = 21;
            this.cariTxt.Texts = "";
            this.cariTxt.UnderlinedStyle = false;
            this.cariTxt._TextChanged += new System.EventHandler(this.searchBtn__TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(896, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cekKas
            // 
            this.cekKas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cekKas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cekKas.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cekKas.BorderRadius = 15;
            this.cekKas.BorderSize = 0;
            this.cekKas.FlatAppearance.BorderSize = 0;
            this.cekKas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekKas.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cekKas.ForeColor = System.Drawing.Color.White;
            this.cekKas.Location = new System.Drawing.Point(885, 124);
            this.cekKas.Name = "cekKas";
            this.cekKas.Size = new System.Drawing.Size(135, 45);
            this.cekKas.TabIndex = 23;
            this.cekKas.Text = "cek Kas";
            this.cekKas.TextColor = System.Drawing.Color.White;
            this.cekKas.UseVisualStyleBackColor = false;
            this.cekKas.Click += new System.EventHandler(this.cekKas_Click);
            // 
            // Anggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 625);
            this.Controls.Add(this.cekKas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cariTxt);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Txtrows);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txtnim);
            this.Controls.Add(this.Txtnama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anggota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Anggota_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private TextBox Txtnama;
        private TextBox Txtnim;
        private DataGridView dataGridView1;
        private Label Txtrows;
        private Label backBtn;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private RJCodeAdvance.RJControls.RJButton addBtn;
        private RJCodeAdvance.RJControls.RJComboBox cmbgender;
        private RJCodeAdvance.RJControls.RJButton clearBtn;
        private RJCodeAdvance.RJControls.RJButton updateBtn;
        private RJCodeAdvance.RJControls.RJTextBox cariTxt;
        private PictureBox pictureBox2;
        private RJCodeAdvance.RJControls.RJButton cekKas;
    }
}