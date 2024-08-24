using Assets._Project.Scripts.MVP.Models;

namespace Assets._Project.Scripts.MVP.Presenters
{
    public class SimplePresenter : Presenter
    {
        public SimplePresenter(Model model) : base(model)
        {
        }

        public override void OnInputFieldEndEdit(string value)
        {
            Model.SetStringValue(value);
        }

        public override void OnPlusButtonClicked()
        {
            int newValue = Model.IntValue + 1;
            Model.ChangeIntValue(newValue);
        }

        public override void OnMinusButtonClicked()
        {
            int newValue = Model.IntValue - 1;
            Model.ChangeIntValue(newValue);
        }
    }
}