using System;

namespace Exercises_DesingADataBaseConnection
{
    public class DbCommand
    {
        private readonly DbConnection _connection;
        private readonly string _instruccion;
        public DbCommand(DbConnection connection, string instruccion)
        {
            if (connection == null)
                throw new ArgumentException("DbConnections cannot be null");

            _connection = connection;
            _instruccion = instruccion;
        }

        public void Execute()
        {
            _connection.Open();
            System.Console.WriteLine("this is your instruccion: " + _instruccion);
            _connection.Closed();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("URL DATA BASE");
            // sql.Open();
            // sql.Closed();
            // Console.WriteLine();

            // var oracle = new OracleConnection(""); //Force the error
            // oracle.Open();
            // oracle.Closed();

            var command = new DbCommand(sql , "New Instruccion");
            command.Execute();
        }
    }
}
