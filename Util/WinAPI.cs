using System;
using System.Runtime.InteropServices;

namespace niushuai233.Util
{
    public class WinAPI
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;

        /// <summary>
        /// 剪切板更新触发
        /// </summary>
        public const int WM_CLIPBOARDUPDATE = 0x031D;

        public const int WM_CHANGE_CLIPBOARD_CHAIN = 0x030D;

        public const int HT_CAPTION = 0x2;
        public const int MOUSEWHEEL = 0x020A;

        [DllImportAttribute("user32.dll")]
        internal static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        internal static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImportAttribute("user32.dll")]
        internal static extern bool ReleaseCapture();

        // 设置此窗体为活动窗体：
        // 将创建指定窗口的线程带到前台并激活该窗口。键盘输入直接指向窗口，并为用户更改各种视觉提示。
        // 系统为创建前台窗口的线程分配的优先级略高于其他线程。
        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        internal static extern bool SetForegroundWindow(IntPtr hWnd);

        // 设置此窗体为活动窗体：
        // 激活窗口。窗口必须附加到调用线程的消息队列。
        [DllImport("user32.dll", EntryPoint = "SetActiveWindow")]
        internal static extern IntPtr SetActiveWindow(IntPtr hWnd);

        // 设置窗体位置
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern int SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int Width, int Height, int flags);

        [DllImport("user32.dll ", CharSet = CharSet.Auto)]
        internal static extern int SetClipboardViewer(int hWndNewViewer);

        [DllImport("user32.dll ", CharSet = CharSet.Auto)]
        internal static extern bool AddClipboardFormatListener(IntPtr hwnd);

        [DllImport("user32.dll ", CharSet = CharSet.Auto)]
        internal static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);
    }
}