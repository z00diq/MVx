using Assets._Project.Scripts.MVP;

namespace Assets._Project.Scripts.MVP
{
    public class MVPPresenter
    {
        private readonly MVPModel _model;

        public MVPPresenter(MVPModel model)
        {
            _model = model;
        }

        public void OnInputFieldEndEdit(string value)
        {
            _model.SetStringValue(value);
        }

        public void OnPlusButtonClicked()
        {
            int newValue = _model.IntValue + 1;
            _model.ChangeIntValue(newValue);
        }

        public void OnMinusButtonClicked()
        {
            int newValue = _model.IntValue - 1;
            _model.ChangeIntValue(newValue);
        }
    }
}