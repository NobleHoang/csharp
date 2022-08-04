using System;
class Program3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("{0}",Min(null));
        List<int> list = new List<int>();
        list.Add(10);
        list.Add(1);
        list.Add(1230);
        Console.WriteLine("{0}",GetFirst(list));
    }
    private static int ? GetFirst(List<int> list)
    {
        if(list ==null || list.Count==0)
        {
            return null;
        }
        return list[0];
    }
}