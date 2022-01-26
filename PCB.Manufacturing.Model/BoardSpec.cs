namespace PCB.Manufacturing.Model;

public class BoardSpec
{
    public Impedance ControlledImpedance;
    public CooperWeight CooperWeightOnInnerLayers;
    public CooperWeight CooperWeightOnOuterLayers;
    public Flux FluxType;
    public IPC IpcClass;
    public ITAR Itar;
    public LeadFree LeadFree;

    public string Notes;
    public SilkscreenColor SilkscreenColor;
    public Stuckup Stuckup;
    public Tenting TentingForVias;
}