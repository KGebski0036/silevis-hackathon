using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePinIdToPitchId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Pitches_PitchId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "PinId",
                table: "Events");

            migrationBuilder.AlterColumn<int>(
                name: "PitchId",
                table: "Events",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Pitches_PitchId",
                table: "Events",
                column: "PitchId",
                principalTable: "Pitches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Pitches_PitchId",
                table: "Events");

            migrationBuilder.AlterColumn<int>(
                name: "PitchId",
                table: "Events",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "PinId",
                table: "Events",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Pitches_PitchId",
                table: "Events",
                column: "PitchId",
                principalTable: "Pitches",
                principalColumn: "Id");
        }
    }
}
