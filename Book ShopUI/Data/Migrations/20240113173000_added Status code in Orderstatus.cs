﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book_ShopUI.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedStatuscodeinOrderstatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "OrderStatus",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "OrderStatus");
        }
    }
}
