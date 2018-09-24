﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Safari_Online;

namespace Safari_Online.Migrations
{
    [DbContext(typeof(SafariVacationContext))]
    [Migration("20180919192637_AddSeenAnimalTable")]
    partial class AddSeenAnimalTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Safari_Online.SeenAnimal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountOfTimesSeen");

                    b.Property<string>("Location");

                    b.Property<string>("Species");

                    b.Property<DateTime>("TimeOfLastSeen");

                    b.HasKey("Id");

                    b.ToTable("SeenAnimalsTable");
                });
#pragma warning restore 612, 618
        }
    }
}
