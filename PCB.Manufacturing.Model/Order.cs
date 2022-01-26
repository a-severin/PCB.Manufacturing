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