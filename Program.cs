using System.IO;
using System.Data.SqlClient;
using Dapper;

namespace RecursionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // string txtPath = @"/Data.txt";
            // List<string> lines = new List<string>();
            // List<Lines> textData = new List<Lines>();

            // lines = File.ReadAllLines(txtPath).ToList();

            // foreach (var line in lines)
            // {
            //     string[] items = line.Split(',');
            //     Lines l = new Lines(int.Parse(items[0]), items[1], int.Parse(items[2]));
            //     textData.Add(l);
            // }
            // Lines.RecursiveMethod(textData, 0, 0);

            var connectionString = "Data Source=localhost;Initial Catalog=DatabaseName;Integrated Security=True";

            var getLinesQuery = "select * from Lines";
            using (var connection = new SqlConnection(connectionString)) {
                var lines = connection.Query<Lines>(getLinesQuery).ToList();
            }

            var insertLinesQuery = "insert into Lines (Text, ParentID) values (@Text, @ParentID)";
            using (var connection = new SqlConnection(connectionString)) {
                connection.Execute(insertLinesQuery, new { Text = "text2", ParentID = 1});
                var lines = connection.Query<Lines>(getLinesQuery).ToList();
            }
        }
    }
}
