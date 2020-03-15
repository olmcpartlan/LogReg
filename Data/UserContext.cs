using Microsoft.EntityFrameworkCore;

namespace AngularLogReg.Data
{
  public class UserContext : DbContext
  {
    public UserContext(DbContextOptions<UserContext> options)
        : base(options)
    {
    }

    public DbSet<AngularLogReg.Models.user> user { get; set; }
  }
}
