using BilgeSinema.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeSinema.Data.Context
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieEntity>().HasQueryFilter(x => x.IsDeleted == false);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<MovieEntity> MovieEntities => Set<MovieEntity>();
    }
}
