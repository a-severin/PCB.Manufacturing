using System.Windows.Media;
using PCB.Manufacturing.Model;
using Prism.Mvvm;

namespace PCB.Manufacturing.UI.Preferences;

public class SolderMaskColorPresenter : BindableBase
{
    public readonly SolderMaskColor SolderMaskColor;

    public SolderMaskColorPresenter(SolderMaskColor solderMaskColor)
    {
        SolderMaskColor = solderMaskColor;

        Text = solderMaskColor.Name;

        var brush = new SolidColorBrush(
            Color.FromRgb(
                solderMaskColor.R,
                solderMaskColor.G,
                solderMaskColor.B
            )
        );
        brush.Freeze();
        Brush = brush;
    }

    public Brush Brush { get; }

    public string Text { get; }
}