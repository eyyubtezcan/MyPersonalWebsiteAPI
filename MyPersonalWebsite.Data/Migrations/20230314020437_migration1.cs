using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyPersonalWebsite.Data.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Config",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Config", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenericLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EncryptedPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BadLoginAttempts = table.Column<int>(type: "int", nullable: false),
                    ActivationHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerOrderNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FromAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantityUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WeightUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_MaterialInformations_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "MaterialInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "OrderStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GenericLists",
                columns: new[] { "Id", "Code", "CreatedById", "CreatedDate", "IsActive", "ModifiedById", "Name", "TypeName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "100", 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6882), true, null, "Adet", "Miktar", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6880) },
                    { 2, "101", 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6884), true, null, "Koli", "Miktar", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6883) },
                    { 3, "103", 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6887), true, null, "Paket", "Miktar", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6886) },
                    { 4, "104", 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6890), true, null, "Palet", "Miktar", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6889) },
                    { 5, "200", 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6892), true, null, "Kg", "Ağırlık", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6891) },
                    { 6, "201", 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6895), true, null, "Ton", "Ağırlık", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6894) }
                });

            migrationBuilder.InsertData(
                table: "MaterialInformations",
                columns: new[] { "Id", "Code", "CreatedById", "CreatedDate", "Description", "IsActive", "ModifiedById", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "1000000", 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6792), "", true, null, "Dell Insprion 5515 Laptop", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6790) },
                    { 2, "1000002", 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6795), "", true, null, "Apple Macbook Pro 13", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6794) },
                    { 3, "1000003", 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6798), "", true, null, "MSI 32 Curve Monitor", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6796) },
                    { 4, "1000004", 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6800), "", true, null, "Microsoft Mouse", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6799) },
                    { 5, "1000005", 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6803), "", true, null, "Windows 11 Kutulu Lisans", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6802) },
                    { 6, "1000006", 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6806), "", true, null, "100 Watt Type C Adaptör", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6804) }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "Code", "CreatedById", "CreatedDate", "Description", "IsActive", "ModifiedById", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "100", 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6706), "Sipariş Alındı", true, null, "Sipariş Alındı", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6703) },
                    { 2, "101", 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6709), "Yola Çıktı", true, null, "Yola Çıktı", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6707) },
                    { 3, "102", 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6711), "Dağıtım Merkezinde", true, null, "Dağıtım Merkezinde", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6710) },
                    { 4, "103", 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6714), "Dağıtıma Çıktı", true, null, "Dağıtıma Çıktı", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6713) },
                    { 5, "104", 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6716), "Teslim Edildi", true, null, "Teslim Edildi", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6715) },
                    { 6, "105", 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6719), "Teslim Edilemedi", true, null, "Teslim Edilemedi", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6718) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ActivationHash", "BadLoginAttempts", "CreatedById", "CreatedDate", "Email", "EncryptedPassword", "ExpireDate", "IsActive", "LastName", "ModifiedById", "Name", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, "", 0, 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6538), "eyyub.tezcan@gmail.com", "", new DateTime(2023, 4, 13, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6532), false, "", null, "System", "", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6528), "System" },
                    { 2, "", 0, 1, new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6542), "eyyub.tezcan@gmail.com", "", new DateTime(2023, 4, 13, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6541), true, "Tezcan", null, "Eyyüb", "05375140784", new DateTime(2023, 3, 14, 5, 4, 37, 59, DateTimeKind.Local).AddTicks(6540), "eyyub.tezcan@gmail.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerOrderNo",
                table: "Orders",
                column: "CustomerOrderNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_MaterialId",
                table: "Orders",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StatusId",
                table: "Orders",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Config");

            migrationBuilder.DropTable(
                name: "GenericLists");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "MaterialInformations");

            migrationBuilder.DropTable(
                name: "OrderStatuses");
        }
    }
}
