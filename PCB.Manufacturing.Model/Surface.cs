namespace PCB.Manufacturing.Model;

public struct Surface
{
    public int Id;
    public string Name;
    public int ExtraMoney;
    public int ExtraTime;

    public override bool Equals(object? obj)
    {
        return obj is Surface surface
               && surface.Id == Id;
    }

    public override int GetHashCode()
    {
        return Id;
    }
}