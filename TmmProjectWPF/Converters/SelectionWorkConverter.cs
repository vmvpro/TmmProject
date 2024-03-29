﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using TmmProjectWPF.Models;

namespace TmmProjectWPF.Converters
{
    public class SelectionWorkConverter : IMultiValueConverter
    {

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] == null || values[1] == null)
                return (object)null;

            int work = (int)values[0];
            int variant = (int)values[1];

            var obj = new SelectionWork(work, variant);

            return obj;

            //return (object)values[0];
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class CurrentWorkConverter : IMultiValueConverter
    {

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] == null || values[1] == null)
                return (object)null;

            string lastName = (string)values[0];
            int year = System.Convert.ToInt32(values[1]); 

            var obj = new Student() { LastName = lastName, Year = year };
            
            //var obj = new SelectionWork(work, variant);

            //return obj;

            return obj;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class IsEnabledConverter : IMultiValueConverter
    {

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] == null || values[1] == null)
                return false;

            return true;

            //return (object)values[0];
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


}
