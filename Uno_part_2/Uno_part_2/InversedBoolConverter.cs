﻿//Mitchell & Perri
//Used the Karli Cards Example from the textbook for reference

using System;
using System.Windows.Data;

namespace Uno_part_2
{
    [ValueConversion(typeof(bool), typeof(bool))]
    public class InversedBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            return !(bool)value;
        }
        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            return !(bool)value;
        }
    }
}
