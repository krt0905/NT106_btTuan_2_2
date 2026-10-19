using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNguoiDung
{
    public partial class FormDangKy : Form
    {
     
        private const int TEN_DANG_NHAP_MIN = 3;
        private const int TEN_DANG_NHAP_MAX = 20;
        private const int MAT_KHAU_MIN = 8;
        private const int MAT_KHAU_MAX = 64;
        private const int HO_TEN_MAX = 50;
        private const int EMAIL_MAX = 100;

        private static readonly Regex MauEmail =
            new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);

        public string TenDangNhapVuaTao { get; private set; } = string.Empty;

        public FormDangKy()
        {
            InitializeComponent();
            GanSuKien();
            GoiYTextBox.Dat(txtTenDangNhap, "3-20 ký tự");
            GoiYTextBox.Dat(txtHoTen, "Nguyễn Văn A");
            GoiYTextBox.Dat(txtMatKhau, "tối thiểu 8 ký tự");
            GoiYTextBox.Dat(txtXacNhanMatKhau, "nhập lại mật khẩu");
            GoiYTextBox.Dat(txtEmail, "ten@mien.com");
        }


        private void GanSuKien()
        {
            txtTenDangNhap.TextChanged += txtTenDangNhap_TextChanged;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            txtXacNhanMatKhau.TextChanged += txtXacNhanMatKhau_TextChanged;
            txtEmail.TextChanged += txtEmail_TextChanged;
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            lblLoiTenDangNhap.Text = string.Empty;
            lblLoiChung.Text = string.Empty;
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            lblLoiHoTen.Text = string.Empty;
            lblLoiChung.Text = string.Empty;
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            lblLoiMatKhau.Text = string.Empty;
            lblLoiChung.Text = string.Empty;
        }

        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {
            lblLoiXacNhanMatKhau.Text = string.Empty;
            lblLoiChung.Text = string.Empty;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblLoiEmail.Text = string.Empty;
            lblLoiChung.Text = string.Empty;
        }

        private async void btnDangKy_Click_1(object sender, EventArgs e)
        {// 1. Kiểm tra dữ liệu nhập tại Form[cite: 26]
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                lblLoiTenDangNhap.Text = "Tên đăng nhập không được để trống.";
                txtTenDangNhap.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                lblLoiHoTen.Text = "Họ tên không được để trống";
                txtHoTen.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text) || txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                lblLoiMatKhau.Text = "Mật khẩu không được để trống và phải khớp nhau.";
                txtMatKhau.Focus();
                return;
            }

            lblLoiTenDangNhap.Text = "";
            lblLoiHoTen.Text = "";
            lblLoiMatKhau.Text = "";

            // 2. Khóa nút bấm tránh người dùng spam click
            btnDangKy.Enabled = false;
            btnDangKy.Text = "Đang xử lý...";

            try
            {
                var db = new TruyCapDuLieu();

                // 3. Kiểm tra tên đăng nhập đã tồn tại chưa[cite: 26]
                bool tonTai = await db.KiemTraTenDangNhapTonTaiAsync(txtTenDangNhap.Text);
                if (tonTai)
                {
                    lblLoiHoTen.Text = "Tên này đã có người dùng"; // Nội dung yêu cầu đúng chuẩn đề bài[cite: 26]
                    return;
                }

                // 4. Băm mật khẩu ra Chuỗi Băm và Salt[cite: 28, 29]
                var (salt, bam) = MatKhau.Tao(txtMatKhau.Text);

                // Nếu trên Form Đăng ký có ô txtHoTen thì dùng txtHoTen.Text, không có thì dùng mặc định
                string hoTen = "Người dùng mới";
                string email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text;

                // 5. Thêm tài khoản vào cơ sở dữ liệu[cite: 26, 28]
                await db.ThemTaiKhoanAsync(txtTenDangNhap.Text, bam, salt, hoTen, email);

                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form Đăng ký để quay về Form Đăng nhập[cite: 26]
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDangKy.Enabled = true;
                btnDangKy.Text = "Đăng ký";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLoiTenDangNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
