using News24.Data.Entities.NewsEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace News24.Data.Context;
public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<News> Newses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {

        builder.IdentitySeed();
        builder.NewsSeed();

        base.OnModelCreating(builder);
    }
}
