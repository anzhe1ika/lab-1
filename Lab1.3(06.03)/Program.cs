using System;
class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list.Add("lncksfnvk");
        list.Add("icfnvkn");
        list.Add("kncksfnvk");
        list.Add("acfnvkn");

        var agg = list.Aggregate("", (current, next) => current + next[0]);
        Console.WriteLine(agg);

        Console.ReadKey();
    }

}