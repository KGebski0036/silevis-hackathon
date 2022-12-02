using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePitches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Pitch_PitchId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Pitch_Photos_PhotoId",
                table: "Pitch");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Pitch_PitchId",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pitch",
                table: "Pitch");

            migrationBuilder.RenameTable(
                name: "Pitch",
                newName: "Pitches");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Pitches",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Pitch_PhotoId",
                table: "Pitches",
                newName: "IX_Pitches_PhotoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pitches",
                table: "Pitches",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Pitches_PitchId",
                table: "Events",
                column: "PitchId",
                principalTable: "Pitches",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pitches_Photos_PhotoId",
                table: "Pitches",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Pitches_PitchId",
                table: "Reservation",
                column: "PitchId",
                principalTable: "Pitches",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Pitches_PitchId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Pitches_Photos_PhotoId",
                table: "Pitches");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Pitches_PitchId",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pitches",
                table: "Pitches");

            migrationBuilder.RenameTable(
                name: "Pitches",
                newName: "Pitch");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Pitch",
                newName: "Adress");

            migrationBuilder.RenameIndex(
                name: "IX_Pitches_PhotoId",
                table: "Pitch",
                newName: "IX_Pitch_PhotoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pitch",
                table: "Pitch",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Pitch_PitchId",
                table: "Events",
                column: "PitchId",
                principalTable: "Pitch",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pitch_Photos_PhotoId",
                table: "Pitch",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Pitch_PitchId",
                table: "Reservation",
                column: "PitchId",
                principalTable: "Pitch",
                principalColumn: "Id");
        }
    }
}
