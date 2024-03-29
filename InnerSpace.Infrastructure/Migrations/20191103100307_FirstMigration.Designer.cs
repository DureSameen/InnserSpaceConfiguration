﻿// <auto-generated />
using System;
using InnerSpace.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InnerSpace.Infrastructure.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20191103100307_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InnerSpace.Domain.Aggregates.ConfigurationAggregate.Configuration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<bool>("Enabled");

                    b.Property<DateTimeOffset>("ModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Configurations");
                });

            modelBuilder.Entity("InnerSpace.Domain.Aggregates.ConfigurationAggregate.SubscriptionConfiguration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ConfigurationId");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<bool>("Enabled");

                    b.Property<DateTimeOffset>("ModifiedOn");

                    b.Property<Guid>("SubcriptionId");

                    b.HasKey("Id");

                    b.ToTable("SubcriptionConfigurations");
                });

            modelBuilder.Entity("InnerSpace.Domain.Aggregates.CustomerSubscriptionsConfigurationsAggregate.CustomerSubscriptionsConfigurations", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ConfigurationId");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<bool>("Enabled");

                    b.Property<DateTimeOffset>("ModifiedOn");

                    b.Property<Guid>("UserSubscriptionId");

                    b.HasKey("Id");

                    b.ToTable("CustomerSubscriptionsConfigurations");
                });

            modelBuilder.Entity("InnerSpace.Domain.Aggregates.SubscriptionAggregate.Subscription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<bool>("Enabled");

                    b.Property<DateTimeOffset>("ModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("InnerSpace.Domain.Aggregates.UserSubscriptionsAggregate.UserSubscriptions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("APIKey");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<DateTimeOffset>("ModifiedOn");

                    b.Property<Guid>("SubcriptionId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserSubcriptions");
                });

            modelBuilder.Entity("InnerSpace.Infrastructure.Logging.EventLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("Data");

                    b.Property<Guid>("EntityId");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("EventLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
