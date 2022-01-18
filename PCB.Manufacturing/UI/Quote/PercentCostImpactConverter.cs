using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Markup;

namespace PCB.Manufacturing.UI.Quote;

[ValueConversion(typeof(SummaryPreferenceCollection), typeof(string))]
public class PercentCostImpactConverter : MarkupExtension, IValueConverter
{
    public int GroupIndex { get; set; }

    public object Convert(
        object value,
        Type targetType,
        object parameter,
        CultureInfo culture
    )
    {
        if (value is SummaryPreferenceCollection collection
            && collection.CollectionView.Groups[GroupIndex] is CollectionViewGroup collectionViewGroup)
        {
            var total = collection
                .Select(_ => _.CostImpact)
                .Sum();

            var groupSum = collectionViewGroup
                .Items
                .OfType<SummaryPreferencePresenter>()
                .Select(_ => _.CostImpact)
                .Sum();

            if (total == 0
                || groupSum == 0)
            {
                return string.Empty;
            }

            var percent = groupSum / total;

            return percent.ToString("P0");
        }

        return string.Empty;
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