﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using autosales.Models;

#nullable disable

namespace autosales.Migrations
{
    [DbContext(typeof(AutosalesDbContext))]
    [Migration("20230904105419_user_data")]
    partial class user_data
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("autosales.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("brand_pkey");

                    b.ToTable("brand", (string)null);
                });

            modelBuilder.Entity("autosales.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("isdeleted");

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasColumnName("price");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userid");

                    b.HasKey("Id")
                        .HasName("car_pkey");

                    b.HasIndex("UserId");

                    b.ToTable("car", (string)null);
                });

            modelBuilder.Entity("autosales.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("color_pkey");

                    b.ToTable("color", (string)null);
                });

            modelBuilder.Entity("autosales.Models.Creation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int")
                        .HasColumnName("brandid");

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("carid");

                    b.Property<int>("ModelId")
                        .HasColumnType("int")
                        .HasColumnName("modelid");

                    b.Property<int>("Year")
                        .HasColumnType("int")
                        .HasColumnName("year");

                    b.HasKey("Id")
                        .HasName("creation_pkey");

                    b.HasIndex("BrandId");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.HasIndex("ModelId");

                    b.ToTable("creation", (string)null);
                });

            modelBuilder.Entity("autosales.Models.Info", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("carid");

                    b.Property<int>("ColorId")
                        .HasColumnType("int")
                        .HasColumnName("colorid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<int>("StateId")
                        .HasColumnType("int")
                        .HasColumnName("stateid");

                    b.Property<int>("TypeId")
                        .HasColumnType("int")
                        .HasColumnName("typeid");

                    b.HasKey("Id")
                        .HasName("info_pkey");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.HasIndex("ColorId");

                    b.HasIndex("StateId");

                    b.HasIndex("TypeId");

                    b.ToTable("info", (string)null);
                });

            modelBuilder.Entity("autosales.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userid");

                    b.HasKey("Id")
                        .HasName("login_pkey");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("login", (string)null);
                });

            modelBuilder.Entity("autosales.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int")
                        .HasColumnName("brandid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("model_pkey");

                    b.HasIndex("BrandId");

                    b.ToTable("model", (string)null);
                });

            modelBuilder.Entity("autosales.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("state_pkey");

                    b.ToTable("state", (string)null);
                });

            modelBuilder.Entity("autosales.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("type_pkey");

                    b.ToTable("type", (string)null);
                });

            modelBuilder.Entity("autosales.Models.Usage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("carid");

                    b.Property<bool>("IsDamaged")
                        .HasColumnType("bit")
                        .HasColumnName("isdamaged");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit")
                        .HasColumnName("isnew");

                    b.Property<int>("Mileage")
                        .HasColumnType("int")
                        .HasColumnName("mileage");

                    b.HasKey("Id")
                        .HasName("usage_pkey");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.ToTable("usage", (string)null);
                });

            modelBuilder.Entity("autosales.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone");

                    b.HasKey("Id")
                        .HasName("user_pkey");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("autosales.Models.Car", b =>
                {
                    b.HasOne("autosales.Models.User", "UserNavigation")
                        .WithMany("CarNavigation")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("car_userid_fkey");

                    b.Navigation("UserNavigation");
                });

            modelBuilder.Entity("autosales.Models.Creation", b =>
                {
                    b.HasOne("autosales.Models.Brand", "BrandNavigation")
                        .WithMany("CreationNavigation")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("creation_brandid_fkey");

                    b.HasOne("autosales.Models.Car", "CarNavigation")
                        .WithOne("CreationNavigation")
                        .HasForeignKey("autosales.Models.Creation", "CarId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("creation_carid_fkey");

                    b.HasOne("autosales.Models.Model", "ModelNavigation")
                        .WithMany("CreationNavigation")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("creation_modelid_fkey");

                    b.Navigation("BrandNavigation");

                    b.Navigation("CarNavigation");

                    b.Navigation("ModelNavigation");
                });

            modelBuilder.Entity("autosales.Models.Info", b =>
                {
                    b.HasOne("autosales.Models.Car", "CarNavigation")
                        .WithOne("InfoNavigation")
                        .HasForeignKey("autosales.Models.Info", "CarId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("info_carid_fkey");

                    b.HasOne("autosales.Models.Color", "ColorNavigation")
                        .WithMany("InfoNavigation")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("info_colorid_fkey");

                    b.HasOne("autosales.Models.State", "StateNavigation")
                        .WithMany("InfoNavigation")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("info_stateid_fkey");

                    b.HasOne("autosales.Models.Type", "TypeNavigation")
                        .WithMany("InfoNavigation")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("info_typeid_fkey");

                    b.Navigation("CarNavigation");

                    b.Navigation("ColorNavigation");

                    b.Navigation("StateNavigation");

                    b.Navigation("TypeNavigation");
                });

            modelBuilder.Entity("autosales.Models.Login", b =>
                {
                    b.HasOne("autosales.Models.User", "UserNavigation")
                        .WithOne("LoginNavigation")
                        .HasForeignKey("autosales.Models.Login", "UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("login_userid_fkey");

                    b.Navigation("UserNavigation");
                });

            modelBuilder.Entity("autosales.Models.Model", b =>
                {
                    b.HasOne("autosales.Models.Brand", "BrandNavigation")
                        .WithMany("ModelNavigation")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("model_brandid_fkey");

                    b.Navigation("BrandNavigation");
                });

            modelBuilder.Entity("autosales.Models.Usage", b =>
                {
                    b.HasOne("autosales.Models.Car", "CarNavigation")
                        .WithOne("UsageNavigation")
                        .HasForeignKey("autosales.Models.Usage", "CarId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("usage_carid_fkey");

                    b.Navigation("CarNavigation");
                });

            modelBuilder.Entity("autosales.Models.Brand", b =>
                {
                    b.Navigation("CreationNavigation");

                    b.Navigation("ModelNavigation");
                });

            modelBuilder.Entity("autosales.Models.Car", b =>
                {
                    b.Navigation("CreationNavigation");

                    b.Navigation("InfoNavigation");

                    b.Navigation("UsageNavigation");
                });

            modelBuilder.Entity("autosales.Models.Color", b =>
                {
                    b.Navigation("InfoNavigation");
                });

            modelBuilder.Entity("autosales.Models.Model", b =>
                {
                    b.Navigation("CreationNavigation");
                });

            modelBuilder.Entity("autosales.Models.State", b =>
                {
                    b.Navigation("InfoNavigation");
                });

            modelBuilder.Entity("autosales.Models.Type", b =>
                {
                    b.Navigation("InfoNavigation");
                });

            modelBuilder.Entity("autosales.Models.User", b =>
                {
                    b.Navigation("CarNavigation");

                    b.Navigation("LoginNavigation");
                });
#pragma warning restore 612, 618
        }
    }
}
