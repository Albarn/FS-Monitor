using System;
using System.Runtime.InteropServices;

namespace FileSystemMonitor.ConsoleApp
{
    class Program
    {
        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();

        [DllImport("kernel32.dll")]
        public static extern bool ReadDirectoryChangesW(IntPtr hDirectory, out char[] lpBuffer, int nBufferLength, bool bWatchSubtree, int dwNotifyFilter, out int lpBytesReturned, ref int lpOverlapped, int lpCompletionRoutine);

        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        [DllImport(
            @"C:\Users\elrib\source\repos\FileSystemMonitor\Debug\Dll1.dll", CharSet = CharSet.Unicode)]
        unsafe public static extern bool Monitor();

        int count=0;

        static void Main(string[] args)
        {
            //unsafe
            //{
            //    bool b = Monitor();
            //    Console.Read();
            //}
            //CSharpMonitoring();
        }

        private static void CSharpMonitoring()
        {
            unsafe
            {
                IntPtr p = CreateFile(@"D:\some stuff\fds",
                    //GENERIC_READ
                    0x80000000,
                    //FILE_SHARE_WRITE | READ | DELETE
                    0x00000001 | 0x00000004 | 0x00000002,
                    //opt
                    new IntPtr(),
                    //OPEN_EXISTING
                    3,
                    //FILE_FLAG_BACKUP_SEMANTICS(for directories)
                    0x02000000 | 0x40000000,
                    //opt
                    new IntPtr());

                char[] lpBuffer = new char[1000];
                int lpBytesReturned;
                int lpOverlapped = 0;
                uint err = GetLastError();  //err code
                //should be true
                bool b = ReadDirectoryChangesW(
                    //directory handle
                    p,
                    //result
                    out lpBuffer,
                    //size of lpbuffer
                    lpBuffer.Length,
                    //searching in sub folders
                    false,
                    //filter
                    0x00000001, //FILE_NOTIFY_CHANGE_FILE_NAME
                                //opt
                    out lpBytesReturned,
                    //opt
                    ref lpOverlapped, 0);
                err = GetLastError();//6 - invalid handle
                Console.Read();
            }
        }
    }
}
