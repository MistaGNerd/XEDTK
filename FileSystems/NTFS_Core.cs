using System.Collections.Generic;

namespace XEDTK.FileSystems
{
    internal class NTFS_Core
    {
        #region Private Fields

        private static byte[] endOfSectorMarker = new byte[2]
        {
            0x00000055,
            0x000000AA
        };

        #endregion Private Fields

        #region Internal Methods

        internal void ntfsdata()
        {
            int sectorSize = 512; // 0x00000200
            List<byte> sData;
            byte[] sectorData = new byte[sectorSize];
            int sectorNumber = 0;

            byte[] masterBootCode = new byte[2];     // 0x00000000 until 0x000001BD.
            byte[] diskSignature = new byte[2];      // 0x000001B5 until 0x000001BB. 7 bytes total.
            byte[] partitiontable1 = new byte[16];    // 0x000001BE until 0x000001CD.
            byte[] partitiontable2 = new byte[2];    // 0x000001CE until 0x000001DD.
            byte[] partitiontable3 = new byte[2];    // 0x000001DE until 0x000001ED.
            byte[] partitiontable4 = new byte[2];    // 0x000001EE until 0x000001FD.
            byte[] endOfSectorMarker = new byte[2];  // 0x000001FE and 0x000001FF.
            byte[] masterBoootRecord = new byte[2];
        }

        #endregion Internal Methods
    }
}