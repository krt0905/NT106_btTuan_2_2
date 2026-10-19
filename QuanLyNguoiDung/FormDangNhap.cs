using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNguoiDung
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            GoiYTextBox.Dat(txtTenDangNhap, "nguyenvana");
        }

        public void XoaLoi()
        {
            lblLoi.Text = string.Empty;
        }

        private async void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                lblLoi.Text = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.";
                return;
            }

            lblLoi.Text = "";

            btnDangNhap.Enabled = false;
            btnDangNhap.Text = "Đang xử lý...";

            try
            {
                var db = new TruyCapDuLieu();

                // 1. Fetch login credentials for password verification
                var userRecord = await db.LayThongTinDangNhapAsync(txtTenDangNhap.Text);

                // Security check: Same error message for invalid user or wrong password
                if (userRecord == null || !MatKhau.KiemTra(txtMatKhau.Text, userRecord.Salt, userRecord.MatKhauBam))
                {
                    lblLoi.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                    return;
                }

                // 2. Update last login timestamp in database
                await db.CapNhatLanDangNhapCuoiAsync(userRecord.UserId);

                // 3. Fetch form display data (contains Email, NgayTao, LanDangNhapCuoi)
                var formInfo = await db.LayThongTinFormChinhAsync(txtTenDangNhap.Text);

                if (formInfo != null)
                {
                    FormChinh frmChinh = new FormChinh(
                        formInfo.HoTen,
                        formInfo.TenDangNhap,
                        formInfo.Email,
                        formInfo.NgayTao,
                        formInfo.LanDangNhapCuoi
                    );

                    this.Hide();
                    frmChinh.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể kết nối tới máy chủ SQL. Vui lòng thử lại sau.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lblLoi.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                txtMatKhau.Clear(); 
                txtMatKhau.Focus(); 
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkDangKy_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var frmDangKy = new FormDangKy())
            {
                Hide();
                DialogResult ketQua = frmDangKy.ShowDialog();
                Show();

                XoaLoi();
                if (ketQua == DialogResult.OK)
                {
                    txtTenDangNhap.Text = frmDangKy.TenDangNhapVuaTao;
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                }
                else
                {
                    txtTenDangNhap.Focus();
                }
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            XoaLoi();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            XoaLoi();
        }
    }
}
