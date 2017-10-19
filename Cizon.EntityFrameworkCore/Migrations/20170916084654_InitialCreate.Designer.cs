﻿// <auto-generated />
using Cizon.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Cizon.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(CizonDbContext))]
    [Migration("20170916084654_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Cizon.Domain.Entities.DeptDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("Address")
                        .HasMaxLength(100);

                    b.Property<string>("CityCode")
                        .HasMaxLength(20);

                    b.Property<int?>("Code")
                        .IsRequired();

                    b.Property<string>("Contact")
                        .HasMaxLength(10);

                    b.Property<string>("ContactNumber")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("CreateTime")
                        .IsRequired();

                    b.Property<string>("Creator")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Leader")
                        .HasMaxLength(10);

                    b.Property<int?>("Level")
                        .IsRequired();

                    b.Property<string>("Modifier")
                        .HasMaxLength(10);

                    b.Property<DateTime?>("ModifyTime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Note")
                        .HasMaxLength(255);

                    b.Property<string>("Postcode")
                        .HasMaxLength(10);

                    b.Property<string>("ShortName")
                        .HasMaxLength(50);

                    b.Property<int?>("State");

                    b.Property<string>("Tag1")
                        .HasMaxLength(50);

                    b.Property<string>("Tag2")
                        .HasMaxLength(50);

                    b.Property<string>("WebSite")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("dept");
                });

            modelBuilder.Entity("Cizon.Domain.Entities.MenuDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("AssemblyName");

                    b.Property<string>("BindRight");

                    b.Property<string>("ClassName");

                    b.Property<string>("Icon1");

                    b.Property<string>("Icon2");

                    b.Property<string>("Modifier")
                        .IsRequired();

                    b.Property<DateTime?>("ModifyTime")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("NavigationVisible")
                        .IsRequired();

                    b.Property<string>("Note");

                    b.Property<int?>("OpenType")
                        .IsRequired();

                    b.Property<int?>("OrderNum")
                        .IsRequired();

                    b.Property<string>("PId")
                        .IsRequired();

                    b.Property<string>("SystemId");

                    b.Property<int?>("Type")
                        .IsRequired();

                    b.Property<string>("UrlAddress");

                    b.Property<string>("UrlExtraParam");

                    b.Property<string>("UrlIncludeUserSession");

                    b.Property<int?>("Visible")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("s_menu");
                });

            modelBuilder.Entity("Cizon.Domain.Entities.RightDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("Modifier");

                    b.Property<DateTime?>("ModifyTime");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Note");

                    b.Property<int?>("OrderNum")
                        .IsRequired();

                    b.Property<string>("SystemId");

                    b.Property<int?>("Visible")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("s_right");
                });

            modelBuilder.Entity("Cizon.Domain.Entities.RoleAssignmentDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.Property<DateTime?>("SetTime")
                        .IsRequired();

                    b.Property<string>("Setter")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int?>("State")
                        .IsRequired();

                    b.Property<string>("SystemId")
                        .IsRequired();

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("UserType")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("s_roleassignment");
                });

            modelBuilder.Entity("Cizon.Domain.Entities.RoleDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("Modifier")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("ModifyTime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Note")
                        .HasMaxLength(255);

                    b.Property<string>("RoleCode")
                        .HasMaxLength(50);

                    b.Property<int?>("State");

                    b.Property<string>("SystemId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("s_role");
                });

            modelBuilder.Entity("Cizon.Domain.Entities.RoleSettingDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("LinkId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("LinkType");

                    b.Property<string>("Modifier")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("ModifyTime");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("s_rolesetting");
                });

            modelBuilder.Entity("Cizon.Domain.Entities.UserInfoDto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("Address")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("Birthdate");

                    b.Property<DateTime?>("CreateTime")
                        .IsRequired();

                    b.Property<string>("Creator")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("DeptId");

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<int?>("ErrorTimes");

                    b.Property<string>("LogonCode")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("MobileNumber")
                        .HasMaxLength(20);

                    b.Property<string>("Modifier")
                        .HasMaxLength(10);

                    b.Property<DateTime?>("ModifyTime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Note")
                        .HasMaxLength(255);

                    b.Property<string>("Password");

                    b.Property<string>("Postcode")
                        .HasMaxLength(10);

                    b.Property<int?>("Sex")
                        .IsRequired();

                    b.Property<int?>("State")
                        .IsRequired();

                    b.Property<string>("Tel")
                        .HasMaxLength(20);

                    b.Property<int?>("UserCode");

                    b.HasKey("Id");

                    b.ToTable("userinfo");
                });
#pragma warning restore 612, 618
        }
    }
}
