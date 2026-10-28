using HuynhNguyenMinhTrien_6551071088_VP104_LTTQ.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace HuynhNguyenMinhTrien_6551071088_VP104_LTTQ

{
    public partial class Form1 : Form
    {
        private DuLieu_NhanSuContext _context = new DuLieu_NhanSuContext();

        private async Task LoadDataAsync()
        {
            var list = await _context.NhanViens
                .Select(x => new
                {
                    x.MaNhanVien,
                    x.TenNhanVien,
                    x.LuongCoBan
                })
                .ToListAsync();

            dgvDanhSachNhanVien.DataSource = list;
            dgvDanhSachNhanVien.ClearSelection();
            dgvDanhSachNhanVien.CurrentCell = null;
            ClearInputs();
        }

        private void SetButtonState(bool dangChonDong)
        {
            btnThem.Enabled = !dangChonDong;
            btnSua.Enabled = dangChonDong;
            btnXoa.Enabled = dangChonDong;
            txtMaNhanVien.ReadOnly = dangChonDong;
        }

        private static bool IsValidSalary(string value)
        {
            return decimal.TryParse(value, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal salary)
                && salary >= 0;
        }

        private void ClearInputs()
        {
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            txtLuongCoBan.Clear();
            txtMaNhanVien.ReadOnly = false;
            SetButtonState(false);
        }

        private void dgvDanhSachNhanVien_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvDanhSachNhanVien.SelectedRows.Count == 0)
            {
                SetButtonState(false);
                return;
            }

            var row = dgvDanhSachNhanVien.SelectedRows[0];
            txtMaNhanVien.Text = row.Cells[nameof(NhanVien.MaNhanVien)].Value?.ToString() ?? string.Empty;
            txtTenNhanVien.Text = row.Cells[nameof(NhanVien.TenNhanVien)].Value?.ToString() ?? string.Empty;
            txtLuongCoBan.Text = row.Cells[nameof(NhanVien.LuongCoBan)].Value?.ToString() ?? string.Empty;
            SetButtonState(true);
        }

        private void dgvDanhSachNhanVien_MouseClick(object? sender, MouseEventArgs e)
        {
            if (dgvDanhSachNhanVien.HitTest(e.X, e.Y).RowIndex < 0)
            {
                dgvDanhSachNhanVien.ClearSelection();
                dgvDanhSachNhanVien.CurrentCell = null;
                ClearInputs();
            }
        }

        public Form1()
        {
            InitializeComponent();
            dgvDanhSachNhanVien.SelectionChanged += dgvDanhSachNhanVien_SelectionChanged;
            dgvDanhSachNhanVien.MouseClick += dgvDanhSachNhanVien_MouseClick;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            SetButtonState(false);
            await LoadDataAsync();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult hoi = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );


            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            DialogResult hoi = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa dữ liệu này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (hoi != DialogResult.Yes)
            {
                return;
            }

            try
            {
                string ma = txtMaNhanVien.Text.Trim();
                var item = await _context.NhanViens.FindAsync(ma);
                if (item == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    await LoadDataAsync();
                    return;
                }

                _context.NhanViens.Remove(item);
                await _context.SaveChangesAsync();
                MessageBox.Show("Xóa thành công!");
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaNhanVien.Text.Trim();
            string ten = txtTenNhanVien.Text.Trim();
            string luong = txtLuongCoBan.Text.Trim();

            if (string.IsNullOrWhiteSpace(ma))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!");
                txtMaNhanVien.Focus();
                return;
            }

            if (ma.Length > 10)
            {
                MessageBox.Show("Mã nhân viên không được vượt quá 10 ký tự!");
                txtMaNhanVien.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!");
                txtTenNhanVien.Focus();
                return;
            }

            if (!IsValidSalary(luong))
            {
                MessageBox.Show("Lương cơ bản phải là số nguyên hoặc số thực không âm!");
                txtLuongCoBan.Focus();
                return;
            }

            try
            {
                bool daTonTai = await _context.NhanViens.AnyAsync(x => x.MaNhanVien == ma);
                if (daTonTai)
                {
                    MessageBox.Show("Mã nhân viên này đã tồn tại!");
                    txtMaNhanVien.Focus();
                    return;
                }

                var moi = new NhanVien
                {
                    MaNhanVien = ma,
                    TenNhanVien = ten,
                    LuongCoBan = luong
                };

                _context.NhanViens.Add(moi);
                await _context.SaveChangesAsync();
                MessageBox.Show("Thêm mới thành công!");
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.");
                return;
            }

            string ten = txtTenNhanVien.Text.Trim();
            string luong = txtLuongCoBan.Text.Trim();
            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Tên nhân viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }

            if (!IsValidSalary(luong))
            {
                MessageBox.Show("Lương cơ bản phải là số nguyên hoặc số thực không âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuongCoBan.Focus();
                return;
            }

            try
            {
                string ma = dgvDanhSachNhanVien.SelectedRows[0].Cells[nameof(NhanVien.MaNhanVien)].Value?.ToString() ?? string.Empty;
                var nv = await _context.NhanViens.FindAsync(ma);
                if (nv == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    await LoadDataAsync();
                    return;
                }

                nv.TenNhanVien = ten;
                nv.LuongCoBan = luong;
                await _context.SaveChangesAsync();
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



