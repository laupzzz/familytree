namespace Library;
public class OldestChildVisitor
    : IVisitor<Person>
{
    public Person OldestChild
    {
        get;
        private set;
    }

    public void Visit(Node<Person> node)
    {
        bool isLeaf =
            node.Children.Count == 0;

        if (isLeaf)
        {
            if (this.OldestChild == null
                || node.Data.Age
                > this.OldestChild.Age)
            {
                this.OldestChild =
                    node.Data;
            }
        }
    }
}