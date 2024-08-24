using Assets._Project.Scripts.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._Project.Scripts.Views
{
    public class SimpleView : View
    {
        [SerializeField] private Text _intText;
        [SerializeField] private Text _stringText;


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
