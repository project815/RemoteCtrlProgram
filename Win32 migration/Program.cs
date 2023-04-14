using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win32_migration
{

    //    WINUSERAPI
    //VOID
    //WINAPI
    //keybd_event(
    //    _In_ BYTE bVk,
    //    _In_ BYTE bScan,
    //    _In_ DWORD dwFlags,
    //    _In_ ULONG_PTR dwExtraInfo);
    class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>

        [DllImport("User32.dll")]
        static extern void keybd_event(byte vk, byte scan, int flag, int extra);

        public static void KeyDown(int keycode)
        {
            keybd_event((byte)keycode, 0, 0, 0);

        }

        public static void KeyUp(int keycode)
        {
            keybd_event((byte)keycode, 0, 2, 0);
        }

        static void Main()
        {
            Thread.Sleep(5000);
            KeyDown('D');
            Thread.Sleep(300);
            KeyUp('D');
            Thread.Sleep(300);
            KeyDown('J');
            Thread.Sleep(300);
            KeyUp('J');
            Thread.Sleep(300);
            KeyDown('S');
            Thread.Sleep(300);
            KeyUp('S');
            Thread.Sleep(300);
            KeyDown('W');
            Thread.Sleep(300);
            KeyUp('W');
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            Thread.Sleep(300);
            KeyDown('P');
            Thread.Sleep(300);
            KeyUp('P');
            Thread.Sleep(300);
            KeyDown('S');
            Thread.Sleep(300);
            KeyUp('S');
            Thread.Sleep(300);
            KeyDown('K');
            Thread.Sleep(300);
            KeyUp('K');
            Thread.Sleep(300);
            KeyDown('G');
            Thread.Sleep(300);
            KeyUp('G');
            Thread.Sleep(300);
            KeyDown('B');
            Thread.Sleep(300);
            KeyUp('B');
            Thread.Sleep(300);
            KeyDown('D');
            Thread.Sleep(300);
            KeyUp('D');
            Thread.Sleep(300);
            KeyDown('L');
            Thread.Sleep(300);
            KeyUp('L');
            Thread.Sleep(300);
            KeyDown('F');
            Thread.Sleep(300);
            KeyUp('F');
        }
    }
}
