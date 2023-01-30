
namespace FormDangNhap
{
    partial class HOADONBAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOADONBAN));
            this.dgvhoadonban = new System.Windows.Forms.DataGridView();
            this.colmahoadonban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmanhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colngayban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmakhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmakhach = new System.Windows.Forms.TextBox();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.txtmahoadonban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.dTNgayBan = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDong = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.Button();
            this.txtXoa = new System.Windows.Forms.Button();
            this.txtSua = new System.Windows.Forms.Button();
            this.txtThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadonban)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvhoadonban
            // 
            this.dgvhoadonban.AllowUserToAddRows = false;
            this.dgvhoadonban.AllowUserToDeleteRows = false;
            this.dgvhoadonban.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvhoadonban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadonban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmahoadonban,
            this.colmanhanvien,
            this.colngayban,
            this.colmakhach});
            this.dgvhoadonban.Location = new System.Drawing.Point(12, 28);
            this.dgvhoadonban.Name = "dgvhoadonban";
            this.dgvhoadonban.ReadOnly = true;
            this.dgvhoadonban.RowHeadersWidth = 51;
            this.dgvhoadonban.RowTemplate.Height = 24;
            this.dgvhoadonban.Size = new System.Drawing.Size(808, 528);
            this.dgvhoadonban.TabIndex = 5;
            this.dgvhoadonban.DoubleClick += new System.EventHandler(this.dgvhoadonban_DoubleClick);
            // 
            // colmahoadonban
            // 
            this.colmahoadonban.DataPropertyName = "MaHoaDonBan";
            this.colmahoadonban.HeaderText = "Mã HĐ Bán";
            this.colmahoadonban.MinimumWidth = 3;
            this.colmahoadonban.Name = "colmahoadonban";
            this.colmahoadonban.ReadOnly = true;
            this.colmahoadonban.Width = 180;
            // 
            // colmanhanvien
            // 
            this.colmanhanvien.DataPropertyName = "MaNhanVien";
            this.colmanhanvien.HeaderText = "Mã Nhân Viên";
            this.colmanhanvien.MinimumWidth = 3;
            this.colmanhanvien.Name = "colmanhanvien";
            this.colmanhanvien.ReadOnly = true;
            this.colmanhanvien.Width = 210;
            // 
            // colngayban
            // 
            this.colngayban.DataPropertyName = "NgayBan";
            this.colngayban.HeaderText = "Ngày Bán";
            this.colngayban.MinimumWidth = 3;
            this.colngayban.Name = "colngayban";
            this.colngayban.ReadOnly = true;
            this.colngayban.Width = 180;
            // 
            // colmakhach
            // 
            this.colmakhach.DataPropertyName = "MaKhach";
            this.colmakhach.HeaderText = "Mã Khách";
            this.colmakhach.MinimumWidth = 63;
            this.colmakhach.Name = "colmakhach";
            this.colmakhach.ReadOnly = true;
            this.colmakhach.Width = 180;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvhoadonban);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(406, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 565);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hóa Đơn Bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(441, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 55);
            this.label1.TabIndex = 33;
            this.label1.Text = "Hóa Đơn Bán";
            // 
            // txtmakhach
            // 
            this.txtmakhach.Location = new System.Drawing.Point(184, 341);
            this.txtmakhach.Multiline = true;
            this.txtmakhach.Name = "txtmakhach";
            this.txtmakhach.Size = new System.Drawing.Size(203, 25);
            this.txtmakhach.TabIndex = 32;
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(184, 219);
            this.txtmanhanvien.Multiline = true;
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(203, 25);
            this.txtmanhanvien.TabIndex = 30;
            // 
            // txtmahoadonban
            // 
            this.txtmahoadonban.Location = new System.Drawing.Point(184, 153);
            this.txtmahoadonban.Multiline = true;
            this.txtmahoadonban.Name = "txtmahoadonban";
            this.txtmahoadonban.Size = new System.Drawing.Size(203, 28);
            this.txtmahoadonban.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ngày Bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 341);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Mã Khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.BackColor = System.Drawing.Color.White;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(0, 156);
            this.lable.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(176, 25);
            this.lable.TabIndex = 25;
            this.lable.Text = "Mã Hóa Đơn Bán";
            // 
            // dTNgayBan
            // 
            this.dTNgayBan.CustomFormat = "dd/MM/yyyy";
            this.dTNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTNgayBan.Location = new System.Drawing.Point(184, 277);
            this.dTNgayBan.Name = "dTNgayBan";
            this.dTNgayBan.Size = new System.Drawing.Size(203, 22);
            this.dTNgayBan.TabIndex = 40;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FormDangNhap.Properties.Resources._5b97d164cf34a92436848649208c72fc;
            this.pictureBox2.Location = new System.Drawing.Point(769, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormDangNhap.Properties.Resources._5b97d164cf34a92436848649208c72fc;
            this.pictureBox1.Location = new System.Drawing.Point(325, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // txtDong
            // 
            this.txtDong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDong.Image = global::FormDangNhap.Properties.Resources.cancel5;
            this.txtDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDong.Location = new System.Drawing.Point(218, 610);
            this.txtDong.Name = "txtDong";
            this.txtDong.Size = new System.Drawing.Size(169, 60);
            this.txtDong.TabIndex = 38;
            this.txtDong.Text = "ĐÓNG";
            this.txtDong.UseVisualStyleBackColor = false;
            this.txtDong.Click += new System.EventHandler(this.txtDong_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Image = global::FormDangNhap.Properties.Resources.Find3;
            this.txtTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTimKiem.Location = new System.Drawing.Point(11, 610);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(171, 60);
            this.txtTimKiem.TabIndex = 37;
            this.txtTimKiem.Text = "TÌM KIẾM";
            this.txtTimKiem.UseVisualStyleBackColor = false;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            // 
            // txtXoa
            // 
            this.txtXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXoa.Image = global::FormDangNhap.Properties.Resources.delete3;
            this.txtXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtXoa.Location = new System.Drawing.Point(131, 509);
            this.txtXoa.Name = "txtXoa";
            this.txtXoa.Size = new System.Drawing.Size(160, 60);
            this.txtXoa.TabIndex = 36;
            this.txtXoa.Text = "XÓA";
            this.txtXoa.UseVisualStyleBackColor = false;
            this.txtXoa.Click += new System.EventHandler(this.txtXoa_Click);
            // 
            // txtSua
            // 
            this.txtSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSua.Image = global::FormDangNhap.Properties.Resources.update3;
            this.txtSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSua.Location = new System.Drawing.Point(218, 411);
            this.txtSua.Name = "txtSua";
            this.txtSua.Size = new System.Drawing.Size(169, 60);
            this.txtSua.TabIndex = 35;
            this.txtSua.Text = "SỬA";
            this.txtSua.UseVisualStyleBackColor = false;
            this.txtSua.Click += new System.EventHandler(this.txtSua_Click);
            // 
            // txtThem
            // 
            this.txtThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThem.Image = global::FormDangNhap.Properties.Resources.add13;
            this.txtThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtThem.Location = new System.Drawing.Point(19, 411);
            this.txtThem.Name = "txtThem";
            this.txtThem.Size = new System.Drawing.Size(157, 60);
            this.txtThem.TabIndex = 34;
            this.txtThem.Text = "THÊM";
            this.txtThem.UseVisualStyleBackColor = false;
            this.txtThem.Click += new System.EventHandler(this.txtThem_Click);
            // 
            // HOADONBAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1249, 703);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dTNgayBan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDong);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtXoa);
            this.Controls.Add(this.txtSua);
            this.Controls.Add(this.txtThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmakhach);
            this.Controls.Add(this.txtmanhanvien);
            this.Controls.Add(this.txtmahoadonban);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HOADONBAN";
            this.Text = "Hóa Đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HOADONBAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadonban)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvhoadonban;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txtDong;
        private System.Windows.Forms.Button txtTimKiem;
        private System.Windows.Forms.Button txtXoa;
        private System.Windows.Forms.Button txtSua;
        private System.Windows.Forms.Button txtThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmakhach;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.TextBox txtmahoadonban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.DateTimePicker dTNgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmahoadonban;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmanhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colngayban;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmakhach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}