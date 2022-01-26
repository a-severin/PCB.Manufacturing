using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PCB.Manufacturing.Data;
using PCB.Manufacturing.Model;
using Prism.Mvvm;

namespace PCB.Manufacturing.UI.Preferences;

public class ImportantBoardPreferencesViewModel : BindableBase
{
    private readonly BoardInfo _boardInfo;

    private readonly Database _database = new();
    private MaterialPresenter _material;

    public ImportantBoardPreferencesViewModel(BoardInfo boardInfo)
    {
        _boardInfo = boardInfo;

        Materials = _database.Materials()
            .Select(_ => new MaterialPresenter(_))
            .ToList();
    }

    public double BoardThickness
    {
        get => _boardInfo.BoardThickness;
        set => SetProperty(ref _boardInfo.BoardThickness, value);
    }

    public MaterialPresenter Material
    {
        get => _material;
        set
        {
            SetProperty(
                ref _material,
                value,
                () => { _boardInfo.Material = value.Material; }
            );
        }
    }

    public IEnumerable<MaterialPresenter> Materials { get; }
}

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

    public string Text { get; }

    public string ExtraMoney { get; }

    public string ExtraTime { get; }
}