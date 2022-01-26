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
                Id = 2,
                R = 0,
                G = 255,
                B = 0
            },
            new SolderMaskColor
            {
                Name = "Blue",
                Id = 3,
                R = 0,
                G = 0,
                B = 255
            }
        };
    }

    public IEnumerable<Surface> Surfaces()
    {
        return new[]
        {
            new Surface
            {
                Id = 1,
                Name = "FACE_1",
                ExtraMoney = 100,
                ExtraTime = 1
            },
            new Surface
            {
                Id = 2,
                Name = "FACE_2",
                ExtraMoney = 200,
                ExtraTime = 2
            },
            new Surface
            {
                Id = 3,
                Name = "FACE_3",
                ExtraMoney = 300,
                ExtraTime = 3
            }
        };
    }
}