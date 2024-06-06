using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNameImageId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageId",
                schema: "BasicInfo",
                table: "Image");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                schema: "BasicInfo",
                table: "Image",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
