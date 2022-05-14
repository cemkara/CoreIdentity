using CoreIdentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CoreIdentity.Concrete
{
    public class Context : IdentityDbContext<MyUser, MyRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=CoreIdentity;trusted_connection=true;");
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<AdminArticle> AdminArticles { get; set; }
    }
}
