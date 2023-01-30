
namespace FormDangNhap
{
    partial class CHATLIEU
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
            this.dgvchatlieu = new System.Windows.Forms.DataGridView();
            this.colmachatlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltenchatlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.txtmachatlieu = new System.Windows.Forms.TextBox();
            this.txttenchatlieu = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDong = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.Button();
            this.txtXoa = new System.Windows.Forms.Button();
            this.txtSua = new System.Windows.Forms.Button();
            this.txtThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchatlieu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvchatlieu
            // 
            this.dgvchatlieu.AllowUserToAddRows = false;
            this.dgvchatlieu.AllowUserToDeleteRows = false;
            this.dgvchatlieu.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvchatlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchatlieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmachatlieu,
            this.coltenchatlieu});
            this.dgvchatlieu.Location = new System.Drawing.Point(6, 34);
            this.dgvchatlieu.Name = "dgvchatlieu";
            this.dgvchatlieu.ReadOnly = true;
            this.dgvchatlieu.RowHeadersWidth = 51;
            this.dgvchatlieu.RowTemplate.Height = 24;
            this.dgvchatlieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvchatlieu.Size = new System.Drawing.Size(603, 483);
            this.dgvchatlieu.TabIndex = 5;
            this.dgvchatlieu.DoubleClick += new System.EventHandler(this.dgvchatlieu_DoubleClick);
            // 
            // colmachatlieu
            // 
            this.colmachatlieu.DataPropertyName = "MaChatLieu";
            this.colmachatlieu.HeaderText = "Mã Chất Liệu";
            this.colmachatlieu.MinimumWidth = 3;
            this.colmachatlieu.Name = "colmachatlieu";
            this.colmachatlieu.ReadOnly = true;
            this.colmachatlieu.Width = 230;
            // 
            // coltenchatlieu
            // 
            this.coltenchatlieu.DataPropertyName = "TenChatLieu";
            this.coltenchatlieu.HeaderText = "Tên Chất Liệu";
            this.coltenchatlieu.MinimumWidth = 3;
            this.coltenchatlieu.Name = "coltenchatlieu";
            this.coltenchatlieu.ReadOnly = true;
            this.coltenchatlieu.Width = 240;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvchatlieu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(538, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 523);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Chất Liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(332, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 55);
            this.label1.TabIndex = 33;
            this.label1.Text = "Quản Lý Chất Liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên Chất Liệu";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.BackColor = System.Drawing.Color.White;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(17, 186);
            this.lable.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(141, 25);
            this.lable.TabIndex = 25;
            this.lable.Text = "Mã Chất Liệu";
            // 
            // txtmachatlieu
            // 
            this.txtmachatlieu.Location = new System.Drawing.Point(172, 186);
            this.txtmachatlieu.Name = "txtmachatlieu";
            this.txtmachatlieu.Size = new System.Drawing.Size(333, 22);
            this.txtmachatlieu.TabIndex = 29;
            // 
            // txttenchatlieu
            // 
            this.txttenchatlieu.Location = new System.Drawing.Point(172, 250);
            this.txttenchatlieu.Name = "txttenchatlieu";
            this.txttenchatlieu.Size = new System.Drawing.Size(333, 22);
            this.txttenchatlieu.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FormDangNhap.Properties.Resources.pngtree_meb_cute_cartoon_icon_material_is_commercially_available_cute_cartoon_icon_png_image_4026048;
            this.pictureBox2.Location = new System.Drawing.Point(780, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormDangNhap.Properties.Resources.pngtree_meb_cute_cartoon_icon_material_is_commercially_available_cute_cartoon_icon_png_image_4026048;
            this.pictureBox1.Location = new System.Drawing.Point(226, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // txtDong
            // 
            this.txtDong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDong.Image = global::FormDangNhap.Properties.Resources.cancel3;
            this.txtDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDong.Location = new System.Drawing.Point(320, 541);
            this.txtDong.Name = "txtDong";
            this.txtDong.Size = new System.Drawing.Size(154, 60);
            this.txtDong.TabIndex = 38;
            this.txtDong.Text = "ĐÓNG";
            this.txtDong.UseVisualStyleBackColor = false;
            this.txtDong.Click += new System.EventHandler(this.txtDong_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Image = global::FormDangNhap.Properties.Resources.Find1;
            this.txtTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTimKiem.Location = new System.Drawing.Point(22, 541);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(181, 60);
            this.txtTimKiem.TabIndex = 37;
            this.txtTimKiem.Text = "TÌM KIẾM";
            this.txtTimKiem.UseVisualStyleBackColor = false;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            // 
            // txtXoa
            // 
            this.txtXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXoa.Image = global::FormDangNhap.Properties.Resources.delete1;
            this.txtXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtXoa.Location = new System.Drawing.Point(172, 451);
            this.txtXoa.Name = "txtXoa";
            this.txtXoa.Size = new System.Drawing.Size(154, 60);
            this.txtXoa.TabIndex = 36;
            this.txtXoa.Text = "XÓA";
            this.txtXoa.UseVisualStyleBackColor = false;
            this.txtXoa.Click += new System.EventHandler(this.txtXoa_Click);
            // 
            // txtSua
            // 
            this.txtSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSua.Image = global::FormDangNhap.Properties.Resources.update1;
            this.txtSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSua.Location = new System.Drawing.Point(320, 357);
            this.txtSua.Name = "txtSua";
            this.txtSua.Size = new System.Drawing.Size(167, 60);
            this.txtSua.TabIndex = 35;
            this.txtSua.Text = "SỬA";
            this.txtSua.UseVisualStyleBackColor = false;
            this.txtSua.Click += new System.EventHandler(this.txtSua_Click);
            // 
            // txtThem
            // 
            this.txtThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThem.Image = global::FormDangNhap.Properties.Resources.add11;
            this.txtThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtThem.Location = new System.Drawing.Point(22, 357);
            this.txtThem.Name = "txtThem";
            this.txtThem.Size = new System.Drawing.Size(165, 60);
            this.txtThem.TabIndex = 34;
            this.txtThem.Text = "THÊM";
            this.txtThem.UseVisualStyleBackColor = false;
            this.txtThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // CHATLIEU
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
            this.Controls.Add(this.txttenchatlieu);
            this.Controls.Add(this.txtmachatlieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable);
            this.Name = "CHATLIEU";
            this.Text = "Chất Liệu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CHATLIEU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchatlieu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvchatlieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtTimKiem;
        private System.Windows.Forms.Button txtThem;
        private System.Windows.Forms.Button txtXoa;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Button txtDong;
        private System.Windows.Forms.TextBox txtmachatlieu;
        private System.Windows.Forms.Button txtSua;
        private System.Windows.Forms.TextBox txttenchatlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmachatlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltenchatlieu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}