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
}