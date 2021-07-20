﻿using CSHTML5.TelerikChartExample.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CSHTML5.TelerikChartExample.Helpers
{
    public class BrokenViewModel: NotifierBase
    {
        private string _label;
        public string Label
        {
            get { return _label; }
            set
            {
                _label = value;
                OnPropertyChanged("Label");
            }
        }

        private string _value;
        public string Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged("Value");
            }
        }

        private Color _color;
        public Color Color
        {
            get { return _color; }
            set
            {
                _color = value;
                OnPropertyChanged("Color");
            }
        }
    }
}