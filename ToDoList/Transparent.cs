using CuoreUI.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Transparent : cuiListbox
    {
        public Transparent()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);         
        }    
    }
}
