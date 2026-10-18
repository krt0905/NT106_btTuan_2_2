using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNguoiDung
{
    public partial class FormChinh : Form
    {
        private const string DINH_DANG_NGAY_GIO = "dd/MM/yyyy HH:mm";

        public FormChinh()
        {
            InitializeComponent();
        }

        /// <param name="hoTen">Họ tên người dùng (hiện ở lời chào)</param>
        /// <param name="tenDangNhap">Tên đăng nhập</param>
        /// <param name="email">Email, null nếu người dùng không nhập</param>
        /// <param name="ngayTao">Ngày tạo tài khoản (cột NgayTao)</param>
        /// <param name="lanDangNhapGanNhat">Lần đăng nhập trước đó (cột LanDangNhapCuoi), null nếu chưa có</param>
        public FormChinh(string hoTen, string tenDangNhap, string email,
                         DateTime ngayTao, DateTime? lanDangNhapGanNhat) : this()
        {

            lblXinChao.Text = $"Xin chào, {hoTen}";
            lblTenDangNhapGiaTri.Text = tenDangNhap;
            lblEmailGiaTri.Text = string.IsNullOrWhiteSpace(email) ? "(chưa cập nhật)" : email;
            lblNgayTaoGiaTri.Text = ngayTao.ToString(DINH_DANG_NGAY_GIO);
            lblLanDangNhapGanNhatGiaTri.Text = lanDangNhapGanNhat.HasValue
                ? lanDangNhapGanNhat.Value.ToString(DINH_DANG_NGAY_GIO)
                : "(đây là lần đăng nhập đầu tiên)";
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
