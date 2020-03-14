﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Poseidon.API.Data;

namespace Poseidon.API.Migrations
{
    [DbContext(typeof(PoseidonContext))]
    partial class PoseidonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Poseidon.API.Models.BidList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<double?>("Ask")
                        .HasColumnType("float");

                    b.Property<double?>("AskQuantity")
                        .HasColumnType("float");

                    b.Property<string>("Benchmark")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<double?>("Bid")
                        .HasColumnType("float");

                    b.Property<DateTime?>("BidListDate")
                        .HasColumnType("datetime");

                    b.Property<double?>("BidQuantity")
                        .HasColumnType("float");

                    b.Property<string>("Book")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("Commentary")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreationName")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("DealName")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("DealType")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<DateTime?>("RevisionDate")
                        .HasColumnType("datetime");

                    b.Property<string>("RevisionName")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("Security")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("Side")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("SourceListId")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("Status")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Trader")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("BidList");
                });

            modelBuilder.Entity("Poseidon.API.Models.CurvePoint", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AsOfDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<short?>("CurveId")
                        .HasColumnType("smallint");

                    b.Property<double?>("Term")
                        .HasColumnType("float");

                    b.Property<double?>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("CurvePoint");
                });

            modelBuilder.Entity("Poseidon.API.Models.Rating", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FitchRating")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("MoodysRating")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<short?>("OrderNumber")
                        .HasColumnType("smallint");

                    b.Property<string>("SandPrating")
                        .HasColumnName("SandPRating")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.HasKey("Id")
                        .HasName("Rating_pk")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("Rating_Id_uindex");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("Poseidon.API.Models.RuleName", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("Json")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("SqlPart")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("SqlStr")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("Template")
                        .HasColumnType("varchar(512)")
                        .HasMaxLength(512)
                        .IsUnicode(false);

                    b.HasKey("Id")
                        .HasName("RuleName_pk")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("RuleName_Id_uindex");

                    b.ToTable("RuleName");
                });

            modelBuilder.Entity("Poseidon.API.Models.Trade", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Benchmark")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("Book")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<decimal?>("BuyPrice")
                        .HasColumnType("money");

                    b.Property<double?>("BuyQuantity")
                        .HasColumnType("float");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreationName")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("DealName")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("DealType")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<DateTime?>("RevisionDate")
                        .HasColumnType("datetime");

                    b.Property<string>("RevisionName")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("Security")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<decimal?>("SellPrice")
                        .HasColumnType("money");

                    b.Property<double?>("SellQuantity")
                        .HasColumnType("float");

                    b.Property<string>("Side")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("SourceListId")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("Status")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<DateTime?>("TradeDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Trader")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Trade");
                });

            modelBuilder.Entity("Poseidon.API.Models.Users", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("Role")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("Username")
                        .HasColumnType("varchar(125)")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.HasKey("Id")
                        .HasName("Users_pk")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("Users_Id_uindex");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
