using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPersonalWebsite.Data.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChangeLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryKeyValue = table.Column<int>(type: "int", nullable: false),
                    OldValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateChanged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeLogs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "GenericLists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5902), null });

            migrationBuilder.UpdateData(
                table: "GenericLists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5904), null });

            migrationBuilder.UpdateData(
                table: "GenericLists",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5906), null });

            migrationBuilder.UpdateData(
                table: "GenericLists",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5908), null });

            migrationBuilder.UpdateData(
                table: "GenericLists",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5910), null });

            migrationBuilder.UpdateData(
                table: "GenericLists",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5912), null });

            migrationBuilder.UpdateData(
                table: "MaterialInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5829), null });

            migrationBuilder.UpdateData(
                table: "MaterialInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5832), null });

            migrationBuilder.UpdateData(
                table: "MaterialInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5834), null });

            migrationBuilder.UpdateData(
                table: "MaterialInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5836), null });

            migrationBuilder.UpdateData(
                table: "MaterialInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5838), null });

            migrationBuilder.UpdateData(
                table: "MaterialInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5840), null });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5755), null });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5759), null });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5761), null });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5763), null });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5765), null });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5768), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExpireDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5609), new DateTime(2023, 4, 13, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5603), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ExpireDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5613), new DateTime(2023, 4, 13, 8, 37, 51, 207, DateTimeKind.Local).AddTicks(5612), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChangeLogs");

            migrationBuilder.UpdateData(
                table: "GenericLists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6882), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "GenericLists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6884), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "GenericLists",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6887), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "GenericLists",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6890), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "GenericLists",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6892), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "GenericLists",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6895), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "MaterialInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6792), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "MaterialInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6795), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "MaterialInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6798), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "MaterialInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6800), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "MaterialInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6803), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "MaterialInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6806), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6706), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6709), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6711), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6714), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6716), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6719), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExpireDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6538), new DateTime(2023, 4, 13, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6532), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ExpireDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6542), new DateTime(2023, 4, 13, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6541), new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6540) });
        }
    }
}
