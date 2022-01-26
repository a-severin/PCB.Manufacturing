namespace PCB.Manufacturing.Model;

public class BoardSpec
{
    public LeadFree LeadFree;
    public IPC IpcClass;
    public ITAR Itar;
    public Flux FluxType;
    public SilkscreenColor SilkscreenColor;
    public CooperWeight CooperWeightOnInnerLayers;
    public CooperWeight CooperWeightOnOuterLayers;
    public Impedance ControlledImpedance;
    public Tenting TentingForVias;
    public Stuckup Stuckup;

    public string Notes;
}