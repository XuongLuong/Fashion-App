
namespace FormDangNhap
{
    partial class NHANVIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NHANVIEN));
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.colmanhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDong = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.Button();
            this.txtXoa = new System.Windows.Forms.Button();
            this.txtSua = new System.Windows.Forms.Button();
            this.txtThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            resources.ApplyResources(this.label, "label");
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Name = "label";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // txtmanhanvien
            // 
            resources.ApplyResources(this.txtmanhanvien, "txtmanhanvien");
            this.txtmanhanvien.Name = "txtmanhanvien";
            // 
            // txttennhanvien
            // 
            resources.ApplyResources(this.txttennhanvien, "txttennhanvien");
            this.txttennhanvien.Name = "txttennhanvien";
            // 
            // txtdienthoai
            // 
            resources.ApplyResources(this.txtdienthoai, "txtdienthoai");
            this.txtdienthoai.Name = "txtdienthoai";
            // 
            // txtdiachi
            // 
            resources.ApplyResources(this.txtdiachi, "txtdiachi");
            this.txtdiachi.Name = "txtdiachi";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Name = "label1";
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.AllowUserToAddRows = false;
            this.dgvnhanvien.AllowUserToDeleteRows = false;
            this.dgvnhanvien.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmanhanvien,
            this.coltennhanvien,
            this.colgioitinh,
            this.coldiachi,
            this.coldienthoai,
            this.colngaysinh});
            resources.ApplyResources(this.dgvnhanvien, "dgvnhanvien");
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.ReadOnly = true;
            this.dgvnhanvien.RowTemplate.Height = 24;
            this.dgvnhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvnhanvien.DoubleClick += new System.EventHandler(this.dgvnhanvien_DoubleClick);
            // 
            // colmanhanvien
            // 
            this.colmanhanvien.DataPropertyName = "MaNhanVien";
            resources.ApplyResources(this.colmanhanvien, "colmanhanvien");
            this.colmanhanvien.Name = "colmanhanvien";
            this.colmanhanvien.ReadOnly = true;
            // 
            // coltennhanvien
            // 
            this.coltennhanvien.DataPropertyName = "TenNhanVien";
            resources.ApplyResources(this.coltennhanvien, "coltennhanvien");
            this.coltennhanvien.Name = "coltennhanvien";
            this.coltennhanvien.ReadOnly = true;
            // 
            // colgioitinh
            // 
            this.colgioitinh.DataPropertyName = "GioiTinh";
            resources.ApplyResources(this.colgioitinh, "colgioitinh");
            this.colgioitinh.Name = "colgioitinh";
            this.colgioitinh.ReadOnly = true;
            // 
            // coldiachi
            // 
            this.coldiachi.DataPropertyName = "DiaChi";
            resources.ApplyResources(this.coldiachi, "coldiachi");
            this.coldiachi.Name = "coldiachi";
            this.coldiachi.ReadOnly = true;
            // 
            // coldienthoai
            // 
            this.coldienthoai.DataPropertyName = "DienThoai";
            resources.ApplyResources(this.coldienthoai, "coldienthoai");
            this.coldienthoai.Name = "coldienthoai";
            this.coldienthoai.ReadOnly = true;
            // 
            // colngaysinh
            // 
            this.colngaysinh.DataPropertyName = "NgaySinh";
            resources.ApplyResources(this.colngaysinh, "colngaysinh");
            this.colngaysinh.Name = "colngaysinh";
            this.colngaysinh.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvnhanvien);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dTNgaySinh
            // 
            resources.ApplyResources(this.dTNgaySinh, "dTNgaySinh");
            this.dTNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTNgaySinh.Name = "dTNgaySinh";
            // 
            // rbNu
            // 
            resources.ApplyResources(this.rbNu, "rbNu");
            this.rbNu.Name = "rbNu";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            resources.ApplyResources(this.rbNam, "rbNam");
            this.rbNam.Checked = true;
            this.rbNam.Name = "rbNam";
            this.rbNam.TabStop = true;
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FormDangNhap.Properties.Resources.kisspng_faculty_clip_art_staff_icon_5b5c6243700af9_9248638215327811234589;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormDangNhap.Properties.Resources.kisspng_faculty_clip_art_staff_icon_5b5c6243700af9_9248638215327811234589;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // txtDong
            // 
            this.txtDong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDong.Image = global::FormDangNhap.Properties.Resources.cancel7;
            resources.ApplyResources(this.txtDong, "txtDong");
            this.txtDong.Name = "txtDong";
            this.txtDong.UseVisualStyleBackColor = false;
            this.txtDong.Click += new System.EventHandler(this.txtDong_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTimKiem.Image = global::FormDangNhap.Properties.Resources.Find5;
            resources.ApplyResources(this.txtTimKiem, "txtTimKiem");
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.UseVisualStyleBackColor = false;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            // 
            // txtXoa
            // 
            this.txtXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtXoa.Image = global::FormDangNhap.Properties.Resources.delete5;
            resources.ApplyResources(this.txtXoa, "txtXoa");
            this.txtXoa.Name = "txtXoa";
            this.txtXoa.UseVisualStyleBackColor = false;
            this.txtXoa.Click += new System.EventHandler(this.txtXoa_Click);
            // 
            // txtSua
            // 
            this.txtSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSua.Image = global::FormDangNhap.Properties.Resources.update5;
            resources.ApplyResources(this.txtSua, "txtSua");
            this.txtSua.Name = "txtSua";
            this.txtSua.UseVisualStyleBackColor = false;
            this.txtSua.Click += new System.EventHandler(this.txtSua_Click);
            // 
            // txtThem
            // 
            this.txtThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtThem.Image = global::FormDangNhap.Properties.Resources.add15;
            resources.ApplyResources(this.txtThem, "txtThem");
            this.txtThem.Name = "txtThem";
            this.txtThem.UseVisualStyleBackColor = false;
            this.txtThem.Click += new System.EventHandler(this.txtThem_Click);
            // 
            // NHANVIEN
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.dTNgaySinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDong);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtXoa);
            this.Controls.Add(this.txtSua);
            this.Controls.Add(this.txtThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtdienthoai);
            this.Controls.Add(this.txttennhanvien);
            this.Controls.Add(this.txtmanhanvien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Name = "NHANVIEN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NHANVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtThem;
        private System.Windows.Forms.Button txtSua;
        private System.Windows.Forms.Button txtXoa;
        private System.Windows.Forms.Button txtTimKiem;
        private System.Windows.Forms.Button txtDong;
        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmanhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colngaysinh;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.DateTimePicker dTNgaySinh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}