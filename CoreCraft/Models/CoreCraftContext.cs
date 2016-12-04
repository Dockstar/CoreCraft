using System;
using System.Data.Common;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CoreCraft.Models
{
    public class CoreCraftContext : DbContext
    {
        private DbSet<Host> Hosts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            var Builder = new ConfigurationBuilder()
//                .AddJsonFile(Directory.GetCurrentDirectory() + "appsettings.json", optional: false);
//
//            var Config = Builder.Build();

            optionsBuilder.UseMySql("Server=localhost;database=corecraft;uid=root;pwd=19931101;");

        }
    }
}