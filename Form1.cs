using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace XEDTK
{
    public partial class Form1 : Form
    {
        #region Public Fields

        public List<Storage_Device> DetectedStorageDevices = new List<Storage_Device>();

        public List<XBOX_External_Storage_Device> DetectedXBOXDevices = new List<XBOX_External_Storage_Device>();

        #endregion Public Fields

        #region Public Constructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Public Methods

        public void ParsePhysicalDrives()
        {
            Cursor.Current = Cursors.WaitCursor;
            DetectedXBOXDevices.Clear();
            uint num = 2147483648u;
            uint num2 = 1073741824u;
            uint dwCreationDisposition = 3u;
            int num3 = 2;
            int num4 = 510;
            int num5 = 512;
            int numBytesRead = 0;
            byte[] array = new byte[num5];
            byte[] second = new byte[2]
            {
                153, // 0x00000099
				204 // 0x000000CC
			};
            byte[] second2 = new byte[2]
            {
                85, // 0x00000055
				170 // 0x000000AA
			};
            for (int i = 0; i < 10; i++)
            {
                string text = $"\\\\.\\PhysicalDrive{i}";
                SafeFileHandle safeFileHandle = CreateFile(text, num | num2, 0u, IntPtr.Zero, dwCreationDisposition, 0u, IntPtr.Zero);
                if (safeFileHandle.IsInvalid)
                {
                    Console.WriteLine("FileHandle is Invalid!");
                    safeFileHandle.Close();
                    break;
                }
                ReadFile(safeFileHandle, array, num5, out numBytesRead, IntPtr.Zero);
                Console.WriteLine("Number of Bytes Read: " + numBytesRead);
                byte[] array2 = new byte[num3];
                array2[0] = array[num4];
                array2[1] = array[num4 + 1];
                if (array2.SequenceEqual(second))
                {
                    XBOX_External_Storage_Device xBOX_External_Storage_Device = new XBOX_External_Storage_Device();
                    xBOX_External_Storage_Device.DeviceName = text;
                    xBOX_External_Storage_Device.DeviceMode = "XBOX Mode";
                    DetectedXBOXDevices.Add(xBOX_External_Storage_Device);
                }
                else if (array2.SequenceEqual(second2))
                {
                    bool flag = true;
                    for (int j = 0; j < 440; j++)
                    {
                        if (array[j] != 0)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        XBOX_External_Storage_Device xBOX_External_Storage_Device2 = new XBOX_External_Storage_Device();
                        xBOX_External_Storage_Device2.DeviceName = text;
                        xBOX_External_Storage_Device2.DeviceMode = "PC Mode";
                        DetectedXBOXDevices.Add(xBOX_External_Storage_Device2);
                    }
                }
                safeFileHandle.Close();
            }
            foreach (XBOX_External_Storage_Device detectedXBOXDevice in DetectedXBOXDevices)
            {
                textBox2.Text += detectedXBOXDevice.DeviceName + " : " + detectedXBOXDevice.DeviceMode + Environment.NewLine;
            }
            Cursor.Current = Cursors.Default;
            if (DetectedXBOXDevices.Count == 0)
            {
                MessageBox.Show("No XBOX One External Storage Devices Found.");
            }
        }

        #endregion Public Methods

        #region Internal Methods

        [DllImport("kernel32", SetLastError = true)]
        internal static extern int ReadFile(SafeFileHandle handle, byte[] bytes, int numBytesToRead, out int numBytesRead, IntPtr overlapped_MustBeZero);

        [DllImport("kernel32", SetLastError = true)]
        internal static extern int WriteFile(SafeFileHandle handle, byte[] bytes, int numBytesToWrite, out int numBytesWritten, IntPtr overlapped_MustBeZero);

        #endregion Internal Methods

        #region Private Methods

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern SafeFileHandle CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        [DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern uint SetFilePointer([In] SafeFileHandle hFile, [In] int lDistanceToMove, IntPtr high, [In] EMoveMethod dwMoveMethod);

        private void Form1_Load(object sender, EventArgs e)
        {
            List<DriveInfo> myDrives = new List<DriveInfo>();
            foreach (DriveInfo drInfo in DriveInfo.GetDrives())
            {
                if (drInfo.DriveType == DriveType.Fixed)
                {
                    myDrives.Add(drInfo);
                    textBox1.Text += drInfo.VolumeLabel + "(" + drInfo.RootDirectory + ")" + Environment.NewLine;

                    Console.WriteLine("Detected {0} ( {1} )", drInfo.VolumeLabel, drInfo.RootDirectory);
                }
            }
        }

        private void scanDrivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Beginning Scan for Drives");
            //ParsePhysicalDrives();
            ScanForDrives();
        }

        private void ScanForDrives()
        {
            // SETUP VARS AND BEGIN PROCESS
            Cursor.Current = Cursors.WaitCursor;

            // PROCESS
            Console.WriteLine("Beginning Iteration for Drives!");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("----------------------------------------------");
                string text = $"\\\\.\\PhysicalDrive{i}";

                Console.WriteLine("checking for drive : {0}", text);

                FileHandler fHandler = new FileHandler();
                fHandler.FileLoader(text, AccessMask.GENERIC_READWRITE, ShareMode.ZERO, CreationDisposition.OPEN_EXISTING,
                    FlagsAndAttributes.ZERO);
                if (fHandler.IsHandleInvalid) { break; }
                if (fHandler.StorageDevice.Name != null)
                {
                    Console.WriteLine("Detected {0} in {1}", fHandler.StorageDevice.Name,
                        fHandler.StorageDevice.Mode);
                }
                else { Console.WriteLine("Squat!"); }

                DetectedStorageDevices.Add(fHandler.StorageDevice);
            }
            int count = 0;
            foreach (Storage_Device storage_Device in DetectedStorageDevices)
            {

                textBox2.Text += count + " : " + storage_Device.Name + " : " + storage_Device.Mode + Environment.NewLine;
                AddDeviceToGridView(storage_Device, count);
                count++;
            }
            Cursor.Current = Cursors.Default;
            if (DetectedStorageDevices.Count == 0)
            {
                MessageBox.Show("No Storage Devices Found.");
            } else
            {
                textBox2.Text += "Detected Storage Devices: " + DetectedStorageDevices.Count;
            }

            // CLOSE VARS AND END PROCESS
            Cursor.Current = Cursors.Default;
        }

        private void AddDeviceToGridView(Storage_Device storage_Device, int count)
        {
            deviceGridView.Rows.Add(storage_Device.Name, count, " ", storage_Device.Mode);
            
            //dataGridView2.Rows.Add()

            dataGridView2.Rows.Add(storage_Device.Name);

            var row = new string[] { storage_Device.Name, storage_Device.Mode };
            var lvi = new ListViewItem(row);
            listView1.Items.Add(lvi);
        }

        #endregion Private Methods

        #region Public Classes

        public class XBOX_External_Storage_Device
        {
            #region Public Fields

            public string DeviceMode;
            public string DeviceName;

            #endregion Public Fields
        }

        #endregion Public Classes

        private void button1_Click(object sender, EventArgs e)
        {
            ScanForDrives();
        }

        private void reloadDiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScanForDrives();
        }
    }
}