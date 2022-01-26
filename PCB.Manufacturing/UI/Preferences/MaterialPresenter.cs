using PCB.Manufacturing.Model;
using Prism.Mvvm;

namespace PCB.Manufacturing.UI.Preferences;

public class MaterialPresenter : BindableBase
{
    public readonly Material Material;

    public MaterialPresenter(Material material)
    {
        Material = material;

        Text = Material.Name;
        ExtraMoney = Material.ExtraMoney > 0 ? $"+{Material.ExtraMoney:C}" : string.Empty;
        ExtraTime = Material.ExtraTime == 0 ? string.Empty : $"+{Material.ExtraTime} days";
    }

    public string ExtraMoney { get; }

    public string ExtraTime { get; }

    public string Text { get; }
}