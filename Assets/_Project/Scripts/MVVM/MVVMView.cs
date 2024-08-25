using UnityEngine;
using UnityEngine.UI;

namespace Assets._Project.Scripts.MVVM
{
    public class MVVMView: MonoBehaviour
    {
        [SerializeField] private Text _intText;
        [SerializeField] private Text _stringText;
        [SerializeField] private InputField _inputField;
        [SerializeField] private Button _plus;
        [SerializeField] private Button _minus;
        [SerializeField] private Button _submit;

        private MVVMViewModel ViewModel;

        public void Construct(MVVMViewModel viewModel)
        {
            ViewModel = viewModel;
            ViewModel.StringValueView.OnChanged += OnStringValueViewChanged;
            ViewModel.IntValueView.OnChanged += OnIntValueViewChanged;
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

        private  void OnIntValueViewChanged(int value)
        {
            _intText.text = value.ToString();
        }

        private void OnStringValueViewChanged(string value)
        {
            _stringText.text = value;
        }
    }
}
