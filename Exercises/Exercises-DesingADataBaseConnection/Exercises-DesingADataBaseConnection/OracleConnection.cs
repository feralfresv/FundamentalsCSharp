namespace Exercises_DesingADataBaseConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string url) : base(url)
        {
            
        }

        public override void Closed()
        {
            System.Console.WriteLine("Oracle Closed");
        }

        public override void Open()
        {
            System.Console.WriteLine("Oracle Open");
        }
    }
}
