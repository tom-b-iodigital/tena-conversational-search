﻿// <auto-generated />

#nullable disable

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConversationalSearchPlatform.BackOffice.Data.Migrations.Tenant
{
    [DbContext(typeof(Data.TenantDbContext))]
    [Migration("20231012131703_InitialTenants")]
    partial class InitialTenants
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.2.23480.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Finbuckle.MultiTenant.TenantInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("ConnectionString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identifier")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Identifier")
                        .IsUnique()
                        .HasFilter("[Identifier] IS NOT NULL");

                    b.ToTable("TenantInfo");

                    b.HasData(
                        new
                        {
                            Id = "270AFA90-DF18-4FB2-AC10-CFD31E79B238",
                            Identifier = "DEFAULT",
                            Name = "DEFAULT"
                        },
                        new
                        {
                            Id = "D2FA78CE-3185-458E-964F-8FD0052B4330",
                            Identifier = "Polestar",
                            Name = "Polestar"
                        },
                        new
                        {
                            Id = "CCFA9314-ABE6-403A-9E21-2B31D95A5258",
                            Identifier = "iodigital",
                            Name = "iODigital"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
