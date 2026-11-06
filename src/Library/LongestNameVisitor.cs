namespace Library;
public class LongestNameVisitor
    : IVisitor<Person>
{
    public Person Person
    {
        get;
        private set;
    }

    public void Visit(Node<Person> node)
    {
        if (this.Person == null
            || node.Data.Name.Length
            > this.Person.Name.Length)
        {
            this.Person = node.Data;
        }
    }
}