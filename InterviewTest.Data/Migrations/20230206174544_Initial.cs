using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InterviewTest.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Value = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("01613536-5375-40e8-8141-930fd76beb15"), "Gary", 9190 },
                    { new Guid("036c8215-3747-4bb2-be6a-1c4d38f48e1e"), "Sharni", 7737 },
                    { new Guid("09f77ea3-bf1c-4df6-b188-0163913d2bea"), "Nichole", 1221 },
                    { new Guid("0c08428a-94b4-4acf-8bf7-f9a2ed4bdec4"), "Paul", 4332 },
                    { new Guid("0da26f0c-421a-40a7-967c-93fbf0f57555"), "Josef", 3714 },
                    { new Guid("12c113d0-1dc3-4934-bbae-ac2a7ae1fe1f"), "Tim", 8386 },
                    { new Guid("1afe428c-341a-4215-b2e8-f35a053e68ca"), "Dario", 284 },
                    { new Guid("1b6fb999-236d-4f24-afb7-4b8d3830c054"), "Ashley", 8151 },
                    { new Guid("1e0a1c9c-e8ed-4680-a0ed-66922ccd6b52"), "Patryk", 1418 },
                    { new Guid("23e7c483-06de-44e1-bd2f-de887c6c664c"), "Marzena", 7515 },
                    { new Guid("27d754f2-e148-4081-b52b-cddc2beb97ca"), "Shaheen", 3721 },
                    { new Guid("3d8933e0-03f2-4cce-b17c-796e1bd0455c"), "Alexander", 2296 },
                    { new Guid("3fcd436e-e782-492a-a61f-ca717d2ff330"), "Ella", 4549 },
                    { new Guid("43258789-6cef-4093-abd6-73394c8cdd8d"), "Elike", 1860 },
                    { new Guid("47e19e1b-822c-4441-a4b9-70163abbb67a"), "Abul", 1357 },
                    { new Guid("4fd2c0e3-c0ba-4d02-b2d0-3079f3626a8f"), "Greg", 5929 },
                    { new Guid("500ee11d-656c-4376-8657-93dd002228bb"), "Tracy", 1771 },
                    { new Guid("5373905a-813e-49ac-ba56-9012156f1593"), "Frank", 3281 },
                    { new Guid("58459587-5215-43ef-a770-77f7417d10ec"), "Lee", 269 },
                    { new Guid("59efb144-f51e-4c90-8742-361c1940225e"), "Ryan", 252 },
                    { new Guid("624cabf5-f1e7-43e2-9ec8-d46b7e5a30f1"), "Raymond", 7393 },
                    { new Guid("63f5b227-45eb-413c-b6eb-c2407185c5ae"), "Jarek", 6581 },
                    { new Guid("65d3c585-0ad3-468b-8837-926afc32afcf"), "Mohamed", 1080 },
                    { new Guid("67577f37-a12f-4ff7-8410-cf6b740eb04c"), "Tina", 5133 },
                    { new Guid("68a11938-6c30-4193-a624-fd0b5595bc1f"), "Tom", 7553 },
                    { new Guid("6d084ceb-82a9-4df9-ab2f-e3739de2cc16"), "Faye", 7399 },
                    { new Guid("6d61de9c-2faf-4595-9069-194b9ef1220d"), "Anna", 4040 },
                    { new Guid("76f606d8-393b-4cf9-b64f-55c59c91f0f4"), "Roman", 4056 },
                    { new Guid("77b90328-0135-4213-b34d-a4508c907ab7"), "Huzairi", 9491 },
                    { new Guid("7abbb958-fa0a-4a14-9161-2336b94495fa"), "Sara", 2618 },
                    { new Guid("7ce1b4ac-9b78-42af-a320-134fa25d13e4"), "Tristan", 2030 },
                    { new Guid("85c5ddc1-191c-4de1-a079-45ee460415b3"), "Jose", 1605 },
                    { new Guid("8b1af87e-805d-4c3c-9b80-fa60bb687122"), "Cecilia", 2136 },
                    { new Guid("8d0c9341-6789-4429-abda-9bbf6054c97f"), "Tony", 4432 },
                    { new Guid("8dbbd341-442c-465c-a298-169e7c7b7cdc"), "Helen", 963 },
                    { new Guid("9394d033-6e76-4894-ad78-2bf8ffa514d0"), "Oliver", 2868 },
                    { new Guid("93da39b3-ad27-4c69-9c53-b780a01dbcb0"), "Borja", 9428 },
                    { new Guid("9b67d81b-a1e1-4278-84c3-af1201250072"), "Christopher", 9035 },
                    { new Guid("9f638ee8-7721-4e3a-bf4f-f8670dfaccc9"), "Jim", 202 },
                    { new Guid("a693ca42-2688-4b2f-b752-e0212a281807"), "Karthik", 4828 },
                    { new Guid("ab3d1c5e-105f-4c3f-b797-b3d2b810220f"), "Ellie", 5736 },
                    { new Guid("ab4b45ef-3ed0-49d5-8f9e-bc3814eee117"), "Harvey", 8471 },
                    { new Guid("b126d858-8dd1-4560-abaa-bc67edc4b104"), "Sergey", 8282 },
                    { new Guid("b2fe771e-215f-4e92-98dd-d83bd34bcb4c"), "David", 948 },
                    { new Guid("b466fbf1-b16d-41fb-8462-87bca8675094"), "James", 6994 },
                    { new Guid("b82de73d-72d3-4f8c-9273-0a1a6ec59ccb"), "Mark", 3368 },
                    { new Guid("b84d769b-d544-4079-8e16-b467389457dd"), "Elliot", 1020 },
                    { new Guid("b97997dc-5233-41b9-ba0c-5c17d6d0b38e"), "Amber", 1145 },
                    { new Guid("bb85a8db-9c3a-47f1-8a89-fa9c45ed1c89"), "Ralph", 1581 },
                    { new Guid("bc009e00-c659-4fc3-9b3f-1eb50dde12e4"), "Antony", 449 },
                    { new Guid("bcae1b7f-b6e4-4f50-9c82-65a029ae750e"), "Amy", 4359 },
                    { new Guid("bcf86dc4-d194-449e-8631-690af3f5175f"), "Stephen", 8105 },
                    { new Guid("c2c57ab5-3cdf-4072-99fa-e9e2db295d7f"), "Seb", 5395 },
                    { new Guid("c702fe18-d4e5-48fe-9196-0871e7697bf2"), "John", 261 },
                    { new Guid("cca207a2-cf5f-4cbe-9ce7-9426b76a8b7a"), "Madiha", 2329 },
                    { new Guid("d2038a11-31d2-4124-be8c-5daacb613382"), "Sean", 691 },
                    { new Guid("d2506368-4ffa-430b-a975-c0e9a785e733"), "Izmi", 8324 },
                    { new Guid("d43d23c3-df06-4bb5-95c4-f2ad389e6830"), "Francisco", 5028 },
                    { new Guid("d83fdd0a-4899-4317-a8c1-de2ca5fb6958"), "Yury", 1854 },
                    { new Guid("db97b177-ac44-4660-bca2-7577153e7150"), "Adolfo", 1224 },
                    { new Guid("dd57c2ae-d145-4b2e-8d4e-53ab9c89d9e8"), "Fern", 1422 },
                    { new Guid("de56e0f5-4492-44e9-9570-cb65c1a3de11"), "Dan", 1475 },
                    { new Guid("de97b818-663f-4b74-9d87-acbb87686518"), "Marc", 3651 },
                    { new Guid("e4f938c5-9975-4481-b5fd-9b63393ad1f4"), "Sinu", 3349 },
                    { new Guid("e53ccddd-07e5-4119-83c3-01f463b9bab3"), "Marina", 6903 },
                    { new Guid("e5bc6dbd-18d9-4e04-ba4b-8bac07b28d60"), "Katrin", 5393 },
                    { new Guid("e63f9663-8bc0-4f11-a480-b17bf8235630"), "Germaine", 6437 },
                    { new Guid("e933f2ce-9b85-4a25-8d1c-2ccee4d6c7b8"), "Victor", 1046 },
                    { new Guid("ed7f9b71-6764-47ce-864d-cace6e7d26c9"), "Andy", 1966 },
                    { new Guid("efb9a9ba-7366-46ea-9d32-716de7511f0d"), "Nikita", 8520 },
                    { new Guid("f1d02ef8-9048-4986-a06d-3ebccaf3e461"), "Luke", 5926 },
                    { new Guid("fed9971c-70c2-4e30-afa3-5f288a23b14f"), "Emily", 7658 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
