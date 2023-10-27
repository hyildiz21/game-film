﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace game_film.DB.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoriesTableProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "GameCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActive",
                table: "GameCategories");
        }
    }
}
