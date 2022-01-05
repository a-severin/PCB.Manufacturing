using PCB.Manufacturing.Model;
using Prism.Mvvm;

namespace PCB.Manufacturing.UI.Preferences;

public class SpecialBoardPreferencesViewModel : BindableBase
{
    private Impedance _controlledImpedance;

    private Flux _fluxType;

    private IPC _ipcClass;

    private ITAR _itar;

    private LeadFree _leadFree = LeadFree.No;

    private Stuckup _stuckup;

    private Tenting _tentingForVias;

    public Impedance ControlledImpedance
    {
        get => _controlledImpedance;
        set => SetProperty(ref _controlledImpedance, value);
    }

    public Flux FluxType
    {
        get => _fluxType;
        set => SetProperty(ref _fluxType, value);
    }

    public IPC IpcClass
    {
        get => _ipcClass;
        set => SetProperty(ref _ipcClass, value);
    }

    public ITAR Itar
    {
        get => _itar;
        set => SetProperty(ref _itar, value);
    }

    public LeadFree LeadFree
    {
        get => _leadFree;
        set => SetProperty(ref _leadFree, value);
    }

    public Stuckup Stuckup
    {
        get => _stuckup;
        set => SetProperty(ref _stuckup, value);
    }

    public Tenting TentingForVias
    {
        get => _tentingForVias;
        set => SetProperty(ref _tentingForVias, value);
    }
}