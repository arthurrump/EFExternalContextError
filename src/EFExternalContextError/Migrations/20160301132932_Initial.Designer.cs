using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using EFExternalContextErrorCore;

namespace EFExternalContextError.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20160301132932_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("EFExternalContextErrorCore.Thing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Prop1");

                    b.Property<string>("Prop2");

                    b.HasKey("Id");
                });
        }
    }
}
