using UnityEngine;
using UnityEngine.UI;

namespace Assets._Project.Scripts.MVVM
{
    public class SimpleView : View
    {
        [SerializeField] private Text _intText;
        [SerializeField] private Text _stringText;
        [SerializeField] private InputField _inputField;
        [SerializeField] private Button _plus;
        [SerializeField] private Button _minus;
        [SerializeField] private Button _submit;

        public override void Construct(ViewModel viewModel)
        {
            base.Construct(viewModel);
            _plus.onClick.AddListener(ViewModel.OnIntValueViewIncreaseButtonClick);
            _minus.onClick.AddListener(ViewModel.OnIntValueViewDecreaseButtonClick);
            _submit.onClick.AddListener(ViewModel.OnSubmitButtonClicled);
            _inputField.onEndEdit.AddListener(ViewModel.OnStringValueViewEndEdit);
        }

        private void OnDestroy()
        {
            _plus.onClick.RemoveListener(ViewModel.OnIntValueViewIncreaseButtonClick);
            _minus.onClick.RemoveListener(ViewModel.OnIntValueViewDecreaseButtonClick);
            _submit.onClick.RemoveListener(ViewModel.OnSubmitButtonClicled);
            _inputField.onEndEdit.RemoveListener(ViewModel.OnStringValueViewEndEdit);
        }

        protected override void OnIntValueViewChanged(int value)
        {
            _intText.text = value.ToString();
        }

        protected override void OnStringValueViewChanged(string value)
        {
            _stringText.text = value;
        }
    }
}
