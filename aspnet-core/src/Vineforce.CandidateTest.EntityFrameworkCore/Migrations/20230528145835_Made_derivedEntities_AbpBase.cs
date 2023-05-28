using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vineforce.CandidateTest.Migrations
{
    /// <inheritdoc />
    public partial class Made_derivedEntities_AbpBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "States",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "States",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "States",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "States",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "States",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "States",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "States",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Countries",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Countries",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Countries",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Countries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Countries",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Countries",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "States");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "States");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "States");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "States");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "States");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "States");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "States");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Countries");
        }
    }
}
