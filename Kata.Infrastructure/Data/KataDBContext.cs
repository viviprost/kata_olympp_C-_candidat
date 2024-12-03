using Kata.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kata.Infrastructure.Data
{
    public class KataDBContext : DbContext
    {
        public KataDBContext(DbContextOptions<KataDBContext> options) : base(options)
        {
        }

        public DbSet<Clan> Clans { get; set; }
        public DbSet<Army> Armies { get; set; }
        public DbSet<BattleReport> BattleReports { get; set; }
        public DbSet<Soldier> Soldiers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Army>()
                .HasOne(c => c.Clan)
                .WithMany(a => a.Armies)
                .HasForeignKey(p => p.ClanId);

            modelBuilder.Entity<Soldier>()
                .HasOne(c => c.Army)
                .WithMany(a => a.Soldiers)
                .HasForeignKey(p => p.ArmyId);
        }
    }
}