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
                new SolidColorBrush(Color.FromRgb(79,79,79))
            );

            _set(
                ThemeResourceKey.WindowForeground,
                new SolidColorBrush(Colors.White) { Opacity = 0.95 }
            );

            _set(
                ThemeResourceKey.ContentBackground,
                new SolidColorBrush(Color.FromRgb(65,65,65))
            );

            _set(
                ThemeResourceKey.HeaderBackground,
                new SolidColorBrush(Color.FromRgb(78,78,78))
            );

            _set(
                ThemeResourceKey.TextBoxBackground,
                new SolidColorBrush(Color.FromRgb(47,47,47))
            );

            _set(
                ThemeResourceKey.ComboBoxBackground,
                new SolidColorBrush(Color.FromRgb(93,93,93))
            );

            _set(
                ThemeResourceKey.ButtonBackground,
                new SolidColorBrush(Color.FromRgb(84,84,84))
            );

            _set(
                ThemeResourceKey.CheckedButtonBackground,
                new SolidColorBrush(Colors.DodgerBlue)
            );

            _set(
                ThemeResourceKey.BorderBrush,
                new SolidColorBrush(Color.FromRgb(45,45,45))
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
                new SolidColorBrush(Colors.RoyalBlue)
            );
        }

        private static void _set(ThemeResourceKey key, object resource)
        {
            ResourceDictionary[key.ToString()] = resource;
        }
    }
}