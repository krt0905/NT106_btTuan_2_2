using System;
using System.Security.Cryptography;

public static class MatKhau
{
    private const int VONG_LAP = 600000; // 600,000 iterations required[cite: 29]

    // Called during Registration[cite: 29]
    public static (string Salt, string Bam) Tao(string matKhau)
    {
        byte[] salt = new byte[16];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(salt);
        }

        using (var pbkdf2 = new Rfc2898DeriveBytes(matKhau, salt, VONG_LAP, HashAlgorithmName.SHA256))
        {
            byte[] bam = pbkdf2.GetBytes(32);
            return (Convert.ToBase64String(salt), Convert.ToBase64String(bam));
        }
    }

    // Called during Login[cite: 29]
    public static bool KiemTra(string matKhau, string saltLuu, string bamLuu)
    {
        byte[] salt = Convert.FromBase64String(saltLuu);
        byte[] bamCu = Convert.FromBase64String(bamLuu);

        using (var pbkdf2 = new Rfc2898DeriveBytes(matKhau, salt, VONG_LAP, HashAlgorithmName.SHA256))
        {
            byte[] bamMoi = pbkdf2.GetBytes(32);
            return SoSanhThoiGianCoDinh(bamCu, bamMoi);
        }
    }

    // Custom Constant-Time byte comparison for .NET Framework 4.7.2 to prevent timing attacks[cite: 29]
    private static bool SoSanhThoiGianCoDinh(byte[] a, byte[] b)
    {
        if (a == null || b == null || a.Length != b.Length)
            return false;

        int diff = 0;
        for (int i = 0; i < a.Length; i++)
        {
            diff |= a[i] ^ b[i];
        }
        return diff == 0;
    }
}