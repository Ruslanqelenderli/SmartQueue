using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartQueue.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Queues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HashedPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Queues",
                columns: new[] { "Id", "CreatedDate", "Email", "IsDeleted", "Name", "PhoneNumber", "State", "Surname", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8941), "ruslan.galandarli@gmail.com", false, "Gular", "0559122536", true, "Azimli", null },
                    { 2, new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8944), "ruslan.galandarli@gmail.com", false, "Ruslan", "0559122536", true, "Galandarli", null },
                    { 3, new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8946), "ruslan.galandarli@gmail.com", false, "Laman", "0559122536", true, "Galandarli", null },
                    { 4, new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8960), "ruslan.galandarli@gmail.com", false, "Nijat", "0559122536", true, "Mammadzada", null },
                    { 5, new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8962), "ruslan.galandarli@gmail.com", false, "Ruslan", "0559122536", true, "Salahow", null },
                    { 6, new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8964), "ruslan.galandarli@gmail.com", false, "Mecid", "0559122536", true, "Abdullayev", null },
                    { 7, new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8966), "ruslan.galandarli@gmail.com", false, "Ata", "0559122536", true, "Babayev", null },
                    { 8, new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8968), "ruslan.galandarli@gmail.com", false, "Nijat", "0559122536", true, "Aliyev", null },
                    { 9, new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8970), "ruslan.galandarli@gmail.com", false, "Ali", "0559122536", true, "Nehmatov", null },
                    { 10, new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8972), "ruslan.galandarli@gmail.com", false, "Samad", "0559122536", true, "Samadov", null },
                    { 11, new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8973), "ruslan.galandarli@gmail.com", false, "Ehtiram", "0559122536", true, "Salayev", null },
                    { 12, new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8976), "ruslan.galandarli@gmail.com", false, "Kerim", "0559122536", true, "Mammadzada", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "State", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8898), false, "Admin", true, null },
                    { 2, new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8901), false, "User", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "HashedPassword", "IsDeleted", "Name", "PhoneNumber", "State", "Surname", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8654), "admin@gmail.com", "jGl25bVBBBW96Qi9Te4V37Fnqchz/Eu4qB9vKrRIqRg=", false, "Admin", "0559122536", true, "Admin", null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "RoleId", "State", "UpdatedDate", "UserId" },
                values: new object[] { 1, new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8921), false, 1, true, null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Queues");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
