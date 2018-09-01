using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SMS.DomainEntites;
using SMS.DomainEntites.Entities;

namespace SMS.DataAccessLayer
{
   
    public class MyDbContext : DbContext
    {
        public MyDbContext(string conString) : base(conString)
        {
            Database.SetInitializer<MyDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


        #region Entities

        // Declartion of Entites. Associating Entities with EF
        // Need to declare all entities over here.
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<User> User { get; set; }

        #endregion




    }
}
