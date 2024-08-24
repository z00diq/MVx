using Assets._Project.Scripts.MVP.Models;

namespace Assets._Project.Scripts.MVP.Presenters
{
    public abstract class Presenter
    {
        protected readonly Model Model;

        public Presenter(Model model)
        {
            Model = model;
        } 

        public abstract void OnInputFieldEndEdit(string arg0);

        public abstract void OnPlusButtonClicked();

        public abstract void OnMinusButtonClicked();

    }
}