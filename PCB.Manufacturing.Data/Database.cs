using PCB.Manufacturing.Model;

namespace PCB.Manufacturing.Data;

public class Database
{
    public IEnumerable<Material> Materials()
    {
        return new[]
        {
            new Material
            {
                Id = 1,
                Name = "Arlon",
                ExtraMoney = 160,
                ExtraTime = 0
            },
            new Material
            {
                Id = 2,
                Name = "Carbon",
                ExtraMoney = 260,
                ExtraTime = 3
            },
            new Material
            {
                Id = 3,
                Name = "Wolfram",
                ExtraMoney = 560,
                ExtraTime = 7
            }
        };
    }

    public IEnumerable<SolderMaskColor> SolderMaskColors()
    {
        return new[]
        {
            new SolderMaskColor
            {
                Name = "Red",
                Id = 1,
                R = 255,
                G = 0,
                B = 0
            },
            new SolderMaskColor
            {
                Name = "Green",
                Id = 1,
                R = 0,
                G = 255,
                B = 0
            },
            new SolderMaskColor
            {
                Name = "Blue",
                Id = 1,
                R = 0,
                G = 0,
                B = 255
            }
        };
    }
}