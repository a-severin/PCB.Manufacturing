using System.Windows;

namespace PCB.Manufacturing.Theme;

public sealed class ThemeResourceDictionary : ResourceDictionary
{
    public ThemeResourceDictionary()
    {
        MergedDictionaries.Add(Theme.ResourceDictionary);
    }
}