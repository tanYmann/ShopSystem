using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopSystem.Migrations
{
    public partial class cookie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salutation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseNo = table.Column<int>(type: "int", nullable: false),
                    Zip = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SavedFrom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VersionId = table.Column<int>(type: "int", nullable: true),
                    Ean = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnStock = table.Column<bool>(type: "bit", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerNo = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FK_Customers_Addresses_Id = table.Column<int>(type: "int", nullable: true),
                    Options = table.Column<int>(type: "int", nullable: false),
                    Gln = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrpStat5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Addresses_FK_Customers_Addresses_Id",
                        column: x => x.FK_Customers_Addresses_Id,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    FK_Orders_Addresses_Id = table.Column<int>(type: "int", nullable: true),
                    Project = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InvoiceAddress = table.Column<int>(type: "int", nullable: true),
                    DeliveryNoteAddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_FK_Orders_Addresses_Id",
                        column: x => x.FK_Orders_Addresses_Id,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryNoteNo = table.Column<int>(type: "int", nullable: false),
                    FK_DeliveryNotes_Customers_Id = table.Column<int>(type: "int", nullable: true),
                    FK_DeliveryNotes_Orders_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryNotes_Customers_FK_DeliveryNotes_Customers_Id",
                        column: x => x.FK_DeliveryNotes_Customers_Id,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeliveryNotes_Orders_FK_DeliveryNotes_Orders_Id",
                        column: x => x.FK_DeliveryNotes_Orders_Id,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNo = table.Column<int>(type: "int", nullable: false),
                    FK_Invoice_Orders_Id = table.Column<int>(type: "int", nullable: true),
                    FK_Invoices_Customers_Id = table.Column<int>(type: "int", nullable: true),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Customers_FK_Invoices_Customers_Id",
                        column: x => x.FK_Invoices_Customers_Id,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_Orders_FK_Invoice_Orders_Id",
                        column: x => x.FK_Invoice_Orders_Id,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    FK_Positions_Orders_Id = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FK_Positions_Items_Id = table.Column<int>(type: "int", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    VersionId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positions_Items_FK_Positions_Items_Id",
                        column: x => x.FK_Positions_Items_Id,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Positions_Orders_FK_Positions_Orders_Id",
                        column: x => x.FK_Positions_Orders_Id,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_FK_Customers_Addresses_Id",
                table: "Customers",
                column: "FK_Customers_Addresses_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryNotes_FK_DeliveryNotes_Customers_Id",
                table: "DeliveryNotes",
                column: "FK_DeliveryNotes_Customers_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryNotes_FK_DeliveryNotes_Orders_Id",
                table: "DeliveryNotes",
                column: "FK_DeliveryNotes_Orders_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_FK_Invoice_Orders_Id",
                table: "Invoices",
                column: "FK_Invoice_Orders_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_FK_Invoices_Customers_Id",
                table: "Invoices",
                column: "FK_Invoices_Customers_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FK_Orders_Addresses_Id",
                table: "Orders",
                column: "FK_Orders_Addresses_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_FK_Positions_Items_Id",
                table: "Positions",
                column: "FK_Positions_Items_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_FK_Positions_Orders_Id",
                table: "Positions",
                column: "FK_Positions_Orders_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliveryNotes");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
