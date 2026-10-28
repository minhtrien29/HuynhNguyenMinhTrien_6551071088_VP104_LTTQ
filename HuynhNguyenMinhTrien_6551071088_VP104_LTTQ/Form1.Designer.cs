namespace HuynhNguyenMinhTrien_6551071088_VP104_LTTQ
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
            gbThongTinNhanVien = new GroupBox();
            txtLuongCoBan = new TextBox();
            txtTenNhanVien = new TextBox();
            txtMaNhanVien = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbThaoTac = new GroupBox();
            gbCacChucNang = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            gbDanhSachNhanVien = new GroupBox();
            dgvDanhSachNhanVien = new DataGridView();
            gbThongTinNhanVien.SuspendLayout();
            gbThaoTac.SuspendLayout();
            gbCacChucNang.SuspendLayout();
            gbDanhSachNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).BeginInit();
            SuspendLayout();
            // 
            // gbThongTinNhanVien
            // 
            gbThongTinNhanVien.Controls.Add(txtLuongCoBan);
            gbThongTinNhanVien.Controls.Add(txtTenNhanVien);
            gbThongTinNhanVien.Controls.Add(txtMaNhanVien);
            gbThongTinNhanVien.Controls.Add(label3);
            gbThongTinNhanVien.Controls.Add(label2);
            gbThongTinNhanVien.Controls.Add(label1);
            gbThongTinNhanVien.Location = new Point(42, 42);
            gbThongTinNhanVien.Name = "gbThongTinNhanVien";
            gbThongTinNhanVien.Size = new Size(588, 196);
            gbThongTinNhanVien.TabIndex = 0;
            gbThongTinNhanVien.TabStop = false;
            gbThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.Location = new Point(139, 145);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.Size = new Size(394, 27);
            txtLuongCoBan.TabIndex = 5;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(143, 94);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(390, 27);
            txtTenNhanVien.TabIndex = 4;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(144, 39);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(389, 27);
            txtMaNhanVien.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 140);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Lương cơ bản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 93);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 41);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // gbThaoTac
            // 
            gbThaoTac.Controls.Add(gbCacChucNang);
            gbThaoTac.Location = new Point(673, 42);
            gbThaoTac.Name = "gbThaoTac";
            gbThaoTac.Size = new Size(329, 194);
            gbThaoTac.TabIndex = 1;
            gbThaoTac.TabStop = false;
            gbThaoTac.Text = "Thao tác";
            // 
            // gbCacChucNang
            // 
            gbCacChucNang.Controls.Add(btnXoa);
            gbCacChucNang.Controls.Add(btnSua);
            gbCacChucNang.Controls.Add(btnThoat);
            gbCacChucNang.Controls.Add(btnThem);
            gbCacChucNang.Location = new Point(21, 26);
            gbCacChucNang.Name = "gbCacChucNang";
            gbCacChucNang.Size = new Size(286, 162);
            gbCacChucNang.TabIndex = 0;
            gbCacChucNang.TabStop = false;
            gbCacChucNang.Text = "Các chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(153, 104);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 30);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(30, 105);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(147, 48);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 33);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(29, 50);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 28);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // gbDanhSachNhanVien
            // 
            gbDanhSachNhanVien.Controls.Add(dgvDanhSachNhanVien);
            gbDanhSachNhanVien.Location = new Point(38, 260);
            gbDanhSachNhanVien.Name = "gbDanhSachNhanVien";
            gbDanhSachNhanVien.Size = new Size(966, 330);
            gbDanhSachNhanVien.TabIndex = 2;
            gbDanhSachNhanVien.TabStop = false;
            gbDanhSachNhanVien.Text = "Danh sách nhân viên";
            // 
            // dgvDanhSachNhanVien
            // 
            dgvDanhSachNhanVien.AllowUserToAddRows = false;
            dgvDanhSachNhanVien.AllowUserToDeleteRows = false;
            dgvDanhSachNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNhanVien.Location = new Point(4, 25);
            dgvDanhSachNhanVien.MultiSelect = false;
            dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            dgvDanhSachNhanVien.ReadOnly = true;
            dgvDanhSachNhanVien.RowHeadersWidth = 51;
            dgvDanhSachNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachNhanVien.Size = new Size(956, 299);
            dgvDanhSachNhanVien.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 603);
            Controls.Add(gbDanhSachNhanVien);
            Controls.Add(gbThaoTac);
            Controls.Add(gbThongTinNhanVien);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbThongTinNhanVien.ResumeLayout(false);
            gbThongTinNhanVien.PerformLayout();
            gbThaoTac.ResumeLayout(false);
            gbCacChucNang.ResumeLayout(false);
            gbDanhSachNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbThongTinNhanVien;
        private TextBox txtLuongCoBan;
        private TextBox txtTenNhanVien;
        private TextBox txtMaNhanVien;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gbThaoTac;
        private GroupBox gbCacChucNang;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThoat;
        private Button btnThem;
        private GroupBox gbDanhSachNhanVien;
        private DataGridView dgvDanhSachNhanVien;
    }
}
