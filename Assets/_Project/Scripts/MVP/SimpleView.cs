using Assets._Project.Scripts.Views;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._Project.Scripts.MVP.Views
{
    public class SimpleView : View
    {
        [SerializeField] private Text _intText;
        [SerializeField] private Text _stringText;
        [SerializeField] private InputField _inputField;
        [SerializeField] private Button _plus;
        [SerializeField] private Button _minus;

        private void Start()
        {
            _plus.onClick.AddListener(Presenter.OnPlusButtonClicked);
            _minus.onClick.AddListener(Presenter.OnMinusButtonClicked);
            _inputField.onEndEdit.AddListener(Presenter.OnInputFieldEndEdit);

        }

        private void OnDestroy()
        {
            _plus.onClick.RemoveListener(Presenter.OnPlusButtonClicked);
            _plus.onClick.RemoveListener(Presenter.OnMinusButtonClicked);
            _inputField.onEndEdit.RemoveListener(Presenter.OnInputFieldEndEdit);
        }

        public override void ReDraw(params object[] @params)
        {
            foreach (object obj in @params)
            {
                if (obj is string)
                    _stringText.text = obj.ToString();
                else
                {
                    _intText.text = Convert.ToInt32(obj).ToString();
                }
            }
        }
    }
}
