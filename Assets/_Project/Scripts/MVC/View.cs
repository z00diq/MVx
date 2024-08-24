using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets._Project.Scripts.Views
{
    public abstract class View : MonoBehaviour
    {
        public abstract void ReDraw(params object[] @params);
    }
}
