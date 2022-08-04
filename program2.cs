using System;
class Product
{
    private string name;
    private double cost;
    private int onhand;
    public Product(string n,double c, int h)
    {
        name = n;
        cost = c;
        onhand = h;
    }
    public override string ToString()
    {
         return string.Format("{0,-10}Cost: {1,6:C} On hand: {2}",name, cost, onhand);
    }
}
class Program
{
    public static void Main1(string[] args)
    {
        List<Product> inv = new List<Product>();
        inv.Add(new Product("A",5.9,3));
        inv.Add(new Product("B",5.9,2));
        inv.Add(new Product("C",5.9,4));
        inv.Add(new Product("D",5.9,8));
        Console.WriteLine("Product List :");
        foreach(Product i in inv)
        {
            Console.WriteLine(""+i);
        }
    }
}