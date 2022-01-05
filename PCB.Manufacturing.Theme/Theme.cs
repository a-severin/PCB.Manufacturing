using System;
using System.Windows;
using System.Windows.Media;

namespace PCB.Manufacturing.Theme
{
    public sealed class Theme
    {
        [ThreadStatic]
        private static ResourceDictionary? _resourceDictionary;

        internal static ResourceDictionary ResourceDictionary
        {
            get
            {
                if (_resourceDictionary != null)
                {
                    return _resourceDictionary;
                }

                _resourceDictionary = new ResourceDictionary();
                LoadTheme();
                return _resourceDictionary;
            }
        }

        public static object? GetResource(ThemeResourceKey resourceKey)
        {
            return ResourceDictionary.Contains(resourceKey.ToString())
                ? ResourceDictionary[resourceKey.ToString()]
                : null;
        }

        public static void LoadTheme()
        {
            SetResource(
                ThemeResourceKey.WindowBackground,
                new SolidColorBrush(Colors.LightSlateGray)
            );

            SetResource(
                ThemeResourceKey.WindowForeground,
                new SolidColorBrush(Colors.White) { Opacity = 0.95 }
            );

            SetResource(
                ThemeResourceKey.ContentBackground,
                new SolidColorBrush(Colors.DarkGray)
            );

            SetResource(
                ThemeResourceKey.HeaderBackground,
                new SolidColorBrush(Colors.SlateGray)
            );

            SetResource(
                ThemeResourceKey.TextBoxBackground,
                new SolidColorBrush(Colors.DimGray)
            );

            SetResource(
                ThemeResourceKey.ComboBoxBackground,
                new SolidColorBrush(Colors.LightGray)
            );

            SetResource(
                ThemeResourceKey.ButtonBackground,
                new SolidColorBrush(Colors.SlateGray)
            );

            SetResource(
                ThemeResourceKey.CheckedButtonBackground,
                new SolidColorBrush(Colors.Cyan)
            );

            SetResource(
                ThemeResourceKey.BorderBackground,
                new SolidColorBrush(Colors.DarkSlateGray)
            );

            SetResource(
                ThemeResourceKey.BorderThickness,
                new Thickness(2, 2, 2, 2)
            );

            SetResource(
                ThemeResourceKey.CornerRadius,
                new CornerRadius(4, 4, 4, 4)
            );

            SetResource(
                ThemeResourceKey.ExtraMoneyForeground.ToString(),
                new SolidColorBrush(Colors.Gold)
            );

            SetResource(
                ThemeResourceKey.ExtraTimeForeground.ToString(),
                new SolidColorBrush(Colors.DodgerBlue)
            );
        }

        internal static void SetResource(object key, object resource)
        {
            ResourceDictionary[key] = resource;
        }
    }
}