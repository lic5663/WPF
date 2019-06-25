﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Report2
{
    public class MultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // Return the total value of all the items in stock.
            //decimal unitCost = (decimal)values[0];
            //int unitsInStock = (int)values[1];
            //return unitCost * unitsInStock;
            string firstName = (string)values[0];
            string lastName = (string)values[1];
            return String.Format("{0} {1}", firstName, lastName);

        }
        public object[] ConvertBack(object value, Type[] targetTypes,
        object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
