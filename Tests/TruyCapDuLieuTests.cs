using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyNguoiDung;

namespace QuanLyNguoiDung.Tests
{
    [TestClass]
    public class TruyCapDuLieuTests
    {
        // Integration-style unit test that performs a full user lifecycle against the configured database.
        // This test requires the connection string in appsettings.json to point to an accessible SQL Server
        // and will create a user in the Users table.
        [TestMethod]
        public async Task FullUserLifecycleTest()
        {
            var db = new TruyCapDuLieu();

            string username = "ut_" + Guid.NewGuid().ToString("N").Substring(0, 8);

            // Ensure user does not exist
            bool exists = await db.KiemTraTenDangNhapTonTaiAsync(username);
            Assert.IsFalse(exists, "User should not exist before creation.");

            // Create user
            await db.ThemTaiKhoanAsync(
                username,
                new string('A', 64),
                new string('B', 32),
                "Unit Test User",
                null);

            // User should now exist
            bool exists2 = await db.KiemTraTenDangNhapTonTaiAsync(username);
            Assert.IsTrue(exists2, "User should exist after insertion.");

            // Retrieve login info
            var loginInfo = await db.LayThongTinDangNhapAsync(username);
            Assert.IsNotNull(loginInfo, "Login info should be retrievable.");
            Assert.AreEqual(username, loginInfo.TenDangNhap);

            // Update last login
            await db.CapNhatLanDangNhapCuoiAsync(loginInfo.UserId);

            // Retrieve form info
            var formInfo = await db.LayThongTinFormChinhAsync(username);
            Assert.IsNotNull(formInfo, "Form info should be retrievable.");
            Assert.AreEqual(username, formInfo.TenDangNhap);
        }

        // Basic existence check for a known test user (depends on test data)
        [TestMethod]
        public async Task KiemTraTenDangNhapTonTai_ReturnsTrueForExisting()
        {
            var db = new TruyCapDuLieu();
            string username = "testuser01";

            bool exists = await db.KiemTraTenDangNhapTonTaiAsync(username);

            Assert.IsTrue(exists, "Expected testuser01 to exist in the database.");
        }
    }
}
