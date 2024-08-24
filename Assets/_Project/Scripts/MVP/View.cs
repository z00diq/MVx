using Assets._Project.Scripts.MVP.Presenters;
using UnityEngine;

namespace Assets._Project.Scripts.MVP.Views
{
    public abstract class View : MonoBehaviour
    {
        protected Presenter Presenter;


        public void Constrtuct(Presenter presenter)
        {
            Presenter = presenter;
        }

        public abstract void ReDraw(params object[] @params);
    }
}
