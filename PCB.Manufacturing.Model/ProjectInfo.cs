namespace PCB.Manufacturing.Model;

public class Order
{
    public Order()
    {
        ProjectInfo = new ProjectInfo();
        BoardInfo = new BoardInfo();
    }

    public ProjectInfo ProjectInfo;
    public BoardInfo BoardInfo;
}

public class ProjectInfo
{
    public int BoardsQuantity;
    public LeadFree LeadFree;
    public string ProjectName;
    public string Zipcode;
}

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

public struct SolderMaskColor
{
    public int Id;
    public string Name;
    public short R;
    public short G;
    public short B;

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
    public double BoardThickness;
    public Material Material;
    public SolderMaskColor SolderMaskColor;
    public Surface Surface;
}