﻿// <auto-generated />
using System;
using DzEntityFramework1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DzEntityFramework1.Migrations
{
    [DbContext(typeof(MusicDbContext))]
    partial class MusicDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DzEntityFramework1.Entities.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("AlbumId");

                    b.HasIndex("GenreId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            AlbumId = 1,
                            ArtistId = 2,
                            GenreId = 1,
                            Name = "Kamikaze",
                            Rating = 8,
                            Year = 2020
                        },
                        new
                        {
                            AlbumId = 2,
                            ArtistId = 5,
                            GenreId = 5,
                            Name = "Body Language",
                            Rating = 2,
                            Year = 2008
                        },
                        new
                        {
                            AlbumId = 3,
                            ArtistId = 1,
                            GenreId = 3,
                            Name = "Oczy wizji",
                            Rating = 9,
                            Year = 2022
                        },
                        new
                        {
                            AlbumId = 4,
                            ArtistId = 3,
                            GenreId = 4,
                            Name = "Fun",
                            Rating = 4,
                            Year = 2017
                        },
                        new
                        {
                            AlbumId = 5,
                            ArtistId = 4,
                            GenreId = 2,
                            Name = "Black Market",
                            Rating = 10,
                            Year = 2015
                        });
                });

            modelBuilder.Entity("DzEntityFramework1.Entities.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.HasIndex("AlbumId");

                    b.HasIndex("CountryId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            CountryId = 1,
                            Name = "Slim",
                            Surname = "Shady"
                        },
                        new
                        {
                            ArtistId = 2,
                            CountryId = 3,
                            Name = "Tion",
                            Surname = "Wayne"
                        },
                        new
                        {
                            ArtistId = 3,
                            CountryId = 2,
                            Name = "Lory",
                            Surname = "Rywa"
                        },
                        new
                        {
                            ArtistId = 4,
                            CountryId = 5,
                            Name = "Arturro",
                            Surname = "Mass"
                        },
                        new
                        {
                            ArtistId = 5,
                            CountryId = 4,
                            Name = "Mark",
                            Surname = "Urso"
                        });
                });

            modelBuilder.Entity("DzEntityFramework1.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Action"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Drama"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Horror"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Romance"
                        });
                });

            modelBuilder.Entity("DzEntityFramework1.Entities.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            Name = "США"
                        },
                        new
                        {
                            CountryId = 2,
                            Name = "PL"
                        },
                        new
                        {
                            CountryId = 3,
                            Name = "UK"
                        },
                        new
                        {
                            CountryId = 4,
                            Name = "BG"
                        },
                        new
                        {
                            CountryId = 5,
                            Name = "UA"
                        });
                });

            modelBuilder.Entity("DzEntityFramework1.Entities.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            Name = "Rap"
                        },
                        new
                        {
                            GenreId = 2,
                            Name = "Pop"
                        },
                        new
                        {
                            GenreId = 3,
                            Name = "Rock"
                        },
                        new
                        {
                            GenreId = 4,
                            Name = "Juzz"
                        },
                        new
                        {
                            GenreId = 5,
                            Name = "Classic"
                        });
                });

            modelBuilder.Entity("DzEntityFramework1.Entities.Playlist", b =>
                {
                    b.Property<int>("PlaylistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlaylistId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Playlists");

                    b.HasData(
                        new
                        {
                            PlaylistId = 1,
                            CategoryId = 1,
                            Name = "My Playlist 1"
                        },
                        new
                        {
                            PlaylistId = 2,
                            CategoryId = 2,
                            Name = "My Playlist 2"
                        },
                        new
                        {
                            PlaylistId = 3,
                            CategoryId = 3,
                            Name = "My Playlist 3"
                        },
                        new
                        {
                            PlaylistId = 4,
                            CategoryId = 4,
                            Name = "My Playlist 4"
                        },
                        new
                        {
                            PlaylistId = 5,
                            CategoryId = 5,
                            Name = "My Playlist 5"
                        });
                });

            modelBuilder.Entity("DzEntityFramework1.Entities.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<double>("Auditions")
                        .HasColumnType("float");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrackId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            TrackId = 1,
                            AlbumId = 3,
                            ArtistId = 3,
                            Auditions = 12930.0,
                            Duration = new TimeSpan(0, 0, 3, 42, 0),
                            Rating = 10,
                            Text = "xxxxxxxxxxxxxxxxxx"
                        },
                        new
                        {
                            TrackId = 2,
                            AlbumId = 5,
                            ArtistId = 1,
                            Auditions = 9728.0,
                            Duration = new TimeSpan(0, 0, 4, 10, 0),
                            Rating = 5,
                            Text = "xxxxxxxxxxxxxxxxxx"
                        },
                        new
                        {
                            TrackId = 3,
                            AlbumId = 1,
                            ArtistId = 5,
                            Auditions = 1000000.0,
                            Duration = new TimeSpan(0, 0, 5, 23, 0),
                            Rating = 1,
                            Text = "xxxxxxxxxxxxxxxxxx"
                        },
                        new
                        {
                            TrackId = 4,
                            AlbumId = 4,
                            ArtistId = 4,
                            Auditions = 29402.0,
                            Duration = new TimeSpan(0, 0, 2, 50, 0),
                            Rating = 4,
                            Text = "xxxxxxxxxxxxxxxxxx"
                        },
                        new
                        {
                            TrackId = 5,
                            AlbumId = 2,
                            ArtistId = 2,
                            Auditions = 18209.0,
                            Duration = new TimeSpan(0, 0, 3, 58, 0),
                            Rating = 7,
                            Text = "xxxxxxxxxxxxxxxxxx"
                        });
                });

            modelBuilder.Entity("PlaylistTrack", b =>
                {
                    b.Property<int>("PlaylistsPlaylistId")
                        .HasColumnType("int");

                    b.Property<int>("TracksTrackId")
                        .HasColumnType("int");

                    b.HasKey("PlaylistsPlaylistId", "TracksTrackId");

                    b.HasIndex("TracksTrackId");

                    b.ToTable("PlaylistTrack");
                });

            modelBuilder.Entity("DzEntityFramework1.Entities.Album", b =>
                {
                    b.HasOne("DzEntityFramework1.Entities.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("DzEntityFramework1.Entities.Artist", b =>
                {
                    b.HasOne("DzEntityFramework1.Entities.Album", null)
                        .WithMany("Artist")
                        .HasForeignKey("AlbumId");

                    b.HasOne("DzEntityFramework1.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("DzEntityFramework1.Entities.Playlist", b =>
                {
                    b.HasOne("DzEntityFramework1.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DzEntityFramework1.Entities.Track", b =>
                {
                    b.HasOne("DzEntityFramework1.Entities.Album", "Album")
                        .WithMany()
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("PlaylistTrack", b =>
                {
                    b.HasOne("DzEntityFramework1.Entities.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistsPlaylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DzEntityFramework1.Entities.Track", null)
                        .WithMany()
                        .HasForeignKey("TracksTrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DzEntityFramework1.Entities.Album", b =>
                {
                    b.Navigation("Artist");
                });
#pragma warning restore 612, 618
        }
    }
}
