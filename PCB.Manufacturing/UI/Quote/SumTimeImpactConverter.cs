using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Markup;

namespace PCB.Manufacturing.UI.Quote;

public class SumTimeImpactConverter : MarkupExtension, IValueConverter
{
    public object Convert(
        object value,
        Type targetType,
        object parameter,
        CultureInfo culture
    )
    {
        if (value is IEnumerable collection)
        {
            var sum = collection.OfType<SummaryPreferencePresenter>()
                .Select(_ => _.TimeImpact)
                .Sum();

            return TimeImpactConverter.Represent(sum);
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
}