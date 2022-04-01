namespace ImportFromExcel.Classes
{
    public partial class DefaultParams
    {
        private int _defaultCellwidth = 80;
        private bool _proceduredefault = true;
        private int _ColCount = 0;
        private int _RowCount = 0;


        public int DefaultCellwidth
        {
            get
            {
                return _defaultCellwidth;
            }

            set
            {
                _defaultCellwidth = value;
            }
        }

        public bool Proceduredefault
        {
            get
            {
                return _proceduredefault;
            }

            set
            {
                _proceduredefault = value;
            }
        }

        public int ColCount
        {
            get
            {
                return _ColCount;
            }

            set
            {
                _ColCount = value;
            }
        }

        public int RowCount
        {
            get
            {
                return _RowCount;
            }

            set
            {
                _RowCount = value;
            }
        }
    }
}
