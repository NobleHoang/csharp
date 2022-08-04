using System;
class Program2
{
    public static void Main1(string[] args)
    {
        String a = "a";
        String b = "b";
        Swap<String>(ref a,ref b);
        System.Console.WriteLine(a+""+b);
    }
    static void Swap<T>(ref T lhs, ref T rhs)
    {
        T temp = lhs;
        lhs = rhs;
        rhs = temp;
    }
}