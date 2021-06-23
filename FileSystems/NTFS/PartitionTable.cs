using System.Collections.Generic;

namespace XEDTK.FileSystems.NTFS
{
    internal class PartitionTable
    {
        #region Internal Constructors

        internal PartitionTable(byte[] partitionTableData)
        {
            Load(partitionTableData);
        }

        internal PartitionTable(List<byte> partitionTableData)
        {
            Load(partitionTableData);
        }

        #endregion Internal Constructors

        #region Internal Enums

        internal enum BootIndicator : uint
        {
            ACTIVE_PARTITION = 0x00000080,
            INACTIVE_PARTITION = 0x00000000,
        };

        internal enum VolumeType : uint
        {
            /// <summary>
            /// FAT12 primary partition or logical drive (fewer than 32,680 sectors in the volume)
            /// </summary>
            FAT12 = 0x00000001,

            /// <summary>
            /// FAT16 partition or logical drive (32,680–65,535 sectors or 16 MB–33 MB)
            /// </summary>
            FAT16 = 0x00000004,

            /// <summary>
            /// Extended Partition
            /// </summary>
            EXTENDED_PARTITION = 0x00000005,

            /// <summary>
            /// Installable File System (NTFS partition or logical drive)
            /// </summary>
            NTFS = 0x00000007,

            /// <summary>
            /// FAT32 partition or logical drive
            /// </summary>
            FAT32 = 0x0000000B,

            /// <summary>
            /// FAT32 partition or logical drive using BIOS INT 13h extensions
            /// </summary>
            FAT32_BIOS = 0x0000000C,

            /// <summary>
            /// Dynamic Disk Volume.
            /// </summary>
            DYNAMIC_DISK = 0x00000042,

            /// <summary>
            /// GPT Partition.
            /// </summary>
            GPT = 0x000000EE
        }

        #endregion Internal Enums

        #region Internal Properties

        internal BootIndicator bootIndicator { get; set; }
        internal List<byte> data { get; set; }
        internal byte endingCylinder { get; set; }
        internal byte endingHead { get; set; }
        internal byte endingSector { get; set; }
        internal List<byte> relativeSectors { get; set; }
        internal byte startingCylinder { get; set; }
        internal byte startingHead { get; set; }
        internal byte startingSector { get; set; }
        internal List<byte> totalSectors { get; set; }
        internal VolumeType volumeType { get; set; }

        #endregion Internal Properties

        #region Internal Methods

        internal void Load(List<byte> partitionTableData)
        {
            this.data = partitionTableData;
            bootIndicator = (BootIndicator)partitionTableData[0];
            startingHead = partitionTableData[1];
            startingSector = partitionTableData[2];
            startingCylinder = partitionTableData[3];
            volumeType = (VolumeType)partitionTableData[4];
            endingHead = partitionTableData[5];
            endingSector = partitionTableData[6];
            endingCylinder = partitionTableData[7];
            relativeSectors = partitionTableData.GetRange(8, 4);
            totalSectors = partitionTableData.GetRange(12, 4);
        }

        internal void Load(byte[] partitionTableData)
        {
            Load(new List<byte>(partitionTableData));
        }

        #endregion Internal Methods
    }
}