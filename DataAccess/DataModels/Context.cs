using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataModels
{
    public class Context: DbContext
    {
        public DbSet<DataModels.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database = ToDoList; Trusted_Connection = True;");
        }
    }
}
