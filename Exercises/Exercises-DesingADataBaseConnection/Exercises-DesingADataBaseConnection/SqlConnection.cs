namespace Exercises_DesingADataBaseConnection
{

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string url) : base(url)
        {
            
        }
        public override void Open()
        {
            System.Console.WriteLine("SQL Open");
        }

        public override void Closed()
        {
            System.Console.WriteLine("SQL Closed");
        }
    }
}
