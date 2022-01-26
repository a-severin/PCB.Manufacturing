using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using PCB.Manufacturing.Data;
using PCB.Manufacturing.Model;
using Prism.Mvvm;

namespace PCB.Manufacturing.UI.Preferences;

public class ImportantBoardPreferencesViewModel : BindableBase
{
    private readonly BoardInfo _boardInfo;

    private readonly Database _database = new();

    private MaterialPresenter _material;

    private SolderMaskColorPresenter _solderMaskColor;

    public ImportantBoardPreferencesViewModel(BoardInfo boardInfo)
    {
        _boardInfo = boardInfo;

        Materials = _database.Materials()
            .Select(_ => new MaterialPresenter(_))
            .ToList();

        SolderMaskColors = _database.SolderMaskColors()
            .Select(_ => new SolderMaskColorPresenter(_))
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

    public SolderMaskColorPresenter SolderMaskColor
    {
        get => _solderMaskColor;
        set => SetProperty(
            ref _solderMaskColor,
            value,
            () => { _boardInfo.SolderMaskColor = value.SolderMaskColor; }
        );
    }

    public IEnumerable<SolderMaskColorPresenter> SolderMaskColors { get; }
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

    public string ExtraMoney { get; }

    public string ExtraTime { get; }

    public string Text { get; }
}

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