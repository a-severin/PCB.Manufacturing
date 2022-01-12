using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Markup;

namespace PCB.Manufacturing.UI.Quote;

public class SumCostImpactConverter: MarkupExtension, IValueConverter
{
    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return this;
    }

    public object Convert(
        object value,
        Type targetType,
        object parameter,
        CultureInfo culture
    )
    {
        if (value is IEnumerable collection)
        {
            return collection.OfType<SummaryPreferencePresenter>()
                .Select(_ => _.CostImpact)
                .Sum()
                .ToString("C");
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
}