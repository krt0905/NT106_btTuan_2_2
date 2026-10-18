using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QuanLyNguoiDung
{
    // Thong tin dung de xac thuc dang nhap
    public class ThongTinDangNhap
    {
        public int UserId { get; set; }
        public string TenDangNhap { get; set; } = "";
        public string MatKhauBam { get; set; } = "";
        public string Salt { get; set; } = "";
        public string HoTen { get; set; } = "";
    }

    // Thong tin hien thi o form Chinh
    public class ThongTinFormChinh
    {
        public string TenDangNhap { get; set; } = "";
        public string HoTen { get; set; } = "";
        public string Email { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime? LanDangNhapCuoi { get; set; }
    }

    public class TruyCapDuLieu
    {
        // 1. Kiem tra ten dang nhap da ton tai
        public async Task<bool> KiemTraTenDangNhapTonTaiAsync(string tenDangNhap)
        {
            const string sql = @"
                SELECT CASE
                    WHEN EXISTS (
                        SELECT 1
                        FROM Users
                        WHERE TenDangNhap = @ten
                    )
                    THEN 1 ELSE 0
                END;";

            using (var conn = new SqlConnection(Config.ChuoiKetNoi))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;
                await conn.OpenAsync();

                object ketQua = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(ketQua) == 1;
            }
        }

        // 2. Them tai khoan moi
        public async Task ThemTaiKhoanAsync(
            string tenDangNhap,
            string matKhauBam,
            string salt,
            string hoTen,
            string email)
        {
            const string sql = @"
                INSERT INTO Users
                    (TenDangNhap, MatKhauBam, Salt, HoTen, Email)
                VALUES
                    (@ten, @bam, @salt, @hoTen, @email);";

            using (var conn = new SqlConnection(Config.ChuoiKetNoi))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;
                cmd.Parameters.Add("@bam", SqlDbType.NVarChar, 64).Value = matKhauBam;
                cmd.Parameters.Add("@salt", SqlDbType.NVarChar, 32).Value = salt;
                cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar, 50).Value = hoTen;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value =
                    string.IsNullOrWhiteSpace(email) ? (object)DBNull.Value : email;

                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }

        // 3. Lay thong tin tai khoan de xac thuc dang nhap
        public async Task<ThongTinDangNhap> LayThongTinDangNhapAsync(string tenDangNhap)
        {
            const string sql = @"
                SELECT UserId, TenDangNhap, MatKhauBam, Salt, HoTen
                FROM Users
                WHERE TenDangNhap = @ten;";

            using (var conn = new SqlConnection(Config.ChuoiKetNoi))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;
                await conn.OpenAsync();

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (!await reader.ReadAsync())
                        return null;

                    return new ThongTinDangNhap
                    {
                        UserId = reader.GetInt32(reader.GetOrdinal("UserId")),
                        TenDangNhap = reader.GetString(reader.GetOrdinal("TenDangNhap")),
                        MatKhauBam = reader.GetString(reader.GetOrdinal("MatKhauBam")),
                        Salt = reader.GetString(reader.GetOrdinal("Salt")),
                        HoTen = reader.GetString(reader.GetOrdinal("HoTen"))
                    };
                }
            }
        }

        // 4. Cap nhat thoi diem dang nhap cuoi
        public async Task CapNhatLanDangNhapCuoiAsync(int userId)
        {
            const string sql = @"
                UPDATE Users
                SET LanDangNhapCuoi = SYSDATETIME()
                WHERE UserId = @userId;";

            using (var conn = new SqlConnection(Config.ChuoiKetNoi))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }

        // 5. Lay thong tin hien thi o form Chinh
        public async Task<ThongTinFormChinh> LayThongTinFormChinhAsync(string tenDangNhap)
        {
            const string sql = @"
                SELECT TenDangNhap, HoTen, Email,
                       NgayTao, LanDangNhapCuoi
                FROM Users
                WHERE TenDangNhap = @ten;";

            using (var conn = new SqlConnection(Config.ChuoiKetNoi))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;
                await conn.OpenAsync();

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (!await reader.ReadAsync())
                        return null;

                    int viTriEmail = reader.GetOrdinal("Email");
                    int viTriLanCuoi = reader.GetOrdinal("LanDangNhapCuoi");

                    return new ThongTinFormChinh
                    {
                        TenDangNhap = reader.GetString(reader.GetOrdinal("TenDangNhap")),
                        HoTen = reader.GetString(reader.GetOrdinal("HoTen")),
                        Email = reader.IsDBNull(viTriEmail) ? null : reader.GetString(viTriEmail),
                        NgayTao = reader.GetDateTime(reader.GetOrdinal("NgayTao")),
                        LanDangNhapCuoi = reader.IsDBNull(viTriLanCuoi) ? (DateTime?)null : reader.GetDateTime(viTriLanCuoi)
                    };
                }
            }
        }
    }
}