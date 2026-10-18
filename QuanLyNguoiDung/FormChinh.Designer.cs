using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNguoiDung
{
    partial class FormChinh
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
            this.lblXinChao = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblTenDangNhapGiaTri = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmailGiaTri = new System.Windows.Forms.Label();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.lblNgayTaoGiaTri = new System.Windows.Forms.Label();
            this.lblLanDangNhapGanNhat = new System.Windows.Forms.Label();
            this.lblLanDangNhapGanNhatGiaTri = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
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
            this.pnlTieuDe.Size = new System.Drawing.Size(440, 40);
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
            this.lblTieuDe.Size = new System.Drawing.Size(440, 40);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Trang chính";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblXinChao
            // 
            this.lblXinChao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblXinChao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.lblXinChao.Location = new System.Drawing.Point(24, 58);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(392, 30);
            this.lblXinChao.TabIndex = 1;
            this.lblXinChao.Text = "Xin chào";
            this.lblXinChao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(24, 106);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(110, 20);
            this.lblTenDangNhap.TabIndex = 2;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lblTenDangNhapGiaTri
            // 
            this.lblTenDangNhapGiaTri.Location = new System.Drawing.Point(190, 106);
            this.lblTenDangNhapGiaTri.Name = "lblTenDangNhapGiaTri";
            this.lblTenDangNhapGiaTri.Size = new System.Drawing.Size(226, 18);
            this.lblTenDangNhapGiaTri.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 138);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblEmailGiaTri
            // 
            this.lblEmailGiaTri.Location = new System.Drawing.Point(190, 138);
            this.lblEmailGiaTri.Name = "lblEmailGiaTri";
            this.lblEmailGiaTri.Size = new System.Drawing.Size(226, 18);
            this.lblEmailGiaTri.TabIndex = 5;
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Location = new System.Drawing.Point(24, 170);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(73, 20);
            this.lblNgayTao.TabIndex = 6;
            this.lblNgayTao.Text = "Ngày tạo:";
            // 
            // lblNgayTaoGiaTri
            // 
            this.lblNgayTaoGiaTri.Location = new System.Drawing.Point(190, 170);
            this.lblNgayTaoGiaTri.Name = "lblNgayTaoGiaTri";
            this.lblNgayTaoGiaTri.Size = new System.Drawing.Size(226, 18);
            this.lblNgayTaoGiaTri.TabIndex = 7;
            // 
            // lblLanDangNhapGanNhat
            // 
            this.lblLanDangNhapGanNhat.AutoSize = true;
            this.lblLanDangNhapGanNhat.Location = new System.Drawing.Point(24, 202);
            this.lblLanDangNhapGanNhat.Name = "lblLanDangNhapGanNhat";
            this.lblLanDangNhapGanNhat.Size = new System.Drawing.Size(172, 20);
            this.lblLanDangNhapGanNhat.TabIndex = 8;
            this.lblLanDangNhapGanNhat.Text = "Lần đăng nhập gần nhất:";
            // 
            // lblLanDangNhapGanNhatGiaTri
            // 
            this.lblLanDangNhapGanNhatGiaTri.Location = new System.Drawing.Point(190, 202);
            this.lblLanDangNhapGanNhatGiaTri.Name = "lblLanDangNhapGanNhatGiaTri";
            this.lblLanDangNhapGanNhatGiaTri.Size = new System.Drawing.Size(226, 18);
            this.lblLanDangNhapGanNhatGiaTri.TabIndex = 9;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(306, 250);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(110, 32);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click_1);
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 306);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.lblLanDangNhapGanNhatGiaTri);
            this.Controls.Add(this.lblLanDangNhapGanNhat);
            this.Controls.Add(this.lblNgayTaoGiaTri);
            this.Controls.Add(this.lblNgayTao);
            this.Controls.Add(this.lblEmailGiaTri);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTenDangNhapGiaTri);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.lblXinChao);
            this.Controls.Add(this.pnlTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chính";
            this.pnlTieuDe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private Label lblXinChao;
        private Label lblTenDangNhap;
        private Label lblTenDangNhapGiaTri;
        private Label lblEmail;
        private Label lblEmailGiaTri;
        private Label lblNgayTao;
        private Label lblNgayTaoGiaTri;
        private Label lblLanDangNhapGanNhat;
        private Label lblLanDangNhapGanNhatGiaTri;
        private Button btnDangXuat;
    }
}
