namespace Assets._Project.Scripts.MVC
{
    public  class MVCController
    {
        private  MVCView _view;
        private MVCModel _model;

        public MVCController(MVCView view, MVCModel model)
        {
            _view = view;
            _model = model;
        }

        public void IncrementintValue()
        {
            int newValue = _model.IntValue + 1;
            _model.ChangeIntValue(newValue);
        }

        public void DecrementintValue()
        {
            int newValue = _model.IntValue - 1;
            _model.ChangeIntValue(newValue);
        }

        public void ChangeString(string value)
        {
            _model.SetStringValue(value);
        }
    }
}
