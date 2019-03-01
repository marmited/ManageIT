﻿// <auto-generated />
using System;
using ManageIt.Core.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ManageIt.Core.Migrations
{
    [DbContext(typeof(ManageItDbContext))]
    [Migration("20190301204056_basicMigration")]
    partial class basicMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ManageIt.Core.Context.Request", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<string>("Email");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("TimeSlotId");

                    b.Property<int?>("UserId");

                    b.HasKey("RequestId");

                    b.HasIndex("TimeSlotId");

                    b.HasIndex("UserId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("ManageIt.Core.Context.TimeSlot", b =>
                {
                    b.Property<int>("TimeSlotId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<DateTime>("EndTime");

                    b.Property<bool>("IsBlocked");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("StartTime");

                    b.Property<int>("UserId");

                    b.HasKey("TimeSlotId");

                    b.HasIndex("UserId");

                    b.ToTable("TimeSlots");
                });

            modelBuilder.Entity("ManageIt.Core.Context.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("IsBlocked");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PasswordHash")
                        .IsRequired();

                    b.Property<string>("Salt")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ManageIt.Core.Context.Request", b =>
                {
                    b.HasOne("ManageIt.Core.Context.TimeSlot", "TimeSlot")
                        .WithMany()
                        .HasForeignKey("TimeSlotId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ManageIt.Core.Context.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ManageIt.Core.Context.TimeSlot", b =>
                {
                    b.HasOne("ManageIt.Core.Context.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
