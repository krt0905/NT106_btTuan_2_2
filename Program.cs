using System;
using System;
using QuanLyNguoiDung;
using QuanLyNguoiDung.Tests;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running tests from TruyCapDuLieuTests...");

        var tests = new TruyCapDuLieuTests();

        try
        {
            tests.FullUserLifecycleTest().GetAwaiter().GetResult();
            Console.WriteLine("FullUserLifecycleTest: PASSED");
        }
        catch (Exception ex)
        {
            Console.WriteLine("FullUserLifecycleTest: FAILED");
            Console.WriteLine(ex.ToString());
        }

        try
        {
            tests.KiemTraTenDangNhapTonTai_ReturnsTrueForExisting().GetAwaiter().GetResult();
            Console.WriteLine("KiemTraTenDangNhapTonTai_ReturnsTrueForExisting: PASSED");
        }
        catch (Exception ex)
        {
            Console.WriteLine("KiemTraTenDangNhapTonTai_ReturnsTrueForExisting: FAILED");
            Console.WriteLine(ex.ToString());
        }

        Console.WriteLine("All done. Press Enter to exit.");
        Console.ReadLine();
    }
}
