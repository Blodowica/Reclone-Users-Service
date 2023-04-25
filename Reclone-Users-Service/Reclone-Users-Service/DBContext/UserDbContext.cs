using Microsoft.EntityFrameworkCore;
using Reclone_Users_Service.Models;

namespace Reclone_Users_Service.DBContext
{
    public class UserDbContext : DbContext 
    {

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }


        //Enteties 

       public DbSet<User> User { get; set; }
        public DbSet<Follower> Follower { get; set; }

    }
}
