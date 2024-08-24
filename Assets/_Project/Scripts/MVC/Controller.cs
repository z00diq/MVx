using Assets._Project.Scripts.Models;
using Assets._Project.Scripts.Views;

namespace Assets._Project.Scripts.Controllers
{
    public abstract class Controller
    {
        protected readonly View View;
        protected readonly Model Model;

        public Controller(View view, Model model)
        {
            View = view;
            Model = model;
        }
    }
}
