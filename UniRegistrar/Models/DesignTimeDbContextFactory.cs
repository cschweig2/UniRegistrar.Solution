using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace UniRegistrar.Models
{
    public class UniRegistrarContextFactory : IDesignTimeDbContextFactory<UniRegistrarContext>
    {

        UniRegistrarContext IDesignTimeDbContextFactory<UniRegistrarContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<UniRegistrarContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseMySql(connectionString);

            return new UniRegistrarContext(builder.Options);
        }
    }
}