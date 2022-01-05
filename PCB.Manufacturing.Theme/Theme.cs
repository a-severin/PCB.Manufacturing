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