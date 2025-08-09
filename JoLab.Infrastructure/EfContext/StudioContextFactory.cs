﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace JoLab.Infrastructure.EfContext
{
    public class StudioContextFactory : IDesignTimeDbContextFactory<StudioContext>
    {
        public StudioContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StudioContext>();
            var rootPath = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            var configuration = new ConfigurationBuilder()
                     .SetBasePath(Path.Combine(rootPath, "JoLab"))
                     .AddJsonFile("appsettings.json")
                     .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("JoLab"));
            return new(optionsBuilder.Options);
        }
    }

}
