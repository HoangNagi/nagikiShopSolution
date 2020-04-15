using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace nagikiShopSolution.Data.EF
{
    public class NagikiShopDbContextFactory : IDesignTimeDbContextFactory<NagikiShopDbContext>
    {
        public NagikiShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("NagikiShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<NagikiShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new NagikiShopDbContext(optionsBuilder.Options);
        }
    }
}
