using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddSeatConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypicalSeats",
                table: "Aircraft");

            migrationBuilder.CreateTable(
                name: "aircraftSeats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AircraftTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Class = table.Column<string>(type: "TEXT", nullable: false),
                    SeatCount = table.Column<int>(type: "INTEGER", nullable: false),
                    AircraftId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aircraftSeats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_aircraftSeats_Aircraft_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircraft",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_aircraftSeats_AircraftId",
                table: "aircraftSeats",
                column: "AircraftId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aircraftSeats");

            migrationBuilder.AddColumn<int>(
                name: "TypicalSeats",
                table: "Aircraft",
                type: "INTEGER",
                nullable: true);
        }
    }
}
