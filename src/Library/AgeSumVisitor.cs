namespace Library;
public class AgeSumVisitor
    : IVisitor<Person>
{
    private int totalAge = 0;

    public int TotalAge
    {
        get
        {
            return this.totalAge;
        }
    }

    public void Visit(Node<Person> node)
    {
        this.totalAge =
            this.totalAge + node.Data.Age;
    }
}