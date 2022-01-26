using PCB.Manufacturing.Model;
using Prism.Mvvm;

namespace PCB.Manufacturing.UI.Preferences;

public class SurfacePresenter : BindableBase
{
    public readonly Surface Surface;

    public SurfacePresenter(Surface surface)
    {
        Surface = surface;

        Text = Surface.Name;
        ExtraMoney = Surface.ExtraMoney > 0 ? $"+{Surface.ExtraMoney:C}" : string.Empty;
        ExtraTime = Surface.ExtraTime == 0 ? string.Empty : $"+{Surface.ExtraTime} days";
    }

    public string ExtraMoney { get; }

    public string ExtraTime { get; }

    public string Text { get; }
}