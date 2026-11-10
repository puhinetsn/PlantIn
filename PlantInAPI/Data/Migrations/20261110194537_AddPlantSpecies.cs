using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlantInAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPlantSpecies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlantSpecies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuidv7()"),
                    CommonName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    LatinName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    AlternativeNames = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    Description = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantSpecies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlantSpecies_LatinName",
                table: "PlantSpecies",
                column: "LatinName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlantSpecies");
        }
    }
}
