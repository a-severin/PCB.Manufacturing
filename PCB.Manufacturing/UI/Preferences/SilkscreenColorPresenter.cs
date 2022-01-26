using System.Windows.Media;
using PCB.Manufacturing.Model;

namespace PCB.Manufacturing.UI.Preferences;

public class SilkscreenColorPresenter
{
    public readonly SilkscreenColor SilkscreenColor;

    public SilkscreenColorPresenter(SilkscreenColor silkscreenColor)
    {
        SilkscreenColor = silkscreenColor;

        Text = silkscreenColor.Name;

        var brush = new SolidColorBrush(
            Color.FromRgb(
                silkscreenColor.R,
                silkscreenColor.G,
                silkscreenColor.B
            )
        );
        brush.Freeze();
        Brush = brush;
    }

    public Brush Brush { get; }

    public string Text { get; }
}