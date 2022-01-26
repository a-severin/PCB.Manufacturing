namespace PCB.Manufacturing.Model;

public struct SolderMaskColor
{
    public int Id;
    public string Name;
    public byte R;
    public byte G;
    public byte B;

    public override bool Equals(object? obj)
    {
        return obj is SolderMaskColor solderMaskColor
               && solderMaskColor.Id == Id;
    }

    public override int GetHashCode()
    {
        return Id;
    }
}