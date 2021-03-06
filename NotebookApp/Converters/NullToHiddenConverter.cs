using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;

namespace EngineeringNotebook.Converters
{
  public class NullToHiddenConverter : BaseOneWayConverter<object, Visibility>
  {
    public override Visibility ConvertValue(object fromValue, object parameter, CultureInfo language)
    {
      return fromValue == null ? Visibility.Hidden : Visibility.Visible;
    }
  }
}