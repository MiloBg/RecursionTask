using System.IO;

namespace RecursionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string txtPath = @"/home/milobg/Documents/Web Development/CSharp/RecursionTask/Data.txt";
            List<string> lines = new List<string>();
            List<Lines> textData = new List<Lines>();

            lines = File.ReadAllLines(txtPath).ToList();

            foreach (var line in lines)
            {
                string[] items = line.Split(',');
                Lines l = new Lines(int.Parse(items[0]), items[1], int.Parse(items[2]));
                textData.Add(l);
            }
            Lines.RecursiveMethod(textData, 0, 0);
        }
    }
}