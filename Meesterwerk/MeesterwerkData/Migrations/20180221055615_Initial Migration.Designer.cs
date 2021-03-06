﻿// <auto-generated />
using MeesterwerkData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace MeesterwerkData.Migrations
{
    [DbContext(typeof(MeesterwerkContext))]
    [Migration("20180221055615_Initial Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MeesterwerkData.Models.Drawing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DeliveryDate");

                    b.Property<int>("Line");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Number")
                        .IsRequired();

                    b.Property<decimal>("PricePerUnit");

                    b.Property<bool>("Printed");

                    b.Property<int?>("PurchaseOrderId");

                    b.Property<int>("Quantity");

                    b.Property<string>("Rev");

                    b.HasKey("Id");

                    b.HasIndex("PurchaseOrderId");

                    b.ToTable("Drawings");
                });

            modelBuilder.Entity("MeesterwerkData.Models.PurchaseOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("OrderNumber");

                    b.HasKey("Id");

                    b.ToTable("PurchaseOrders");
                });

            modelBuilder.Entity("MeesterwerkData.Models.Drawing", b =>
                {
                    b.HasOne("MeesterwerkData.Models.PurchaseOrder")
                        .WithMany("Drawings")
                        .HasForeignKey("PurchaseOrderId");
                });
#pragma warning restore 612, 618
        }
    }
}
