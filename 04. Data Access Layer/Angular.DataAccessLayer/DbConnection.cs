using System.Configuration;

namespace SMS.DataAccessLayer
{
    public static class DbConnection
    {
        public static MyDbContext GetContext()
        {
            string connectionString = @"Data Source=MAHUA-PC\SQLEXPRESS;Initial Catalog=SMS;Integrated Security=true";
            return  new MyDbContext(connectionString);
        }
    }
}
