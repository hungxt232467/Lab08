using System;
class Product
{
    private string name;
    private double cost;
    private int onhand;
    public Product(string n, double c, int h)
    {
        name = n;
        cost = c;
        onhand = h;
    }
    public override string ToString()
    {
        return String.Format("{0,-10}Cost: {1,6:C} On hand:"
            { 2}",
            name, cost, onhand);
    }
}
class Program
{
    public static void Main()
    {
        List<Product> inv = new List<Product>();
        inv.Add(new Product("A", 5.9, 3));
        inv.Add(new Product("B", 8.2, 2));
        inv.Add(new Product("C", 3.5, 4));
        inv.Add(new Product("D", 1.8, 8));
        Console.WriteLine("Product List:");
        foreach (Product i in inv)
        {
            Console.WriteLine(" " + i);
        }
    }
}
class Pair<T>
{
    private T first;
    private T second;
    public Pair(T first, T second)
    {
        this.first = first;
        this.second = second;
    }
    public T First
    {
        get { return first; }
    }
    public T Second
    {
        get { return second; }
    }
}
class Program1
{
    public static void Main(string[] args)
    {
        Pair<String> pair = new Pair<string>("An", "Nga");
        Console.WriteLine("({0},{1})", pair.First,
        pair.Second);
        Console.ReadLine();
    }
}
class Program2
{
    public static void Main(string[] args)
    {
        String a = "a";
        String b = "b";
        Swap<String>(ref a, ref b);
        System.Console.WriteLine(a + " " + b);
    }
    static void Swap<T>(ref T lhs, ref T rhs)
    {
        T temp = lhs;
        lhs = rhs;
        rhs = temp;
    }
}
class Program3
{
    public static void Main(string[] args)
    {
        //Test in case return null
        Console.WriteLine("{0}", Min(null));

        //Add data to list
        List<int> list = new List<int>();
        list.Add(10);
        list.Add(1);
        list.Add(1230);
        //Test in case does not return null
        Console.WriteLine("{0}", GetFirst(list));
    }
    private static int? GetFirst(List<int> list)
    {
        if (list == null || list.Count == 0)
        {
            return null;
        }
        return list[0];
    }
}
