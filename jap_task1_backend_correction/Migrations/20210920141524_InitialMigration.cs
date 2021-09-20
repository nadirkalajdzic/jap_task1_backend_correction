﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JapTask1BackendCorrection.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MostRatedMoviesReports",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfRatings = table.Column<int>(type: "int", nullable: false),
                    AverageRating = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MoviesWithMostScreeningsReports",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfScreenings = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MoviesWithMostSoldTicketsReports",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScreeningName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoldTickets = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Salt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Hash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActorMedia",
                columns: table => new
                {
                    ActorsId = table.Column<int>(type: "int", nullable: false),
                    MediasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMedia", x => new { x.ActorsId, x.MediasId });
                    table.ForeignKey(
                        name: "FK_ActorMedia_Actors_ActorsId",
                        column: x => x.ActorsId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMedia_Medias_MediasId",
                        column: x => x.MediasId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryMedia",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    MediasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMedia", x => new { x.CategoriesId, x.MediasId });
                    table.ForeignKey(
                        name: "FK_CategoryMedia_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryMedia_Medias_MediasId",
                        column: x => x.MediasId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Screenings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false),
                    AvailableTickets = table.Column<int>(type: "int", nullable: false),
                    SoldTickets = table.Column<int>(type: "int", nullable: false),
                    ScreeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Screenings_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<float>(type: "real", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoughtTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScreeningId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BoughtTickets = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoughtTickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoughtTickets_Screenings_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "Screenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoughtTickets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(7353), "SYSTEM", "Morgan", "Freeman" },
                    { 51, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8417), "SYSTEM", "Lance", "Reddick" },
                    { 50, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8415), "SYSTEM", "Dominic", "West" },
                    { 49, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8412), "SYSTEM", "Jessie", "Buckley" },
                    { 48, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8409), "SYSTEM", "Stellan", "Skarsgard" },
                    { 47, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8407), "SYSTEM", "Jared", "Harris" },
                    { 46, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8404), "SYSTEM", "Jessie", "Buckley" },
                    { 52, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8420), "SYSTEM", "Sonja", "Sohn" },
                    { 45, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8365), "SYSTEM", "Ron", "Livingston" },
                    { 43, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8360), "SYSTEM", "Scott", "Grimes" },
                    { 42, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8357), "SYSTEM", "Anna", "Gunn" },
                    { 41, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8355), "SYSTEM", "Aaron", "Paul" },
                    { 40, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8352), "SYSTEM", "Bryan", "Cranston" },
                    { 39, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8350), "SYSTEM", "Nikolay", "Drozdov" },
                    { 38, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8347), "SYSTEM", "Sigourney", "Weaver" },
                    { 44, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8362), "SYSTEM", "Damian", "Lewis" },
                    { 37, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8345), "SYSTEM", "David", "Attenborough" },
                    { 53, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8422), "SYSTEM", "Peter", "Drost" },
                    { 55, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8427), "SYSTEM", "Neil", "deGrasse Tyson" },
                    { 70, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8467), "SYSTEM", "Eddie", "Falco" },
                    { 68, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8462), "SYSTEM", "James", "Gandolfini" },
                    { 67, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8459), "SYSTEM", "Kit", "Harington" },
                    { 66, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8456), "SYSTEM", "Peter", "Dinklage" },
                    { 65, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8452), "SYSTEM", "Emilia", "Clarke" },
                    { 64, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8450), "SYSTEM", "Jonathan", "Fahn" },
                    { 54, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8425), "SYSTEM", "Roger", "Horrocks" },
                    { 63, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8447), "SYSTEM", "Jaromir", "Hanzlik" },
                    { 61, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8442), "SYSTEM", "Mae", "Whitman" },
                    { 60, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8440), "SYSTEM", "Zach", "Tyler" },
                    { 59, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8437), "SYSTEM", "Dee", "Bradley Baker" },
                    { 58, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8435), "SYSTEM", "Neil", "deGrasse Tyson" },
                    { 57, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8432), "SYSTEM", "Piotr", "Michael" },
                    { 56, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8430), "SYSTEM", "Stoney", "Emshwiller" },
                    { 62, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8445), "SYSTEM", "Carl", "Sagan" },
                    { 36, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8342), "SYSTEM", "Elliot", "Page" },
                    { 69, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8464), "SYSTEM", "Lorraine", "Bracco" },
                    { 34, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8337), "SYSTEM", "Leonardo", "DiCaprio" },
                    { 15, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8286), "SYSTEM", "Liam", "Neeson" },
                    { 13, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8281), "SYSTEM", "Lee", "J. Cobb" },
                    { 12, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8278), "SYSTEM", "Henry", "Fonda" },
                    { 11, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8276), "SYSTEM", "Aaron", "Eckhart" },
                    { 10, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8273), "SYSTEM", "Heath", "Ledger" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 9, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8269), "SYSTEM", "Christian", "Bale" },
                    { 16, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8289), "SYSTEM", "Ralph", "Fiennes" },
                    { 8, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8267), "SYSTEM", "Robert", "Duvall" },
                    { 6, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8261), "SYSTEM", "James", "Caan" },
                    { 5, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8253), "SYSTEM", "Al", "Pacino" },
                    { 4, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8250), "SYSTEM", "Marlon", "Brando" },
                    { 3, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8247), "SYSTEM", "Tim", "Robbins" },
                    { 35, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8340), "SYSTEM", "Joseph", "Gordon-Levitt" },
                    { 2, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8234), "SYSTEM", "Bob", "Gunton" },
                    { 7, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8264), "SYSTEM", "Robert", "De Niro" },
                    { 17, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8291), "SYSTEM", "Ben", "Kingsley" },
                    { 14, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8284), "SYSTEM", "Martin", "Balsam" },
                    { 19, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8298), "SYSTEM", "Viggo", "Mortensen" },
                    { 33, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8333), "SYSTEM", "Gary", "Sinise" },
                    { 32, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8331), "SYSTEM", "Robin", "Wright" },
                    { 31, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8328), "SYSTEM", "Tom", "Hanks" },
                    { 30, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8326), "SYSTEM", "Meat", "Loaf" },
                    { 18, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8295), "SYSTEM", "Elijah", "Wood" },
                    { 28, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8321), "SYSTEM", "Brad", "Pitt" },
                    { 27, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8318), "SYSTEM", "Orlando", "Bloom" },
                    { 29, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8323), "SYSTEM", "Edward", "Norton" },
                    { 25, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8313), "SYSTEM", "Eli", "Wallach" },
                    { 24, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8311), "SYSTEM", "Clint", "Eastwood" },
                    { 23, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8308), "SYSTEM", "Samuel", "L. Jackson" },
                    { 22, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8306), "SYSTEM", "Uma", "Thurman" },
                    { 21, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8303), "SYSTEM", "John", "Travolta" },
                    { 20, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8301), "SYSTEM", "Ian", "McKellen" },
                    { 26, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 512, DateTimeKind.Local).AddTicks(8316), "SYSTEM", "Lee", "Van Cleef" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Name" },
                values: new object[,]
                {
                    { 10, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 510, DateTimeKind.Local).AddTicks(1198), "SYSTEM", "BIOGRAPHY" },
                    { 15, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 510, DateTimeKind.Local).AddTicks(1212), "SYSTEM", "ANIMATION" },
                    { 14, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 510, DateTimeKind.Local).AddTicks(1209), "SYSTEM", "HISTORY" },
                    { 13, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 510, DateTimeKind.Local).AddTicks(1206), "SYSTEM", "DOCUMENTARY" },
                    { 12, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 510, DateTimeKind.Local).AddTicks(1203), "SYSTEM", "SCI-FI" },
                    { 11, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 510, DateTimeKind.Local).AddTicks(1201), "SYSTEM", "ROMANCE" },
                    { 9, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 510, DateTimeKind.Local).AddTicks(1194), "SYSTEM", "WESTERN" },
                    { 3, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 510, DateTimeKind.Local).AddTicks(1173), "SYSTEM", "THRILLER" },
                    { 7, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 510, DateTimeKind.Local).AddTicks(1189), "SYSTEM", "BIOGRAPHY" },
                    { 6, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 510, DateTimeKind.Local).AddTicks(1186), "SYSTEM", "CRIME" },
                    { 5, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 510, DateTimeKind.Local).AddTicks(1180), "SYSTEM", "TRAGEDY" },
                    { 4, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 510, DateTimeKind.Local).AddTicks(1178), "SYSTEM", "DRAMA" },
                    { 8, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 510, DateTimeKind.Local).AddTicks(1192), "SYSTEM", "ADVENTURE" },
                    { 2, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 510, DateTimeKind.Local).AddTicks(1141), "SYSTEM", "COMEDY" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Name" },
                values: new object[] { 1, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 508, DateTimeKind.Local).AddTicks(2750), "SYSTEM", "ACTION" });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Description", "ImageUrl", "ReleaseDate", "Title", "Type" },
                values: new object[,]
                {
                    { 70, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8510), "SYSTEM", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight 5", 0 },
                    { 71, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8513), "SYSTEM", "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", "https://upload.wikimedia.org/wikipedia/commons/b/b5/12_Angry_Men_%281957_film_poster%29.jpg", new DateTime(1957, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Angry Men 5", 0 },
                    { 72, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8516), "SYSTEM", "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/c617e634647543.56d846b10d56f.jpg", new DateTime(1994, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schindler's List 5", 0 },
                    { 73, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8519), "SYSTEM", "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", "https://img.discogs.com/MsgjJVAxVCXb1w86ffIbaNRr2BY=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-728620-1512923411-4779.jpeg.jpg", new DateTime(2003, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Return of the King 5", 0 },
                    { 76, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8549), "SYSTEM", "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png", new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction 52", 0 },
                    { 75, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8546), "SYSTEM", "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png", new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction 51", 0 },
                    { 69, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8507), "SYSTEM", "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.", "https://shotonwhat.com/images/0071562-med.jpg", new DateTime(1974, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather: Part II 5", 0 },
                    { 77, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8553), "SYSTEM", "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png", new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction 53", 0 },
                    { 78, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8556), "SYSTEM", "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.", "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg", new DateTime(1996, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Good, the Bad and the Ugly 5", 0 },
                    { 74, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8523), "SYSTEM", "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png", new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction 5", 0 },
                    { 68, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8504), "SYSTEM", "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.", "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg", new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather 5", 0 },
                    { 64, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8489), "SYSTEM", "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.", "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg", new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump 4", 0 },
                    { 66, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8497), "SYSTEM", "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg", new DateTime(2010, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception 4444", 0 },
                    { 65, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8493), "SYSTEM", "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg", new DateTime(2010, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception 4", 0 },
                    { 63, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8485), "SYSTEM", "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", "https://m.media-amazon.com/images/I/51v5ZpFyaFL._AC_.jpg", new DateTime(1999, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club 4", 0 },
                    { 62, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8482), "SYSTEM", "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", "https://images.moviesanywhere.com/198e228b071c60f5ad57e5f62fe60029/ff22cad6-2218-414d-b853-3f95d76905c7.jpg?h=375&resize=fit&w=250", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Fellowship of the Ring 4", 0 },
                    { 61, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8478), "SYSTEM", "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.", "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg", new DateTime(1996, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Good, the Bad and the Ugly 4", 0 },
                    { 60, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8475), "SYSTEM", "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png", new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction 4", 0 },
                    { 59, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8472), "SYSTEM", "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", "https://img.discogs.com/MsgjJVAxVCXb1w86ffIbaNRr2BY=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-728620-1512923411-4779.jpeg.jpg", new DateTime(2003, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Return of the King 4", 0 },
                    { 58, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8468), "SYSTEM", "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/c617e634647543.56d846b10d56f.jpg", new DateTime(1994, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schindler's List 4", 0 },
                    { 56, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8462), "SYSTEM", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight 4", 0 },
                    { 57, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8465), "SYSTEM", "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", "https://upload.wikimedia.org/wikipedia/commons/b/b5/12_Angry_Men_%281957_film_poster%29.jpg", new DateTime(1957, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Angry Men 4", 0 },
                    { 79, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8559), "SYSTEM", "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.", "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg", new DateTime(1996, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Good, the Bad and the Ugly 51", 0 },
                    { 67, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8501), "SYSTEM", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop", new DateTime(1994, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption 5", 0 },
                    { 80, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8562), "SYSTEM", "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", "https://images.moviesanywhere.com/198e228b071c60f5ad57e5f62fe60029/ff22cad6-2218-414d-b853-3f95d76905c7.jpg?h=375&resize=fit&w=250", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Fellowship of the Ring 5", 0 },
                    { 104, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8641), "SYSTEM", "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.", "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg", new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather 76", 0 },
                    { 82, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8569), "SYSTEM", "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.", "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg", new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump 5", 0 },
                    { 55, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8459), "SYSTEM", "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.", "https://shotonwhat.com/images/0071562-med.jpg", new DateTime(1974, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather: Part II 4", 0 },
                    { 105, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8645), "SYSTEM", "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.", "https://shotonwhat.com/images/0071562-med.jpg", new DateTime(1974, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather: Part II 76", 0 },
                    { 103, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8638), "SYSTEM", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop", new DateTime(1994, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption 76", 0 },
                    { 102, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8635), "SYSTEM", "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg", new DateTime(2010, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception 66", 0 },
                    { 101, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8632), "SYSTEM", "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.", "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg", new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump 66", 0 },
                    { 100, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8629), "SYSTEM", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight 7", 0 },
                    { 99, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8626), "SYSTEM", "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.", "https://shotonwhat.com/images/0071562-med.jpg", new DateTime(1974, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather: Part II 7", 0 },
                    { 98, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8622), "SYSTEM", "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.", "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg", new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather 7", 0 },
                    { 97, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8619), "SYSTEM", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop", new DateTime(1994, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption 7", 0 },
                    { 96, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8616), "SYSTEM", "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg", new DateTime(2010, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception 6", 0 },
                    { 95, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8613), "SYSTEM", "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.", "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg", new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump 6", 0 },
                    { 94, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8610), "SYSTEM", "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", "https://m.media-amazon.com/images/I/51v5ZpFyaFL._AC_.jpg", new DateTime(1999, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club 6", 0 },
                    { 93, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8606), "SYSTEM", "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", "https://images.moviesanywhere.com/198e228b071c60f5ad57e5f62fe60029/ff22cad6-2218-414d-b853-3f95d76905c7.jpg?h=375&resize=fit&w=250", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Fellowship of the Ring 6", 0 },
                    { 92, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8603), "SYSTEM", "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.", "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg", new DateTime(1996, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Good, the Bad and the Ugly 6", 0 }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Description", "ImageUrl", "ReleaseDate", "Title", "Type" },
                values: new object[,]
                {
                    { 91, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8600), "SYSTEM", "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png", new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction 6", 0 },
                    { 90, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8597), "SYSTEM", "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", "https://img.discogs.com/MsgjJVAxVCXb1w86ffIbaNRr2BY=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-728620-1512923411-4779.jpeg.jpg", new DateTime(2003, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Return of the King 6", 0 },
                    { 89, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8593), "SYSTEM", "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/c617e634647543.56d846b10d56f.jpg", new DateTime(1994, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schindler's List 6", 0 },
                    { 88, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8588), "SYSTEM", "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", "https://upload.wikimedia.org/wikipedia/commons/b/b5/12_Angry_Men_%281957_film_poster%29.jpg", new DateTime(1957, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Angry Men 6", 0 },
                    { 87, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8585), "SYSTEM", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight 6", 0 },
                    { 86, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8582), "SYSTEM", "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.", "https://shotonwhat.com/images/0071562-med.jpg", new DateTime(1974, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather: Part II 6", 0 },
                    { 85, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8579), "SYSTEM", "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.", "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg", new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather 6", 0 },
                    { 84, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8576), "SYSTEM", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop", new DateTime(1994, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption 6", 0 },
                    { 83, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8572), "SYSTEM", "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg", new DateTime(2010, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception 5", 0 },
                    { 81, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8566), "SYSTEM", "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", "https://m.media-amazon.com/images/I/51v5ZpFyaFL._AC_.jpg", new DateTime(1999, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club 5", 0 },
                    { 54, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8456), "SYSTEM", "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.", "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg", new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather 4", 0 },
                    { 11, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8255), "SYSTEM", "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", "https://m.media-amazon.com/images/I/51v5ZpFyaFL._AC_.jpg", new DateTime(1999, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club", 0 },
                    { 52, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8449), "SYSTEM", "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg", new DateTime(2010, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception 3", 0 },
                    { 23, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8334), "SYSTEM", "In a war-torn world of elemental magic, a young boy reawakens to undertake a dangerous mystic quest to fulfill his destiny as the Avatar, and bring peace to the world.", "https://images-na.ssl-images-amazon.com/images/I/914eUC4XPML.jpg", new DateTime(2005, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avatar: The Last Airbender", 1 },
                    { 22, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8331), "SYSTEM", "An exploration of our discovery of the laws of nature and coordinates in space and time.", "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/5945/5945188_sa.jpg;maxHeight=640;maxWidth=550", new DateTime(2014, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cosmos: A Spacetime Odyssey", 1 },
                    { 21, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8327), "SYSTEM", "Documentary series focusing on the breadth of the diversity of habitats around the world, from the remote Arctic wilderness and mysterious deep oceans to the vast landscapes of Africa and diverse jungles of South America.", "https://www.penguin.co.uk/content/dam/prh/books/111/1115210/9780593079768.jpg.transform/PRHDesktopWide_small/image.jpg", new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Our Planet", 1 },
                    { 20, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8324), "SYSTEM", "David Attenborough returns to the world's oceans in this sequel to the acclaimed documentary filming rare and unusual creatures of the deep, as well as documenting the problems our oceans face.", "https://cdn.shopify.com/s/files/1/0747/3829/products/mL1006_1024x1024.jpg?v=1571445246", new DateTime(2017, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blue Planet II", 1 },
                    { 19, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8321), "SYSTEM", "The Baltimore drug scene, as seen through the eyes of drug dealers and law enforcement.", "https://tvshows.today/wp-content/uploads/the-wire-season-1-poster.jpg", new DateTime(2008, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Wire", 1 },
                    { 18, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8317), "SYSTEM", "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.", "https://i.redd.it/bv5isr69yr531.png", new DateTime(1986, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chernobyl", 1 },
                    { 17, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8275), "SYSTEM", "The story of Easy Company of the U.S. Army 101st Airborne Division and their mission in World War II Europe, from Operation Overlord to V-J Day.", "https://i.dailymail.co.uk/i/pix/2017/02/13/01/3D24EF6B00000578-4215748-image-a-63_1486948627611.jpg", new DateTime(2001, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Band of Brothers", 1 },
                    { 16, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8272), "SYSTEM", "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.", "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/ggFHVNu6YYI5L9pCfOacjizRGt.jpg", new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breaking Bad", 1 },
                    { 15, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8268), "SYSTEM", "Emmy Award-winning, 11 episodes, five years in the making, the most expensive nature documentary series ever commissioned by the BBC, and the first to be filmed in high definition.", "https://m.media-amazon.com/images/I/91X9p6+58KL._SY445_.jpg", new DateTime(2010, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planet Earth", 1 },
                    { 14, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8265), "SYSTEM", "Wildlife documentary series with David Attenborough, beginning with a look at the remote islands which offer sanctuary to some of the planet's rarest creatures, to the beauty of cities, which are home to humans, and animals..", "https://blackwells.co.uk/jacket/l/9781785943041.jpg", new DateTime(2016, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planet Earth II", 1 },
                    { 13, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8262), "SYSTEM", "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg", new DateTime(2010, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception", 0 },
                    { 12, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8259), "SYSTEM", "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.", "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg", new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump", 0 },
                    { 106, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8648), "SYSTEM", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight 76", 0 },
                    { 10, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8252), "SYSTEM", "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", "https://images.moviesanywhere.com/198e228b071c60f5ad57e5f62fe60029/ff22cad6-2218-414d-b853-3f95d76905c7.jpg?h=375&resize=fit&w=250", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Fellowship of the Ring", 0 },
                    { 9, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8248), "SYSTEM", "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.", "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg", new DateTime(1996, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Good, the Bad and the Ugly", 0 },
                    { 8, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8244), "SYSTEM", "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png", new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction", 0 },
                    { 7, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8241), "SYSTEM", "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", "https://img.discogs.com/MsgjJVAxVCXb1w86ffIbaNRr2BY=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-728620-1512923411-4779.jpeg.jpg", new DateTime(2003, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Return of the King", 0 },
                    { 6, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8238), "SYSTEM", "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/c617e634647543.56d846b10d56f.jpg", new DateTime(1994, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schindler's List", 0 },
                    { 5, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8229), "SYSTEM", "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", "https://upload.wikimedia.org/wikipedia/commons/b/b5/12_Angry_Men_%281957_film_poster%29.jpg", new DateTime(1957, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Angry Men", 0 },
                    { 4, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8225), "SYSTEM", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight", 0 },
                    { 3, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8221), "SYSTEM", "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.", "https://shotonwhat.com/images/0071562-med.jpg", new DateTime(1974, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather: Part II", 0 },
                    { 2, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8206), "SYSTEM", "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.", "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg", new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather", 0 },
                    { 1, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(6621), "SYSTEM", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop", new DateTime(1994, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption", 0 },
                    { 24, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8337), "SYSTEM", "Astronomer Carl Sagan leads us on an engaging guided tour of the various elements and cosmological theories of the universe.", "https://www.themoviedb.org/t/p/original/4WJ9kNejI8apl3f8hMNwo8V3hGT.jpg", new DateTime(1980, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cosmos", 1 },
                    { 25, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8340), "SYSTEM", "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.", "https://m.media-amazon.com/images/M/MV5BYTRiNDQwYzAtMzVlZS00NTI5LWJjYjUtMzkwNTUzMWMxZTllXkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_FMjpg_UX1000_.jpg", new DateTime(2011, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Game of Thrones", 1 },
                    { 26, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8343), "SYSTEM", "New Jersey mob boss Tony Soprano deals with personal and professional issues in his home and business life that affect his mental state, leading him to seek professional psychiatric counseling.", "https://m.media-amazon.com/images/M/MV5BZGJjYzhjYTYtMDBjYy00OWU1LTg5OTYtNmYwOTZmZjE3ZDdhXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_FMjpg_UX1000_.jpg", new DateTime(1999, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sopranos", 1 },
                    { 27, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8347), "SYSTEM", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop", new DateTime(1994, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption 2", 0 },
                    { 51, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8445), "SYSTEM", "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.", "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg", new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump 3", 0 },
                    { 50, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8442), "SYSTEM", "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", "https://m.media-amazon.com/images/I/51v5ZpFyaFL._AC_.jpg", new DateTime(1999, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club 3", 0 }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Description", "ImageUrl", "ReleaseDate", "Title", "Type" },
                values: new object[,]
                {
                    { 49, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8439), "SYSTEM", "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", "https://images.moviesanywhere.com/198e228b071c60f5ad57e5f62fe60029/ff22cad6-2218-414d-b853-3f95d76905c7.jpg?h=375&resize=fit&w=250", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Fellowship of the Ring 3", 0 },
                    { 48, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8435), "SYSTEM", "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.", "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg", new DateTime(1996, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Good, the Bad and the Ugly 3", 0 },
                    { 47, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8432), "SYSTEM", "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png", new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction 3", 0 },
                    { 46, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8409), "SYSTEM", "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", "https://img.discogs.com/MsgjJVAxVCXb1w86ffIbaNRr2BY=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-728620-1512923411-4779.jpeg.jpg", new DateTime(2003, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Return of the King 3", 0 },
                    { 45, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8405), "SYSTEM", "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/c617e634647543.56d846b10d56f.jpg", new DateTime(1994, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schindler's List 3", 0 },
                    { 44, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8402), "SYSTEM", "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", "https://upload.wikimedia.org/wikipedia/commons/b/b5/12_Angry_Men_%281957_film_poster%29.jpg", new DateTime(1957, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Angry Men 3", 0 },
                    { 43, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8399), "SYSTEM", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight 3", 0 },
                    { 42, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8396), "SYSTEM", "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.", "https://shotonwhat.com/images/0071562-med.jpg", new DateTime(1974, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather: Part II 3", 0 },
                    { 41, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8393), "SYSTEM", "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.", "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg", new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather 3", 0 },
                    { 53, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8452), "SYSTEM", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop", new DateTime(1994, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption 4", 0 },
                    { 40, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8390), "SYSTEM", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop", new DateTime(1994, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption 3", 0 },
                    { 38, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8383), "SYSTEM", "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.", "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg", new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump 2", 0 },
                    { 37, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8380), "SYSTEM", "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", "https://m.media-amazon.com/images/I/51v5ZpFyaFL._AC_.jpg", new DateTime(1999, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club 2", 0 },
                    { 36, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8377), "SYSTEM", "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", "https://images.moviesanywhere.com/198e228b071c60f5ad57e5f62fe60029/ff22cad6-2218-414d-b853-3f95d76905c7.jpg?h=375&resize=fit&w=250", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Fellowship of the Ring 2", 0 },
                    { 35, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8374), "SYSTEM", "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.", "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg", new DateTime(1996, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Good, the Bad and the Ugly 2", 0 },
                    { 34, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8370), "SYSTEM", "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png", new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction 2", 0 },
                    { 33, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8366), "SYSTEM", "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", "https://img.discogs.com/MsgjJVAxVCXb1w86ffIbaNRr2BY=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-728620-1512923411-4779.jpeg.jpg", new DateTime(2003, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Return of the King 2", 0 },
                    { 32, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8362), "SYSTEM", "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/c617e634647543.56d846b10d56f.jpg", new DateTime(1994, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schindler's List 2", 0 },
                    { 31, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8359), "SYSTEM", "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", "https://upload.wikimedia.org/wikipedia/commons/b/b5/12_Angry_Men_%281957_film_poster%29.jpg", new DateTime(1957, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Angry Men 2", 0 },
                    { 30, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8356), "SYSTEM", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight 2", 0 },
                    { 29, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8353), "SYSTEM", "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.", "https://shotonwhat.com/images/0071562-med.jpg", new DateTime(1974, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather: Part II 2", 0 },
                    { 28, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8350), "SYSTEM", "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.", "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg", new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather 2", 0 },
                    { 39, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 516, DateTimeKind.Local).AddTicks(8387), "SYSTEM", "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg", new DateTime(2010, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception 2", 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Email", "FirstName", "Hash", "LastName", "Salt" },
                values: new object[] { 1, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 519, DateTimeKind.Local).AddTicks(8303), "SYSTEM", "admin@gmail.com", "Admin", new byte[] { 83, 133, 199, 240, 91, 252, 175, 59, 129, 154, 137, 144, 243, 23, 88, 79, 36, 74, 112, 119, 108, 220, 214, 126, 2, 69, 245, 253, 118, 46, 182, 160, 119, 230, 34, 235, 242, 193, 170, 237, 200, 76, 55, 246, 164, 190, 104, 125, 91, 65, 239, 105, 216, 195, 137, 139, 232, 138, 18, 174, 110, 10, 226, 81 }, "Admin", new byte[] { 251, 171, 222, 41, 114, 124, 192, 29, 104, 175, 90, 65, 47, 101, 131, 214, 158, 166, 120, 158, 94, 186, 224, 193, 249, 209, 122, 3, 125, 103, 105, 125, 47, 120, 87, 244, 224, 97, 137, 129, 167, 205, 138, 217, 17, 199, 216, 97, 157, 228, 164, 213, 56, 232, 182, 42, 124, 27, 177, 128, 26, 27, 111, 15, 108, 234, 245, 109, 81, 57, 218, 9, 199, 200, 23, 19, 13, 224, 212, 73, 200, 196, 88, 12, 165, 53, 105, 181, 6, 24, 60, 54, 110, 189, 206, 213, 24, 254, 105, 0, 111, 240, 204, 231, 45, 54, 185, 217, 59, 142, 68, 121, 239, 198, 101, 88, 48, 59, 87, 80, 76, 34, 137, 28, 131, 0, 44, 69 } });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "MediaId", "UserId", "Value" },
                values: new object[,]
                {
                    { 2, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6422), "SYSTEM", 2, 1, 4.5f },
                    { 32, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6611), "SYSTEM", 32, 1, 4.4f },
                    { 33, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6614), "SYSTEM", 33, 1, 4.3f },
                    { 34, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6618), "SYSTEM", 34, 1, 4.2f },
                    { 35, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6621), "SYSTEM", 35, 1, 4.1f },
                    { 36, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6623), "SYSTEM", 36, 1, 4.1f },
                    { 37, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6626), "SYSTEM", 37, 1, 4.1f },
                    { 38, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6629), "SYSTEM", 38, 1, 4f },
                    { 39, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6631), "SYSTEM", 39, 1, 3.9f },
                    { 40, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6633), "SYSTEM", 40, 1, 4.7f },
                    { 41, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6636), "SYSTEM", 41, 1, 4.6f },
                    { 42, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6638), "SYSTEM", 42, 1, 4.6f },
                    { 43, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6641), "SYSTEM", 43, 1, 4.6f },
                    { 44, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6643), "SYSTEM", 44, 1, 4.5f },
                    { 45, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6645), "SYSTEM", 45, 1, 4.4f },
                    { 46, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6648), "SYSTEM", 46, 1, 4.3f },
                    { 47, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6650), "SYSTEM", 47, 1, 4.2f },
                    { 48, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6653), "SYSTEM", 48, 1, 4.1f },
                    { 49, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6655), "SYSTEM", 49, 1, 4.1f },
                    { 50, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6657), "SYSTEM", 50, 1, 4.1f },
                    { 51, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6660), "SYSTEM", 51, 1, 4f },
                    { 52, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6662), "SYSTEM", 52, 1, 3.9f },
                    { 53, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6665), "SYSTEM", 53, 1, 4.7f },
                    { 54, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6667), "SYSTEM", 54, 1, 4.6f },
                    { 31, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6609), "SYSTEM", 31, 1, 4.5f },
                    { 55, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6670), "SYSTEM", 55, 1, 4.6f },
                    { 30, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6607), "SYSTEM", 30, 1, 4.6f },
                    { 28, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6602), "SYSTEM", 28, 1, 4.6f },
                    { 5, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6452), "SYSTEM", 5, 1, 4.4f },
                    { 6, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6465), "SYSTEM", 6, 1, 4.35f },
                    { 7, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6468), "SYSTEM", 7, 1, 4.3f },
                    { 8, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6471), "SYSTEM", 8, 1, 4.2f },
                    { 9, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6473), "SYSTEM", 9, 1, 4.2f },
                    { 10, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6477), "SYSTEM", 10, 1, 4.2f },
                    { 11, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6479), "SYSTEM", 11, 1, 4.2f },
                    { 12, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6482), "SYSTEM", 12, 1, 4.1f },
                    { 13, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6484), "SYSTEM", 13, 1, 4.1f },
                    { 14, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6487), "SYSTEM", 14, 1, 4.7f },
                    { 15, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6489), "SYSTEM", 15, 1, 4.6f },
                    { 16, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6492), "SYSTEM", 16, 1, 4.6f },
                    { 17, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6494), "SYSTEM", 17, 1, 4.6f },
                    { 18, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6498), "SYSTEM", 18, 1, 4.5f }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "MediaId", "UserId", "Value" },
                values: new object[,]
                {
                    { 19, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6500), "SYSTEM", 19, 1, 4.4f },
                    { 20, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6503), "SYSTEM", 20, 1, 4.3f },
                    { 21, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6547), "SYSTEM", 21, 1, 4.2f },
                    { 22, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6550), "SYSTEM", 22, 1, 4.1f },
                    { 23, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6552), "SYSTEM", 23, 1, 4.1f },
                    { 24, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6592), "SYSTEM", 24, 1, 4.1f },
                    { 25, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6594), "SYSTEM", 25, 1, 4f },
                    { 26, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6597), "SYSTEM", 26, 1, 3.9f },
                    { 27, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6599), "SYSTEM", 27, 1, 4.7f },
                    { 29, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6604), "SYSTEM", 29, 1, 4.6f },
                    { 4, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6443), "SYSTEM", 4, 1, 4.5f },
                    { 56, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6672), "SYSTEM", 56, 1, 4.6f },
                    { 58, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6677), "SYSTEM", 58, 1, 4.4f },
                    { 86, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6746), "SYSTEM", 86, 1, 4.2f },
                    { 87, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6748), "SYSTEM", 87, 1, 4.1f },
                    { 88, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6751), "SYSTEM", 88, 1, 4.1f },
                    { 89, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6753), "SYSTEM", 89, 1, 4.1f },
                    { 90, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6756), "SYSTEM", 90, 1, 4f },
                    { 91, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6758), "SYSTEM", 91, 1, 3.9f },
                    { 92, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6760), "SYSTEM", 92, 1, 4.7f },
                    { 93, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6763), "SYSTEM", 93, 1, 4.6f },
                    { 94, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6765), "SYSTEM", 94, 1, 4.6f },
                    { 95, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6767), "SYSTEM", 95, 1, 4.6f },
                    { 96, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6770), "SYSTEM", 96, 1, 4.5f },
                    { 97, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6772), "SYSTEM", 97, 1, 4.4f },
                    { 98, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6774), "SYSTEM", 98, 1, 4.3f },
                    { 99, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6777), "SYSTEM", 99, 1, 4.2f },
                    { 100, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6779), "SYSTEM", 100, 1, 4.1f },
                    { 101, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6782), "SYSTEM", 100, 1, 5f },
                    { 102, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6784), "SYSTEM", 100, 1, 5f },
                    { 103, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6786), "SYSTEM", 100, 1, 5f },
                    { 104, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6789), "SYSTEM", 10, 1, 5f },
                    { 105, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6791), "SYSTEM", 67, 1, 5f },
                    { 106, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6794), "SYSTEM", 67, 1, 5f },
                    { 107, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6796), "SYSTEM", 44, 1, 5f },
                    { 108, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6799), "SYSTEM", 17, 1, 5f },
                    { 85, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6743), "SYSTEM", 85, 1, 4.3f },
                    { 57, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6674), "SYSTEM", 57, 1, 4.5f },
                    { 84, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6741), "SYSTEM", 84, 1, 4.4f },
                    { 82, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6736), "SYSTEM", 82, 1, 4.6f },
                    { 59, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6679), "SYSTEM", 59, 1, 4.3f },
                    { 60, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6682), "SYSTEM", 60, 1, 4.2f }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "MediaId", "UserId", "Value" },
                values: new object[,]
                {
                    { 61, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6684), "SYSTEM", 61, 1, 4.1f },
                    { 62, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6687), "SYSTEM", 62, 1, 4.1f },
                    { 63, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6689), "SYSTEM", 63, 1, 4.1f },
                    { 64, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6691), "SYSTEM", 64, 1, 4f },
                    { 65, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6694), "SYSTEM", 65, 1, 3.9f },
                    { 66, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6697), "SYSTEM", 66, 1, 4.7f },
                    { 67, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6700), "SYSTEM", 67, 1, 4.6f },
                    { 68, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6703), "SYSTEM", 68, 1, 4.6f },
                    { 69, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6705), "SYSTEM", 69, 1, 4.6f },
                    { 70, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6707), "SYSTEM", 70, 1, 4.5f },
                    { 71, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6710), "SYSTEM", 71, 1, 4.4f },
                    { 72, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6712), "SYSTEM", 72, 1, 4.3f },
                    { 73, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6715), "SYSTEM", 73, 1, 4.2f },
                    { 74, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6717), "SYSTEM", 74, 1, 4.1f },
                    { 75, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6719), "SYSTEM", 75, 1, 4.1f },
                    { 76, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6722), "SYSTEM", 76, 1, 4.1f },
                    { 77, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6724), "SYSTEM", 77, 1, 4f },
                    { 78, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6726), "SYSTEM", 78, 1, 3.9f },
                    { 79, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6729), "SYSTEM", 79, 1, 4.7f },
                    { 80, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6731), "SYSTEM", 80, 1, 4.6f },
                    { 81, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6734), "SYSTEM", 81, 1, 4.6f },
                    { 83, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6739), "SYSTEM", 83, 1, 4.5f },
                    { 3, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6440), "SYSTEM", 3, 1, 4.5f },
                    { 110, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6804), "SYSTEM", 7, 1, 5f },
                    { 1, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(4909), "SYSTEM", 1, 1, 4.6f },
                    { 109, null, null, new DateTime(2021, 9, 20, 16, 15, 24, 522, DateTimeKind.Local).AddTicks(6801), "SYSTEM", 17, 1, 5f }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "AvailableTickets", "CreatedAt", "CreatedBy", "Duration", "MediaId", "Name", "ScreeningDate", "SoldTickets" },
                values: new object[,]
                {
                    { 3, null, null, 13, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1038), "SYSTEM", 100, 3, "Screening 3", new DateTime(2021, 9, 30, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1041), 5 },
                    { 31, null, null, 10, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1223), "SYSTEM", 40, 31, "Screening 31", new DateTime(2021, 10, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1225), 2 },
                    { 32, null, null, 19, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1228), "SYSTEM", 50, 32, "Screening 32", new DateTime(2021, 10, 19, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1230), 2 },
                    { 33, null, null, 102, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1232), "SYSTEM", 310, 33, "Screening 33", new DateTime(2021, 9, 21, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1235), 2 },
                    { 34, null, null, 4, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1239), "SYSTEM", 200, 34, "Screening 34", new DateTime(2021, 10, 11, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1241), 4 },
                    { 35, null, null, 10, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1244), "SYSTEM", 210, 35, "Screening 35", new DateTime(2010, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, null, null, 22, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1247), "SYSTEM", 220, 36, "Screening 36", new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 37, null, null, 11, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1250), "SYSTEM", 300, 37, "Screening 37", new DateTime(2021, 10, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1252), 7 },
                    { 38, null, null, 12, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1254), "SYSTEM", 200, 38, "Screening 38", new DateTime(2021, 10, 10, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1257), 6 },
                    { 39, null, null, 13, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1259), "SYSTEM", 100, 39, "Screening 39", new DateTime(2021, 9, 30, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1261), 5 },
                    { 40, null, null, 14, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1264), "SYSTEM", 400, 40, "Screening 40", new DateTime(2021, 9, 25, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1266), 4 },
                    { 30, null, null, 16, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1219), "SYSTEM", 320, 30, "Screening 30", new DateTime(2015, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, null, null, 15, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1269), "SYSTEM", 500, 41, "Screening 41", new DateTime(2021, 9, 21, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1271), 3 },
                    { 43, null, null, 10, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1276), "SYSTEM", 40, 43, "Screening 43", new DateTime(2021, 10, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1278), 2 },
                    { 44, null, null, 19, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1281), "SYSTEM", 50, 44, "Screening 44", new DateTime(2021, 10, 19, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1283), 2 },
                    { 45, null, null, 102, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1286), "SYSTEM", 310, 45, "Screening 45", new DateTime(2021, 9, 21, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1288), 2 }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "AvailableTickets", "CreatedAt", "CreatedBy", "Duration", "MediaId", "Name", "ScreeningDate", "SoldTickets" },
                values: new object[,]
                {
                    { 46, null, null, 4, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1290), "SYSTEM", 200, 46, "Screening 46", new DateTime(2021, 10, 11, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1293), 4 },
                    { 47, null, null, 10, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1295), "SYSTEM", 210, 47, "Screening 47", new DateTime(2010, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, null, null, 22, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1298), "SYSTEM", 220, 48, "Screening 48", new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 49, null, null, 11, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1301), "SYSTEM", 300, 49, "Screening 49", new DateTime(2021, 10, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1303), 7 },
                    { 50, null, null, 12, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1305), "SYSTEM", 200, 50, "Screening 50", new DateTime(2021, 10, 10, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1308), 6 },
                    { 51, null, null, 13, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1310), "SYSTEM", 100, 51, "Screening 51", new DateTime(2021, 9, 30, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1313), 5 },
                    { 52, null, null, 14, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1315), "SYSTEM", 400, 52, "Screening 52", new DateTime(2021, 9, 25, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1317), 4 },
                    { 42, null, null, 16, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1274), "SYSTEM", 320, 42, "Screening 42", new DateTime(2015, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, null, null, 15, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1215), "SYSTEM", 500, 29, "Screening 29", new DateTime(2021, 9, 21, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1217), 3 },
                    { 28, null, null, 14, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1210), "SYSTEM", 400, 28, "Screening 28", new DateTime(2021, 9, 25, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1212), 4 },
                    { 53, null, null, 15, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1320), "SYSTEM", 500, 53, "Screening 53", new DateTime(2021, 9, 21, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1322), 3 },
                    { 4, null, null, 14, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1044), "SYSTEM", 400, 4, "Screening 4", new DateTime(2021, 9, 25, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1046), 4 },
                    { 5, null, null, 15, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1049), "SYSTEM", 500, 5, "Screening 5", new DateTime(2021, 9, 21, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1051), 3 },
                    { 6, null, null, 16, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1111), "SYSTEM", 320, 6, "Screening 6", new DateTime(2015, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, null, null, 10, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1115), "SYSTEM", 40, 7, "Screening 7", new DateTime(2021, 10, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1117), 2 },
                    { 8, null, null, 19, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1120), "SYSTEM", 50, 8, "Screening 8", new DateTime(2021, 10, 19, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1122), 2 },
                    { 9, null, null, 102, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1125), "SYSTEM", 310, 9, "Screening 9", new DateTime(2021, 9, 21, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1127), 2 },
                    { 10, null, null, 4, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1131), "SYSTEM", 200, 10, "Screening 10", new DateTime(2021, 10, 11, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1134), 4 },
                    { 11, null, null, 10, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1136), "SYSTEM", 210, 11, "Screening 11", new DateTime(2010, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, null, null, 22, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1139), "SYSTEM", 220, 12, "Screening 12", new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 13, null, null, 11, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1142), "SYSTEM", 300, 13, "Screening 13", new DateTime(2021, 10, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1144), 7 },
                    { 14, null, null, 12, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1147), "SYSTEM", 200, 14, "Screening 14", new DateTime(2021, 10, 10, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1149), 6 },
                    { 15, null, null, 13, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1152), "SYSTEM", 100, 15, "Screening 15", new DateTime(2021, 9, 30, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1154), 5 },
                    { 16, null, null, 14, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1157), "SYSTEM", 400, 16, "Screening 16", new DateTime(2021, 9, 25, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1159), 4 },
                    { 17, null, null, 15, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1162), "SYSTEM", 500, 17, "Screening 17", new DateTime(2021, 9, 21, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1164), 3 },
                    { 18, null, null, 16, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1167), "SYSTEM", 320, 18, "Screening 18", new DateTime(2015, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, null, null, 10, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1170), "SYSTEM", 40, 19, "Screening 19", new DateTime(2021, 10, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1173), 2 },
                    { 20, null, null, 19, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1175), "SYSTEM", 50, 20, "Screening 20", new DateTime(2021, 10, 19, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1177), 2 },
                    { 21, null, null, 102, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1180), "SYSTEM", 310, 21, "Screening 21", new DateTime(2021, 9, 21, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1182), 2 },
                    { 22, null, null, 4, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1185), "SYSTEM", 200, 22, "Screening 22", new DateTime(2021, 10, 11, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1187), 4 },
                    { 23, null, null, 10, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1190), "SYSTEM", 210, 23, "Screening 23", new DateTime(2010, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, null, null, 22, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1192), "SYSTEM", 220, 24, "Screening 24", new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 25, null, null, 11, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1195), "SYSTEM", 300, 25, "Screening 25", new DateTime(2021, 10, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1197), 7 },
                    { 26, null, null, 12, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1200), "SYSTEM", 200, 26, "Screening 26", new DateTime(2021, 10, 10, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1202), 6 },
                    { 2, null, null, 12, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1023), "SYSTEM", 200, 2, "Screening 2", new DateTime(2021, 10, 10, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1034), 6 },
                    { 27, null, null, 13, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1205), "SYSTEM", 100, 27, "Screening 27", new DateTime(2021, 9, 30, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1207), 5 },
                    { 54, null, null, 16, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1324), "SYSTEM", 320, 54, "Screening 54", new DateTime(2015, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 56, null, null, 19, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1332), "SYSTEM", 50, 56, "Screening 56", new DateTime(2021, 10, 19, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1334), 2 },
                    { 84, null, null, 22, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1478), "SYSTEM", 220, 84, "Screening 84", new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 85, null, null, 11, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1480), "SYSTEM", 300, 85, "Screening 85", new DateTime(2021, 10, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1483), 7 },
                    { 86, null, null, 12, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1485), "SYSTEM", 200, 86, "Screening 86", new DateTime(2021, 10, 10, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1487), 6 },
                    { 87, null, null, 13, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1490), "SYSTEM", 100, 87, "Screening 87", new DateTime(2021, 9, 30, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1492), 5 }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "AvailableTickets", "CreatedAt", "CreatedBy", "Duration", "MediaId", "Name", "ScreeningDate", "SoldTickets" },
                values: new object[,]
                {
                    { 88, null, null, 14, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1495), "SYSTEM", 400, 88, "Screening 88", new DateTime(2021, 9, 25, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1497), 4 },
                    { 89, null, null, 15, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1500), "SYSTEM", 500, 89, "Screening 89", new DateTime(2021, 9, 21, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1502), 3 },
                    { 90, null, null, 16, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1505), "SYSTEM", 320, 90, "Screening 90", new DateTime(2015, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 91, null, null, 10, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1508), "SYSTEM", 40, 91, "Screening 91", new DateTime(2021, 10, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1510), 2 },
                    { 92, null, null, 19, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1512), "SYSTEM", 50, 92, "Screening 92", new DateTime(2021, 10, 19, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1514), 2 },
                    { 93, null, null, 102, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1517), "SYSTEM", 310, 93, "Screening 93", new DateTime(2021, 9, 21, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1519), 2 },
                    { 94, null, null, 4, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1522), "SYSTEM", 200, 94, "Screening 94", new DateTime(2021, 10, 11, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1524), 4 },
                    { 95, null, null, 10, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1526), "SYSTEM", 210, 95, "Screening 95", new DateTime(2010, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 96, null, null, 22, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1529), "SYSTEM", 220, 96, "Screening 96", new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 97, null, null, 102, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1532), "SYSTEM", 310, 97, "Screening 97", new DateTime(2021, 9, 21, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1534), 2 },
                    { 98, null, null, 4, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1537), "SYSTEM", 200, 98, "Screening 98", new DateTime(2021, 10, 11, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1539), 4 },
                    { 99, null, null, 10, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1541), "SYSTEM", 210, 99, "Screening 99", new DateTime(2010, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 100, null, null, 22, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1544), "SYSTEM", 220, 100, "Screening 100", new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 101, null, null, 22, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1547), "SYSTEM", 220, 100, "Screening 101", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 102, null, null, 22, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1551), "SYSTEM", 220, 100, "Screening 102", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 103, null, null, 22, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1554), "SYSTEM", 220, 100, "Screening 103", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 104, null, null, 22, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1556), "SYSTEM", 120, 104, "Screening 104", new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 105, null, null, 22, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1559), "SYSTEM", 100, 105, "Screening 105", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 106, null, null, 22, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1562), "SYSTEM", 90, 106, "Screening 106", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 83, null, null, 10, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1475), "SYSTEM", 210, 83, "Screening 83", new DateTime(2010, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 55, null, null, 10, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1327), "SYSTEM", 40, 55, "Screening 55", new DateTime(2021, 10, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1329), 2 },
                    { 82, null, null, 4, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1470), "SYSTEM", 200, 82, "Screening 82", new DateTime(2021, 10, 11, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1472), 4 },
                    { 80, null, null, 19, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1460), "SYSTEM", 50, 80, "Screening 80", new DateTime(2021, 10, 19, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1463), 2 },
                    { 57, null, null, 102, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1337), "SYSTEM", 310, 57, "Screening 57", new DateTime(2021, 9, 21, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1339), 2 },
                    { 58, null, null, 4, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1341), "SYSTEM", 200, 58, "Screening 58", new DateTime(2021, 10, 11, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1344), 4 },
                    { 59, null, null, 10, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1366), "SYSTEM", 210, 59, "Screening 59", new DateTime(2010, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 60, null, null, 22, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1369), "SYSTEM", 220, 60, "Screening 60", new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 61, null, null, 11, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1372), "SYSTEM", 300, 61, "Screening 61", new DateTime(2021, 10, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1374), 7 },
                    { 62, null, null, 12, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1376), "SYSTEM", 200, 62, "Screening 62", new DateTime(2021, 10, 10, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1379), 6 },
                    { 63, null, null, 13, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1381), "SYSTEM", 100, 63, "Screening 63", new DateTime(2021, 9, 30, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1384), 5 },
                    { 64, null, null, 14, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1386), "SYSTEM", 400, 64, "Screening 64", new DateTime(2021, 9, 25, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1388), 4 },
                    { 65, null, null, 15, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1391), "SYSTEM", 500, 65, "Screening 65", new DateTime(2021, 9, 21, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1393), 3 },
                    { 66, null, null, 16, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1397), "SYSTEM", 320, 66, "Screening 66", new DateTime(2015, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 67, null, null, 10, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1400), "SYSTEM", 40, 67, "Screening 67", new DateTime(2021, 10, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1402), 2 },
                    { 68, null, null, 19, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1405), "SYSTEM", 50, 68, "Screening 68", new DateTime(2021, 10, 19, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1407), 2 },
                    { 69, null, null, 102, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1409), "SYSTEM", 310, 69, "Screening 69", new DateTime(2021, 9, 21, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1412), 2 },
                    { 70, null, null, 4, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1414), "SYSTEM", 200, 70, "Screening 70", new DateTime(2021, 10, 11, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1417), 4 },
                    { 71, null, null, 10, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1419), "SYSTEM", 210, 71, "Screening 71", new DateTime(2010, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 72, null, null, 22, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1426), "SYSTEM", 220, 72, "Screening 72", new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 73, null, null, 11, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1429), "SYSTEM", 300, 73, "Screening 73", new DateTime(2021, 10, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1431), 7 },
                    { 74, null, null, 12, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1434), "SYSTEM", 200, 74, "Screening 74", new DateTime(2021, 10, 10, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1436), 6 },
                    { 75, null, null, 13, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1438), "SYSTEM", 100, 75, "Screening 75", new DateTime(2021, 9, 30, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1441), 5 }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "AvailableTickets", "CreatedAt", "CreatedBy", "Duration", "MediaId", "Name", "ScreeningDate", "SoldTickets" },
                values: new object[,]
                {
                    { 76, null, null, 14, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1443), "SYSTEM", 400, 76, "Screening 76", new DateTime(2021, 9, 25, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1445), 4 },
                    { 77, null, null, 15, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1448), "SYSTEM", 500, 77, "Screening 77", new DateTime(2021, 9, 21, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1450), 3 },
                    { 78, null, null, 16, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1453), "SYSTEM", 320, 78, "Screening 78", new DateTime(2015, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 79, null, null, 10, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1456), "SYSTEM", 40, 79, "Screening 79", new DateTime(2021, 10, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1458), 2 },
                    { 81, null, null, 102, new DateTime(2021, 9, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1465), "SYSTEM", 310, 81, "Screening 81", new DateTime(2021, 9, 21, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(1467), 2 },
                    { 1, null, null, 11, new DateTime(2021, 9, 20, 16, 15, 24, 526, DateTimeKind.Local).AddTicks(9281), "SYSTEM", 300, 1, "Screening 1", new DateTime(2021, 10, 20, 16, 15, 24, 527, DateTimeKind.Local).AddTicks(513), 7 }
                });

            migrationBuilder.InsertData(
                table: "ActorMedia",
                columns: new[] { "ActorsId", "MediasId" },
                values: new object[,]
                {
                { 1, 1 },
                { 2, 1 },
                { 3, 1 },
                { 4, 2 },
                { 5, 2 },
                { 6, 2 },
                { 5, 3 },
                { 7, 3 },
                { 8, 3 },
                { 9, 4 },
                { 10, 4 },
                { 11, 4 },
                { 12, 5 },
                { 13, 5 },
                { 14, 5 },
                { 15, 6 },
                { 16, 6 },
                { 17, 6 },
                { 18, 7 },
                { 19, 7 },
                { 20, 7 },
                { 21, 8 },
                { 22, 8 },
                { 23, 8 },
                { 24, 9 },
                { 25, 9 },
                { 26, 9 },
                { 18, 10 },
                { 20, 10 },
                { 27, 10 },
                { 28, 11 },
                { 29, 11 },
                { 30, 11 },
                { 31, 12 },
                { 32, 12 },
                { 33, 12 },
                { 34, 13 },
                { 35, 13 },
                { 36, 13 },
                { 37, 14 },
                { 37, 15 },
                { 38, 15 },
                { 39, 15 },
                { 40, 16 },
                { 41, 16 },
                { 42, 16 },
                { 43, 17 },
                { 44, 17 },
                { 45, 17 },
                { 46, 18 },
                { 47, 18 },
                { 48, 18 },
                { 50, 19 },
                { 51, 19 },
                { 52, 19 },
                { 37, 20 },
                { 53, 20 },
                { 54, 20 },
                { 37, 21 },
                { 56, 22 },
                { 57, 22 },
                { 58, 22 },
                { 59, 23 },
                { 60, 23 },
                { 61, 23 },
                { 62, 24 },
                { 63, 24 },
                { 64, 24 },
                { 65, 25 },
                { 66, 25 },
                { 67, 25 },
                { 68, 26 },
                { 69, 26 },
                { 70, 26 },

                { 1, 27 },
                { 2, 27 },
                { 3, 27 },
                { 4, 28 },
                { 5, 28 },
                { 6, 28 },
                { 5, 29 },
                { 7, 29 },
                { 8, 29 },
                { 9, 30 },
                { 10, 30 },
                { 11, 30 },
                { 12, 31 },
                { 13, 31 },
                { 14, 31 },
                { 15, 32 },
                { 16, 32 },
                { 17, 32 },
                { 18, 33 },
                { 19, 34 },
                { 20, 35 },
                { 21, 36 },
                { 22, 36 },
                { 23, 36 },
                { 24, 37 },
                { 25, 37 },
                { 26, 37 },
                { 18, 38 },
                { 20, 39 },
                { 27, 39 },
                { 28, 40 },
                { 29, 40 },
                { 30, 40 },
                { 31, 41 },
                { 32, 41 },
                { 33, 41 },
                { 34, 42 },
                { 35, 42 },
                { 36, 42 },
                { 37, 43 },
                { 37, 44 },
                { 38, 44 },
                { 39, 44 },
                { 40, 45 },
                { 41, 45 },
                { 42, 45 },
                { 43, 46 },
                { 44, 46 },
                { 45, 46 },
                { 46, 47 },
                { 47, 47 },
                { 48, 47 },
                { 50, 48 },
                { 51, 48 },
                { 52, 48 },
                { 37, 49 },
                { 53, 49 },
                { 54, 49 },
                { 37, 50 },
                { 56, 51 },
                { 57, 51 },
                { 58, 51 },
                { 59, 52 },
                { 60, 52 },
                { 61, 52 },
                { 62, 53 },
                { 63, 53 },
                { 64, 53 },
                { 65, 54 },
                { 66, 54 },
                { 67, 54 },
                { 68, 55 },
                { 69, 55 },
                { 70, 55 },

                { 1, 56 },
                { 2, 56 },
                { 3, 56 },
                { 4, 57 },
                { 5, 57 },
                { 6, 57 },
                { 5, 58 },
                { 7, 58 },
                { 8, 58 },
                { 9, 59 },
                { 10, 59 },
                { 11, 59 },
                { 12, 60 },
                { 13, 60 },
                { 14, 60 },
                { 15, 61 },
                { 16, 61 },
                { 17, 61 },
                { 18, 62 },
                { 19, 62 },
                { 20, 62 },
                { 21, 63 },
                { 22, 63 },
                { 23, 63 },
                { 24, 64 },
                { 25, 64 },
                { 26, 64 },
                { 18, 65 },
                { 20, 65 },
                { 27, 65 },
                { 28, 66 },
                { 29, 66 },
                { 30, 66 },
                { 31, 67 },
                { 32, 67 },
                { 33, 67 },
                { 34, 68 },
                { 35, 68 },
                { 36, 68 },
                { 37, 69 },
                { 37, 70 },
                { 38, 71 },
                { 39, 71 },
                { 40, 72 },
                { 41, 72 },
                { 42, 72 },
                { 43, 73 },
                { 44, 73 },
                { 45, 74 },
                { 46, 75 },
                { 47, 75 },
                { 48, 75 },
                { 50, 76 },
                { 51, 76 },
                { 52, 76 },
                { 37, 77 },
                { 53, 77 },
                { 54, 77 },
                { 37, 78 },
                { 56, 79 },
                { 57, 80 },
                { 58, 81 },
                { 59, 82 },
                { 60, 82 },
                { 61, 82 },
                { 62, 83 },
                { 63, 83 },
                { 64, 84 },
                { 65, 85 },
                { 66, 85 },
                { 67, 86 },
                { 68, 87 },
                { 69, 87 },
                { 70, 88 },

                { 1, 89 },
                { 2, 89 },
                { 3, 89 },
                { 4, 90 },
                { 5, 91 },
                { 6, 92 },
                { 5, 92 },
                { 7, 93 },
                { 8, 94 },
                { 9, 94 },
                { 10, 94 },
                { 11, 95 },
                { 12, 95 },
                { 13, 95 },
                { 14, 95 },
                { 15, 96 },
                { 16, 96 },
                { 17, 96 },
                { 18, 97 },
                { 19, 97 },
                { 20, 97 },
                { 21, 98 },
                { 22, 98 },
                { 23, 89 },
                { 24, 99 },
                { 25, 99 },
                { 26, 99 },
                { 18, 100 },
                { 20, 100 },
                { 27, 100 }
            });

            migrationBuilder.InsertData(
                table: "CategoryMedia",
                columns: new[] { "CategoriesId", "MediasId" },
                values: new object[,]
                {
                { 4,  1 },
                { 6,  2 },
                { 4,  2 },
                { 4,  3 },
                { 6,  3 },
                { 4,  4 },
                { 6,  4 },
                { 1,  4 },
                { 4,  5 },
                { 6,  5 },
                { 4,  6 },
                { 7,  6 },
                { 14,  6 },
                { 4,  7 },
                { 8,  7 },
                { 1,  7 },
                { 4,  8 },
                { 6,  8 },
                { 9,  9 },
                { 4,  10 },
                { 8,  10 },
                { 1,  10 },
                { 4,  11 },
                { 4,  12 },
                { 4,  13 },
                { 11,  13 },
                { 13,  14 },
                { 13,  15 },
                { 4,  16 },
                { 6,  16 },
                { 3,  16 },
                { 4,  17 },
                { 1,  17 },
                { 14,  17 },
                { 4,  18 },
                { 14,  18 },
                { 3,  18 },
                { 4,  19 },
                { 6,  19 },
                { 3,  19 },
                { 13,  20 },
                { 13,  21 },
                { 13,  22 },
                { 15,  23 },
                { 1,  23 },
                { 8,  23 },
                { 13,  24 },
                { 1,  25 },
                { 8,  25 },
                { 4,  25 },
                { 4,  26 },
                { 6,  26 },

                { 4,  27 },
                { 6,  28 },
                { 4,  29 },
                { 4,  30 },
                { 6,  31 },
                { 4,  32 },
                { 6,  33 },
                { 1,  34 },
                { 4,  35 },
                { 6,  36 },
                { 4,  37 },
                { 7,  38 },
                { 14, 39 },
                { 4,  40 },
                { 8,  41 },
                { 1,  42 },
                { 4,  43 },
                { 6,  44 },
                { 9,  45 },
                { 4,  46 },
                { 8,  47 },
                { 1,  48 },
                { 4,  49 },
                { 4,  50 },
                { 4,  51 },
                { 11, 52 },
                { 13, 53 },
                { 13, 54 },
                { 4,  55 },
                { 6,  56 },
                { 3,  57 },
                { 4,  58 },
                { 1,  59 },
                { 14, 60 },
                { 4,  61 },
                { 14, 62 },
                { 3,  63 },
                { 4,  64 },
                { 6,  65 },
                { 3,  66 },
                { 13, 67 },
                { 13, 68 },
                { 13, 69 },
                { 15, 70 },
                { 1,  71 },
                { 8,  72 },
                { 13, 73 },
                { 1,  74 },
                { 8,  75 },
                { 4,  76 },
                { 4,  77 },
                { 6,  78 },

                { 4,  79 },
                { 6,  80 },
                { 4,  81 },
                { 4,  82 },
                { 6,  83 },
                { 4,  84 },
                { 6,  85 },
                { 1,  86 },
                { 4,  87 },
                { 6,  88 },
                { 4,  89 },
                { 7,  90 },
                { 14, 91 },
                { 4,  92 },
                { 8,  93 },
                { 1,  94 },
                { 4,  95 },
                { 6,  96 },
                { 9,  97 },
                { 4,  98 },
                { 8,  99 },
                { 1,  100 }
            });

            string getTop10MoviesWithMostRatings = @"CREATE PROCEDURE getTop10MoviesWithMostRatings
                                                     AS
                                                     BEGIN
	                                                    SELECT TOP(10) m.Id as MovieId, m.Title as MovieName, COUNT(r.Value) AS NumberOfRatings, AVG(r.Value) AS AverageRating
	                                                    FROM medias m, ratings r
	                                                    WHERE m.Id = r.MediaId AND TYPE = 0
	                                                    GROUP BY m.Id, m.Title
	                                                    ORDER BY AVG(r.Value) DESC
                                                     END;";

            string getTop10MoviesWithMostScreenings = @"CREATE PROCEDURE getTop10MoviesWithMostScreenings
                                                        @start_date Date,
                                                        @end_date Date
                                                        AS
                                                        BEGIN
                                                            SELECT TOP(10) m.Id as MovieId, m.Title as MovieName, COUNT(s.Id) AS NumberOfScreenings
	                                                        FROM Medias m, Screenings s
	                                                        WHERE m.Id = s.MediaId AND m.TYPE = 0 
	                                                        AND @start_date <= DATEADD(MINUTE, s.Duration, s.ScreeningDate) 
	                                                        AND DATEADD(MINUTE, s.Duration, s.ScreeningDate) <= @end_date
	                                                        GROUP BY m.Id, m.Title
	                                                        ORDER BY COUNT(s.Id) DESC
                                                        END;";

            string getMoviesWithMostSoldTicketsNoRating = @"CREATE PROCEDURE getMoviesWithMostSoldTicketsNoRating
                                                            AS
                                                            BEGIN
                                                                SELECT m.Id as MovieId, m.Title as MovieName, s.Name as ScreeningName, s.SoldTickets as SoldTickets
	                                                            FROM Medias m, Screenings s
	                                                            WHERE (SELECT COUNT(*) 
		                                                               FROM Ratings r 
		                                                               WHERE r.MediaId = m.Id) = 0 
	                                                            AND m.Id = s.MediaId
	                                                            ORDER BY s.SoldTickets DESC
                                                            END;";


            migrationBuilder.Sql(getTop10MoviesWithMostRatings);
            migrationBuilder.Sql(getTop10MoviesWithMostScreenings);
            migrationBuilder.Sql(getMoviesWithMostSoldTicketsNoRating);

            migrationBuilder.CreateIndex(
                name: "IX_ActorMedia_MediasId",
                table: "ActorMedia",
                column: "MediasId");

            migrationBuilder.CreateIndex(
                name: "IX_BoughtTickets_ScreeningId",
                table: "BoughtTickets",
                column: "ScreeningId");

            migrationBuilder.CreateIndex(
                name: "IX_BoughtTickets_UserId",
                table: "BoughtTickets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryMedia_MediasId",
                table: "CategoryMedia",
                column: "MediasId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_MediaId",
                table: "Ratings",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_MediaId",
                table: "Screenings",
                column: "MediaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string getTop10MoviesWithMostRatings = @"DROP PROCEDURE getTop10MoviesWithMostRatings";
            string getTop10MoviesWithMostScreenings = @"DROP PROCEDURE getTop10MoviesWithMostScreenings";
            string getMoviesWithMostSoldTicketsNoRating = @"DROP PROCEDURE getMoviesWithMostSoldTicketsNoRating";

            migrationBuilder.Sql(getTop10MoviesWithMostRatings);
            migrationBuilder.Sql(getTop10MoviesWithMostScreenings);
            migrationBuilder.Sql(getMoviesWithMostSoldTicketsNoRating);

            migrationBuilder.DropTable(
                name: "ActorMedia");

            migrationBuilder.DropTable(
                name: "BoughtTickets");

            migrationBuilder.DropTable(
                name: "CategoryMedia");

            migrationBuilder.DropTable(
                name: "MostRatedMoviesReports");

            migrationBuilder.DropTable(
                name: "MoviesWithMostScreeningsReports");

            migrationBuilder.DropTable(
                name: "MoviesWithMostSoldTicketsReports");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Screenings");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Medias");
        }
    }
}
