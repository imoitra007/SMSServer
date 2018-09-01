using System.Configuration;

namespace SMS.DataAccessLayer
{
    public static class DbConnection
    {
        public static MyDbContext GetContext()
        {
            string connectionString = @"Data Source=.;Initial Catalog=SMS;Integrated Security=True";
            return  new MyDbContext(connectionString);
        }
    }
}
