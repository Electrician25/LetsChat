﻿// <auto-generated />
using System;
using LetsChat.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LetsChat.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LetsChat.Entities.ChatRoom", b =>
                {
                    b.Property<int>("ChatRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ChatRoomId"));

                    b.Property<string>("RoomName")
                        .HasColumnType("text");

                    b.Property<string>("RoomPassword")
                        .HasColumnType("text");

                    b.HasKey("ChatRoomId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            ChatRoomId = 1,
                            RoomName = "YesPass",
                            RoomPassword = "1"
                        },
                        new
                        {
                            ChatRoomId = 2,
                            RoomName = "NoPass"
                        });
                });

            modelBuilder.Entity("LetsChat.Entities.User", b =>
                {
                    b.Property<int?>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("UserId"));

                    b.Property<int>("ChatRoomId")
                        .HasColumnType("integer");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.Property<string>("UserPassword")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.HasIndex("ChatRoomId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            ChatRoomId = 1,
                            UserName = "Alex1",
                            UserPassword = "1"
                        },
                        new
                        {
                            UserId = 2,
                            ChatRoomId = 1,
                            UserName = "Alex2",
                            UserPassword = "2"
                        },
                        new
                        {
                            UserId = 3,
                            ChatRoomId = 1,
                            UserName = "Alex3",
                            UserPassword = "3"
                        },
                        new
                        {
                            UserId = 4,
                            ChatRoomId = 1,
                            UserName = "Alex4",
                            UserPassword = "4"
                        });
                });

            modelBuilder.Entity("LetsChat.Entities.User", b =>
                {
                    b.HasOne("LetsChat.Entities.ChatRoom", "ChatRoom")
                        .WithMany("User")
                        .HasForeignKey("ChatRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChatRoom");
                });

            modelBuilder.Entity("LetsChat.Entities.ChatRoom", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
