using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CoreCraft.Models;

namespace CoreCraft.Migrations
{
    [DbContext(typeof(CoreCraftContext))]
    partial class CoreCraftContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("CoreCraft.Models.Host", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("AuthDetails");

                    b.Property<long>("AuthTypeId");

                    b.Property<int>("CPUCount");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<int>("Memory");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int>("Port");

                    b.Property<DateTime>("UpdatedOn")
                        .IsConcurrencyToken();

                    b.HasKey("Id");

                    b.ToTable("Hosts");
                });
        }
    }
}
