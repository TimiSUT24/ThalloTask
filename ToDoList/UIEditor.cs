using CuoreUI.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class TransparentListBox : cuiListbox
    {
        public TransparentListBox()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);         
        }               
    }         
}

