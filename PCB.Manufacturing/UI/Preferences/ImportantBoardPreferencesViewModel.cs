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

    private SolderMaskColorPresenter _solderMaskColor;

    private SurfacePresenter _surface;

    public ImportantBoardPreferencesViewModel(BoardInfo boardInfo)
    {
        _boardInfo = boardInfo;

        Materials = _database.Materials()
            .Select(_ => new MaterialPresenter(_))
            .ToList();

        SolderMaskColors = _database.SolderMaskColors()
            .Select(_ => new SolderMaskColorPresenter(_))
            .ToList();

        Surfaces = _database.Surfaces()
            .Select(_ => new SurfacePresenter(_))
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
                () => _boardInfo.Material = value.Material
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
            () => _boardInfo.SolderMaskColor = value.SolderMaskColor
        );
    }

    public IEnumerable<SolderMaskColorPresenter> SolderMaskColors { get; }

    public SurfacePresenter Surface
    {
        get => _surface;
        set => SetProperty(
            ref _surface,
            value,
            () => _boardInfo.Surface = value.Surface
        );
    }

    public IEnumerable<SurfacePresenter> Surfaces { get; }
}