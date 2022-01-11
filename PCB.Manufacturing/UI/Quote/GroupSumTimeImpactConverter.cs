using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Markup;

namespace PCB.Manufacturing.UI.Quote;

public class GroupSumTimeImpactConverter: MarkupExtension, IValueConverter
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
        if (value is ReadOnlyObservableCollection<object> collection)
        {
            var sum = collection.OfType<SummaryPreferencePresenter>()
                .Select(_ => _.TimeImpact ?? 0)
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
}