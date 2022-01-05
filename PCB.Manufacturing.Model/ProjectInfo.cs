using System.Net.Http.Headers;

namespace PCB.Manufacturing.Model;

public class ProjectInfo
{
    public string ProjectName { get; set; }
    public string Zipcode { get; set; }
    public int BoardsQuantity { get; set; }
    public LeadFree LeadFree { get; set; }
}

public struct Material
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ExtraMoney { get; set; }
    public int ExtraTime { get; set; }

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

public struct Surface
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ExtraMoney { get; set; }
    public int ExtraTime { get; set; }

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

public struct SolderMaskColor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public short R { get; set; }
    public short G { get; set; }
    public short B { get; set; }

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

public class BoardInfo
{
    public double BoardThickness { get; set; }
    public Material Material { get; set; }
    public Surface Surface { get; set; }
    public SolderMaskColor SolderMaskColor { get; set; }
}