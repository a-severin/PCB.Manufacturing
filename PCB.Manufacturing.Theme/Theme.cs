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
            _set(
                ThemeResourceKey.WindowBackground,
                new SolidColorBrush(Colors.LightSlateGray)
            );

            _set(
                ThemeResourceKey.WindowForeground,
                new SolidColorBrush(Colors.White) { Opacity = 0.95 }
            );

            _set(
                ThemeResourceKey.ContentBackground,
                new SolidColorBrush(Colors.DarkGray)
            );

            _set(
                ThemeResourceKey.HeaderBackground,
                new SolidColorBrush(Colors.SlateGray)
            );

            _set(
                ThemeResourceKey.TextBoxBackground,
                new SolidColorBrush(Colors.DimGray)
            );

            _set(
                ThemeResourceKey.ComboBoxBackground,
                new SolidColorBrush(Colors.LightGray)
            );

            _set(
                ThemeResourceKey.ButtonBackground,
                new SolidColorBrush(Colors.SlateGray)
            );

            _set(
                ThemeResourceKey.CheckedButtonBackground,
                new SolidColorBrush(Colors.Cyan)
            );

            _set(
                ThemeResourceKey.BorderBrush,
                new SolidColorBrush(Colors.DarkSlateGray)
            );

            _set(
                ThemeResourceKey.BorderThickness,
                new Thickness(2, 2, 2, 2)
            );

            _set(
                ThemeResourceKey.CornerRadius,
                new CornerRadius(4, 4, 4, 4)
            );

            _set(
                ThemeResourceKey.ExtraMoneyForeground,
                new SolidColorBrush(Colors.Gold)
            );

            _set(
                ThemeResourceKey.ExtraTimeForeground,
                new SolidColorBrush(Colors.DodgerBlue)
            );
        }

        private static void _set(ThemeResourceKey key, object resource)
        {
            ResourceDictionary[key.ToString()] = resource;
        }
    }
}