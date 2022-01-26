namespace PCB.Manufacturing.Model;

public class Order
{
    public Order()
    {
        ProjectInfo = new ProjectInfo();
        BoardInfo = new BoardInfo();
        BoardSpec = new BoardSpec();
    }

    public ProjectInfo ProjectInfo;
    public BoardInfo BoardInfo;
    public BoardSpec BoardSpec;
}