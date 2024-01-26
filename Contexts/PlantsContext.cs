using Microsoft.EntityFrameworkCore;
using Plants_Api.Models;
using System;
using System.Collections.Generic;

namespace Plants_Api.Contexts
{
    public class PlantsContext: DbContext
    {
        public PlantsContext(DbContextOptions<PlantsContext> options) : base(options)
        {
        }
        public DbSet<PlantDetails> PlantDetails { get; set; }
        public string DbPath { get; }
    }
}
