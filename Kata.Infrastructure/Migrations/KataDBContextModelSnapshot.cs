﻿// <auto-generated />
using Kata.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kata.Infrastructure.Migrations
{
    [DbContext(typeof(KataDBContext))]
    partial class KataDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Kata.Domain.Entities.Army", b =>
                {
                    b.Property<int>("ArmyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArmyId"));

                    b.Property<int>("ClanId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArmyId");

                    b.HasIndex("ClanId");

                    b.ToTable("Armies");
                });

            modelBuilder.Entity("Kata.Domain.Entities.BattleReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("BattleReports");
                });

            modelBuilder.Entity("Kata.Domain.Entities.Clan", b =>
                {
                    b.Property<int>("ClanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClanId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClanId");

                    b.ToTable("Clans");
                });

            modelBuilder.Entity("Kata.Domain.Entities.Soldier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArmyId")
                        .HasColumnType("int");

                    b.Property<int>("Attack")
                        .HasColumnType("int");

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.Property<int>("Life")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArmyId");

                    b.ToTable("Soldiers");
                });

            modelBuilder.Entity("Kata.Domain.Entities.Army", b =>
                {
                    b.HasOne("Kata.Domain.Entities.Clan", "Clan")
                        .WithMany("Armies")
                        .HasForeignKey("ClanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clan");
                });

            modelBuilder.Entity("Kata.Domain.Entities.Soldier", b =>
                {
                    b.HasOne("Kata.Domain.Entities.Army", "Army")
                        .WithMany("Soldiers")
                        .HasForeignKey("ArmyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Army");
                });

            modelBuilder.Entity("Kata.Domain.Entities.Army", b =>
                {
                    b.Navigation("Soldiers");
                });

            modelBuilder.Entity("Kata.Domain.Entities.Clan", b =>
                {
                    b.Navigation("Armies");
                });
#pragma warning restore 612, 618
        }
    }
}