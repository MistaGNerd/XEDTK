namespace XEDTK
{
    public class Storage_Device
    {
        #region Public Constructors

        public Storage_Device(string name, string mode)
        {
            Name = name;
            Mode = mode;
        }

        #endregion Public Constructors

        #region Public Properties

        public string Mode { get; set; }
        public string Name { get; set; }

        #endregion Public Properties
    }
}