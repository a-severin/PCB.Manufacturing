namespace PCB.Manufacturing.Model;

public struct Material
{
    public int Id;
    public string Name;
    public int ExtraMoney;
    public int ExtraTime;

    public override bool Equals(object? obj)
    {
        return obj is Material material
               && material.Id == Id;
    }

    public override int GetHashCode()
    {
        return Id;
    }
}