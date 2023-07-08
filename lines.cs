using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = { "First line", "Second line", "Third line" };
        File.WriteAllLines(@"lines.txt", lines);
    }
}
