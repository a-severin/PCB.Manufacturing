using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace PCB.Manufacturing.UI.Quote;

[ValueConversion(typeof(SummaryPreferenceCollection), typeof(GridLength))]
public class PercentTimeImpactToGridLengthConverter : MarkupExtension, IValueConverter
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
            && collection.CollectionView.Groups.Count > GroupIndex
            && collection.CollectionView.Groups[GroupIndex] is CollectionViewGroup collectionViewGroup)
        {
            double total = collection
                .Select(_ => _.TimeImpact)
                .Sum();

            double groupSum = collectionViewGroup
                .Items
                .OfType<SummaryPreferencePresenter>()
                .Select(_ => _.TimeImpact)
                .Sum();

            if (total == 0
                || groupSum == 0)
            {
                return new GridLength(4, GridUnitType.Pixel);
            }

            var percent = groupSum / total;

            return new GridLength(percent, GridUnitType.Star);
        }

        return new GridLength(1, GridUnitType.Star);
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