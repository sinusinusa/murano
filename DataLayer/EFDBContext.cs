using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DataLayer.Entityes;
using Microsoft.EntityFrameworkCore.Design;

namespace DataLayer;

public class EFDBContext: DbContext
{
  public DbSet<Result> Result { get; set; }

  public EFDBContext(DbContextOptions<EFDBContext> options) : base(options)
  {

  }
  /// <summary>
  /// For Migrations
  /// </summary>
  public class EFDBContextFactory : IDesignTimeDbContextFactory<EFDBContext>
  {
    public EFDBContext CreateDbContext(string[] args)
    {
      var optionsBuilder = new DbContextOptionsBuilder<EFDBContext>();
      optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;TrustServerCertificate=True;", b => b.MigrationsAssembly("DataLayer"));

      return new EFDBContext(optionsBuilder.Options);
    }
  }
}