using System.Windows;
using System.Windows.Controls;

namespace PCB.Manufacturing.CustomControls
{
    public class PreferenceTitle : TextBlock
    {
        static PreferenceTitle()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(PreferenceTitle),
                new FrameworkPropertyMetadata(typeof(PreferenceTitle))
            );
        }
    }
}