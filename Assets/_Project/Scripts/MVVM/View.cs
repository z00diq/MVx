using UnityEngine;

namespace Assets._Project.Scripts.MVVM
{
    public abstract class View: MonoBehaviour
    {
        protected ViewModel ViewModel;

        public virtual void Construct(ViewModel viewModel)
        {
            ViewModel = viewModel;
            ViewModel.StringValueView.OnChanged += OnStringValueViewChanged;
            ViewModel.IntValueView.OnChanged += OnIntValueViewChanged;
        }

        protected abstract void OnIntValueViewChanged(int value);
        protected abstract void OnStringValueViewChanged(string value);
    }
}
