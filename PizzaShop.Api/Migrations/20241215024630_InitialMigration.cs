using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PizzaShop.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "address_state",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    state_initial = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    state_name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address_state", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pizza_size",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    size = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pizza_size", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "address",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    street_number = table.Column<int>(type: "integer", nullable: false),
                    address_line1 = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    address_line2 = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    city = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    state_id = table.Column<int>(type: "integer", nullable: false),
                    zip = table.Column<int>(type: "integer", nullable: false),
                    AddressStateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address", x => x.id);
                    table.ForeignKey(
                        name: "FK_address_address_state_AddressStateId",
                        column: x => x.AddressStateId,
                        principalTable: "address_state",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pizza",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    pizza_size_id = table.Column<int>(type: "integer", nullable: false),
                    pizza_topping_id = table.Column<List<int>>(type: "integer[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pizza", x => x.id);
                    table.ForeignKey(
                        name: "FK_pizza_pizza_size_pizza_size_id",
                        column: x => x.pizza_size_id,
                        principalTable: "pizza_size",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    last_name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    address_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.id);
                    table.ForeignKey(
                        name: "FK_customer_address_address_id",
                        column: x => x.address_id,
                        principalTable: "address",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order_detail",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    pizza_id = table.Column<List<int>>(type: "integer[]", nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false),
                    PizzaId1 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_detail", x => x.id);
                    table.ForeignKey(
                        name: "FK_order_detail_pizza_PizzaId1",
                        column: x => x.PizzaId1,
                        principalTable: "pizza",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pizza_topping",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    pizza_topping = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    PizzaId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pizza_topping", x => x.id);
                    table.ForeignKey(
                        name: "FK_pizza_topping_pizza_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "pizza",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "order",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
                    total_price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order", x => x.id);
                    table.ForeignKey(
                        name: "FK_order_customer_customer_id",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "address_state",
                columns: new[] { "id", "state_initial", "state_name" },
                values: new object[,]
                {
                    { 1, "AL", "Alabama" },
                    { 2, "AK", "Alaska" },
                    { 3, "AZ", "Arizona" },
                    { 4, "AR", "Arkansas" },
                    { 5, "CA", "California" },
                    { 6, "CO", "Colorado" },
                    { 7, "CT", "Connecticut" },
                    { 8, "DE", "Delaware" },
                    { 9, "FL", "Florida" },
                    { 10, "GA", "Georgia" },
                    { 11, "HI", "Hawaii" },
                    { 12, "ID", "Idaho" },
                    { 13, "IL", "Illinois" },
                    { 14, "IN", "Indiana" },
                    { 15, "IA", "Iowa" },
                    { 16, "KS", "Kansas" },
                    { 17, "KY", "Kentucky" },
                    { 18, "LA", "Louisiana" },
                    { 19, "ME", "Maine" },
                    { 20, "MT", "Montana" },
                    { 21, "NE", "Nebraska" },
                    { 22, "NV", "Nevada" },
                    { 23, "NH", "New Hampshire" },
                    { 24, "NJ", "New Jersey" },
                    { 25, "NM", "New Mexico" },
                    { 26, "NY", "New York" },
                    { 27, "NC", "North Carolina" },
                    { 28, "ND", "North Dakota" },
                    { 29, "OH", "Ohio" },
                    { 30, "OK", "Oklahoma" },
                    { 31, "OR", "Oregon" },
                    { 32, "MD", "Maryland" },
                    { 33, "MA", "Massachusetts" },
                    { 34, "MI", "Michigan" },
                    { 35, "MN", "Minnesota" },
                    { 36, "MS", "Mississippi" },
                    { 37, "MO", "Missouri" },
                    { 38, "PA", "Pennsylvania" },
                    { 39, "RI", "Rhode Island" },
                    { 40, "SC", "South Carolina" },
                    { 41, "SD", "South Dakota" },
                    { 42, "TN", "Tennessee" },
                    { 43, "TX", "Texas" },
                    { 44, "UT", "Utah" },
                    { 45, "VT", "Vermont" },
                    { 46, "VA", "Virginia" },
                    { 47, "WA", "Washington" },
                    { 48, "WV", "West Virginia" },
                    { 49, "WI", "Wisconsin" },
                    { 50, "WY", "Wyoming" },
                    { 51, "DC", "District of Columbia" }
                });

            migrationBuilder.InsertData(
                table: "pizza_size",
                columns: new[] { "id", "size" },
                values: new object[,]
                {
                    { 1, "Small" },
                    { 2, "Medium" },
                    { 3, "Large" },
                    { 4, "Extra Large" }
                });

            migrationBuilder.InsertData(
                table: "pizza_topping",
                columns: new[] { "id", "PizzaId", "pizza_topping" },
                values: new object[,]
                {
                    { 1, null, "Pepperoni" },
                    { 2, null, "Cheese" },
                    { 3, null, "Ham" },
                    { 4, null, "Banana Peppers" },
                    { 5, null, "Steak" },
                    { 6, null, "Beef" },
                    { 7, null, "Spinach" },
                    { 8, null, "Mushrooms" },
                    { 9, null, "Sausage" },
                    { 10, null, "Bacon" },
                    { 11, null, "Green Peppers" },
                    { 12, null, "Onions" },
                    { 13, null, "Chicken" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_address_AddressStateId",
                table: "address",
                column: "AddressStateId");

            migrationBuilder.CreateIndex(
                name: "IX_customer_address_id",
                table: "customer",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "IX_order_customer_id",
                table: "order",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_order_detail_PizzaId1",
                table: "order_detail",
                column: "PizzaId1");

            migrationBuilder.CreateIndex(
                name: "IX_pizza_pizza_size_id",
                table: "pizza",
                column: "pizza_size_id");

            migrationBuilder.CreateIndex(
                name: "IX_pizza_topping_PizzaId",
                table: "pizza_topping",
                column: "PizzaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "order");

            migrationBuilder.DropTable(
                name: "order_detail");

            migrationBuilder.DropTable(
                name: "pizza_topping");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "pizza");

            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "pizza_size");

            migrationBuilder.DropTable(
                name: "address_state");
        }
    }
}
