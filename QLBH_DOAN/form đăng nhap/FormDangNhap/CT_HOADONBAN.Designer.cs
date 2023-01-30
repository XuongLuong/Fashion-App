
namespace FormDangNhap
{
    partial class CT_HOADONBAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CT_HOADONBAN));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.numSlg = new System.Windows.Forms.NumericUpDown();
            this.cbHangHoa = new System.Windows.Forms.ComboBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.cbChatLieu = new System.Windows.Forms.ComboBox();
            this.dgvchitiethdban = new System.Windows.Forms.DataGridView();
            this.colmact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmahoadonban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colthanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.cbMaHd = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSlg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitiethdban)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.numSlg);
            this.groupBox1.Controls.Add(this.cbHangHoa);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.cbChatLieu);
            this.groupBox1.Controls.Add(this.dgvchitiethdban);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 495);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Chi Tiết";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = global::FormDangNhap.Properties.Resources.cancel4;
            this.btnDong.Location = new System.Drawing.Point(314, 400);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(102, 53);
            this.btnDong.TabIndex = 23;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // numSlg
            // 
            this.numSlg.Location = new System.Drawing.Point(314, 135);
            this.numSlg.Name = "numSlg";
            this.numSlg.Size = new System.Drawing.Size(102, 28);
            this.numSlg.TabIndex = 22;
            this.numSlg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbHangHoa
            // 
            this.cbHangHoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHangHoa.FormattingEnabled = true;
            this.cbHangHoa.Location = new System.Drawing.Point(6, 260);
            this.cbHangHoa.Name = "cbHangHoa";
            this.cbHangHoa.Size = new System.Drawing.Size(302, 226);
            this.cbHangHoa.TabIndex = 6;
            this.cbHangHoa.Text = "SẢN PHẨM";
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = global::FormDangNhap.Properties.Resources.update2;
            this.btSua.Location = new System.Drawing.Point(314, 205);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(102, 51);
            this.btSua.TabIndex = 20;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = global::FormDangNhap.Properties.Resources.delete2;
            this.btXoa.Location = new System.Drawing.Point(314, 306);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(102, 54);
            this.btXoa.TabIndex = 21;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // cbChatLieu
            // 
            this.cbChatLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbChatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChatLieu.FormattingEnabled = true;
            this.cbChatLieu.Location = new System.Drawing.Point(6, 60);
            this.cbChatLieu.Name = "cbChatLieu";
            this.cbChatLieu.Size = new System.Drawing.Size(302, 186);
            this.cbChatLieu.TabIndex = 5;
            this.cbChatLieu.Text = "CHẤT LIỆU";
            this.cbChatLieu.SelectedIndexChanged += new System.EventHandler(this.cbChatLieu_SelectedIndexChanged);
            // 
            // dgvchitiethdban
            // 
            this.dgvchitiethdban.AllowUserToAddRows = false;
            this.dgvchitiethdban.AllowUserToDeleteRows = false;
            this.dgvchitiethdban.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvchitiethdban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchitiethdban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmact,
            this.colmahoadonban,
            this.colmahang,
            this.colsoluong,
            this.colthanhtien});
            this.dgvchitiethdban.Location = new System.Drawing.Point(422, 49);
            this.dgvchitiethdban.Name = "dgvchitiethdban";
            this.dgvchitiethdban.ReadOnly = true;
            this.dgvchitiethdban.RowHeadersWidth = 51;
            this.dgvchitiethdban.RowTemplate.Height = 24;
            this.dgvchitiethdban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvchitiethdban.Size = new System.Drawing.Size(802, 426);
            this.dgvchitiethdban.TabIndex = 4;
            this.dgvchitiethdban.DoubleClick += new System.EventHandler(this.dgvchitiethdban_DoubleClick);
            // 
            // colmact
            // 
            this.colmact.DataPropertyName = "MaCT";
            this.colmact.HeaderText = "Mã Chi Tiết";
            this.colmact.MinimumWidth = 3;
            this.colmact.Name = "colmact";
            this.colmact.ReadOnly = true;
            this.colmact.Width = 130;
            // 
            // colmahoadonban
            // 
            this.colmahoadonban.DataPropertyName = "MaHoaDonBan";
            this.colmahoadonban.HeaderText = "Mã Hóa Đơn Bán";
            this.colmahoadonban.MinimumWidth = 3;
            this.colmahoadonban.Name = "colmahoadonban";
            this.colmahoadonban.ReadOnly = true;
            this.colmahoadonban.Width = 130;
            // 
            // colmahang
            // 
            this.colmahang.DataPropertyName = "TenHang";
            this.colmahang.HeaderText = "Tên Sản Phẩm";
            this.colmahang.MinimumWidth = 3;
            this.colmahang.Name = "colmahang";
            this.colmahang.ReadOnly = true;
            this.colmahang.Width = 170;
            // 
            // colsoluong
            // 
            this.colsoluong.DataPropertyName = "SoLuong";
            this.colsoluong.HeaderText = "Số Lượng";
            this.colsoluong.MinimumWidth = 3;
            this.colsoluong.Name = "colsoluong";
            this.colsoluong.ReadOnly = true;
            this.colsoluong.Width = 120;
            // 
            // colthanhtien
            // 
            this.colthanhtien.DataPropertyName = "ThanhTien";
            this.colthanhtien.HeaderText = "Thành Tiền";
            this.colthanhtien.MinimumWidth = 63;
            this.colthanhtien.Name = "colthanhtien";
            this.colthanhtien.ReadOnly = true;
            this.colthanhtien.Width = 180;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = global::FormDangNhap.Properties.Resources.add12;
            this.btThem.Location = new System.Drawing.Point(314, 49);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(102, 52);
            this.btThem.TabIndex = 19;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(363, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 55);
            this.label1.TabIndex = 18;
            this.label1.Text = "Chi Tiết Hóa Đơn Bán";
            // 
            // txtmact
            // 
            this.txtmact.Location = new System.Drawing.Point(152, 97);
            this.txtmact.Name = "txtmact";
            this.txtmact.Size = new System.Drawing.Size(326, 22);
            this.txtmact.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã Chi Tiết";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(602, 97);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(176, 25);
            this.label.TabIndex = 6;
            this.label.Text = "Mã Hóa Đơn Bán";
            // 
            // cbMaHd
            // 
            this.cbMaHd.FormattingEnabled = true;
            this.cbMaHd.Location = new System.Drawing.Point(795, 98);
            this.cbMaHd.Name = "cbMaHd";
            this.cbMaHd.Size = new System.Drawing.Size(343, 24);
            this.cbMaHd.TabIndex = 25;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Image = global::FormDangNhap.Properties.Resources.Find2;
            this.txtTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTimKiem.Location = new System.Drawing.Point(1081, 139);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(156, 51);
            this.txtTimKiem.TabIndex = 22;
            this.txtTimKiem.Text = "TÌM KIẾM";
            this.txtTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtTimKiem.UseVisualStyleBackColor = false;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            // 
            // CT_HOADONBAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1249, 703);
            this.Controls.Add(this.cbMaHd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CT_HOADONBAN";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CT_HOADONBAN_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSlg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitiethdban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvchitiethdban;
        private System.Windows.Forms.Button txtTimKiem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.NumericUpDown numSlg;
        private System.Windows.Forms.ComboBox cbHangHoa;
        private System.Windows.Forms.ComboBox cbChatLieu;
        private System.Windows.Forms.ComboBox cbMaHd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmahoadonban;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colthanhtien;
        private System.Windows.Forms.Button btnDong;
    }
}