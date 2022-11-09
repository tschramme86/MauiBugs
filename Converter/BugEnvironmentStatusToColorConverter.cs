using MauiBugs.Data;
using Microsoft.Maui.Graphics;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBugs.Converter
{
    class BugEnvironmentStatusToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is EnvironmentStatus status)
            {
                return status switch
                {
                    EnvironmentStatus.NotTested => Colors.LightGray,
                    EnvironmentStatus.NotAffected => Colors.Green,
                    EnvironmentStatus.Affected => Colors.Red,
                    _ => Colors.Black
                };
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
