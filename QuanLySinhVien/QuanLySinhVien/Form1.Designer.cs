namespace QuanLySinhVien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            grbDSSV = new GroupBox();
            dgvKetQua = new DataGridView();
            grbThongTinSinhVien = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDiemTrungBinh = new TextBox();
            txtTenSinhVien = new TextBox();
            txtMSV = new TextBox();
            grbDSSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            grbThongTinSinhVien.SuspendLayout();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(46, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(119, 44);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(200, 30);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(119, 44);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(368, 30);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(119, 44);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(526, 30);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(119, 44);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // grbDSSV
            // 
            grbDSSV.Controls.Add(dgvKetQua);
            grbDSSV.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbDSSV.Location = new Point(46, 99);
            grbDSSV.Name = "grbDSSV";
            grbDSSV.Size = new Size(599, 480);
            grbDSSV.TabIndex = 4;
            grbDSSV.TabStop = false;
            grbDSSV.Text = "Danh Sách Sinh Viên";
            // 
            // dgvKetQua
            // 
            dgvKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQua.Location = new Point(17, 54);
            dgvKetQua.Name = "dgvKetQua";
            dgvKetQua.RowHeadersWidth = 51;
            dgvKetQua.Size = new Size(560, 403);
            dgvKetQua.TabIndex = 0;
            dgvKetQua.CellClick += dgvKetQua_CellClick;
            // 
            // grbThongTinSinhVien
            // 
            grbThongTinSinhVien.Controls.Add(label3);
            grbThongTinSinhVien.Controls.Add(label2);
            grbThongTinSinhVien.Controls.Add(label1);
            grbThongTinSinhVien.Controls.Add(txtDiemTrungBinh);
            grbThongTinSinhVien.Controls.Add(txtTenSinhVien);
            grbThongTinSinhVien.Controls.Add(txtMSV);
            grbThongTinSinhVien.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbThongTinSinhVien.Location = new Point(669, 99);
            grbThongTinSinhVien.Name = "grbThongTinSinhVien";
            grbThongTinSinhVien.Size = new Size(344, 480);
            grbThongTinSinhVien.TabIndex = 5;
            grbThongTinSinhVien.TabStop = false;
            grbThongTinSinhVien.Text = "Thông Tin Sinh Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 267);
            label3.Name = "label3";
            label3.Size = new Size(183, 31);
            label3.TabIndex = 5;
            label3.Text = "Điểm Trung Bình";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 170);
            label2.Name = "label2";
            label2.Size = new Size(155, 31);
            label2.TabIndex = 4;
            label2.Text = "Tên Sinh Viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 64);
            label1.Name = "label1";
            label1.Size = new Size(153, 31);
            label1.TabIndex = 3;
            label1.Text = "Mã Sinh Viên:";
            // 
            // txtDiemTrungBinh
            // 
            txtDiemTrungBinh.Location = new Point(25, 301);
            txtDiemTrungBinh.Name = "txtDiemTrungBinh";
            txtDiemTrungBinh.Size = new Size(294, 38);
            txtDiemTrungBinh.TabIndex = 2;
            txtDiemTrungBinh.TextChanged += textBox3_TextChanged;
            // 
            // txtTenSinhVien
            // 
            txtTenSinhVien.Location = new Point(25, 204);
            txtTenSinhVien.Name = "txtTenSinhVien";
            txtTenSinhVien.Size = new Size(294, 38);
            txtTenSinhVien.TabIndex = 1;
            // 
            // txtMSV
            // 
            txtMSV.Location = new Point(25, 98);
            txtMSV.Name = "txtMSV";
            txtMSV.Size = new Size(294, 38);
            txtMSV.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 616);
            Controls.Add(grbThongTinSinhVien);
            Controls.Add(grbDSSV);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "Form1";
            Text = "Quản Lý Hồ Sơ Sinh Viên VP102";
            Load += Form1_Load;
            grbDSSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
            grbThongTinSinhVien.ResumeLayout(false);
            grbThongTinSinhVien.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private GroupBox grbDSSV;
        private GroupBox grbThongTinSinhVien;
        private TextBox txtDiemTrungBinh;
        private TextBox txtTenSinhVien;
        private TextBox txtMSV;
        private DataGridView dgvKetQua;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
