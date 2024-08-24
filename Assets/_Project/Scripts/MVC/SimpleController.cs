using Assets._Project.Scripts.Controllers;
using Assets._Project.Scripts.Models;
using Assets._Project.Scripts.Views;

namespace Assets._Project.Scripts
{
    public class SimpleController : Controller
    {
        public SimpleController(View view, Model model) : base(view, model)
        {
        }

        public void IncrementintValue()
        {
            int newValue = Model.IntValue + 1;
            Model.ChangeIntValue(newValue);
        }

        public void DecrementintValue()
        {
            int newValue = Model.IntValue - 1;
            Model.ChangeIntValue(newValue);
        }

        public void ChangeString(string value)
        {
            Model.SetStringValue(value);
        }
    }
}
