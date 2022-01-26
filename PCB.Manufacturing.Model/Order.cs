namespace PCB.Manufacturing.Model;

public class Order
{
    public BoardInfo BoardInfo;
    public BoardSpec BoardSpec;

    public ProjectInfo ProjectInfo;

    public Order()
    {
        ProjectInfo = new ProjectInfo();
        BoardInfo = new BoardInfo();
        BoardSpec = new BoardSpec();
    }
}