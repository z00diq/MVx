using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._Project.Scripts.MVP
{
    public class MVPView : MonoBehaviour
    {
        [SerializeField] private Text _intText;
        [SerializeField] private Text _stringText;
        [SerializeField] private InputField _inputField;
        [SerializeField] private Button _plus;
        [SerializeField] private Button _minus;
        
        private MVPPresenter _presenter;

        public void Constrtuct(MVPPresenter presenter)
        {
            _presenter = presenter;
        }

        private void Start()
        {
            _plus.onClick.AddListener(_presenter.OnPlusButtonClicked);
            _minus.onClick.AddListener(_presenter.OnMinusButtonClicked);
            _inputField.onEndEdit.AddListener(_presenter.OnInputFieldEndEdit);

        }

        private void OnDestroy()
        {
            _plus.onClick.RemoveListener(_presenter.OnPlusButtonClicked);
            _plus.onClick.RemoveListener(_presenter.OnMinusButtonClicked);
            _inputField.onEndEdit.RemoveListener(_presenter.OnInputFieldEndEdit);
        }

        public void RedrawIntText(int value)
        {
            _intText.text = Convert.ToInt32(value).ToString();
        }

        public void RedrawStringText(string value)
        {
            _stringText.text = value;
        }
    }
}
