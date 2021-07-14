using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class moveProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "accuracy_values",
                column: "accuracy",
                values: new object[]
                {
                    30,
                    50,
                    55,
                    60,
                    70,
                    80,
                    85,
                    90,
                    95
                });

            migrationBuilder.InsertData(
                table: "power_values",
                column: "power",
                values: new object[]
                {
                    100,
                    110,
                    125,
                    130,
                    250,
                    150,
                    160,
                    200,
                    95,
                    140,
                    80,
                    55,
                    65,
                    60,
                    50,
                    45,
                    35,
                    30,
                    20,
                    18,
                    15,
                    10,
                    70
                });

            migrationBuilder.InsertData(
                table: "pp_values",
                column: "pp",
                values: new object[]
                {
                    30,
                    5,
                    25,
                    40
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "accuracy_values",
                keyColumn: "accuracy",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "accuracy_values",
                keyColumn: "accuracy",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "accuracy_values",
                keyColumn: "accuracy",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "accuracy_values",
                keyColumn: "accuracy",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "accuracy_values",
                keyColumn: "accuracy",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "accuracy_values",
                keyColumn: "accuracy",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "accuracy_values",
                keyColumn: "accuracy",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "accuracy_values",
                keyColumn: "accuracy",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "accuracy_values",
                keyColumn: "accuracy",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "power_values",
                keyColumn: "power",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "pp_values",
                keyColumn: "pp",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "pp_values",
                keyColumn: "pp",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "pp_values",
                keyColumn: "pp",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "pp_values",
                keyColumn: "pp",
                keyValue: 40);
        }
    }
}
