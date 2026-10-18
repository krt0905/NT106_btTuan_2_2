
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace QuanLyNguoiDung
{
    public static class Config
    {
        private static readonly IConfigurationRoot CauHinhUngDung;

        static Config()
        {
            // Ensure appsettings.json is available in the application's base directory when running.
            string baseDir = AppContext.BaseDirectory ?? AppDomain.CurrentDomain.BaseDirectory;
            string targetPath = Path.Combine(baseDir, "appsettings.json");

            if (!File.Exists(targetPath))
            {
                // Search upward from the base directory for a copy of appsettings.json in the repository
                // (useful when running from the IDE where the file is in the project root but not copied).
                var dir = new DirectoryInfo(baseDir);
                FileInfo found = null;

                for (int i = 0; i < 8 && dir != null; i++)
                {
                    string candidate = Path.Combine(dir.FullName, "appsettings.json");
                    if (File.Exists(candidate))
                    {
                        found = new FileInfo(candidate);
                        break;
                    }
                    dir = dir.Parent;
                }

                if (found != null)
                {
                    try
                    {
                        File.Copy(found.FullName, targetPath, overwrite: true);
                    }
                    catch
                    {
                        // If copy fails, proceed — configuration builder will throw a clear error.
                    }
                }
            }

            CauHinhUngDung = new ConfigurationBuilder()
                .SetBasePath(baseDir)
                .AddJsonFile(
                    "appsettings.json",
                    optional: false,
                    reloadOnChange: false)
                .Build();
        }

        public static string ChuoiKetNoi =>
            CauHinhUngDung.GetConnectionString(
                "QuanLyNguoiDung")
            ?? throw new InvalidOperationException(
                "Khong tim thay chuoi ket noi co so du lieu.");
    }
}