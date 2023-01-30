
namespace FormDangNhap
{
    partial class HANGHOA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HANGHOA));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvhanghoa = new System.Windows.Forms.DataGridView();
            this.colmahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmachatlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgiaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmachatlieu = new System.Windows.Forms.TextBox();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.GiaBan = new System.Windows.Forms.Label();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDong = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.Button();
            this.txtXoa = new System.Windows.Forms.Button();
            this.txtSua = new System.Windows.Forms.Button();
            this.txtThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvhanghoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(523, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 511);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Hàng Hóa";
            // 
            // dgvhanghoa
            // 
            this.dgvhanghoa.AllowUserToAddRows = false;
            this.dgvhanghoa.AllowUserToDeleteRows = false;
            this.dgvhanghoa.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvhanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhanghoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmahang,
            this.coltenhang,
            this.colmachatlieu,
            this.colgiaban});
            this.dgvhanghoa.Location = new System.Drawing.Point(12, 29);
            this.dgvhanghoa.Name = "dgvhanghoa";
            this.dgvhanghoa.ReadOnly = true;
            this.dgvhanghoa.RowHeadersWidth = 51;
            this.dgvhanghoa.RowTemplate.Height = 24;
            this.dgvhanghoa.Size = new System.Drawing.Size(684, 472);
            this.dgvhanghoa.TabIndex = 4;
            this.dgvhanghoa.DoubleClick += new System.EventHandler(this.dgvhanghoa_DoubleClick);
            // 
            // colmahang
            // 
            this.colmahang.DataPropertyName = "MaHang";
            this.colmahang.HeaderText = "Mã Hàng";
            this.colmahang.MinimumWidth = 3;
            this.colmahang.Name = "colmahang";
            this.colmahang.ReadOnly = true;
            this.colmahang.Width = 150;
            // 
            // coltenhang
            // 
            this.coltenhang.DataPropertyName = "TenHang";
            this.coltenhang.HeaderText = "Tên Hàng";
            this.coltenhang.MinimumWidth = 3;
            this.coltenhang.Name = "coltenhang";
            this.coltenhang.ReadOnly = true;
            this.coltenhang.Width = 150;
            // 
            // colmachatlieu
            // 
            this.colmachatlieu.DataPropertyName = "MaChatLieu";
            this.colmachatlieu.HeaderText = "Mã Chất Liệu";
            this.colmachatlieu.MinimumWidth = 3;
            this.colmachatlieu.Name = "colmachatlieu";
            this.colmachatlieu.ReadOnly = true;
            this.colmachatlieu.Width = 180;
            // 
            // colgiaban
            // 
            this.colgiaban.DataPropertyName = "GiaBan";
            this.colgiaban.HeaderText = "Giá Bán";
            this.colgiaban.MinimumWidth = 3;
            this.colgiaban.Name = "colgiaban";
            this.colgiaban.ReadOnly = true;
            this.colgiaban.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(364, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 55);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quản Lý Hàng Hóa";
            // 
            // txtmachatlieu
            // 
            this.txtmachatlieu.Location = new System.Drawing.Point(168, 268);
            this.txtmachatlieu.Name = "txtmachatlieu";
            this.txtmachatlieu.Size = new System.Drawing.Size(296, 22);
            this.txtmachatlieu.TabIndex = 17;
            // 
            // txttenhang
            // 
            this.txttenhang.Location = new System.Drawing.Point(168, 210);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(296, 22);
            this.txttenhang.TabIndex = 13;
            // 
            // txtmahang
            // 
            this.txtmahang.Location = new System.Drawing.Point(168, 152);
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(296, 22);
            this.txtmahang.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã Chất Liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên Hàng";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(30, 148);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(99, 25);
            this.label.TabIndex = 6;
            this.label.Text = "Mã Hàng";
            // 
            // GiaBan
            // 
            this.GiaBan.AutoSize = true;
            this.GiaBan.BackColor = System.Drawing.Color.White;
            this.GiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaBan.Location = new System.Drawing.Point(30, 324);
            this.GiaBan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Size = new System.Drawing.Size(89, 25);
            this.GiaBan.TabIndex = 7;
            this.GiaBan.Text = "Giá Bán";
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(168, 324);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(296, 22);
            this.txtgiaban.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FormDangNhap.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(823, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormDangNhap.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(257, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // txtDong
            // 
            this.txtDong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDong.Image = global::FormDangNhap.Properties.Resources.cancel;
            this.txtDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDong.Location = new System.Drawing.Point(273, 576);
            this.txtDong.Name = "txtDong";
            this.txtDong.Size = new System.Drawing.Size(151, 60);
            this.txtDong.TabIndex = 23;
            this.txtDong.Text = "Đóng";
            this.txtDong.UseVisualStyleBackColor = false;
            this.txtDong.Click += new System.EventHandler(this.txtDong_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Image = global::FormDangNhap.Properties.Resources.Find;
            this.txtTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTimKiem.Location = new System.Drawing.Point(19, 576);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(172, 60);
            this.txtTimKiem.TabIndex = 22;
            this.txtTimKiem.Text = "Tìm kiếm";
            this.txtTimKiem.UseVisualStyleBackColor = false;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            // 
            // txtXoa
            // 
            this.txtXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXoa.Image = global::FormDangNhap.Properties.Resources.delete;
            this.txtXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtXoa.Location = new System.Drawing.Point(152, 484);
            this.txtXoa.Name = "txtXoa";
            this.txtXoa.Size = new System.Drawing.Size(145, 60);
            this.txtXoa.TabIndex = 21;
            this.txtXoa.Text = "Xóa";
            this.txtXoa.UseVisualStyleBackColor = false;
            this.txtXoa.Click += new System.EventHandler(this.txtXoa_Click);
            // 
            // txtSua
            // 
            this.txtSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSua.Image = global::FormDangNhap.Properties.Resources.update;
            this.txtSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSua.Location = new System.Drawing.Point(273, 388);
            this.txtSua.Name = "txtSua";
            this.txtSua.Size = new System.Drawing.Size(151, 60);
            this.txtSua.TabIndex = 20;
            this.txtSua.Text = "Sửa";
            this.txtSua.UseVisualStyleBackColor = false;
            this.txtSua.Click += new System.EventHandler(this.txtSua_Click);
            // 
            // txtThem
            // 
            this.txtThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThem.Image = global::FormDangNhap.Properties.Resources.add1;
            this.txtThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtThem.Location = new System.Drawing.Point(19, 388);
            this.txtThem.Name = "txtThem";
            this.txtThem.Size = new System.Drawing.Size(172, 60);
            this.txtThem.TabIndex = 19;
            this.txtThem.Text = "Thêm";
            this.txtThem.UseVisualStyleBackColor = false;
            this.txtThem.Click += new System.EventHandler(this.txtThem_Click);
            // 
            // HANGHOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1249, 703);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDong);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtXoa);
            this.Controls.Add(this.txtSua);
            this.Controls.Add(this.txtThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtgiaban);
            this.Controls.Add(this.txtmachatlieu);
            this.Controls.Add(this.txttenhang);
            this.Controls.Add(this.txtmahang);
            this.Controls.Add(this.GiaBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HANGHOA";
            this.Text = "Hàng Hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HANGHOA_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvhanghoa;
        private System.Windows.Forms.Button txtDong;
        private System.Windows.Forms.Button txtTimKiem;
        private System.Windows.Forms.Button txtXoa;
        private System.Windows.Forms.Button txtSua;
        private System.Windows.Forms.Button txtThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmachatlieu;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label GiaBan;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmachatlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgiaban;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}