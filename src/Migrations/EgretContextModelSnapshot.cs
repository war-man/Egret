﻿// <auto-generated />
using Egret.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace Egret.Migrations
{
    [DbContext(typeof(EgretContext))]
    partial class EgretContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:adminpack", "'adminpack', '', ''")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Egret.DataAccess.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("suppliers_pkey");

                    b.ToTable("suppliers","public");
                });

            modelBuilder.Entity("Egret.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(450);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Egret.Models.CurrencyType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id");

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnName("abbreviation");

                    b.Property<bool>("Active")
                        .HasColumnName("active");

                    b.Property<bool>("Defaultselection")
                        .HasColumnName("defaultselection");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name");

                    b.Property<int>("Sortorder")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("sortorder")
                        .HasDefaultValueSql("nextval('admin.currency_types_sortorder_seq'::regclass)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnName("symbol");

                    b.HasKey("Id");

                    b.HasIndex("Abbreviation")
                        .IsUnique()
                        .HasName("currency_types_abbreviation_key");

                    b.HasIndex("Sortorder")
                        .IsUnique()
                        .HasName("currency_types_sort_key");

                    b.ToTable("currency_types","admin");
                });

            modelBuilder.Entity("Egret.Models.InventoryCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasDefaultValueSql("nextval('admin.inventory_categories_id_seq'::regclass)");

                    b.Property<bool>("Active")
                        .HasColumnName("active");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name");

                    b.Property<int>("Sortorder")
                        .HasColumnName("sortorder");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("inventory_categories_name_key");

                    b.HasIndex("Sortorder")
                        .IsUnique()
                        .HasName("inventory_categories_sort_key");

                    b.ToTable("inventory_categories","admin");
                });

            modelBuilder.Entity("Egret.Models.InventoryItem", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("code")
                        .HasDefaultValueSql("nextval('master_seq'::regclass)");

                    b.Property<string>("Addedby")
                        .HasColumnName("useraddedby");

                    b.Property<string>("Buycurrency")
                        .HasColumnName("buycurrency");

                    b.Property<double?>("Buyprice")
                        .HasColumnName("buyprice");

                    b.Property<int?>("Buyunit")
                        .HasColumnName("buyunit_fk");

                    b.Property<string>("Category")
                        .HasColumnName("category");

                    b.Property<int?>("Cogacct")
                        .HasColumnName("cogacct");

                    b.Property<string>("Comment")
                        .HasColumnName("comment");

                    b.Property<string>("Conversionsource")
                        .HasColumnName("conversionsource");

                    b.Property<double?>("Costprice")
                        .HasColumnName("costprice");

                    b.Property<DateTime?>("Dateadded")
                        .HasColumnName("dateadded");

                    b.Property<DateTime?>("Dateupdated")
                        .HasColumnName("dateupdated");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description");

                    b.Property<int?>("Flags")
                        .HasColumnName("flags");

                    b.Property<bool?>("Isconversion")
                        .HasColumnName("isconversion");

                    b.Property<double?>("Qtybrksellprice")
                        .HasColumnName("qtybrksellprice");

                    b.Property<int?>("Salesacct")
                        .HasColumnName("salesacct");

                    b.Property<string>("Sellcurrency")
                        .HasColumnName("sellcurrency");

                    b.Property<double?>("Sellprice")
                        .HasColumnName("sellprice");

                    b.Property<int?>("Sellunit")
                        .HasColumnName("sellunit_fk");

                    b.Property<double?>("Sohcount")
                        .HasColumnName("sohcount");

                    b.Property<int?>("Stockacct")
                        .HasColumnName("stockacct");

                    b.Property<double?>("Stocktakenewqty")
                        .HasColumnName("stocktakenewqty");

                    b.Property<double?>("Stockvalue")
                        .HasColumnName("stockvalue");

                    b.Property<int?>("Supplier")
                        .HasColumnName("supplier_fk");

                    b.Property<string>("Updatedby")
                        .HasColumnName("userupdatedby");

                    b.HasKey("Code");

                    b.HasIndex("Buycurrency");

                    b.HasIndex("Buyunit");

                    b.HasIndex("Category");

                    b.HasIndex("Sellcurrency");

                    b.HasIndex("Sellunit");

                    b.ToTable("inventory_items");
                });

            modelBuilder.Entity("Egret.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasDefaultValueSql("nextval('admin.units_id_seq'::regclass)");

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnName("abbreviation");

                    b.Property<bool>("Active")
                        .HasColumnName("active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name");

                    b.Property<int>("Sortorder")
                        .HasColumnName("sortorder");

                    b.HasKey("Id");

                    b.HasIndex("Abbreviation")
                        .IsUnique()
                        .HasName("units_abbreviation_key");

                    b.HasIndex("Sortorder")
                        .IsUnique()
                        .HasName("units_sort_key");

                    b.ToTable("units","admin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(450);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Egret.Models.AppRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");


                    b.ToTable("AppRole");

                    b.HasDiscriminator().HasValue("AppRole");
                });

            modelBuilder.Entity("Egret.Models.InventoryItem", b =>
                {
                    b.HasOne("Egret.Models.CurrencyType", "BuycurrencyNavigation")
                        .WithMany("InventoryItemsBuycurrencyNavigation")
                        .HasForeignKey("Buycurrency")
                        .HasConstraintName("inventory_items_buycurrency_fk")
                        .HasPrincipalKey("Abbreviation")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Egret.Models.Unit", "BuyunitNavigation")
                        .WithMany("InventoryItemsBuyunitNavigation")
                        .HasForeignKey("Buyunit")
                        .HasConstraintName("inventory_items_buyunit_fk")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Egret.Models.InventoryCategory", "CategoryNavigation")
                        .WithMany("InventoryItems")
                        .HasForeignKey("Category")
                        .HasConstraintName("inventory_items_category_fk")
                        .HasPrincipalKey("Name")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Egret.Models.CurrencyType", "SellcurrencyNavigation")
                        .WithMany("InventoryItemsSellcurrencyNavigation")
                        .HasForeignKey("Sellcurrency")
                        .HasConstraintName("inventory_items_sellcurrency_fk")
                        .HasPrincipalKey("Abbreviation")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Egret.Models.Unit", "SellunitNavigation")
                        .WithMany("InventoryItemsSellunitNavigation")
                        .HasForeignKey("Sellunit")
                        .HasConstraintName("inventory_items_sellunit_fk")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Egret.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Egret.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Egret.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Egret.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
