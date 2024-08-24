using Assets._Project.Scripts.Views;

namespace Assets._Project.Scripts.Models
{
    public abstract class Model
    {
        private int _intValue;
        private string _stringValue;
        protected readonly View View;

        public int IntValue => _intValue;

        public Model(View view) 
        { 
            View = view;
            _intValue = 0;
            _stringValue = string.Empty;

            view.ReDraw(_intValue,_stringValue);
        }

        public void ChangeIntValue(int value)
        {
            _intValue = value;
            View.ReDraw(_intValue);
        }

        public void SetStringValue(string value)
        {
            _stringValue = value;
            View.ReDraw(_stringValue);
        }
    }
}
