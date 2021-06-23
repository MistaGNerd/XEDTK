using System.Collections.Generic;

namespace XEDTK.FileSystems.NTFS
{
    internal class MBR
    {
        #region Internal Constructors

        internal MBR(byte[] byteData)
        {
            Load(byteData);
        }

        internal MBR(List<byte> byteData)
        {
            Load(byteData);
        }

        #endregion Internal Constructors

        #region Internal Properties

        internal int blockSize { get; set; }
        internal List<byte> byteData { get; set; }
        internal List<byte> diskSignature { get; set; }
        internal PartitionTable partition1Table { get; set; }
        internal PartitionTable partition2Table { get; set; }
        internal PartitionTable partition3Table { get; set; }
        internal PartitionTable partition4Table { get; set; }

        #endregion Internal Properties

        #region Internal Methods

        internal void Load(List<byte> byteData)
        {
            this.byteData = byteData;
            this.blockSize = this.byteData.Count;
            this.diskSignature = this.byteData.GetRange(437, 7);
            this.partition1Table.Load(byteData.GetRange(446, 16));
            this.partition2Table.data = byteData.GetRange(462, 16);
            this.partition3Table.data = byteData.GetRange(478, 16);
            this.partition4Table.data = byteData.GetRange(494, 16);
        }

        internal void Load(byte[] byteData)
        {
            Load(new List<byte>(byteData));
        }

        #endregion Internal Methods
    }
}