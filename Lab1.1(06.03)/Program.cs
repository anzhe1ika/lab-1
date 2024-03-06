class Program
{
    static void Main(string[] args)
    {
        string path = "C:\\Users\\User\\source\\repos\\Lab1.1(06.03)\\file.txt";

        List<int> list = new List<int>();

        StreamReader sr = new StreamReader(path);
        string s;

        try
        {
            while ((s = sr.ReadLine()) != null)
            {
                list.Add(s.Length);
            }

            sr.Close();

            Console.WriteLine("Number of characters in each line:");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
        catch (Exception ex) { Console.WriteLine("Error: " + ex.Message); }

        Console.ReadKey();
    }
}