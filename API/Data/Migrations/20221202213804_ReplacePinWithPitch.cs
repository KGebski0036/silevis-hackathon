using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReplacePinWithPitch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Pins_PinId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "Pins");

            migrationBuilder.DropIndex(
                name: "IX_Events_PinId",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "PitchId",
                table: "Events",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pitch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Adress = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CoordLat = table.Column<double>(type: "REAL", nullable: false),
                    CoordLon = table.Column<double>(type: "REAL", nullable: false),
                    MaxPlayers = table.Column<int>(type: "INTEGER", nullable: false),
                    PhotoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pitch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pitch_Photo_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    DateFrom = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateTo = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PitchId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservation_Pitch_PitchId",
                        column: x => x.PitchId,
                        principalTable: "Pitch",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_PitchId",
                table: "Events",
                column: "PitchId");

            migrationBuilder.CreateIndex(
                name: "IX_Pitch_PhotoId",
                table: "Pitch",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_PitchId",
                table: "Reservation",
                column: "PitchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Pitch_PitchId",
                table: "Events",
                column: "PitchId",
                principalTable: "Pitch",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Pitch_PitchId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Pitch");

            migrationBuilder.DropIndex(
                name: "IX_Events_PitchId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "PitchId",
                table: "Events");

            migrationBuilder.CreateTable(
                name: "Pins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CoordLat = table.Column<double>(type: "REAL", nullable: false),
                    CoordLon = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pins", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_PinId",
                table: "Events",
                column: "PinId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Pins_PinId",
                table: "Events",
                column: "PinId",
                principalTable: "Pins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
