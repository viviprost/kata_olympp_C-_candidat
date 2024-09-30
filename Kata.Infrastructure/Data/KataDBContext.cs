using Kata.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Infrastructure.Data
{
    public class KataDBContext : DbContext
    {
        public KataDBContext(DbContextOptions<KataDBContext> options) : base(options) { }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<Army> Armies { get; set; }
        public DbSet<BattleReport> BattleReports { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           /// TODO: DefineModel
        }
    }
}
