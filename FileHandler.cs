using Microsoft.Win32.SafeHandles;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace XEDTK
{
    public enum EMoveMethod : uint
    {
        Begin,
        Current,
        End
    }

    internal enum AccessMask : uint
    {
        ZERO = 0x00000000,
        GENERIC_ALL,
        GENERIC_EXECUTE,
        GENERIC_READ = 0x80000000,
        GENERIC_WRITE = 0x40000000,
        GENERIC_READWRITE = 0x80000000 | 0x40000000
    }

    /// <summary>
    ///
    /// </summary>
    internal enum CreationDisposition : uint
    {
        /// <summary>
        /// Creates a new file, if it doesn't already exist, is a valid path, and is writable.
        /// If the file exists, the function fails and the last-error code is set to ERROR_FILE_EXISTS (80).
        /// </summary>
        CREATE_NEW = 1u,

        /// <summary>
        /// Creates a new file always. If the file exists and is writable, the function overwrites
        /// the file, and the last-error code is set to ERROR_ALREADY_EXISTS(183). If the file doesn't exist, is
        /// a valid path; a new file is created, and the last-error code is set to zero.
        /// </summary>
        CREATE_ALWAYS = 2u,

        /// <summary>
        /// Opens a file or device, only if it exists. If the specified file or device doesn't exist,
        /// the function fails and the last-error code is set to ERROR_FILE_NOT_FOUND(2).
        /// </summary>
        OPEN_EXISTING = 3u,

        /// <summary>
        /// Opens a file, always. If the file exists, the function succeeds and the last-error code
        /// is set to ERROR_ALREADY_EXISTS(183). If the file doesn't exist, is a valid path,and is writable; the
        /// function creates a file and the last-error code is set to zero.
        /// </summary>
        OPEN_ALWAYS = 4u,

        /// <summary>
        /// Opens a file and truncates it so the size is zero bytes, only if it exists. If the
        /// file doesn't exist, the function fails and the last-error code is set to ERROR_FILE_NOT_FOUND(2). The
        /// calling process must open the file with the GENERIC_WRITE bit set as part of the dwDesiredAccess parameter.
        /// </summary>
        TRUNCATE_EXISTING = 5u
    }

    internal enum FlagsAndAttributes : uint
    {
        ZERO = 0x00000000,
        FILE_ATTRIBUTE_ARCHIVE = 0x00000020,
        FILE_ATTRIBUTE_ENCRYPTED = 0x00004000,
        FILE_ATTRIBUTE_HIDDEN = 0x00000002,
        FILE_ATTRIBUTE_OFFLINE = 0x00001000,
        FILE_ATTRIBUTE_READONLY = 0x00000001,
        FILE_ATTRIBUTE_RECALL_ON_DATA_ACCESS = 0x00400000,
        FILE_ATTRIBUTE_RECALL_ON_OPEN = 0x00040000,
        FILE_ATTRIBUTE_REPARSE_PORT = 0x00000400,
        FILE_ATTRIBUTE_SPARSE_FILE = 0x00000200,
        FILE_ATTRIBUTE_SYSTEM = 0x00000004,
        FILE_ATTRIBUTE_TEMPORARY = 0x00000100,
        FILE_ATTRIBUTE_VIRTUAL = 0x00010000,
        FILE_FLAG_BACKUP_SEMANTICS = 0x02000000,
        FILE_FLAG_DELETE_ON_CLOSE = 0x04000000,
        FILE_FLAG_NO_BUFFERING = 0x20000000,
        FILE_FLAG_OPEN_NO_RECALL = 0x00100000,
        FILE_FLAG_OPEN_REPARSE_POINT = 0x00200000,
        FILE_FLAG_OVERLAPPED = 0x40000000,
        FILE_FLAG_POSIX_SEMANTICS = 0x01000000,
        FILE_FLAG_RANDOM_ACCESS = 0x10000000,
        FILE_FLAG_SESSION_AWARE = 0x00800000,
        FILE_FLAG_SEQUENTIAL_SCAN = 0x08000000,
        FILE_FLAG_WRITE_THROUGH = 0x80000000
    }

    internal enum ShareMode : uint
    {
        ZERO = 0x00000000,
        FILE_SHARE_DELETE = 0x00000004,
        FILE_SHARE_READ = 0x00000001,
        FILE_SHARE_WRITE = 0x00000002
    }

    internal class FileHandler
    {
        #region Internal Properties

        internal Storage_Device StorageDevice { get; set; } = new Storage_Device("", "");

        internal bool IsHandleInvalid { get; set; } = false;

        #endregion Internal Properties

        #region Internal Methods

        /// <summary>
        ///
        /// </summary>
        /// <param name="lpFileName">Path to File.</param>
        /// <param name="dwDesiredAccess">Access Rights.</param>
        /// <param name="dwShareMode"></param>
        /// <param name="lpSecurityAttributes"></param>
        /// <param name="dwCreationDisposition"></param>
        /// <param name="dwFlagsAndAttributes"></param>
        /// <param name="hTemplateFile"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern SafeFileHandle CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode,
            IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        [DllImport("kernel32", SetLastError = true)]
        internal static extern int ReadFile(SafeFileHandle handle, byte[] lpBuffer, int nBytesToRead, out int nBytesRead,
            IntPtr lpOverlapped_MustBeZero);

        [DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern uint SetFilePointer([In] SafeFileHandle hFile, [In] int lDistanceToMove, IntPtr high,
            [In] EMoveMethod dwMoveMethod);

        [DllImport("kernel32", SetLastError = true)]
        internal static extern int WriteFile(SafeFileHandle handle, byte[] bytes, int numBytesToWrite, out int numBytesWritten,
            IntPtr overlapped_MustBeZero);

        internal void FileLoader(string Path, AccessMask accessMask, ShareMode shareMode,
            CreationDisposition creationDisposition, FlagsAndAttributes flagsAndAttributes)
        {
            StorageDevice.Name = Path;
            StorageDevice.Mode = "Neither!";

            // Properly casting parameters.
            uint _accessMask = (uint)accessMask;
            uint _shareMode = (uint)shareMode;
            uint _creationDisposition = (uint)creationDisposition;
            uint _flagsAndAttributes = (uint)flagsAndAttributes;

            // Verify integrity of Path string.
            if (Path == null && Path.Length == 0)
            {
                throw new ArgumentNullException("Path");
                Console.WriteLine("Path is Null!");
            }

            Console.WriteLine("Path Verification: {0}", Path);


            SafeFileHandle safeFileHandle = FileHandler.CreateFile(Path,
                _accessMask,
                _shareMode,
                IntPtr.Zero,
                _creationDisposition, //dwCreationDisposition,
                _flagsAndAttributes,
                IntPtr.Zero);

            IsHandleInvalid = safeFileHandle.IsInvalid;

            //If handle is invalid, close handle and throw exception.
            //else read data.
            if (IsHandleInvalid)
            {
                Console.WriteLine("Handle is Invalid!");
                
                safeFileHandle.Close();
                Console.WriteLine("Closing SafeFileHandle. Throwing Error!");

                int Win32Error = Marshal.GetLastWin32Error();
                if (Win32Error != 2)
                {
                    string msg = Win32ErrorReport(Win32Error,
                    new System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error()).Message);
                    string caption = "Closing.";
                    System.Windows.Forms.MessageBox.Show(msg, caption, System.Windows.Forms.MessageBoxButtons.OK);
                }
                
                
            }
            else
            {
                Console.WriteLine("Handle is Valid!! YAY!");
                int bytesRead = 0;
                byte[] lpBuffer = new byte[512]; // byte array that will receive data during ReadFile().

                ReadFile(safeFileHandle, lpBuffer, 512, out bytesRead, IntPtr.Zero);

                //Grab End Signature form lpBuffer.
                byte[] endSignature = new byte[2];
                endSignature[0] = lpBuffer[510];
                endSignature[1] = lpBuffer[511];

                Console.WriteLine("End Signature : {0}{1}", endSignature[0].ToString("X"), endSignature[1].ToString("X"));

                //Defining Xbox Signature
                byte[] xboxSignature = new byte[2]
                {
                    0x00000099,
                    0x000000CC
                };

                //Defining PC NTFS Signature
                byte[] pcNTFSSignature = new byte[2]
                {
                    0x00000055,
                    0x000000AA
                };

                //Does End Signature Match XBOX?
                if (endSignature.SequenceEqual(xboxSignature))
                {
                    StorageDevice.Name = Path;
                    StorageDevice.Mode = "XBOX Mode";
                }
                else if (endSignature.SequenceEqual(pcNTFSSignature))
                {
                    StorageDevice.Name = Path;
                    StorageDevice.Mode = "PC Mode";
                }
                safeFileHandle.Close();
            }
            Console.Write("Ran it's Course!");
        }

        private string Win32ErrorReport(int lastWin32Error, string lastWin32ErrorMessage)
        {
            string lastWin32ErrorAdvice = "";

            switch (lastWin32Error)
            {
                case 5:
                    lastWin32ErrorAdvice = "Please enable Administrator Privileges.";
                    break;
            }
            string s = "Error " + lastWin32Error + ": " + lastWin32ErrorMessage + ". " + lastWin32ErrorAdvice;
            return s;
        }

        #endregion Internal Methods
    }
}