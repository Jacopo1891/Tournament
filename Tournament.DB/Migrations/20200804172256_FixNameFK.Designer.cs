﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tournament.DB;

namespace Tournament.DB.Migrations
{
    [DbContext(typeof(TournamentContext))]
    [Migration("20200804172256_FixNameFK")]
    partial class FixNameFK
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tournament.Contracts.EntitiesDB.Competition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEdit")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("Tournament.Contracts.EntitiesDB.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompetitionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GuestPlayerId")
                        .HasColumnType("int");

                    b.Property<int>("GuestScore")
                        .HasColumnType("int");

                    b.Property<int?>("GuestTeamId")
                        .HasColumnType("int");

                    b.Property<int?>("HomePlayerId")
                        .HasColumnType("int");

                    b.Property<int>("HomeScore")
                        .HasColumnType("int");

                    b.Property<int?>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastEdit")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompetitionId");

                    b.HasIndex("GuestPlayerId");

                    b.HasIndex("GuestTeamId");

                    b.HasIndex("HomePlayerId");

                    b.HasIndex("HomeTeamId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Tournament.Contracts.EntitiesDB.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LastEdit")
                        .HasColumnType("datetime2");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Tournament.Contracts.EntitiesDB.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LastEdit")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Tournament.Contracts.EntitiesDB.Match", b =>
                {
                    b.HasOne("Tournament.Contracts.EntitiesDB.Competition", "Competition")
                        .WithMany("Matches")
                        .HasForeignKey("CompetitionId");

                    b.HasOne("Tournament.Contracts.EntitiesDB.Player", "GuestPlayer")
                        .WithMany("GuestMatches")
                        .HasForeignKey("GuestPlayerId");

                    b.HasOne("Tournament.Contracts.EntitiesDB.Team", "GuestTeam")
                        .WithMany("GuestMatches")
                        .HasForeignKey("GuestTeamId");

                    b.HasOne("Tournament.Contracts.EntitiesDB.Player", "HomePlayer")
                        .WithMany("HomeMatches")
                        .HasForeignKey("HomePlayerId");

                    b.HasOne("Tournament.Contracts.EntitiesDB.Team", "HomeTeam")
                        .WithMany("HomeMatches")
                        .HasForeignKey("HomeTeamId");
                });
#pragma warning restore 612, 618
        }
    }
}