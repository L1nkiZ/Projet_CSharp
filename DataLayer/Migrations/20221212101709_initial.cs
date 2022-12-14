using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    gameid = table.Column<int>(name: "game_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GetCurrentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    choux = table.Column<int>(type: "int", nullable: false),
                    numdraw = table.Column<string>(name: "num_draw", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.gameid);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    playerid = table.Column<int>(name: "player_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    guidcode = table.Column<string>(name: "guid_code", type: "nvarchar(max)", nullable: true),
                    numdrawplayer = table.Column<string>(name: "num_draw_player", type: "nvarchar(max)", nullable: true),
                    score = table.Column<int>(type: "int", nullable: false),
                    gameid = table.Column<int>(name: "game_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.playerid);
                    table.ForeignKey(
                        name: "FK_Players_Games_game_id",
                        column: x => x.gameid,
                        principalTable: "Games",
                        principalColumn: "game_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_game_id",
                table: "Players",
                column: "game_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
