using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BumerangHelper.Models.DatabaseModels;

namespace BumerangHelper.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20161106162817_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BumerangHelper.Models.DatabaseModels.Organization", b =>
                {
                    b.Property<int>("OrganizationID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("About");

                    b.Property<DateTime>("AccordDate");

                    b.Property<string>("AccordNumber");

                    b.Property<string>("AccountNumber");

                    b.Property<string>("Address");

                    b.Property<string>("BankInfo");

                    b.Property<string>("Name");

                    b.Property<string>("Pan");

                    b.HasKey("OrganizationID");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("BumerangHelper.Models.DatabaseModels.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("About");

                    b.Property<string>("Country");

                    b.Property<decimal>("LastPrice");

                    b.Property<string>("Name");

                    b.Property<string>("Unit");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });
        }
    }
}
