namespace Library;
public class SumVisitor : IVisitor<int>
{
    private int sum = 0;

    public int Sum
    {
        get
        {
            return this.sum;
        }
    }

    public void Visit(Node<int> node)
    {
        this.sum = this.sum + node.Data;
    }
}