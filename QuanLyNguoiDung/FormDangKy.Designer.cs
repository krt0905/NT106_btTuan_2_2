using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNguoiDung
{
    partial class FormDangKy
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblLoiTenDangNhap = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblLoiHoTen = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblLoiMatKhau = new System.Windows.Forms.Label();
            this.lblXacNhanMatKhau = new System.Windows.Forms.Label();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.lblLoiXacNhanMatKhau = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblLoiEmail = new System.Windows.Forms.Label();
            this.lblLoiChung = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnlTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(420, 40);
            this.pnlTieuDe.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblTieuDe.Size = new System.Drawing.Size(420, 40);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Đăng ký tài khoản";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(24, 66);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(107, 20);
            this.lblTenDangNhap.TabIndex = 1;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(150, 62);
            this.txtTenDangNhap.MaxLength = 20;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(246, 27);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // lblLoiTenDangNhap
            // 
            this.lblLoiTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblLoiTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblLoiTenDangNhap.Location = new System.Drawing.Point(150, 88);
            this.lblLoiTenDangNhap.Name = "lblLoiTenDangNhap";
            this.lblLoiTenDangNhap.Size = new System.Drawing.Size(246, 18);
            this.lblLoiTenDangNhap.TabIndex = 2;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(24, 128);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(54, 20);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(150, 124);
            this.txtHoTen.MaxLength = 50;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(246, 27);
            this.txtHoTen.TabIndex = 2;
            // 
            // lblLoiHoTen
            // 
            this.lblLoiHoTen.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblLoiHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblLoiHoTen.Location = new System.Drawing.Point(150, 150);
            this.lblLoiHoTen.Name = "lblLoiHoTen";
            this.lblLoiHoTen.Size = new System.Drawing.Size(246, 18);
            this.lblLoiHoTen.TabIndex = 4;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(24, 190);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(70, 20);
            this.lblMatKhau.TabIndex = 5;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(150, 186);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(246, 27);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblLoiMatKhau
            // 
            this.lblLoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblLoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblLoiMatKhau.Location = new System.Drawing.Point(150, 212);
            this.lblLoiMatKhau.Name = "lblLoiMatKhau";
            this.lblLoiMatKhau.Size = new System.Drawing.Size(246, 18);
            this.lblLoiMatKhau.TabIndex = 6;
            // 
            // lblXacNhanMatKhau
            // 
            this.lblXacNhanMatKhau.AutoSize = true;
            this.lblXacNhanMatKhau.Location = new System.Drawing.Point(24, 252);
            this.lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            this.lblXacNhanMatKhau.Size = new System.Drawing.Size(134, 20);
            this.lblXacNhanMatKhau.TabIndex = 7;
            this.lblXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(150, 248);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(246, 27);
            this.txtXacNhanMatKhau.TabIndex = 4;
            this.txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // lblLoiXacNhanMatKhau
            // 
            this.lblLoiXacNhanMatKhau.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblLoiXacNhanMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblLoiXacNhanMatKhau.Location = new System.Drawing.Point(150, 274);
            this.lblLoiXacNhanMatKhau.Name = "lblLoiXacNhanMatKhau";
            this.lblLoiXacNhanMatKhau.Size = new System.Drawing.Size(246, 18);
            this.lblLoiXacNhanMatKhau.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 314);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 20);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 310);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // lblLoiEmail
            // 
            this.lblLoiEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblLoiEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblLoiEmail.Location = new System.Drawing.Point(150, 336);
            this.lblLoiEmail.Name = "lblLoiEmail";
            this.lblLoiEmail.Size = new System.Drawing.Size(246, 18);
            this.lblLoiEmail.TabIndex = 10;
            // 
            // lblLoiChung
            // 
            this.lblLoiChung.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblLoiChung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblLoiChung.Location = new System.Drawing.Point(24, 366);
            this.lblLoiChung.Name = "lblLoiChung";
            this.lblLoiChung.Size = new System.Drawing.Size(372, 20);
            this.lblLoiChung.TabIndex = 11;
            this.lblLoiChung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(150, 396);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(110, 32);
            this.btnDangKy.TabIndex = 6;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click_1);
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(276, 396);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(110, 32);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FormDangKy
            // 
            this.AcceptButton = this.btnDangKy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(420, 446);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.lblLoiChung);
            this.Controls.Add(this.lblLoiEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLoiXacNhanMatKhau);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.lblXacNhanMatKhau);
            this.Controls.Add(this.lblLoiMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblLoiHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblLoiTenDangNhap);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.pnlTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản";
            this.pnlTieuDe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private Label lblLoiTenDangNhap;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblLoiHoTen;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Label lblLoiMatKhau;
        private Label lblXacNhanMatKhau;
        private TextBox txtXacNhanMatKhau;
        private Label lblLoiXacNhanMatKhau;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblLoiEmail;
        private Label lblLoiChung;
        private Button btnDangKy;
        private Button btnHuy;
    }
}
