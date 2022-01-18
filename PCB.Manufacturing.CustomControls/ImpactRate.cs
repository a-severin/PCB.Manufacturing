using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace PCB.Manufacturing.CustomControls
{
    public class ImpactRate : Control
    {
        public static readonly DependencyProperty RateValueProperty = DependencyProperty.Register(
            nameof(RateValue),
            typeof(int),
            typeof(ImpactRate),
            new FrameworkPropertyMetadata(
                0,
                FrameworkPropertyMetadataOptions.AffectsRender,
                null,
                _coerceRateValue
            )
        );

        public static readonly DependencyProperty DotSizeProperty = DependencyProperty.Register(
            nameof(DotSize),
            typeof(double),
            typeof(ImpactRate),
            new FrameworkPropertyMetadata(8.0D, FrameworkPropertyMetadataOptions.AffectsRender)
        );

        static ImpactRate()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(ImpactRate),
                new FrameworkPropertyMetadata(typeof(ImpactRate))
            );
        }

        public double DotSize
        {
            get => (double)GetValue(DotSizeProperty);
            set => SetValue(DotSizeProperty, value);
        }

        public int RateValue
        {
            get => (int)GetValue(RateValueProperty);
            set => SetValue(RateValueProperty, value);
        }

        private static object _coerceRateValue(DependencyObject d, object baseValue)
        {
            if (d is ImpactRate impactRate
                && baseValue is int rateValue)
            {
                if (rateValue < 0)
                {
                    return 0;
                }

                if (rateValue > 5)
                {
                    return 5;
                }
            }

            return baseValue;
        }
    }

    public class RateValueToOpacityConverter : IValueConverter
    {
        public object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture
        )
        {
            if (value is int rate
                && parameter is string parameterString
                && int.TryParse(parameterString, out var dotNumber))
            {
                return dotNumber <= rate ? 1.0 : 0.1;
            }

            return 0D;
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
}