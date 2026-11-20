using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlantInAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePlantSpecies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PotSize",
                table: "PlantSpecies",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Soil",
                table: "PlantSpecies",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sunlight",
                table: "PlantSpecies",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Temperature",
                table: "PlantSpecies",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ToxicToCats",
                table: "PlantSpecies",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ToxicToDogs",
                table: "PlantSpecies",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ToxicToHumans",
                table: "PlantSpecies",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Toxicity",
                table: "PlantSpecies",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string[]>(
                name: "TypicalProblems",
                table: "PlantSpecies",
                type: "text[]",
                nullable: false,
                defaultValue: new string[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PotSize",
                table: "PlantSpecies");

            migrationBuilder.DropColumn(
                name: "Soil",
                table: "PlantSpecies");

            migrationBuilder.DropColumn(
                name: "Sunlight",
                table: "PlantSpecies");

            migrationBuilder.DropColumn(
                name: "Temperature",
                table: "PlantSpecies");

            migrationBuilder.DropColumn(
                name: "ToxicToCats",
                table: "PlantSpecies");

            migrationBuilder.DropColumn(
                name: "ToxicToDogs",
                table: "PlantSpecies");

            migrationBuilder.DropColumn(
                name: "ToxicToHumans",
                table: "PlantSpecies");

            migrationBuilder.DropColumn(
                name: "Toxicity",
                table: "PlantSpecies");

            migrationBuilder.DropColumn(
                name: "TypicalProblems",
                table: "PlantSpecies");
        }
    }
}
