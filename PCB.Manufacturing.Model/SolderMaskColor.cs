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

public struct SilkscreenColor
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

public struct CooperWeight
{
    public readonly double Value;

    public CooperWeight(double value)
    {
        Value = value;
    }

    public override bool Equals(object? obj)
    {
        if (obj is CooperWeight cooperWeight && Value == cooperWeight.Value)
        {
            return true;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public override string ToString()
    {
        return $"{Value:F1}oz";
    }
}