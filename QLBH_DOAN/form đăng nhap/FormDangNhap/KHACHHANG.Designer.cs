
namespace FormDangNhap
{
    partial class KHACHHANG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KHACHHANG));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvkhachhang = new System.Windows.Forms.DataGridView();
            this.colmakhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltenkhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.txttenkhach = new System.Windows.Forms.TextBox();
            this.txtmakhach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDong = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.Button();
            this.txtXoa = new System.Windows.Forms.Button();
            this.txtSua = new System.Windows.Forms.Button();
            this.txtThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvkhachhang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1158, 332);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Khách Hàng";
            // 
            // dgvkhachhang
            // 
            this.dgvkhachhang.AllowUserToAddRows = false;
            this.dgvkhachhang.AllowUserToDeleteRows = false;
            this.dgvkhachhang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmakhach,
            this.coltenkhach,
            this.coldiachi,
            this.coldienthoai});
            this.dgvkhachhang.Location = new System.Drawing.Point(9, 25);
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.ReadOnly = true;
            this.dgvkhachhang.RowHeadersWidth = 51;
            this.dgvkhachhang.RowTemplate.Height = 24;
            this.dgvkhachhang.Size = new System.Drawing.Size(1140, 298);
            this.dgvkhachhang.TabIndex = 5;
            this.dgvkhachhang.DoubleClick += new System.EventHandler(this.dgvkhachhang_DoubleClick);
            // 
            // colmakhach
            // 
            this.colmakhach.DataPropertyName = "MaKhach";
            this.colmakhach.HeaderText = "Mã Khách";
            this.colmakhach.MinimumWidth = 3;
            this.colmakhach.Name = "colmakhach";
            this.colmakhach.ReadOnly = true;
            this.colmakhach.Width = 180;
            // 
            // coltenkhach
            // 
            this.coltenkhach.DataPropertyName = "TenKhach";
            this.coltenkhach.HeaderText = "Tên Khách";
            this.coltenkhach.MinimumWidth = 3;
            this.coltenkhach.Name = "coltenkhach";
            this.coltenkhach.ReadOnly = true;
            this.coltenkhach.Width = 210;
            // 
            // coldiachi
            // 
            this.coldiachi.DataPropertyName = "DiaChi";
            this.coldiachi.HeaderText = "Địa Chỉ";
            this.coldiachi.MinimumWidth = 3;
            this.coldiachi.Name = "coldiachi";
            this.coldiachi.ReadOnly = true;
            this.coldiachi.Width = 180;
            // 
            // coldienthoai
            // 
            this.coldienthoai.DataPropertyName = "DienThoai";
            this.coldienthoai.HeaderText = "Điện Thoại";
            this.coldienthoai.MinimumWidth = 63;
            this.coldienthoai.Name = "coldienthoai";
            this.coldienthoai.ReadOnly = true;
            this.coldienthoai.Width = 180;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(362, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 55);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quản Lý Khách Hàng";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(741, 184);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(333, 22);
            this.txtdiachi.TabIndex = 15;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(741, 121);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(333, 22);
            this.txtdienthoai.TabIndex = 14;
            // 
            // txttenkhach
            // 
            this.txttenkhach.Location = new System.Drawing.Point(192, 188);
            this.txttenkhach.Name = "txttenkhach";
            this.txttenkhach.Size = new System.Drawing.Size(333, 22);
            this.txttenkhach.TabIndex = 13;
            // 
            // txtmakhach
            // 
            this.txtmakhach.Location = new System.Drawing.Point(192, 117);
            this.txtmakhach.Name = "txtmakhach";
            this.txtmakhach.Size = new System.Drawing.Size(333, 22);
            this.txtmakhach.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(595, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Điện Thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(605, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên Khách";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.BackColor = System.Drawing.Color.White;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(37, 117);
            this.lable.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(110, 25);
            this.lable.TabIndex = 6;
            this.lable.Text = "Mã Khách";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FormDangNhap.Properties.Resources._11;
            this.pictureBox3.Location = new System.Drawing.Point(883, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormDangNhap.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(256, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // txtDong
            // 
            this.txtDong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDong.Image = global::FormDangNhap.Properties.Resources.cancel6;
            this.txtDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDong.Location = new System.Drawing.Point(924, 263);
            this.txtDong.Name = "txtDong";
            this.txtDong.Size = new System.Drawing.Size(150, 60);
            this.txtDong.TabIndex = 23;
            this.txtDong.Text = "ĐÓNG";
            this.txtDong.UseVisualStyleBackColor = false;
            this.txtDong.Click += new System.EventHandler(this.txtDong_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Image = global::FormDangNhap.Properties.Resources.Find4;
            this.txtTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTimKiem.Location = new System.Drawing.Point(703, 263);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(171, 60);
            this.txtTimKiem.TabIndex = 22;
            this.txtTimKiem.Text = "TÌM KIẾM";
            this.txtTimKiem.UseVisualStyleBackColor = false;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            // 
            // txtXoa
            // 
            this.txtXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXoa.Image = global::FormDangNhap.Properties.Resources.delete4;
            this.txtXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtXoa.Location = new System.Drawing.Point(493, 263);
            this.txtXoa.Name = "txtXoa";
            this.txtXoa.Size = new System.Drawing.Size(144, 60);
            this.txtXoa.TabIndex = 21;
            this.txtXoa.Text = "XÓA";
            this.txtXoa.UseVisualStyleBackColor = false;
            this.txtXoa.Click += new System.EventHandler(this.txtXoa_Click);
            // 
            // txtSua
            // 
            this.txtSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSua.Image = global::FormDangNhap.Properties.Resources.update4;
            this.txtSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSua.Location = new System.Drawing.Point(293, 263);
            this.txtSua.Name = "txtSua";
            this.txtSua.Size = new System.Drawing.Size(144, 60);
            this.txtSua.TabIndex = 20;
            this.txtSua.Text = "SỬA";
            this.txtSua.UseVisualStyleBackColor = false;
            this.txtSua.Click += new System.EventHandler(this.txtSua_Click);
            // 
            // txtThem
            // 
            this.txtThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThem.Image = global::FormDangNhap.Properties.Resources.add14;
            this.txtThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtThem.Location = new System.Drawing.Point(64, 263);
            this.txtThem.Name = "txtThem";
            this.txtThem.Size = new System.Drawing.Size(150, 60);
            this.txtThem.TabIndex = 19;
            this.txtThem.Text = "THÊM";
            this.txtThem.UseVisualStyleBackColor = false;
            this.txtThem.Click += new System.EventHandler(this.txtThem_Click);
            // 
            // KHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1249, 703);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDong);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtXoa);
            this.Controls.Add(this.txtSua);
            this.Controls.Add(this.txtThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtdienthoai);
            this.Controls.Add(this.txttenkhach);
            this.Controls.Add(this.txtmakhach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KHACHHANG";
            this.Text = "Khách Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KHACHHANG_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txtDong;
        private System.Windows.Forms.Button txtTimKiem;
        private System.Windows.Forms.Button txtXoa;
        private System.Windows.Forms.Button txtSua;
        private System.Windows.Forms.Button txtThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.TextBox txttenkhach;
        private System.Windows.Forms.TextBox txtmakhach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.DataGridView dgvkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmakhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltenkhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldienthoai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}