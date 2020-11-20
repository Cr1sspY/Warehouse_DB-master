using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse_DB.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Position_ID = table.Column<int>(type: "INT", nullable: false),
                    Name = table.Column<int>(type: "INT", nullable: false),
                    Salary = table.Column<int>(type: "INT", nullable: false),
                    Duties = table.Column<int>(type: "INT", nullable: false),
                    Requests = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Position_ID);
                });

            migrationBuilder.CreateTable(
                name: "Product_Type",
                columns: table => new
                {
                    Type_ID = table.Column<int>(type: "INT", nullable: false),
                    Name = table.Column<int>(type: "INT", nullable: false),
                    Description = table.Column<int>(type: "INT", nullable: false),
                    Feature = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Type", x => x.Type_ID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Employee_ID = table.Column<int>(type: "INT", nullable: false),
                    Full_Name = table.Column<int>(type: "INT", nullable: false),
                    Age = table.Column<int>(type: "INT", nullable: false),
                    Sex = table.Column<int>(type: "INT", nullable: false),
                    Address = table.Column<int>(type: "INT", nullable: false),
                    Phone_Number = table.Column<int>(type: "INT", nullable: false),
                    Passport_Information = table.Column<int>(type: "INT", nullable: false),
                    Position_ID = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Employee_ID);
                    table.ForeignKey(
                        name: "FK_Employee_Position_Position_ID",
                        column: x => x.Position_ID,
                        principalTable: "Position",
                        principalColumn: "Position_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Product_ID = table.Column<int>(type: "INT", nullable: false),
                    Manufacturer = table.Column<int>(type: "INT", nullable: false),
                    Name = table.Column<int>(type: "INT", nullable: false),
                    Storage_Conditions = table.Column<int>(type: "INT", nullable: false),
                    Package = table.Column<int>(type: "INT", nullable: false),
                    Shelf_Life = table.Column<int>(type: "INT", nullable: false),
                    Type_ID = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Product_ID);
                    table.ForeignKey(
                        name: "FK_Product_Product_Type_Type_ID",
                        column: x => x.Type_ID,
                        principalTable: "Product_Type",
                        principalColumn: "Type_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Customer_ID = table.Column<int>(type: "INT", nullable: false),
                    Name = table.Column<int>(type: "INT", nullable: false),
                    Address = table.Column<int>(type: "INT", nullable: false),
                    Phone_Number = table.Column<int>(type: "INT", nullable: false),
                    Consumed_Product_1_ID = table.Column<int>(type: "INT", nullable: false),
                    Consumed_Product_2_ID = table.Column<int>(type: "INT", nullable: false),
                    Consumed_Product_3_ID = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Customer_ID);
                    table.ForeignKey(
                        name: "FK_Customer_Product_Consumed_Product_1_ID",
                        column: x => x.Consumed_Product_1_ID,
                        principalTable: "Product",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Product_Consumed_Product_2_ID",
                        column: x => x.Consumed_Product_2_ID,
                        principalTable: "Product",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Product_Consumed_Product_3_ID",
                        column: x => x.Consumed_Product_3_ID,
                        principalTable: "Product",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Provider",
                columns: table => new
                {
                    Provider_ID = table.Column<int>(type: "INT", nullable: false),
                    Name = table.Column<int>(type: "INT", nullable: false),
                    Address = table.Column<int>(type: "INT", nullable: false),
                    Phone_Number = table.Column<int>(type: "INT", nullable: false),
                    Supplied_Product_1_ID = table.Column<int>(type: "INT", nullable: false),
                    Supplied_Product_2_ID = table.Column<int>(type: "INT", nullable: false),
                    Supplied_Product_3_ID = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provider", x => x.Provider_ID);
                    table.ForeignKey(
                        name: "FK_Provider_Product_Supplied_Product_1_ID",
                        column: x => x.Supplied_Product_1_ID,
                        principalTable: "Product",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Provider_Product_Supplied_Product_2_ID",
                        column: x => x.Supplied_Product_2_ID,
                        principalTable: "Product",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Provider_Product_Supplied_Product_3_ID",
                        column: x => x.Supplied_Product_3_ID,
                        principalTable: "Product",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    Supply_Date = table.Column<int>(type: "INT", nullable: false),
                    Order_Date = table.Column<int>(type: "INT", nullable: false),
                    Shipment_Date = table.Column<int>(type: "INT", nullable: false),
                    Volume = table.Column<int>(type: "INT", nullable: false),
                    Price = table.Column<int>(type: "INT", nullable: false),
                    Type_of_Delivery = table.Column<int>(type: "INT", nullable: false),
                    Customer_ID = table.Column<int>(type: "INT", nullable: false),
                    Product_ID = table.Column<int>(type: "INT", nullable: false),
                    Employee_ID = table.Column<int>(type: "INT", nullable: false),
                    Provider_ID = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Warehouse_Customer_Customer_ID",
                        column: x => x.Customer_ID,
                        principalTable: "Customer",
                        principalColumn: "Customer_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Warehouse_Employee_Employee_ID",
                        column: x => x.Employee_ID,
                        principalTable: "Employee",
                        principalColumn: "Employee_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Warehouse_Product_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "Product",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Warehouse_Provider_Provider_ID",
                        column: x => x.Provider_ID,
                        principalTable: "Provider",
                        principalColumn: "Provider_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Consumed_Product_1_ID",
                table: "Customer",
                column: "Consumed_Product_1_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Consumed_Product_2_ID",
                table: "Customer",
                column: "Consumed_Product_2_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Consumed_Product_3_ID",
                table: "Customer",
                column: "Consumed_Product_3_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Position_ID",
                table: "Employee",
                column: "Position_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Type_ID",
                table: "Product",
                column: "Type_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Provider_Supplied_Product_1_ID",
                table: "Provider",
                column: "Supplied_Product_1_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Provider_Supplied_Product_2_ID",
                table: "Provider",
                column: "Supplied_Product_2_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Provider_Supplied_Product_3_ID",
                table: "Provider",
                column: "Supplied_Product_3_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_Customer_ID",
                table: "Warehouse",
                column: "Customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_Employee_ID",
                table: "Warehouse",
                column: "Employee_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_Product_ID",
                table: "Warehouse",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_Provider_ID",
                table: "Warehouse",
                column: "Provider_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Provider");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Product_Type");
        }
    }
}
