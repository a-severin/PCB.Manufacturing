using PCB.Manufacturing.Model;

namespace PCB.Manufacturing.UI.Preferences;

public class SpecialBoardPreferencesViewModel
{
    private IPC _ipcClass;
    private LeadFree _leadFree = LeadFree.No;

    public IPC IpcClass
    {
        get => _ipcClass;
        set => _ipcClass = value;
    }

    public LeadFree LeadFree
    {
        get => _leadFree;
        set => _leadFree = value;
    }
}