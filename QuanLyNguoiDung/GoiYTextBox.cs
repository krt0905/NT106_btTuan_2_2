using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuanLyNguoiDung
{
    internal static class GoiYTextBox
    {
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        public static void Dat(TextBox o, string goiY)
        {
            if (o.IsHandleCreated)
                SendMessage(o.Handle, EM_SETCUEBANNER, (IntPtr)1, goiY);
            o.HandleCreated += (s, e) => SendMessage(o.Handle, EM_SETCUEBANNER, (IntPtr)1, goiY);
        }
    }
}
