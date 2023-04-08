﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PurpleBuzz.Data;

#nullable disable

namespace PurpleBuzz.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230407135421_AddWorksAndCategoriesAndWorkImagesTables")]
    partial class AddWorksAndCategoriesAndWorkImagesTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PurpleBuzz.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Filter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Filter = "graphic",
                            Name = "Graphics",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 2,
                            Filter = "ui",
                            Name = "UI/UX",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 3,
                            Filter = "branding",
                            Name = "Branding",
                            SoftDelete = false
                        });
                });

            modelBuilder.Entity("PurpleBuzz.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "You are free to use this template for your commercial or business websites. You are not allowed to re-distribute this template ZIP file on any template collection websites. It is too easy to illegally copy and repost this template.",
                            SoftDelete = false,
                            Title = "Make Success for future"
                        });
                });

            modelBuilder.Entity("PurpleBuzz.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsActive")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Purple Buzz is a corporate HTML template with Bootstrap 5 Beta 1. This CSS template is 100% free to download provided by <a rel=\"nofollow\" href=\"https://templatemo.com/page/1\" target=\"_parent\">TemplateMo</a>. Total 6 HTML pages included in this template. Icon fonts by <a rel=\"nofollow\" href=\"https://boxicons.com/\" target=\"_blank\">Boxicons</a>. Photos are from <a rel=\"nofollow\" href=\"https://unsplash.com/\" target=\"_blank\">Unsplash</a> and <a rel=\"nofollow\" href=\"https://icons8.com/\" target=\"_blank\">Icons 8</a>.",
                            IsActive = "active",
                            SoftDelete = false,
                            Title = "Develop <strong>Strategies</strong> for <br>your business"
                        },
                        new
                        {
                            Id = 2,
                            Description = "You are not allowed to re-distribute this Purple Buzz HTML template as a downloadable ZIP file on any kind of Free CSS collection websites. This is strongly prohibited. Please contact TemplateMo for more information.",
                            IsActive = "deactive",
                            SoftDelete = false,
                            Title = "HTML CSS Template with Bootstrap 5 Beta 1"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat.",
                            IsActive = "deactive",
                            SoftDelete = false,
                            Title = "Cupidatat non proident, sunt in culpa qui officia"
                        });
                });

            modelBuilder.Entity("PurpleBuzz.Models.SliderBackground", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("SliderBackgrounds");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "banner-bg-01.jpg",
                            SoftDelete = false
                        });
                });

            modelBuilder.Entity("PurpleBuzz.Models.Work", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Works");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing",
                            SoftDelete = false
                        });
                });

            modelBuilder.Entity("PurpleBuzz.Models.WorkImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<int>("WorkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkId");

                    b.ToTable("WorkImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsMain = true,
                            Name = "services-01.jpg",
                            SoftDelete = false,
                            WorkId = 1
                        },
                        new
                        {
                            Id = 2,
                            IsMain = false,
                            Name = "services-01.jpg",
                            SoftDelete = false,
                            WorkId = 1
                        },
                        new
                        {
                            Id = 3,
                            IsMain = true,
                            Name = "services-01.jpg",
                            SoftDelete = false,
                            WorkId = 2
                        },
                        new
                        {
                            Id = 4,
                            IsMain = false,
                            Name = "services-01.jpg",
                            SoftDelete = false,
                            WorkId = 2
                        },
                        new
                        {
                            Id = 5,
                            IsMain = true,
                            Name = "services-01.jpg",
                            SoftDelete = false,
                            WorkId = 3
                        },
                        new
                        {
                            Id = 6,
                            IsMain = false,
                            Name = "services-01.jpg",
                            SoftDelete = false,
                            WorkId = 3
                        },
                        new
                        {
                            Id = 7,
                            IsMain = true,
                            Name = "services-01.jpg",
                            SoftDelete = false,
                            WorkId = 4
                        },
                        new
                        {
                            Id = 8,
                            IsMain = false,
                            Name = "services-01.jpg",
                            SoftDelete = false,
                            WorkId = 4
                        },
                        new
                        {
                            Id = 9,
                            IsMain = true,
                            Name = "services-01.jpg",
                            SoftDelete = false,
                            WorkId = 5
                        },
                        new
                        {
                            Id = 10,
                            IsMain = false,
                            Name = "services-01.jpg",
                            SoftDelete = false,
                            WorkId = 5
                        },
                        new
                        {
                            Id = 11,
                            IsMain = true,
                            Name = "services-01.jpg",
                            SoftDelete = false,
                            WorkId = 6
                        },
                        new
                        {
                            Id = 12,
                            IsMain = false,
                            Name = "services-01.jpg",
                            SoftDelete = false,
                            WorkId = 6
                        },
                        new
                        {
                            Id = 13,
                            IsMain = true,
                            Name = "services-01.jpg",
                            SoftDelete = false,
                            WorkId = 7
                        },
                        new
                        {
                            Id = 14,
                            IsMain = false,
                            Name = "services-01.jpg",
                            SoftDelete = false,
                            WorkId = 7
                        },
                        new
                        {
                            Id = 15,
                            IsMain = true,
                            Name = "services-01.jpg",
                            SoftDelete = false,
                            WorkId = 8
                        },
                        new
                        {
                            Id = 16,
                            IsMain = false,
                            Name = "services-01.jpg",
                            SoftDelete = false,
                            WorkId = 8
                        });
                });

            modelBuilder.Entity("PurpleBuzz.Models.Work", b =>
                {
                    b.HasOne("PurpleBuzz.Models.Category", "Category")
                        .WithMany("Works")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PurpleBuzz.Models.WorkImage", b =>
                {
                    b.HasOne("PurpleBuzz.Models.Work", "Work")
                        .WithMany("WorkImages")
                        .HasForeignKey("WorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Work");
                });

            modelBuilder.Entity("PurpleBuzz.Models.Category", b =>
                {
                    b.Navigation("Works");
                });

            modelBuilder.Entity("PurpleBuzz.Models.Work", b =>
                {
                    b.Navigation("WorkImages");
                });
#pragma warning restore 612, 618
        }
    }
}
