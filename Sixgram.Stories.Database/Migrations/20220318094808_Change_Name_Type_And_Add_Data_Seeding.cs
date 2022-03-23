using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sixgram.Stories.Database.Migrations
{
    public partial class Change_Name_Type_And_Add_Data_Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StoriesModels",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "StoriesModels",
                columns: new[] { "Id", "DateCreated", "Description", "FileId", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("d51ff19d-df9c-43e7-b11f-36ea9fb7992a"), new DateTime(2022, 3, 18, 12, 48, 7, 725, DateTimeKind.Local).AddTicks(3695), "Description", new Guid("906eb56c-b191-4b0e-923d-c61741ff0b86"), "FirstStory", new Guid("bd2f3673-0f3e-4260-b85f-ae6a0f9ff212") },
                    { new Guid("e8c174c9-d93c-4092-9d3b-8881fd173bd7"), new DateTime(2022, 3, 18, 12, 48, 7, 726, DateTimeKind.Local).AddTicks(5131), "Description", new Guid("eb8528ea-a14d-443d-a963-e39f58d09f84"), "SecondStory", new Guid("d9d10bc6-e1fe-42c9-9f14-08d1de011e41") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StoriesModels",
                keyColumn: "Id",
                keyValue: new Guid("d51ff19d-df9c-43e7-b11f-36ea9fb7992a"));

            migrationBuilder.DeleteData(
                table: "StoriesModels",
                keyColumn: "Id",
                keyValue: new Guid("e8c174c9-d93c-4092-9d3b-8881fd173bd7"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Name",
                table: "StoriesModels",
                type: "uuid",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);
        }
    }
}
