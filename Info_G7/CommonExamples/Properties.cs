namespace Info_G7.CommonExamples
{
    class Properties
    {
        public int MyProperty { get; private set; }

        public int ReadOnlyProperty1 { get; } = 56;
        public int ReadOnlyProperty2 => 34;

        private int _privateInt = 5;  

        private void SetInt(int newValue)
        {
            _privateInt = newValue;
        }

        public int GetPrivateInt()
        {
            return _privateInt;
        }

        private int _customVariable;

        public int CustomProperty
        {
            get
            {
                return _customVariable * _customVariable;
            }
            set
            {
                _customVariable = value * 2;
            }
        }
    }
}
