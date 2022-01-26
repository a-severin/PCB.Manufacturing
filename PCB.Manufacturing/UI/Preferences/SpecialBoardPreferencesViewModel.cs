using System.Collections.Generic;
using System.Linq;
using PCB.Manufacturing.Data;
using PCB.Manufacturing.Model;
using Prism.Mvvm;

namespace PCB.Manufacturing.UI.Preferences;

public class SpecialBoardPreferencesViewModel : BindableBase
{
    private readonly BoardSpec _boardSpec;

    private readonly Database _database = new();

    private SilkscreenColorPresenter _silkscreenColor;

    public SpecialBoardPreferencesViewModel(BoardSpec boardSpec)
    {
        _boardSpec = boardSpec;

        SilkscreenColors = _database.SilkscreenColors()
            .Select(_ => new SilkscreenColorPresenter(_))
            .ToList();

        CooperWeights = _database.CooperWeights();
    }

    public Impedance ControlledImpedance
    {
        get => _boardSpec.ControlledImpedance;
        set => SetProperty(ref _boardSpec.ControlledImpedance, value);
    }

    public CooperWeight CooperWeightOnInnerLayers
    {
        get => _boardSpec.CooperWeightOnInnerLayers;
        set => SetProperty(ref _boardSpec.CooperWeightOnInnerLayers, value);
    }

    public CooperWeight CooperWeightOnOuterLayers
    {
        get => _boardSpec.CooperWeightOnOuterLayers;
        set => SetProperty(ref _boardSpec.CooperWeightOnOuterLayers, value);
    }

    public IEnumerable<CooperWeight> CooperWeights { get; }

    public Flux FluxType
    {
        get => _boardSpec.FluxType;
        set => SetProperty(ref _boardSpec.FluxType, value);
    }

    public IPC IpcClass
    {
        get => _boardSpec.IpcClass;
        set => SetProperty(ref _boardSpec.IpcClass, value);
    }

    public ITAR Itar
    {
        get => _boardSpec.Itar;
        set => SetProperty(ref _boardSpec.Itar, value);
    }

    public LeadFree LeadFree
    {
        get => _boardSpec.LeadFree;
        set => SetProperty(ref _boardSpec.LeadFree, value);
    }

    public string Notes
    {
        get => _boardSpec.Notes;
        set => SetProperty(ref _boardSpec.Notes, value);
    }

    public SilkscreenColorPresenter SilkscreenColor
    {
        get => _silkscreenColor;
        set => SetProperty(
            ref _silkscreenColor,
            value,
            () => _boardSpec.SilkscreenColor = value.SilkscreenColor
        );
    }

    public IEnumerable<SilkscreenColorPresenter> SilkscreenColors { get; }

    public Stuckup Stuckup
    {
        get => _boardSpec.Stuckup;
        set => SetProperty(ref _boardSpec.Stuckup, value);
    }

    public Tenting TentingForVias
    {
        get => _boardSpec.TentingForVias;
        set => SetProperty(ref _boardSpec.TentingForVias, value);
    }
}