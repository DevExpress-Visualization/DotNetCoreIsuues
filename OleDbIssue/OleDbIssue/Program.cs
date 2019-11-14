using System;

namespace OleDbIssue {
    class Program {
        static void Main(string[] args) {
            SalesGenerator generator = new SalesGenerator();
            string connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}\\sales.mdb", Environment.CurrentDirectory);
            generator.Run(connectionString);
        }
    }
}
