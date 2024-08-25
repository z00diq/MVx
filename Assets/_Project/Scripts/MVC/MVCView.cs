using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._Project.Scripts.MVC
{
    public class MVCView : MonoBehaviour
    {
        [SerializeField] private Text _intText;
        [SerializeField] private Text _stringText;

        public  void RedrawIntText(int value)
        {
            _intText.text = Convert.ToInt32(value).ToString();
        }

        public void RedrawStringText(string value)
        {
            _stringText.text = value;
        }
    }
}
