using Newtonsoft.Json;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, List<string>> dic = new Dictionary<int, List<string>>();
        dic.Add(1, new List<string>(1) { "i" });
        dic.Add(2, new List<string>(2) { "you", "we", "they" });
        dic.Add(3, new List<string>(3) { "he", "she", "it" });

        int count = 0;
        foreach (var value in dic.Values)
        {
            if (value is List<string>)
            {
                count++;
            }
        }

        Console.WriteLine("The number of entries in the dictionary whose values are a list: " + count);
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("Writing a dictionary in JSON format: ");

        string json = JsonConvert.SerializeObject(dic, Formatting.Indented);
        Console.WriteLine(json);


        Console.ReadKey();
    }

}

