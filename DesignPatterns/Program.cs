using System;

namespace DesignPatterns
{
    public class Program
    {
        static public int Area(Rectangle r) => r.Width * r.Height;

        private static void Main(string[] args)
        {
            #region Single Responsibility Principle

            //var j = new Journal();
            //j.AddEntry("I ate food");
            //j.AddEntry("I played");
            //Console.WriteLine(j);
            //Console.ReadLine();

            //var p = new Persistence();
            //var filename = @"D:\journal.txt";
            //p.SaveToFile(j, filename);
            //Process.Start(filename);

            #endregion Single Responsibility Principle

            #region Open Responsibility Principle

            //var apple = new Product("Apple", Color.Green, Size.Small);
            //var tree = new Product("Tree", Color.Green, Size.Large);
            //var house = new Product("House", Color.Blue, Size.Large);

            //Product[] products = { apple, tree, house };

            //var bf = new BetterFilter();
            //Console.WriteLine("Green Products (new):");

            //foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
            //{
            //    Console.WriteLine($" - {p.Name} is green");
            //}

            //Console.WriteLine("Large Blue Item:");
            //foreach (var p in bf.Filter(products, new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
            //{
            //    Console.WriteLine($" - {p.Name} is big and blue");
            //}

            //Console.ReadLine();

            #endregion Open Responsibility Principle

            #region Liskov Substitution Principle

            //Rectangle rc = new Rectangle(2, 3);
            //Console.WriteLine($"{rc} has area {Area(rc)}");

            //Rectangle sq = new Square();
            //sq.Width = 4;
            //Console.WriteLine($"{sq} has area {Area(sq)}");
            //Console.ReadLine();

            #endregion Liskov Substitution Principle

            #region Dependency Inversion Principle

            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Chris" };
            var child2 = new Person { Name = "Mary" };

            var relationships = new RelationShips();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);
            new SingleResponsibility(relationships);

            Console.ReadLine();

            #endregion Dependency Inversion Principle
        }
    }
}