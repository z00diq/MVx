namespace Assets._Project.Scripts.MVC
{
    public  class MVCModel
    {
        private int _intValue;
        private string _stringValue;
        private MVCView _view;

        public int IntValue => _intValue;

        public MVCModel(MVCView view) 
        { 
            _view = view;
            _intValue = 0;
            _stringValue = string.Empty;

            view.RedrawIntText(_intValue);
            view.RedrawStringText(_stringValue);

        }

        public void ChangeIntValue(int value)
        {
            _intValue = value;
            _view.RedrawIntText(_intValue);
        }

        public void SetStringValue(string value)
        {
            _stringValue = value;
            _view.RedrawStringText(_stringValue);
        }
    }
}
