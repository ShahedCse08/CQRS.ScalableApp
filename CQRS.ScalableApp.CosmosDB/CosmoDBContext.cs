using CQRS.ScalableApp.Models.Players;
using CQRS.ScalableApp.Models.Players.ETO;
using CQRS.ScalableApp.Players.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.ScalableApp.CosmosDB
{
    public class CosmoDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseCosmos(
                "https://localhost:8081",
                "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==",
                databaseName: "ScalableApp");
        }
        public DbSet<PlayerEto> Players { get; set; }
       
    }
}
