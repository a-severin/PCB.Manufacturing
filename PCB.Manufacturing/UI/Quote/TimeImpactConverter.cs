using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace PCB.Manufacturing.UI.Quote;

public class TimeImpactConverter : MarkupExtension, IValueConverter
{
    public object Convert(
        object value,
        Type targetType,
        object parameter,
        CultureInfo culture
    )
    {
        if (value is int timeImpact)
        {
            return Represent(timeImpact);
        }

        return "-";
    }

    public object ConvertBack(
        object value,
        Type targetType,
        object parameter,
        CultureInfo culture
    )
    {
        throw new NotImplementedException();
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return this;
    }

    public static string Represent(int timeImpact)
    {
        if (timeImpact == 0)
        {
            return "-";
        }

        if (timeImpact == 1)
        {
            return "1 day";
        }

        return $"{timeImpact} days";
    }
}