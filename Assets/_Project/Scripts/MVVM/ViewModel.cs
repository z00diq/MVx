namespace Assets._Project.Scripts.MVVM
{
    public abstract class ViewModel
    {
        protected readonly Model _model;

        public readonly ReactiveProperty<int> IntValueView = new();
        public readonly ReactiveProperty<string> StringValueView = new();

        public ViewModel(Model model)
        {
            _model = model;

            _model.IntValue.OnChanged += OnModelIntValueChanged;
            _model.StringValue.OnChanged += OnModelStringValueChanged;
        }

        public void Initialize()
        {
            StringValueView.Value = _model.StringValue.Value;
            IntValueView.Value = _model.IntValue.Value;
        }

        public void OnSubmitButtonClicled()
        {
            _model.StringValue.Value = StringValueView.Value;
            _model.IntValue.Value = IntValueView.Value;
        }

        public void OnIntValueViewIncreaseButtonClick()
        {
            IntValueView.Value +=1;
        }

        public void OnIntValueViewDecreaseButtonClick()
        {
            IntValueView.Value -= 1;
        }

        public void OnStringValueViewEndEdit(string value)
        {
            StringValueView.Value = value;
        }

        private void OnModelStringValueChanged(string value)
        {
            StringValueView.Value = value;
        }

        private void OnModelIntValueChanged(int value)
        {
            IntValueView.Value = value;
        }
    }
}
