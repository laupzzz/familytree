using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<Person> ana =
                new Node<Person>(
                    new Person("Ana", 78));

            Node<Person> carlos =
                new Node<Person>(
                    new Person("Carlos", 52));

            Node<Person> laura =
                new Node<Person>(
                    new Person("Laura", 49));

            Node<Person> mateo =
                new Node<Person>(
                    new Person("Mateo", 24));

            Node<Person> sofia =
                new Node<Person>(
                    new Person("Sofía", 20));

            Node<Person> diego =
                new Node<Person>(
                    new Person("Diego", 18));

            Node<Person> valentina =
                new Node<Person>(
                    new Person("Valentina", 15));

            ana.AddChild(carlos);
            ana.AddChild(laura);
            carlos.AddChild(mateo);
            carlos.AddChild(sofia);
            laura.AddChild(diego);
            laura.AddChild(valentina);

            AgeSumVisitor ageVisitor =
                new AgeSumVisitor();

            ana.Accept(ageVisitor);

            OldestChildVisitor oldestVisitor =
                new OldestChildVisitor();

            ana.Accept(oldestVisitor);

            LongestNameVisitor nameVisitor =
                new LongestNameVisitor();

            ana.Accept(nameVisitor);

            Console.WriteLine(
                $"Suma de edades: {ageVisitor.TotalAge}");

            Console.WriteLine(
                $"Hijo mayor: " +
                $"{oldestVisitor.OldestChild.Name} - " +
                $"{oldestVisitor.OldestChild.Age}");

            Console.WriteLine(
                $"Nombre más largo: " +
                $"{nameVisitor.Person.Name}");
        }
    }
}
