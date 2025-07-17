using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HumanCapitalManagement.Migrations
{
    /// <inheritdoc />
    public partial class fixedEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employees_UserId",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "022c36bc-8081-4159-874f-81c7f19ed56b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "05b27d59-860a-403f-b031-b1d71226b1c0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "06a5680e-143b-454f-a58c-922b7806718c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "099bf4d1-ec02-4a69-a1c1-c58d09428bcf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "09e44e1d-4e72-4100-91ff-5d1b31ecb3e2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "0a428d4b-58d2-47a5-b6de-6b2f3d88d847" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "0c6a1cd6-99ed-4ff9-a8e4-6847a8b5eaaf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "0ec762e0-ec2b-41f4-9751-34c7dbc1fc6e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "0fa79691-1937-45ee-8c0c-e2e1f25b0735" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1ceabc7c-ba50-40d6-a0fe-8590d2dbb268" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "2882aa57-8adb-48d0-a730-c8dff27e18f6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "2bc94167-68da-4a53-914f-555414efc55f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "2cbc69fa-7041-4dc9-93b6-a564f485ff60" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "35a803ce-9d5f-4ce1-b343-de7edce5b2d6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "37772433-4b18-467a-b5e2-0fc23508f973" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "3942c37e-14a6-4538-95f7-126dfeafc253" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "3961334a-7c0b-43b0-a0b2-46f06eca7b31" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "3d50a9ee-44e4-444f-bec2-13d6029f670a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "4158f70b-8e4e-48f6-ba4a-ce57f4b37c78" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "440f9a76-0591-4e51-8eb6-50c1bf7bf1b7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "479a2b5c-7d25-4377-8644-4fa1ead05ea3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "50c9665c-8633-4c52-a072-bf10848ed658" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "51681ea7-f777-49a2-8d5e-9d807d1493f7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "57eb8344-013c-4c62-a24a-925e2fe93d39" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "58181f28-91f9-4a64-a3df-ef909f046b33" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "67db0983-40c0-449b-b077-544d4885abac" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "684f3a7b-5ade-4c07-8c53-00aa790d8054" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "697dfeeb-677b-4d1e-889e-1df078918597" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "6a8d59a0-0f17-432a-a049-af5c524d7abe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "782d1e28-0c82-4dc8-b601-64865932fb9c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "82a556f8-6d4a-4291-9d7c-49890d51ace0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "92ac3120-4d66-4ecf-baee-130bfd5015ed" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "a732a1ac-8f5d-4a04-ba29-292878f48467" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "a77d7612-28ed-47a4-8c92-44bd14f76b8d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "ae16d477-0ce6-4ed5-aeb8-7475ea2a9d28" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "b064362a-c0da-4b6f-bd6b-126608bfee9d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "b2a4de94-bfda-4610-8114-24402f2009c3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "b82f8b82-4567-4326-8b62-d7356fe255df" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "c63626b0-9fe9-4333-af7c-e763ad93ed38" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "cfd46f59-5307-40a7-a02c-a57085883d64" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "d05295b9-3eca-485e-86c9-8fdf720ee39f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "d42868ec-505d-4c9c-83a6-4c10735fdb13" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "d5c0d689-46b4-46be-9a76-90cd6d6d18ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "d8060eb6-81a4-46b0-9897-3f5ed97cc286" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "dcc38bd9-a063-4b5d-97e6-8620a437de02" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "dddd68cc-25bc-4b8d-a1f0-37a1a1229808" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "edb5265c-3efc-4b8f-994e-35cda8cb665d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "ef44e7db-09ee-4faf-879c-23bf88c6ea8d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "fb3d84e4-bbec-4e1f-8105-6d6eaecc4086" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "fca954eb-2eef-4190-904a-2580754b0ce1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "022c36bc-8081-4159-874f-81c7f19ed56b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05b27d59-860a-403f-b031-b1d71226b1c0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06a5680e-143b-454f-a58c-922b7806718c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "099bf4d1-ec02-4a69-a1c1-c58d09428bcf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09e44e1d-4e72-4100-91ff-5d1b31ecb3e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a428d4b-58d2-47a5-b6de-6b2f3d88d847");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c6a1cd6-99ed-4ff9-a8e4-6847a8b5eaaf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ec762e0-ec2b-41f4-9751-34c7dbc1fc6e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fa79691-1937-45ee-8c0c-e2e1f25b0735");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ceabc7c-ba50-40d6-a0fe-8590d2dbb268");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2882aa57-8adb-48d0-a730-c8dff27e18f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2bc94167-68da-4a53-914f-555414efc55f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cbc69fa-7041-4dc9-93b6-a564f485ff60");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35a803ce-9d5f-4ce1-b343-de7edce5b2d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37772433-4b18-467a-b5e2-0fc23508f973");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3942c37e-14a6-4538-95f7-126dfeafc253");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3961334a-7c0b-43b0-a0b2-46f06eca7b31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d50a9ee-44e4-444f-bec2-13d6029f670a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4158f70b-8e4e-48f6-ba4a-ce57f4b37c78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "440f9a76-0591-4e51-8eb6-50c1bf7bf1b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "479a2b5c-7d25-4377-8644-4fa1ead05ea3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50c9665c-8633-4c52-a072-bf10848ed658");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51681ea7-f777-49a2-8d5e-9d807d1493f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57eb8344-013c-4c62-a24a-925e2fe93d39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58181f28-91f9-4a64-a3df-ef909f046b33");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67db0983-40c0-449b-b077-544d4885abac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "684f3a7b-5ade-4c07-8c53-00aa790d8054");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "697dfeeb-677b-4d1e-889e-1df078918597");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a8d59a0-0f17-432a-a049-af5c524d7abe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "782d1e28-0c82-4dc8-b601-64865932fb9c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82a556f8-6d4a-4291-9d7c-49890d51ace0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92ac3120-4d66-4ecf-baee-130bfd5015ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a732a1ac-8f5d-4a04-ba29-292878f48467");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a77d7612-28ed-47a4-8c92-44bd14f76b8d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae16d477-0ce6-4ed5-aeb8-7475ea2a9d28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b064362a-c0da-4b6f-bd6b-126608bfee9d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2a4de94-bfda-4610-8114-24402f2009c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b82f8b82-4567-4326-8b62-d7356fe255df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c63626b0-9fe9-4333-af7c-e763ad93ed38");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfd46f59-5307-40a7-a02c-a57085883d64");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d05295b9-3eca-485e-86c9-8fdf720ee39f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42868ec-505d-4c9c-83a6-4c10735fdb13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5c0d689-46b4-46be-9a76-90cd6d6d18ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8060eb6-81a4-46b0-9897-3f5ed97cc286");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dcc38bd9-a063-4b5d-97e6-8620a437de02");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dddd68cc-25bc-4b8d-a1f0-37a1a1229808");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edb5265c-3efc-4b8f-994e-35cda8cb665d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef44e7db-09ee-4faf-879c-23bf88c6ea8d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb3d84e4-bbec-4e1f-8105-6d6eaecc4086");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fca954eb-2eef-4190-904a-2580754b0ce1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a8b7cf02-6fdc-4e63-b602-29ad6e0ddead");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4ac2c98a-f784-4dd0-8379-bc8c14b51084");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "66a419d6-4105-447c-a1f2-41f499c81dec");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[,]
                {
                    { "09459024-e5a6-444e-bbbe-e94700ddcee7", "f2733c1d-d535-4217-bcc9-b1207ecd99d4", "johndoe37@personal.gmail", "JOHNDOE37@PERSONAL.GMAIL", "JOHNDOE37", "AQAAAAIAAYagAAAAENvG9q38JtjAPsE5G1dJ080x3vbk19zMB+K0jWZR7sryhyfh4fxaXXGTx/L8JfN4Uw==", "6dc58302-5b65-4040-9c6d-30fcafe4b24c", "JohnDoe37" },
                    { "0f919670-53a9-40d9-8c7b-d12ea6dff34c", "d749e7a5-60de-4708-a4ed-46d00f3d4d2f", "johndoe44@personal.gmail", "JOHNDOE44@PERSONAL.GMAIL", "JOHNDOE44", "AQAAAAIAAYagAAAAEFAuzkyW+K1NklQNON1U6E67X9Y7V5q248MAIZ5SWRK3y3Gqv99kzxS6c2IjNOyV1g==", "f2f60c45-06d6-46e5-a4c1-887c85d448df", "JohnDoe44" },
                    { "11baebb5-2fa7-4d31-8224-34a607f784d9", "dfcbd0c5-aa6e-4112-80f2-584094d828d8", "johndoe4@personal.gmail", "JOHNDOE4@PERSONAL.GMAIL", "JOHNDOE4", "AQAAAAIAAYagAAAAEELagcr+BknUQsZ8/gpXptNFRmehYpwdcqPdrtAVSU/h0oRjzwuc8JFBHiRRJnYV6Q==", "a48abb73-c983-4b20-a50c-423f8b0a86fc", "JohnDoe4" },
                    { "14891e50-21b9-4803-9366-3f6ca5785327", "52b85139-5317-46ce-bc57-beb6cf5950a7", "johndoe48@personal.gmail", "JOHNDOE48@PERSONAL.GMAIL", "JOHNDOE48", "AQAAAAIAAYagAAAAELPk2yZDzMe7U4YQw1l/DNslOa/J2J+pulAtoPn2JpWJD6QcW+kUvnOFOaLtNwL0Yw==", "a653f2b9-61e6-4a9b-b15b-0a6f173766d3", "JohnDoe48" },
                    { "15eb705f-2cfd-4f5f-a968-fcfd0f03ed2f", "1812b62f-dd61-4e61-a086-91f56033de48", "johndoe9@personal.gmail", "JOHNDOE9@PERSONAL.GMAIL", "JOHNDOE9", "AQAAAAIAAYagAAAAEKjAC1zCcogzDntZRm3fQrrnAvwoZA7c8y9HtOZjUuwY+g44iYuOZsrDQFEYc9uWtA==", "bbb769ee-b376-4fa7-8d4d-84867d1965e5", "JohnDoe9" },
                    { "258f087a-8973-427d-9e10-67ebd39b9440", "77115ab0-54ab-4314-8577-1df896df77a5", "johndoe50@personal.gmail", "JOHNDOE50@PERSONAL.GMAIL", "JOHNDOE50", "AQAAAAIAAYagAAAAED+8TKuEoNCqHtABUAU+Vh5uyC8ywUPW6j5bP/DH3cl0EzKnYMVtWxV6Sr6Qbvwong==", "8f2775ab-7bf4-4da3-afcb-b5898fcb5f92", "JohnDoe50" },
                    { "35d615a1-231f-4139-9a1b-f1bd33826569", "3eca094d-23dd-406f-9954-4d57a26e969d", "johndoe49@personal.gmail", "JOHNDOE49@PERSONAL.GMAIL", "JOHNDOE49", "AQAAAAIAAYagAAAAECIi5wwS/peeA5voJtGavTHwES1htJOeWW4YJJA8BxJgpnN/dyjS5Z2x61Id6oXwyw==", "15ac4656-d273-45a8-97f4-3ba61345b253", "JohnDoe49" },
                    { "3bde0cbb-56ff-477f-a3ce-880661561c92", "11557a11-c27c-4e04-8986-70251bbfbe4c", "johndoe41@personal.gmail", "JOHNDOE41@PERSONAL.GMAIL", "JOHNDOE41", "AQAAAAIAAYagAAAAEO85cAC2uu33rbAlmqexK0/srpJ5aQc0kRCsVSnBIq9pcuTT3SdkFVy0dQ12rbflNA==", "16c01516-7cb3-44cc-badd-aa4f7a86ed98", "JohnDoe41" },
                    { "3e31cd67-e9aa-49f0-911b-6d96c855b8cf", "2a68c85f-b71c-405f-ba45-281e63373844", "johndoe29@personal.gmail", "JOHNDOE29@PERSONAL.GMAIL", "JOHNDOE29", "AQAAAAIAAYagAAAAEENs3Qp3VmJJ1IafO8KSjvHVio7+ZalRXn0j/LHM/UYUPdM8Rht/GKdG6TpDgDm9aA==", "73834daf-2575-4587-b4be-7631956af698", "JohnDoe29" },
                    { "4fa33cc4-bc44-4542-b495-ce9354790436", "91c44f27-e4af-4416-a8ff-87de87830030", "johndoe25@personal.gmail", "JOHNDOE25@PERSONAL.GMAIL", "JOHNDOE25", "AQAAAAIAAYagAAAAEFbp+/RiKVpRTVAWQojGO2rUGJQDEbPJqDcisUVuEMKu8OX4WsyVVD6vyjTOVWe4sQ==", "024b895a-f8a1-47c7-9c74-7f1d803dbd03", "JohnDoe25" },
                    { "5e137885-4d5f-405f-bd00-9442c30fa3c8", "38e3d530-3315-4494-9ba4-feb9f3df31df", "johndoe35@personal.gmail", "JOHNDOE35@PERSONAL.GMAIL", "JOHNDOE35", "AQAAAAIAAYagAAAAEH71HN8YNfN+5rEBW+pCSqwBqZf7BI/zi3iqubA8M8PRDWeuyBuoR//WhQqMzRI9Fg==", "f16f381a-9935-4a2a-b2f7-3d3adae68ed4", "JohnDoe35" },
                    { "65f666d5-cf35-49b7-8ca3-3742ebca48a9", "a3e0846e-17a2-48c5-879c-3897332d0de0", "johndoe40@personal.gmail", "JOHNDOE40@PERSONAL.GMAIL", "JOHNDOE40", "AQAAAAIAAYagAAAAEOIaC6l5oJJNBtxfKer4ewnQ6JmrVh/gPNGaDO3Ve9L/Tl7d8DL8QT/JvStXdh9sYg==", "141455f6-3bf8-4c21-a055-beafa3116bc4", "JohnDoe40" },
                    { "6bf33868-604f-431e-810f-e992bd8fe864", "5369bf42-976d-40f3-8dd0-41a14411a867", "johndoe24@personal.gmail", "JOHNDOE24@PERSONAL.GMAIL", "JOHNDOE24", "AQAAAAIAAYagAAAAEAgKoXhp2/g06Q0QQ4qoaFL/aziKmlX9XBd4XslXa06Gtz/+w/EFNZkjgLvrEbeB5Q==", "1bb0aa66-66ea-4ff2-ad97-ef949ab1e5b4", "JohnDoe24" },
                    { "7510383c-65b2-4b17-98b6-fecdba0b4d4d", "d55e68f8-a083-44b2-b65e-c892f73cdaf7", "johndoe22@personal.gmail", "JOHNDOE22@PERSONAL.GMAIL", "JOHNDOE22", "AQAAAAIAAYagAAAAEN8a5iMO9IlAqPx1o1+xu0vkHAqLtNpkH6RGvq+fLysEZ4XRxF8GOBrMOQDVOHJT4A==", "c7d0b001-1d94-4bdf-9bc7-a634a4cfde1f", "JohnDoe22" },
                    { "788d0ee3-9b5e-42b7-8f1d-19579423e0a0", "c000300d-7ffe-4266-b4b4-4cbfef322426", "johndoe46@personal.gmail", "JOHNDOE46@PERSONAL.GMAIL", "JOHNDOE46", "AQAAAAIAAYagAAAAEPEMGRyiWVuEEzpgboVPZNUatN/PQGhWqMRvTLUEfBVC9uPBYmC3kvUugTOa4IwZyg==", "ae1e67f6-a4c5-4091-8796-0836d50a6700", "JohnDoe46" },
                    { "79dff8cb-f4c4-46b3-8f45-d3a5d391df63", "016285ba-ab2b-4195-839f-490206a434bc", "johndoe14@personal.gmail", "JOHNDOE14@PERSONAL.GMAIL", "JOHNDOE14", "AQAAAAIAAYagAAAAEJTrRVFUsEsRFI8Awx7Bh/f4qN1AJVGoZ46smv1cAy8xUYFk7a6WqLWeU7rtozO8+g==", "14894b57-ad70-461f-ba47-f5fddbc4b048", "JohnDoe14" },
                    { "7d68886e-78bd-446b-b0e0-1b1d23450dc2", "fe665e7e-1d43-40e3-a717-3811741c3283", "johndoe13@personal.gmail", "JOHNDOE13@PERSONAL.GMAIL", "JOHNDOE13", "AQAAAAIAAYagAAAAEIi5xdMwrJ4H/mbWaYq5/2JTmfGadwVw1x48Zyhz9fnViYAaChv5YY5fQukq6B8nPg==", "5d77bdc3-6814-4838-ba41-45e98db03612", "JohnDoe13" },
                    { "88ae37bf-3708-439a-a634-100418cfbb46", "8aa0e24a-7143-4daf-b7c0-b718fa2fb59d", "johndoe32@personal.gmail", "JOHNDOE32@PERSONAL.GMAIL", "JOHNDOE32", "AQAAAAIAAYagAAAAEJI3bRVf+6Q5Pxxx9D4qSEVExTwTD7EFHHZqe0XyvTg+HHKZBcQ4bWAtHEh7FeOFSw==", "02312513-9179-48eb-b4e0-16bc8e05e357", "JohnDoe32" },
                    { "8a3847b3-32c7-45a3-b84e-a7d787c35cbf", "79079629-6c8e-4d90-9151-d1f8664e1340", "johndoe39@personal.gmail", "JOHNDOE39@PERSONAL.GMAIL", "JOHNDOE39", "AQAAAAIAAYagAAAAENXruWL1Gd7TxNkPjNK8dM3o4wnRMFxcOptuV+eAoEOnUwUbFNwsXjQ24I7DpTkWxw==", "d91d472a-75ad-44df-9bc2-4aec410a6541", "JohnDoe39" },
                    { "8f90f0a5-01b6-4622-819b-0292b0bc49da", "1cc977d0-e460-4546-b7ac-172d990cd6a4", "johndoe42@personal.gmail", "JOHNDOE42@PERSONAL.GMAIL", "JOHNDOE42", "AQAAAAIAAYagAAAAEDNgWUG7Tl8VIVQiJ40wAUvQqxHFjdnWO+Vfn89Pd9hIkSAKMZLwgO+p8AAV1rAAeQ==", "2692906e-84c2-4c31-82c3-abbd42211100", "JohnDoe42" },
                    { "8ff6475f-ec42-4b4d-8fef-a1f34aac6c2e", "92e2b8a1-9f06-43fc-98ad-b9f0cb026389", "johndoe33@personal.gmail", "JOHNDOE33@PERSONAL.GMAIL", "JOHNDOE33", "AQAAAAIAAYagAAAAEEuS0gSL2hxApOEL6fwTPbneYLj8NZwp0bpwbIq5EUEQ+23f323HSRic8vefaUU+Ww==", "dc776992-25d4-475c-8829-850ed1f08f7b", "JohnDoe33" },
                    { "9043b6b5-3298-4a3d-9cfb-7bf26b6745fb", "0eabedf9-0cbb-40e8-80fe-46fe08bab0e6", "johndoe19@personal.gmail", "JOHNDOE19@PERSONAL.GMAIL", "JOHNDOE19", "AQAAAAIAAYagAAAAELhUDJxmgkfShvtJB83RCQ66r5wk342DeTIe60QYPfoEyRvYKDZYt1PmmZStHEXosg==", "a5dd5285-a29a-4fcd-86d1-16a6524bf26d", "JohnDoe19" },
                    { "954b71c7-7bc2-4ca6-acb6-44207c49287f", "12d1243e-d8bb-4a9d-aecf-db9bf7cbb8a9", "johndoe5@personal.gmail", "JOHNDOE5@PERSONAL.GMAIL", "JOHNDOE5", "AQAAAAIAAYagAAAAELsYi91c8DCoGL5axbcmg7wArbZvN3qTdX/EOM4a/5uX4LS1C75cHzUKBay7d2XvoA==", "4031d6d9-d809-40f7-bab9-f8eae2a32903", "JohnDoe5" },
                    { "984af3a2-b2f4-4c9b-97ca-f91821b9877e", "fdc95d70-b88c-4fe8-8d5f-67b212a03ad2", "johndoe23@personal.gmail", "JOHNDOE23@PERSONAL.GMAIL", "JOHNDOE23", "AQAAAAIAAYagAAAAEA6TmaBggpG/NBy0p6dGyVRTtvG8eOz6oKddiqJ3zgP9RUt9kAfbX7rjUyf0GZp+pA==", "951a4a2b-4c9e-42fc-8910-5d5f5e42e294", "JohnDoe23" },
                    { "9f08c224-9004-448c-b238-cbb5afe3e389", "1435a9a4-f13b-4a6c-9a10-3cdf318f3c9c", "johndoe6@personal.gmail", "JOHNDOE6@PERSONAL.GMAIL", "JOHNDOE6", "AQAAAAIAAYagAAAAEJ7zXYXgVNDyCJvOrHF+bieIbgxchCXClBm6b+sB8YHfFr3/ty5/uT92Him9A1zehQ==", "ebb85169-ca0b-4b13-9288-371ba3b14859", "JohnDoe6" },
                    { "9f08e2b6-6770-482f-b9f0-de32dc1d7238", "061a4fef-1299-4e49-a9cd-655c0fca16be", "johndoe28@personal.gmail", "JOHNDOE28@PERSONAL.GMAIL", "JOHNDOE28", "AQAAAAIAAYagAAAAECqpTFizvIdR9cwtOF2QLF6VvF9zr+qFpUR9HW6UZe3ZlaG10GcZZC5XiwxdLmsC6A==", "03eb3418-ccec-4fdd-a631-8a4e126572ee", "JohnDoe28" },
                    { "a0eb4e7f-8412-4df6-b5f2-1e792c42f300", "4cba7a7d-6ec3-47ed-99b5-b887ad9a3fc0", "johndoe17@personal.gmail", "JOHNDOE17@PERSONAL.GMAIL", "JOHNDOE17", "AQAAAAIAAYagAAAAEEikOVzcUnGTr/x2vpRIHNk2NuU5t/UBrF5n2OV6ZKgfN8kaKhA5Db6UqjTEyMWXvg==", "ef5dd4df-55a0-42b4-87fa-82d26c5b4e35", "JohnDoe17" },
                    { "aa74bd83-2bdc-4a51-bd29-02f05d1ef82c", "9dd995c1-bfc8-4641-b9c8-2a2a7a61d551", "johndoe34@personal.gmail", "JOHNDOE34@PERSONAL.GMAIL", "JOHNDOE34", "AQAAAAIAAYagAAAAEDlHWtL2BvGz0ZKMP07EmpoX9M/e0tqen6bbEt8VTXII7NLolEjG3mYAnt0gMg2MOg==", "a426db89-bf54-4730-b6cb-6648df315277", "JohnDoe34" },
                    { "aad09454-bf66-4dc8-ab1c-4e145da36b46", "7742f50d-03f4-4dd2-801d-8bb8443dedd6", "johndoe36@personal.gmail", "JOHNDOE36@PERSONAL.GMAIL", "JOHNDOE36", "AQAAAAIAAYagAAAAEI1AfQCbb9gVZ5Pg5cpAkr63uUWAGQj6MzJoa+P+tVtUcLY/VG8xs/59nR2WVVKaWA==", "f4f672e5-60fd-4be8-a17d-6b8164d39132", "JohnDoe36" },
                    { "b11cc300-81bb-46dd-ba40-27e533501b67", "230ff3e4-2778-41d4-a7e9-018c2beb5060", "johndoe38@personal.gmail", "JOHNDOE38@PERSONAL.GMAIL", "JOHNDOE38", "AQAAAAIAAYagAAAAEEWvPadd+u/mbPbsSWcT6ajutBAbl0CDTAe7LIuYJi4ufMggYMGsQmyHnyi1LAx6fg==", "f2cbe563-c529-4ebf-8854-43af182e9440", "JohnDoe38" },
                    { "bac88557-3c4a-479f-aca6-6581b7a8b277", "6befec8f-28f4-49e7-9557-15bc5eed509e", "johndoe15@personal.gmail", "JOHNDOE15@PERSONAL.GMAIL", "JOHNDOE15", "AQAAAAIAAYagAAAAEMFC4qroXC6n62X4+L4UsSh2QUjP9t/5z0rg/FZrjYGmzB3IGYZvg28TTzw1lRKlIQ==", "b883d37d-552e-43b6-bfc5-3ab037f8e561", "JohnDoe15" },
                    { "bc63e1db-31c1-4c60-b794-689c3a2b8ba2", "5adc93f9-d295-4266-87f8-17ef9babca7c", "johndoe10@personal.gmail", "JOHNDOE10@PERSONAL.GMAIL", "JOHNDOE10", "AQAAAAIAAYagAAAAEDr5Us+bzKdwcS8M5p+wyv7tqsE/tgtTfzOL1XW+znoAOl1xjvanT1m5BCH+sarJtA==", "7154906a-6a4d-4047-899c-1c7f8baf9e0c", "JohnDoe10" },
                    { "bf7c5195-38db-4b6c-a49a-bdd27872e6a3", "a9c4ba51-aea9-4c93-98d0-418bd91e6c73", "johndoe1@personal.gmail", "JOHNDOE1@PERSONAL.GMAIL", "JOHNDOE1", "AQAAAAIAAYagAAAAEJ2hmKW5zNKZJTjjXWYvb1E4IOO6Bqhp+jl9EjhC8yYU07gE8wdLoBKqvHPv59wgQQ==", "0c75db9b-5d41-47e9-9ac5-57d2b93136c3", "JohnDoe1" },
                    { "c085ccc9-20d9-4446-ad68-36f36b008f56", "81d9eae7-4cfe-466a-8873-7d7241188518", "johndoe18@personal.gmail", "JOHNDOE18@PERSONAL.GMAIL", "JOHNDOE18", "AQAAAAIAAYagAAAAEMHfjqMPFnahBAm2bVRnjsje4nU+uOzSxjX8g51t02YlcG6SHt9fGy2dsXmDtgqY4w==", "c28580ca-f5dc-4da1-93ee-dfd769021887", "JohnDoe18" },
                    { "c108293f-65b7-402b-8275-a555dceb77ad", "b9346ca2-7d39-4c8f-b09b-138c04470547", "johndoe2@personal.gmail", "JOHNDOE2@PERSONAL.GMAIL", "JOHNDOE2", "AQAAAAIAAYagAAAAEJEHUnj7APG0cfpgg6YRNPMr2OtXwblNW/kAs9sujddvgp0zvjyDJwy1wy9wMOdLcw==", "14c62b43-8581-4fc4-a0d8-d3902940773a", "JohnDoe2" },
                    { "c5163a16-2bac-45e9-b185-568ad85d09f1", "f1f83da4-f054-48e5-8f40-28ca1717b565", "johndoe3@personal.gmail", "JOHNDOE3@PERSONAL.GMAIL", "JOHNDOE3", "AQAAAAIAAYagAAAAEKquacYyVs/cmhMYFoCoxeYdkU5vSAVjtqeQIdWRIuwF+kWD7TQQTcXl3Q8TfNpxag==", "a1f70ff8-1e65-49b2-be45-b394345db7c8", "JohnDoe3" },
                    { "c5622712-52de-418a-8454-5c49917229d9", "70f9648e-a7f2-4e2d-9bc7-a0891891a52d", "johndoe45@personal.gmail", "JOHNDOE45@PERSONAL.GMAIL", "JOHNDOE45", "AQAAAAIAAYagAAAAEHGbteFoSnrNDhI8veu8j08kZJUAi3VJ2U5dE0Z9fDUvyCqxdToDXFBJxT7ouEzv6Q==", "6e498047-8722-49e9-beaf-fd2117a01613", "JohnDoe45" },
                    { "c7519d05-196b-438d-824f-18c36052608b", "4a085163-e7ad-4609-89bf-c034da54218c", "johndoe26@personal.gmail", "JOHNDOE26@PERSONAL.GMAIL", "JOHNDOE26", "AQAAAAIAAYagAAAAEM3cyzaGbJs+jGtjAJSQG1RAT5SpzqQxgnGyTay7iX1eQ0fJjE47Gb/qcZB+niX0kg==", "85bc36f8-a829-41f7-9a06-cc6812c65649", "JohnDoe26" },
                    { "c7c04eb3-fdbb-4f0d-95cd-5d6ea3c8267c", "884dc9a7-e8b9-4863-bd53-63f67073c2c3", "johndoe7@personal.gmail", "JOHNDOE7@PERSONAL.GMAIL", "JOHNDOE7", "AQAAAAIAAYagAAAAEHzMGRUjsoK45J/ykwot5jAv+mC4rh0nX9/BV+vb9YGZmghwvlCktoDPN7ruwbW2Mg==", "6a96aefa-3e91-4284-b792-be89773f872f", "JohnDoe7" },
                    { "c8343387-5046-4233-9990-5cefd61ce6ad", "c8c37b56-30d7-41ee-ab58-d43a91e2cac1", "johndoe43@personal.gmail", "JOHNDOE43@PERSONAL.GMAIL", "JOHNDOE43", "AQAAAAIAAYagAAAAEHB+3XpsxHF6qbDqNu/dG1Kq2DEw4Pr/Fg3RvakraeIahE6+0MFTlZ/yuJgEIBHGQQ==", "7dfcf383-3486-4e0b-b541-171d9c347fd1", "JohnDoe43" },
                    { "cbdc9fbe-cef2-46a9-ac15-48ace5910dfa", "921dab43-45ef-466c-a42d-23c1966fedb7", "johndoe20@personal.gmail", "JOHNDOE20@PERSONAL.GMAIL", "JOHNDOE20", "AQAAAAIAAYagAAAAEMZ/6lWYcwoWNrxvizLRMZ2BNMjfwkLVdREjLmyu3Z2T1Zdu6ahk70RaxcnNZ4Vcgw==", "16313309-4628-44d6-92fe-0d985e1f73d6", "JohnDoe20" },
                    { "cd2d568e-4406-4391-bbfd-5bfcbbb8c213", "b4558d63-55c8-40c0-ab35-69f673476fc8", "johndoe47@personal.gmail", "JOHNDOE47@PERSONAL.GMAIL", "JOHNDOE47", "AQAAAAIAAYagAAAAELMCmFwwYxPqP7vj/+0ob0/piIRr/J/tJNoj2/9TFWd2D7mo6WBAhVU3Ng+UlFm+Nw==", "434d7357-2a54-4cee-a9f3-90995ce82b98", "JohnDoe47" },
                    { "dbef78ce-687f-4011-89fc-3e0456745f6b", "125c74a8-5b84-40bd-98c7-a95e383984cd", "johndoe21@personal.gmail", "JOHNDOE21@PERSONAL.GMAIL", "JOHNDOE21", "AQAAAAIAAYagAAAAEPKsq3lORXtrssZMEts3ML2bPAmGg/ihqWfkrngClFIoOqh6kHn8csb4jH7zqRtlhQ==", "998a68c1-4a56-441d-84af-9e59390b6e56", "JohnDoe21" },
                    { "ded7fc29-d7a1-475a-a586-4336fc7709c2", "6a1e46b0-b1e6-4ddd-82a3-ff4b6d7f88d0", "johndoe30@personal.gmail", "JOHNDOE30@PERSONAL.GMAIL", "JOHNDOE30", "AQAAAAIAAYagAAAAEK/zLaz6+ki9EKvRX7XhDQWdAgV/gIvf5y8/zBEOvB9YYAlqCzsnMtJJQ1V+R6X7qA==", "5a1ccdca-9acd-465e-9035-4f971ddb2b89", "JohnDoe30" },
                    { "e1b47112-dd02-4784-b69f-37b0fcb86ab8", "3311e055-39ba-48a9-b396-4e4b0976d7aa", "johndoe12@personal.gmail", "JOHNDOE12@PERSONAL.GMAIL", "JOHNDOE12", "AQAAAAIAAYagAAAAEEyk3+GpLgku26DGA5laUqiJx/3nImypeWkGw22FnWkIqQihoCGnHWPpUiHZP4jMlQ==", "ee9c5836-bba7-4799-a316-ee35fe338690", "JohnDoe12" },
                    { "e2fe5cd4-9b84-40a7-ad53-14c7dc4ab919", "1dc81106-522a-44ba-8e97-9ae57b21e7ae", "johndoe27@personal.gmail", "JOHNDOE27@PERSONAL.GMAIL", "JOHNDOE27", "AQAAAAIAAYagAAAAEILKV/NmgTyA6sWZ/mHyC5+6feI24AcYQyEzdxGtBwhMdGjY3F+zy/7nGV8h1iMgAA==", "6758fc14-9188-4964-b160-42542c03cead", "JohnDoe27" },
                    { "e5bf254d-d447-47a6-b954-da6f5387fd99", "f5d9cf20-1747-47a9-ba8b-2d50a6b3430f", "johndoe11@personal.gmail", "JOHNDOE11@PERSONAL.GMAIL", "JOHNDOE11", "AQAAAAIAAYagAAAAEFN6G+3ll9kXBkoDj2Iw1GSwTaLZw88rpAgQNXKKn08hDgPLVKvmzuY1ApY/TGjpYg==", "8efd63c0-cbcd-4553-abd0-3f98f492689f", "JohnDoe11" },
                    { "e7a47064-a28b-4476-b12a-990ecbe99f59", "da6ea515-24f8-4b37-abf4-df05188843e5", "johndoe31@personal.gmail", "JOHNDOE31@PERSONAL.GMAIL", "JOHNDOE31", "AQAAAAIAAYagAAAAEPyQ7N0ivQPIiSS5FPC/jRR+gVogvt6cj8S0yolZRMAqQwTNAw2DPirrILwLXrpv/g==", "3cd161b4-33ea-403e-bd8d-908b83fe785b", "JohnDoe31" },
                    { "ede19227-19da-4fec-beda-b850b6e7ab32", "338f3d13-75a7-435e-9a52-3f8d49379407", "johndoe8@personal.gmail", "JOHNDOE8@PERSONAL.GMAIL", "JOHNDOE8", "AQAAAAIAAYagAAAAEPk8m8eKK+WNXXqRqnj7nJLRfsQzKrfKu03An6nm79YRl3F0ZQWypilhHZFuCzK5Gg==", "70d914f8-ea0d-4b72-b431-5a4e1fda5d4f", "JohnDoe8" },
                    { "ee37cb9c-21ad-476e-a088-f51d5a0f76cb", "bca3d871-6bc2-409b-8328-715b894bcdbf", "johndoe16@personal.gmail", "JOHNDOE16@PERSONAL.GMAIL", "JOHNDOE16", "AQAAAAIAAYagAAAAEKKhZnEfni17kZD16XXhj45X5uzsTk/2Xk7UlD6gq+JA/fDndtXwsdOkTlHPwdYrlw==", "8bf462c4-1425-4586-a1bf-c51cc8fd76c9", "JohnDoe16" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 3072.0m, "bf7c5195-38db-4b6c-a49a-bdd27872e6a3" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 7090.5m, "c108293f-65b7-402b-8275-a555dceb77ad" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 3259.5m, "c5163a16-2bac-45e9-b185-568ad85d09f1" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 4860.0m, "11baebb5-2fa7-4d31-8224-34a607f784d9" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 3990.0m, "954b71c7-7bc2-4ca6-acb6-44207c49287f" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2335.5m, "9f08c224-9004-448c-b238-cbb5afe3e389" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Financial Analyst", 2192m, "c7c04eb3-fdbb-4f0d-95cd-5d6ea3c8267c" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Database Admin", 4459m, "ede19227-19da-4fec-beda-b850b6e7ab32" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Social Media Manager", 2122m, "15eb705f-2cfd-4f5f-a968-fcfd0f03ed2f" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Sales Representative", 3181m, "bc63e1db-31c1-4c60-b794-689c3a2b8ba2" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2829m, "e5bf254d-d447-47a6-b954-da6f5387fd99" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Training Specialist", 1614m, "e1b47112-dd02-4784-b69f-37b0fcb86ab8" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Financial Analyst", 2002m, "7d68886e-78bd-446b-b0e0-1b1d23450dc2" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Network Engineer", 4823m, "79dff8cb-f4c4-46b3-8f45-d3a5d391df63" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "SEO Analyst", 2139m, "bac88557-3c4a-479f-aca6-6581b7a8b277" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Account Executive", 4429m, "ee37cb9c-21ad-476e-a088-f51d5a0f76cb" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2844m, "a0eb4e7f-8412-4df6-b5f2-1e792c42f300" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1544m, "c085ccc9-20d9-4446-ad68-36f36b008f56" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Auditor", 2051m, "9043b6b5-3298-4a3d-9cfb-7bf26b6745fb" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Network Engineer", 4229m, "cbdc9fbe-cef2-46a9-ac15-48ace5910dfa" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Content Writer", 2149m, "dbef78ce-687f-4011-89fc-3e0456745f6b" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Business Developer", 2569m, "7510383c-65b2-4b17-98b6-fecdba0b4d4d" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2602m, "984af3a2-b2f4-4c9b-97ca-f91821b9877e" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Recruiter", 1710m, "6bf33868-604f-431e-810f-e992bd8fe864" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2174m, "4fa33cc4-bc44-4542-b495-ce9354790436" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 4564m, "c7519d05-196b-438d-824f-18c36052608b" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Social Media Manager", 2074m, "e2fe5cd4-9b84-40a7-ad53-14c7dc4ab919" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Account Executive", 3710m, "9f08e2b6-6770-482f-b9f0-de32dc1d7238" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Facilities Manager", 2949m, "3e31cd67-e9aa-49f0-911b-6d96c855b8cf" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Compensation Analyst", 1677m, "ded7fc29-d7a1-475a-a586-4336fc7709c2" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Financial Analyst", 2179m, "e7a47064-a28b-4476-b12a-990ecbe99f59" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 4350m, "88ae37bf-3708-439a-a634-100418cfbb46" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2030m, "8ff6475f-ec42-4b4d-8fef-a1f34aac6c2e" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 3070m, "aa74bd83-2bdc-4a51-bd29-02f05d1ef82c" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Facilities Manager", 2512m, "5e137885-4d5f-405f-bd00-9442c30fa3c8" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "HR Generalist", 1646m, "aad09454-bf66-4dc8-ab1c-4e145da36b46" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2072m, "09459024-e5a6-444e-bbbe-e94700ddcee7" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 4098m, "b11cc300-81bb-46dd-ba40-27e533501b67" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Social Media Manager", 2124m, "8a3847b3-32c7-45a3-b84e-a7d787c35cbf" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Sales Engineer", 2664m, "65f666d5-cf35-49b7-8ca3-3742ebca48a9" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Logistics Coordinator", 2502m, "3bde0cbb-56ff-477f-a3ce-880661561c92" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "HR Generalist", 1598m, "8f90f0a5-01b6-4622-819b-0292b0bc49da" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2060m, "c8343387-5046-4233-9990-5cefd61ce6ad" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Database Admin", 4136m, "0f919670-53a9-40d9-8c7b-d12ea6dff34c" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Social Media Manager", 2021m, "c5622712-52de-418a-8454-5c49917229d9" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Sales Representative", 4555m, "788d0ee3-9b5e-42b7-8f1d-19579423e0a0" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Operations Specialist", 2727m, "cd2d568e-4406-4391-bbfd-5bfcbbb8c213" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Compensation Analyst", 1594m, "14891e50-21b9-4803-9366-3f6ca5785327" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Financial Analyst", 2180m, "35d615a1-231f-4139-9a1b-f1bd33826569" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Network Engineer", 4972m, "258f087a-8973-427d-9e10-67ebd39b9440" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3", "09459024-e5a6-444e-bbbe-e94700ddcee7" },
                    { "3", "0f919670-53a9-40d9-8c7b-d12ea6dff34c" },
                    { "2", "11baebb5-2fa7-4d31-8224-34a607f784d9" },
                    { "1", "14891e50-21b9-4803-9366-3f6ca5785327" },
                    { "3", "15eb705f-2cfd-4f5f-a968-fcfd0f03ed2f" },
                    { "3", "258f087a-8973-427d-9e10-67ebd39b9440" },
                    { "3", "35d615a1-231f-4139-9a1b-f1bd33826569" },
                    { "3", "3bde0cbb-56ff-477f-a3ce-880661561c92" },
                    { "3", "3e31cd67-e9aa-49f0-911b-6d96c855b8cf" },
                    { "3", "4fa33cc4-bc44-4542-b495-ce9354790436" },
                    { "3", "5e137885-4d5f-405f-bd00-9442c30fa3c8" },
                    { "3", "65f666d5-cf35-49b7-8ca3-3742ebca48a9" },
                    { "1", "6bf33868-604f-431e-810f-e992bd8fe864" },
                    { "3", "7510383c-65b2-4b17-98b6-fecdba0b4d4d" },
                    { "3", "788d0ee3-9b5e-42b7-8f1d-19579423e0a0" },
                    { "3", "79dff8cb-f4c4-46b3-8f45-d3a5d391df63" },
                    { "3", "7d68886e-78bd-446b-b0e0-1b1d23450dc2" },
                    { "3", "88ae37bf-3708-439a-a634-100418cfbb46" },
                    { "3", "8a3847b3-32c7-45a3-b84e-a7d787c35cbf" },
                    { "1", "8f90f0a5-01b6-4622-819b-0292b0bc49da" },
                    { "3", "8ff6475f-ec42-4b4d-8fef-a1f34aac6c2e" },
                    { "3", "9043b6b5-3298-4a3d-9cfb-7bf26b6745fb" },
                    { "2", "954b71c7-7bc2-4ca6-acb6-44207c49287f" },
                    { "3", "984af3a2-b2f4-4c9b-97ca-f91821b9877e" },
                    { "1", "9f08c224-9004-448c-b238-cbb5afe3e389" },
                    { "3", "9f08e2b6-6770-482f-b9f0-de32dc1d7238" },
                    { "3", "a0eb4e7f-8412-4df6-b5f2-1e792c42f300" },
                    { "3", "aa74bd83-2bdc-4a51-bd29-02f05d1ef82c" },
                    { "1", "aad09454-bf66-4dc8-ab1c-4e145da36b46" },
                    { "3", "b11cc300-81bb-46dd-ba40-27e533501b67" },
                    { "3", "bac88557-3c4a-479f-aca6-6581b7a8b277" },
                    { "3", "bc63e1db-31c1-4c60-b794-689c3a2b8ba2" },
                    { "2", "bf7c5195-38db-4b6c-a49a-bdd27872e6a3" },
                    { "1", "c085ccc9-20d9-4446-ad68-36f36b008f56" },
                    { "2", "c108293f-65b7-402b-8275-a555dceb77ad" },
                    { "2", "c5163a16-2bac-45e9-b185-568ad85d09f1" },
                    { "3", "c5622712-52de-418a-8454-5c49917229d9" },
                    { "3", "c7519d05-196b-438d-824f-18c36052608b" },
                    { "3", "c7c04eb3-fdbb-4f0d-95cd-5d6ea3c8267c" },
                    { "3", "c8343387-5046-4233-9990-5cefd61ce6ad" },
                    { "3", "cbdc9fbe-cef2-46a9-ac15-48ace5910dfa" },
                    { "3", "cd2d568e-4406-4391-bbfd-5bfcbbb8c213" },
                    { "3", "dbef78ce-687f-4011-89fc-3e0456745f6b" },
                    { "1", "ded7fc29-d7a1-475a-a586-4336fc7709c2" },
                    { "1", "e1b47112-dd02-4784-b69f-37b0fcb86ab8" },
                    { "3", "e2fe5cd4-9b84-40a7-ad53-14c7dc4ab919" },
                    { "3", "e5bf254d-d447-47a6-b954-da6f5387fd99" },
                    { "3", "e7a47064-a28b-4476-b12a-990ecbe99f59" },
                    { "3", "ede19227-19da-4fec-beda-b850b6e7ab32" },
                    { "3", "ee37cb9c-21ad-476e-a088-f51d5a0f76cb" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employees_UserId",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "09459024-e5a6-444e-bbbe-e94700ddcee7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "0f919670-53a9-40d9-8c7b-d12ea6dff34c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "11baebb5-2fa7-4d31-8224-34a607f784d9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "14891e50-21b9-4803-9366-3f6ca5785327" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "15eb705f-2cfd-4f5f-a968-fcfd0f03ed2f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "258f087a-8973-427d-9e10-67ebd39b9440" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "35d615a1-231f-4139-9a1b-f1bd33826569" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "3bde0cbb-56ff-477f-a3ce-880661561c92" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "3e31cd67-e9aa-49f0-911b-6d96c855b8cf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "4fa33cc4-bc44-4542-b495-ce9354790436" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "5e137885-4d5f-405f-bd00-9442c30fa3c8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "65f666d5-cf35-49b7-8ca3-3742ebca48a9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "6bf33868-604f-431e-810f-e992bd8fe864" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "7510383c-65b2-4b17-98b6-fecdba0b4d4d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "788d0ee3-9b5e-42b7-8f1d-19579423e0a0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "79dff8cb-f4c4-46b3-8f45-d3a5d391df63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "7d68886e-78bd-446b-b0e0-1b1d23450dc2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "88ae37bf-3708-439a-a634-100418cfbb46" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "8a3847b3-32c7-45a3-b84e-a7d787c35cbf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "8f90f0a5-01b6-4622-819b-0292b0bc49da" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "8ff6475f-ec42-4b4d-8fef-a1f34aac6c2e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "9043b6b5-3298-4a3d-9cfb-7bf26b6745fb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "954b71c7-7bc2-4ca6-acb6-44207c49287f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "984af3a2-b2f4-4c9b-97ca-f91821b9877e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "9f08c224-9004-448c-b238-cbb5afe3e389" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "9f08e2b6-6770-482f-b9f0-de32dc1d7238" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "a0eb4e7f-8412-4df6-b5f2-1e792c42f300" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "aa74bd83-2bdc-4a51-bd29-02f05d1ef82c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "aad09454-bf66-4dc8-ab1c-4e145da36b46" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "b11cc300-81bb-46dd-ba40-27e533501b67" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "bac88557-3c4a-479f-aca6-6581b7a8b277" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "bc63e1db-31c1-4c60-b794-689c3a2b8ba2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "bf7c5195-38db-4b6c-a49a-bdd27872e6a3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "c085ccc9-20d9-4446-ad68-36f36b008f56" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "c108293f-65b7-402b-8275-a555dceb77ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "c5163a16-2bac-45e9-b185-568ad85d09f1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "c5622712-52de-418a-8454-5c49917229d9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "c7519d05-196b-438d-824f-18c36052608b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "c7c04eb3-fdbb-4f0d-95cd-5d6ea3c8267c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "c8343387-5046-4233-9990-5cefd61ce6ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "cbdc9fbe-cef2-46a9-ac15-48ace5910dfa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "cd2d568e-4406-4391-bbfd-5bfcbbb8c213" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "dbef78ce-687f-4011-89fc-3e0456745f6b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "ded7fc29-d7a1-475a-a586-4336fc7709c2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "e1b47112-dd02-4784-b69f-37b0fcb86ab8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "e2fe5cd4-9b84-40a7-ad53-14c7dc4ab919" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "e5bf254d-d447-47a6-b954-da6f5387fd99" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "e7a47064-a28b-4476-b12a-990ecbe99f59" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "ede19227-19da-4fec-beda-b850b6e7ab32" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "ee37cb9c-21ad-476e-a088-f51d5a0f76cb" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09459024-e5a6-444e-bbbe-e94700ddcee7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f919670-53a9-40d9-8c7b-d12ea6dff34c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11baebb5-2fa7-4d31-8224-34a607f784d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14891e50-21b9-4803-9366-3f6ca5785327");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15eb705f-2cfd-4f5f-a968-fcfd0f03ed2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "258f087a-8973-427d-9e10-67ebd39b9440");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35d615a1-231f-4139-9a1b-f1bd33826569");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bde0cbb-56ff-477f-a3ce-880661561c92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e31cd67-e9aa-49f0-911b-6d96c855b8cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fa33cc4-bc44-4542-b495-ce9354790436");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e137885-4d5f-405f-bd00-9442c30fa3c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65f666d5-cf35-49b7-8ca3-3742ebca48a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bf33868-604f-431e-810f-e992bd8fe864");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7510383c-65b2-4b17-98b6-fecdba0b4d4d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "788d0ee3-9b5e-42b7-8f1d-19579423e0a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79dff8cb-f4c4-46b3-8f45-d3a5d391df63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d68886e-78bd-446b-b0e0-1b1d23450dc2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88ae37bf-3708-439a-a634-100418cfbb46");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a3847b3-32c7-45a3-b84e-a7d787c35cbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f90f0a5-01b6-4622-819b-0292b0bc49da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ff6475f-ec42-4b4d-8fef-a1f34aac6c2e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9043b6b5-3298-4a3d-9cfb-7bf26b6745fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "954b71c7-7bc2-4ca6-acb6-44207c49287f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "984af3a2-b2f4-4c9b-97ca-f91821b9877e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f08c224-9004-448c-b238-cbb5afe3e389");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f08e2b6-6770-482f-b9f0-de32dc1d7238");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0eb4e7f-8412-4df6-b5f2-1e792c42f300");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa74bd83-2bdc-4a51-bd29-02f05d1ef82c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aad09454-bf66-4dc8-ab1c-4e145da36b46");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b11cc300-81bb-46dd-ba40-27e533501b67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bac88557-3c4a-479f-aca6-6581b7a8b277");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc63e1db-31c1-4c60-b794-689c3a2b8ba2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf7c5195-38db-4b6c-a49a-bdd27872e6a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c085ccc9-20d9-4446-ad68-36f36b008f56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c108293f-65b7-402b-8275-a555dceb77ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5163a16-2bac-45e9-b185-568ad85d09f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5622712-52de-418a-8454-5c49917229d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7519d05-196b-438d-824f-18c36052608b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7c04eb3-fdbb-4f0d-95cd-5d6ea3c8267c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8343387-5046-4233-9990-5cefd61ce6ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cbdc9fbe-cef2-46a9-ac15-48ace5910dfa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd2d568e-4406-4391-bbfd-5bfcbbb8c213");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbef78ce-687f-4011-89fc-3e0456745f6b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ded7fc29-d7a1-475a-a586-4336fc7709c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1b47112-dd02-4784-b69f-37b0fcb86ab8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2fe5cd4-9b84-40a7-ad53-14c7dc4ab919");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5bf254d-d447-47a6-b954-da6f5387fd99");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7a47064-a28b-4476-b12a-990ecbe99f59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ede19227-19da-4fec-beda-b850b6e7ab32");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee37cb9c-21ad-476e-a088-f51d5a0f76cb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "7f01c7f4-2c17-4032-9c63-5f0ba0a90931");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "50865b45-adcf-4ae8-ab4d-f607e750041d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "c0078c37-ac40-451f-979c-f7d45c4eb604");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[,]
                {
                    { "022c36bc-8081-4159-874f-81c7f19ed56b", "b45b34c1-7916-41ba-976e-518c5bd1cf98", "johndoe35@personal.gmail", "JOHNDOE35@PERSONAL.GMAIL", "JOHNDOE35", "AQAAAAIAAYagAAAAEGazbbeZKkdCY+lhhEx83wMEwZf7HpltDyg7Em7VsNG6OCPwSK9g+JL1xDWHHGXqSA==", "afb3a4bb-4a47-4cbd-aa42-30b15bc0b534", "JohnDoe35" },
                    { "05b27d59-860a-403f-b031-b1d71226b1c0", "3ebdc812-f3d3-411f-9f74-c6dd1dcc7bdb", "johndoe28@personal.gmail", "JOHNDOE28@PERSONAL.GMAIL", "JOHNDOE28", "AQAAAAIAAYagAAAAEMwY3A9Qs3eqvLTJ8QYqrkBKwqiYuccFZWJMM/NM9TtKmAtl2ukRnE+YT52rYpc9Pw==", "338c1eab-8f15-4124-a3de-fff493a1f26c", "JohnDoe28" },
                    { "06a5680e-143b-454f-a58c-922b7806718c", "dfdb0570-c86f-4392-9bcf-0de9311edb34", "johndoe40@personal.gmail", "JOHNDOE40@PERSONAL.GMAIL", "JOHNDOE40", "AQAAAAIAAYagAAAAEK3uGtVUp5B+HFFTeLHyH2esRaL8Gw6wVVDIUI8mcWTr+uwcBFCw2y3yBJBMuXVPVw==", "d1b97202-7dce-4ff9-86d9-b8c223d1b7a6", "JohnDoe40" },
                    { "099bf4d1-ec02-4a69-a1c1-c58d09428bcf", "91aab8e5-25b6-426f-af18-33dfdd8c9cbc", "johndoe39@personal.gmail", "JOHNDOE39@PERSONAL.GMAIL", "JOHNDOE39", "AQAAAAIAAYagAAAAEOxdg5KicTIVotoMWs8zSTslE2P5Yl5q4PHlB+VM7PjlV1RWi9SBJkT5pjzm6RZUWQ==", "7e40c360-828e-496b-9744-83b5a96d8732", "JohnDoe39" },
                    { "09e44e1d-4e72-4100-91ff-5d1b31ecb3e2", "805c6fb7-488e-4857-8666-833c7eabd1da", "johndoe20@personal.gmail", "JOHNDOE20@PERSONAL.GMAIL", "JOHNDOE20", "AQAAAAIAAYagAAAAECMP/bIDLm8kQEkaKjhdHBEIRGssfyAzjBy6cQpjn+ZyJpRfuXP6lj+mGWw+V73ygw==", "f4e2eb6f-f50a-4fbd-b1ae-67396b9419dd", "JohnDoe20" },
                    { "0a428d4b-58d2-47a5-b6de-6b2f3d88d847", "a6f5b789-47f0-437f-badc-ed906b588460", "johndoe13@personal.gmail", "JOHNDOE13@PERSONAL.GMAIL", "JOHNDOE13", "AQAAAAIAAYagAAAAEJCPT09b3Q/zoqmHKrMierr97eIntjQ5OLIadneKhNd7y33n5ODLAtmN1+y6BSvT2g==", "388e39e9-212d-4f77-8e01-5e20bf2ee15b", "JohnDoe13" },
                    { "0c6a1cd6-99ed-4ff9-a8e4-6847a8b5eaaf", "da745e6b-d349-4b2b-b200-bc4643cff2d5", "johndoe30@personal.gmail", "JOHNDOE30@PERSONAL.GMAIL", "JOHNDOE30", "AQAAAAIAAYagAAAAEL6c0M4o5doSxryHmr3tvik73KtS7ExHqh5HQaDHtS0wjUqAsGMNO0jJ/1VK2KFEhg==", "eadab7e5-076a-42dc-a44f-913f875f684e", "JohnDoe30" },
                    { "0ec762e0-ec2b-41f4-9751-34c7dbc1fc6e", "b46faad0-b04a-49ec-beb4-26088a085bfe", "johndoe36@personal.gmail", "JOHNDOE36@PERSONAL.GMAIL", "JOHNDOE36", "AQAAAAIAAYagAAAAENm+hzXE1YiNNWSq7ErkzuDx7YkMyqjptSPkTcTmZy27YlZI1ItxoEC2IbOrQr2rbQ==", "7b51251d-9109-43a7-8fef-f575bbf8b390", "JohnDoe36" },
                    { "0fa79691-1937-45ee-8c0c-e2e1f25b0735", "b328c781-6d44-4255-af81-347f1e15eb31", "johndoe49@personal.gmail", "JOHNDOE49@PERSONAL.GMAIL", "JOHNDOE49", "AQAAAAIAAYagAAAAEIAPMSz9T7nxWfzwPXtd4Dqh5k9dc1VOlouZKH9hZXj3zqSmdBoWT1NsQXdjD2B9WQ==", "2da81b8f-53c7-4677-a4cd-f4f78bf7c93b", "JohnDoe49" },
                    { "1ceabc7c-ba50-40d6-a0fe-8590d2dbb268", "cdb3b173-1dc5-409c-816a-c1442e5ac904", "johndoe6@personal.gmail", "JOHNDOE6@PERSONAL.GMAIL", "JOHNDOE6", "AQAAAAIAAYagAAAAECRQVig5PLZCH5GdLgSR4DB0X6O7US59cvYz+4M0OId2F4inu/FakjJRA8LIy5eX/g==", "b698ce78-c430-484e-8be1-edc69facb179", "JohnDoe6" },
                    { "2882aa57-8adb-48d0-a730-c8dff27e18f6", "3ae4df41-7d09-4bc3-abf6-9eeaabd6d19d", "johndoe43@personal.gmail", "JOHNDOE43@PERSONAL.GMAIL", "JOHNDOE43", "AQAAAAIAAYagAAAAEP0CIpTTXr97QQUrIOEolk96GPaps8Qn1okbP0XJnnfEZssXE10Nivk+ggxIjFw2Yw==", "13b6a43d-8a2f-4b08-9208-3f038cdb0209", "JohnDoe43" },
                    { "2bc94167-68da-4a53-914f-555414efc55f", "5acc0d5a-8927-42a4-b4d7-27045f32b751", "johndoe9@personal.gmail", "JOHNDOE9@PERSONAL.GMAIL", "JOHNDOE9", "AQAAAAIAAYagAAAAEHeBV7STn/MnGh2hY+Z92uasy5tYksacx3lxlFqwOYGBucaj65KIk3i1ZpjtOt61Yw==", "9df3055d-6983-427c-8769-afee020971bc", "JohnDoe9" },
                    { "2cbc69fa-7041-4dc9-93b6-a564f485ff60", "24df4cda-fd06-4b77-b4a3-1fd2b450f031", "johndoe15@personal.gmail", "JOHNDOE15@PERSONAL.GMAIL", "JOHNDOE15", "AQAAAAIAAYagAAAAENvtY7EMWYQXLwZl1qyMU/IxdLhcT/I4LnSCVoUAjoK0dc885Cvdr27+nA/LRRZ2Mw==", "d41a268c-7c66-4ac6-a0c7-99ab793e112e", "JohnDoe15" },
                    { "35a803ce-9d5f-4ce1-b343-de7edce5b2d6", "bdf7b9ae-5699-4ef9-a6ab-2b274579bd1e", "johndoe42@personal.gmail", "JOHNDOE42@PERSONAL.GMAIL", "JOHNDOE42", "AQAAAAIAAYagAAAAEGnL9GEBKotABLUbF/ay6oaZC/e88jux9UlDrlEfGpppTKwEu21dnFFHe1VgpgPskw==", "1300227b-799b-4d98-8431-efa855803cb5", "JohnDoe42" },
                    { "37772433-4b18-467a-b5e2-0fc23508f973", "82c75f87-18a0-4c6a-a4be-359882664147", "johndoe16@personal.gmail", "JOHNDOE16@PERSONAL.GMAIL", "JOHNDOE16", "AQAAAAIAAYagAAAAEHTIE6Ct31MWiSyUgce11Fto2u0OdPtBQqZ+CNpqIud/N1NAAiphwkgmyts4BNRkpg==", "5d26e97f-144e-42cc-8168-41dfcc5c1703", "JohnDoe16" },
                    { "3942c37e-14a6-4538-95f7-126dfeafc253", "7a3cf402-266f-4220-bd79-7f3bf8f065f8", "johndoe2@personal.gmail", "JOHNDOE2@PERSONAL.GMAIL", "JOHNDOE2", "AQAAAAIAAYagAAAAEFtSsPKrSMIYS27HDvhW0mDaieLoveWwYhuocOGl4kqcxSagi34XGzT6cpaE+GdcFQ==", "025ec64d-7978-46b7-8d9e-681c1f0c13d7", "JohnDoe2" },
                    { "3961334a-7c0b-43b0-a0b2-46f06eca7b31", "9ee87386-5c88-4645-b822-9f955f81ac3e", "johndoe12@personal.gmail", "JOHNDOE12@PERSONAL.GMAIL", "JOHNDOE12", "AQAAAAIAAYagAAAAENSuMwVXUepT+1CmwToWK6j3tRzb0VIGDeDdNkMucxnL4A2G5ULbaUffO4NtbzIlzQ==", "5080d6ab-7a83-4ed1-8b7a-c5b39f5fc3d1", "JohnDoe12" },
                    { "3d50a9ee-44e4-444f-bec2-13d6029f670a", "09412f98-614e-4de2-9c69-5cfebd538cc0", "johndoe24@personal.gmail", "JOHNDOE24@PERSONAL.GMAIL", "JOHNDOE24", "AQAAAAIAAYagAAAAEI42jq5EREHtagww2PUE2IuFdvV+tLYAGCy+hYr6J5ZRbk9AGPvxUjf3QE2z/w3HLw==", "9d33fa63-3264-4912-852d-5699132a33de", "JohnDoe24" },
                    { "4158f70b-8e4e-48f6-ba4a-ce57f4b37c78", "2dc8b796-505e-47c5-8cad-d126d6d8f302", "johndoe31@personal.gmail", "JOHNDOE31@PERSONAL.GMAIL", "JOHNDOE31", "AQAAAAIAAYagAAAAEAMNv2DC+La9TojjjR5G0q83dW4V7Bm0SlQo9TqT9ELO50dEaDvLEz/c2wUWBrfXgg==", "d84f9ff2-63ae-4074-8afd-08aa2672c307", "JohnDoe31" },
                    { "440f9a76-0591-4e51-8eb6-50c1bf7bf1b7", "28dd1811-92de-4635-a657-c5bcb6ab39f6", "johndoe14@personal.gmail", "JOHNDOE14@PERSONAL.GMAIL", "JOHNDOE14", "AQAAAAIAAYagAAAAEGsAy4NKQNxKLaPHnDdtVVApmpOzz6lqJHSgEyZ4e60dmqmEK7AEUaDW3SYW0S9d2A==", "23d5b027-efef-402f-ac40-1c973ec32c91", "JohnDoe14" },
                    { "479a2b5c-7d25-4377-8644-4fa1ead05ea3", "b99cd7d2-0715-4cb2-be32-9d67bf880b8b", "johndoe25@personal.gmail", "JOHNDOE25@PERSONAL.GMAIL", "JOHNDOE25", "AQAAAAIAAYagAAAAEGQT6K3kOOgG0+CcHou8XNshU5GrVPH37rkGfT/tbnnCABFAWC2Uj7oZdkGrttg58A==", "2376960e-fc42-427a-a04d-81eddb1789ce", "JohnDoe25" },
                    { "50c9665c-8633-4c52-a072-bf10848ed658", "2d9dd2f0-327f-43e1-a436-6af46d5e9fa3", "johndoe3@personal.gmail", "JOHNDOE3@PERSONAL.GMAIL", "JOHNDOE3", "AQAAAAIAAYagAAAAEIH/9JU3VyMzrayf6Z7LLYe6ceTDhQjVeOTQ1wWwFcUWHRDgl4Q2z4UL+5W/AB5Itw==", "51b9fff2-dd89-4200-a84d-dd43130bb02d", "JohnDoe3" },
                    { "51681ea7-f777-49a2-8d5e-9d807d1493f7", "8921b097-7496-445b-a05d-97cf08410fff", "johndoe34@personal.gmail", "JOHNDOE34@PERSONAL.GMAIL", "JOHNDOE34", "AQAAAAIAAYagAAAAEMlkKf78KhI+WbuJ4GsVC+zhFkeHCl7+LQKVsYyubAmbLyUH/ubohcEIjn7tYkzG1w==", "906b9c28-97f7-4551-9b60-4e84529a6bce", "JohnDoe34" },
                    { "57eb8344-013c-4c62-a24a-925e2fe93d39", "5f3039f7-e7fa-4ef2-b36e-e2faa6e7c90c", "johndoe41@personal.gmail", "JOHNDOE41@PERSONAL.GMAIL", "JOHNDOE41", "AQAAAAIAAYagAAAAENUHlZKpKEeDKe6H2fuL9ln1i51S9c7WXBEKq+7tGCme9wLVocO9crG0WnJjJn9gMQ==", "666107f3-0748-4f5f-962c-4abcc86c4b6a", "JohnDoe41" },
                    { "58181f28-91f9-4a64-a3df-ef909f046b33", "c81c37dd-7479-44f3-8075-be4535cf2e5c", "johndoe1@personal.gmail", "JOHNDOE1@PERSONAL.GMAIL", "JOHNDOE1", "AQAAAAIAAYagAAAAEIZY+PVZwk0U8/Ftp4vsNvxTI8AjnarQotQoaUJiVoeHG3IxFxE7pCEpJPYLLjI5kw==", "85e366b2-9c7c-4151-836c-62a94cb17b9e", "JohnDoe1" },
                    { "67db0983-40c0-449b-b077-544d4885abac", "ff3d8b52-f0b9-4f0a-bdd4-aa75752bb7aa", "johndoe5@personal.gmail", "JOHNDOE5@PERSONAL.GMAIL", "JOHNDOE5", "AQAAAAIAAYagAAAAEB0riXLhJdW0yfnsDga1jU5L9SxSqxtPbSaphtnC3RIn2njpP6q8s0SadMP9oQ9JQg==", "28df6871-ed92-4595-8675-5191aa001f18", "JohnDoe5" },
                    { "684f3a7b-5ade-4c07-8c53-00aa790d8054", "03c14717-39f9-4cad-8a2e-bf8d3d8d53b9", "johndoe17@personal.gmail", "JOHNDOE17@PERSONAL.GMAIL", "JOHNDOE17", "AQAAAAIAAYagAAAAEEhvSxdC1Izuu0PcwB39Vaub3oWf/DpGm94eFYLUL/XFnj5RPDArSRJlv6lLgID1cw==", "fbd3c36b-84bc-4efb-a344-311e5816a477", "JohnDoe17" },
                    { "697dfeeb-677b-4d1e-889e-1df078918597", "a76db69d-ed9a-4a19-ab53-934e0ba4aa71", "johndoe38@personal.gmail", "JOHNDOE38@PERSONAL.GMAIL", "JOHNDOE38", "AQAAAAIAAYagAAAAEA4x9AK/QLuuJfEfwXyKXEJVS1W2bXhjOQlH3CqP016PwrqKo/7x5mqH1EgWfqb5Dw==", "7db35984-be96-4e52-ad92-d897a7741a8c", "JohnDoe38" },
                    { "6a8d59a0-0f17-432a-a049-af5c524d7abe", "e7af5bd1-c736-4106-bf22-e138cb8537ef", "johndoe50@personal.gmail", "JOHNDOE50@PERSONAL.GMAIL", "JOHNDOE50", "AQAAAAIAAYagAAAAEKkq7O8se7Zd+1P9nX6NAkC8r+BfLE8Yw+I3htsdISv+N0VxEr7smZeO3gA+dpNPIw==", "5ab2b8d0-bb48-4bb7-bd09-c0c4b699920f", "JohnDoe50" },
                    { "782d1e28-0c82-4dc8-b601-64865932fb9c", "25a1ef8f-0823-49a1-9610-8997929daab7", "johndoe21@personal.gmail", "JOHNDOE21@PERSONAL.GMAIL", "JOHNDOE21", "AQAAAAIAAYagAAAAEMs0AgWingbveWmlcMHCFYGcH7AK+i2Yb0kP825ax478EclU7opU30wBTcw/RcMYjA==", "b902004f-a6f8-450c-892a-993dda280c0d", "JohnDoe21" },
                    { "82a556f8-6d4a-4291-9d7c-49890d51ace0", "b3481f0c-b821-40d2-b634-d2c9b3c719d9", "johndoe23@personal.gmail", "JOHNDOE23@PERSONAL.GMAIL", "JOHNDOE23", "AQAAAAIAAYagAAAAEGV0PcYyQaZuEu0vjQwA9otSitAmfEVq/DXy7tdVjhcsphKJ/gU9qmXMHHhvhdOa0g==", "1d058c3e-9512-4e96-8eb1-dde174d12852", "JohnDoe23" },
                    { "92ac3120-4d66-4ecf-baee-130bfd5015ed", "e9bbac70-1231-4b26-84f7-7f79f7997cde", "johndoe22@personal.gmail", "JOHNDOE22@PERSONAL.GMAIL", "JOHNDOE22", "AQAAAAIAAYagAAAAEHb/7gUS+PdqRDgB3AjZbYpK/S5wPGcsg/SqnST1dCAWwB9cjHvddq/zFGhdp3ValQ==", "9dab455f-ef48-4f0d-9466-795d8a1dee70", "JohnDoe22" },
                    { "a732a1ac-8f5d-4a04-ba29-292878f48467", "2add984a-d76c-4bf8-8d48-6459ddd99322", "johndoe27@personal.gmail", "JOHNDOE27@PERSONAL.GMAIL", "JOHNDOE27", "AQAAAAIAAYagAAAAEG4J3pjKyPVpXVdHLR/8bVyssbSBkViYWQI6I5RI5ZlUpXvZH7RNJoSLe7F0RyvWpA==", "ba85f425-9ea7-4608-8aab-1a687327a369", "JohnDoe27" },
                    { "a77d7612-28ed-47a4-8c92-44bd14f76b8d", "2ac55d50-6279-45f3-a925-2fe944d92bce", "johndoe18@personal.gmail", "JOHNDOE18@PERSONAL.GMAIL", "JOHNDOE18", "AQAAAAIAAYagAAAAEKaCKCPWXQmvcfsGG3uaUO22tAxHTgPF1mOy+luuIXsg+tmprywwA7+HKQoeiT5+sg==", "d90b669d-6356-4cf4-8613-11d347e8ab3b", "JohnDoe18" },
                    { "ae16d477-0ce6-4ed5-aeb8-7475ea2a9d28", "d1f3b896-f16d-489d-ad04-1c5abb17af0b", "johndoe33@personal.gmail", "JOHNDOE33@PERSONAL.GMAIL", "JOHNDOE33", "AQAAAAIAAYagAAAAECjpB4Y4vlpXhEXouBqnNh7dXeZq/2jpD7QeKQ0JxI/5AQ2qMizcxIA+6/HtwX4Jhw==", "0c4e7e74-aeca-4ad9-87ef-ac476f461b18", "JohnDoe33" },
                    { "b064362a-c0da-4b6f-bd6b-126608bfee9d", "2799ccb2-8397-45fe-87ad-1fce963de483", "johndoe48@personal.gmail", "JOHNDOE48@PERSONAL.GMAIL", "JOHNDOE48", "AQAAAAIAAYagAAAAEOhhoW7xL1y1cOAv2AWRPVJQiceDzXIn4g8/OC7L7ZMiIcsMNKMWvVzRbqKtWD/Pbw==", "221dfca4-db48-4b59-aec6-c9b5d2d651b5", "JohnDoe48" },
                    { "b2a4de94-bfda-4610-8114-24402f2009c3", "dd64b84e-01b4-40ff-9289-7e62bfd86de4", "johndoe37@personal.gmail", "JOHNDOE37@PERSONAL.GMAIL", "JOHNDOE37", "AQAAAAIAAYagAAAAEB1xzAAa3xAHAl0BAXz5yL+C3s86BT9nk/rLmShYhNbkbIai2xefIG5KA1236U8+NA==", "169b4624-f3ac-4962-9f7e-ac181f6c95d7", "JohnDoe37" },
                    { "b82f8b82-4567-4326-8b62-d7356fe255df", "d43b7612-3822-4661-8ba1-976bc0aa1bdf", "johndoe47@personal.gmail", "JOHNDOE47@PERSONAL.GMAIL", "JOHNDOE47", "AQAAAAIAAYagAAAAELmPS0nXmrngbcXs7B6/rEnmZMmjmISlBQTTGNGl7NRFvYtyGO+n6QhLe5oAr3nEQA==", "73f5adeb-0f5c-4770-9734-a0e5458d84d1", "JohnDoe47" },
                    { "c63626b0-9fe9-4333-af7c-e763ad93ed38", "899c05af-333d-4bae-b589-d6830fe02dd9", "johndoe4@personal.gmail", "JOHNDOE4@PERSONAL.GMAIL", "JOHNDOE4", "AQAAAAIAAYagAAAAEERPwioCMQeBklbXnTBg0Eml1P4OBhOXXn6wux/VBbrqmXWax5KOy/KDPoVPb0gAkg==", "611a49b3-cd0c-45f8-9335-1acde08224ec", "JohnDoe4" },
                    { "cfd46f59-5307-40a7-a02c-a57085883d64", "4a89d96a-cf9c-4fbd-a0b7-dde60140adf1", "johndoe26@personal.gmail", "JOHNDOE26@PERSONAL.GMAIL", "JOHNDOE26", "AQAAAAIAAYagAAAAEDcljehmjdlEEK2GTioV7qvXJVB9QOEt9hMgb7bbFXUHK5p2nqveeEP8Eb1yoD4CGg==", "36f5a519-9712-4a2e-b2a3-87cf9af1e5dc", "JohnDoe26" },
                    { "d05295b9-3eca-485e-86c9-8fdf720ee39f", "962176cd-cbda-4e1f-bd99-3ac2fad9048e", "johndoe29@personal.gmail", "JOHNDOE29@PERSONAL.GMAIL", "JOHNDOE29", "AQAAAAIAAYagAAAAEHf2s8wRy/eYWuu5eVuLfytJDCnxPC9nTelSO9sYTWxfe+vVeyQiyLzNoCtsbw/nyA==", "390d3a1e-2d0b-4432-b021-823557d547c1", "JohnDoe29" },
                    { "d42868ec-505d-4c9c-83a6-4c10735fdb13", "493e1c87-c036-478c-901d-35f5e7cf8771", "johndoe7@personal.gmail", "JOHNDOE7@PERSONAL.GMAIL", "JOHNDOE7", "AQAAAAIAAYagAAAAEFCp2JFNilSMKZ/EaIfBfjEJQ4Pdl65BcnxRNwXwmkT5i8PDmj8D+Hnl1o+o6yBgOA==", "567c8ef7-2aec-4cd2-9513-da5dd82e7be8", "JohnDoe7" },
                    { "d5c0d689-46b4-46be-9a76-90cd6d6d18ad", "7f7ac8d8-1b67-4837-a350-33cb47dbcad4", "johndoe8@personal.gmail", "JOHNDOE8@PERSONAL.GMAIL", "JOHNDOE8", "AQAAAAIAAYagAAAAEDeX7PurO/iEYoIFCKN/kDPP8PXBPaKLUJkbdM1RlsPFJ0Q2o5ooLuruWWSGIXqj6Q==", "cc1c47ea-910c-4297-8bd1-4df837c7059b", "JohnDoe8" },
                    { "d8060eb6-81a4-46b0-9897-3f5ed97cc286", "3486998e-3fb9-4680-b0d3-933a664f8716", "johndoe46@personal.gmail", "JOHNDOE46@PERSONAL.GMAIL", "JOHNDOE46", "AQAAAAIAAYagAAAAEJgzWN2PqggRHw0F+A5UFS4JmztI8A4f03eqXq3NjF4kTpO1g4ILrPm6aVNdxZ2nSA==", "b99ba755-d78f-4aff-9a38-3c3883790252", "JohnDoe46" },
                    { "dcc38bd9-a063-4b5d-97e6-8620a437de02", "eb313c8c-6015-4ea1-b379-3a8bf9964243", "johndoe11@personal.gmail", "JOHNDOE11@PERSONAL.GMAIL", "JOHNDOE11", "AQAAAAIAAYagAAAAEGGloPXB87JczP68870nGY6mg/DKAgUIOeqjj6ptL/oMbzFO1fU2N4y9bXPcpSGfow==", "51ebeddd-5630-4071-9423-fb5e49b9e232", "JohnDoe11" },
                    { "dddd68cc-25bc-4b8d-a1f0-37a1a1229808", "8a6da0f3-e5a2-417e-89bf-bbc8ad0bd542", "johndoe10@personal.gmail", "JOHNDOE10@PERSONAL.GMAIL", "JOHNDOE10", "AQAAAAIAAYagAAAAEMvVQZep8/3G7W0E192RKBl1qGPqlo9ceMyJig7hSqmsTOMLNXcctUxKV/hgOlMPsw==", "8dc9500b-d544-4708-80f6-9bb4159710ad", "JohnDoe10" },
                    { "edb5265c-3efc-4b8f-994e-35cda8cb665d", "c71829fd-0b3b-4ab0-a362-bd83edad71cf", "johndoe32@personal.gmail", "JOHNDOE32@PERSONAL.GMAIL", "JOHNDOE32", "AQAAAAIAAYagAAAAEDik0zCD2x2QYusETY6I0Q80OpH2kNwb5DhutAImE/iwGKdiI8fEWNwxU4IH6s6t/A==", "a8212c12-f762-40ba-8c99-abab18141b63", "JohnDoe32" },
                    { "ef44e7db-09ee-4faf-879c-23bf88c6ea8d", "6800f0da-cd7e-40aa-896f-6a9488414bc9", "johndoe44@personal.gmail", "JOHNDOE44@PERSONAL.GMAIL", "JOHNDOE44", "AQAAAAIAAYagAAAAEKV4XJQQe/N/l3FEPTGrttkruPrzMK6c4MkJv58Dmj5sn34eAWLoGNGPEiUqV14ieQ==", "2e24e690-95a8-4914-b644-5e1af00090b4", "JohnDoe44" },
                    { "fb3d84e4-bbec-4e1f-8105-6d6eaecc4086", "ff5851e6-bba3-498c-9728-3d03a2c51c81", "johndoe45@personal.gmail", "JOHNDOE45@PERSONAL.GMAIL", "JOHNDOE45", "AQAAAAIAAYagAAAAEMXk3mErPBxCaxgfTwJym26ZT3J9eD/7MfiA1d0G9XdkVNQ7/FGdE6dZptamaRKraA==", "59a802f9-12c8-42b4-89e7-cb2ee29ee57c", "JohnDoe45" },
                    { "fca954eb-2eef-4190-904a-2580754b0ce1", "6c536684-3010-4ab7-a1e0-5a8b8f5f79cc", "johndoe19@personal.gmail", "JOHNDOE19@PERSONAL.GMAIL", "JOHNDOE19", "AQAAAAIAAYagAAAAEBK2nsBWqYOqN7Cbh1dsYklbrWpC4qOeYjqm46sexkC0MaOBMpm60ynyX65vDUeIzg==", "c7f37a7a-d7d6-4839-bcd4-b1b2584a667d", "JohnDoe19" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 3172.5m, "58181f28-91f9-4a64-a3df-ef909f046b33" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 6561.0m, "3942c37e-14a6-4538-95f7-126dfeafc253" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 3039.0m, "50c9665c-8633-4c52-a072-bf10848ed658" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 3634.5m, "c63626b0-9fe9-4333-af7c-e763ad93ed38" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 4071.0m, "67db0983-40c0-449b-b077-544d4885abac" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2484.0m, "1ceabc7c-ba50-40d6-a0fe-8590d2dbb268" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Auditor", 2078m, "d42868ec-505d-4c9c-83a6-4c10735fdb13" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Software Developer", 4215m, "d5c0d689-46b4-46be-9a76-90cd6d6d18ad" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Marketing Specialist", 2046m, "2bc94167-68da-4a53-914f-555414efc55f" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Business Developer", 4018m, "dddd68cc-25bc-4b8d-a1f0-37a1a1229808" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2589m, "dcc38bd9-a063-4b5d-97e6-8620a437de02" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Compensation Analyst", 1520m, "3961334a-7c0b-43b0-a0b2-46f06eca7b31" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Auditor", 2010m, "0a428d4b-58d2-47a5-b6de-6b2f3d88d847" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "System Admin", 4905m, "440f9a76-0591-4e51-8eb6-50c1bf7bf1b7" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Marketing Specialist", 2022m, "2cbc69fa-7041-4dc9-93b6-a564f485ff60" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Business Developer", 3093m, "37772433-4b18-467a-b5e2-0fc23508f973" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2718m, "684f3a7b-5ade-4c07-8c53-00aa790d8054" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1738m, "a77d7612-28ed-47a4-8c92-44bd14f76b8d" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Accountant", 2156m, "fca954eb-2eef-4190-904a-2580754b0ce1" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Database Admin", 4692m, "09e44e1d-4e72-4100-91ff-5d1b31ecb3e2" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Marketing Specialist", 2125m, "782d1e28-0c82-4dc8-b601-64865932fb9c" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Sales Engineer", 4514m, "92ac3120-4d66-4ecf-baee-130bfd5015ed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2864m, "82a556f8-6d4a-4291-9d7c-49890d51ace0" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "HR Generalist", 1683m, "3d50a9ee-44e4-444f-bec2-13d6029f670a" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2010m, "479a2b5c-7d25-4377-8644-4fa1ead05ea3" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 4727m, "cfd46f59-5307-40a7-a02c-a57085883d64" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Content Writer", 2168m, "a732a1ac-8f5d-4a04-ba29-292878f48467" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Sales Representative", 3682m, "05b27d59-860a-403f-b031-b1d71226b1c0" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Operations Specialist", 2584m, "d05295b9-3eca-485e-86c9-8fdf720ee39f" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "HR Generalist", 1585m, "0c6a1cd6-99ed-4ff9-a8e4-6847a8b5eaaf" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Auditor", 2102m, "4158f70b-8e4e-48f6-ba4a-ce57f4b37c78" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 4256m, "edb5265c-3efc-4b8f-994e-35cda8cb665d" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2132m, "ae16d477-0ce6-4ed5-aeb8-7475ea2a9d28" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 4049m, "51681ea7-f777-49a2-8d5e-9d807d1493f7" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Operations Specialist", 2957m, "022c36bc-8081-4159-874f-81c7f19ed56b" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Recruiter", 1517m, "0ec762e0-ec2b-41f4-9751-34c7dbc1fc6e" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2102m, "b2a4de94-bfda-4610-8114-24402f2009c3" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 4374m, "697dfeeb-677b-4d1e-889e-1df078918597" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Content Writer", 2198m, "099bf4d1-ec02-4a69-a1c1-c58d09428bcf" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Sales Representative", 3523m, "06a5680e-143b-454f-a58c-922b7806718c" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Facilities Manager", 2762m, "57eb8344-013c-4c62-a24a-925e2fe93d39" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Training Specialist", 1712m, "35a803ce-9d5f-4ce1-b343-de7edce5b2d6" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2099m, "2882aa57-8adb-48d0-a730-c8dff27e18f6" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Software Developer", 4796m, "ef44e7db-09ee-4faf-879c-23bf88c6ea8d" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Marketing Specialist", 2018m, "fb3d84e4-bbec-4e1f-8105-6d6eaecc4086" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Sales Engineer", 2272m, "d8060eb6-81a4-46b0-9897-3f5ed97cc286" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Supply Chain Analyst", 2620m, "b82f8b82-4567-4326-8b62-d7356fe255df" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Training Specialist", 1745m, "b064362a-c0da-4b6f-bd6b-126608bfee9d" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Tax Specialist", 2068m, "0fa79691-1937-45ee-8c0c-e2e1f25b0735" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "System Admin", 4642m, "6a8d59a0-0f17-432a-a049-af5c524d7abe" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3", "022c36bc-8081-4159-874f-81c7f19ed56b" },
                    { "3", "05b27d59-860a-403f-b031-b1d71226b1c0" },
                    { "3", "06a5680e-143b-454f-a58c-922b7806718c" },
                    { "3", "099bf4d1-ec02-4a69-a1c1-c58d09428bcf" },
                    { "3", "09e44e1d-4e72-4100-91ff-5d1b31ecb3e2" },
                    { "3", "0a428d4b-58d2-47a5-b6de-6b2f3d88d847" },
                    { "1", "0c6a1cd6-99ed-4ff9-a8e4-6847a8b5eaaf" },
                    { "1", "0ec762e0-ec2b-41f4-9751-34c7dbc1fc6e" },
                    { "3", "0fa79691-1937-45ee-8c0c-e2e1f25b0735" },
                    { "1", "1ceabc7c-ba50-40d6-a0fe-8590d2dbb268" },
                    { "3", "2882aa57-8adb-48d0-a730-c8dff27e18f6" },
                    { "3", "2bc94167-68da-4a53-914f-555414efc55f" },
                    { "3", "2cbc69fa-7041-4dc9-93b6-a564f485ff60" },
                    { "1", "35a803ce-9d5f-4ce1-b343-de7edce5b2d6" },
                    { "3", "37772433-4b18-467a-b5e2-0fc23508f973" },
                    { "2", "3942c37e-14a6-4538-95f7-126dfeafc253" },
                    { "1", "3961334a-7c0b-43b0-a0b2-46f06eca7b31" },
                    { "1", "3d50a9ee-44e4-444f-bec2-13d6029f670a" },
                    { "3", "4158f70b-8e4e-48f6-ba4a-ce57f4b37c78" },
                    { "3", "440f9a76-0591-4e51-8eb6-50c1bf7bf1b7" },
                    { "3", "479a2b5c-7d25-4377-8644-4fa1ead05ea3" },
                    { "2", "50c9665c-8633-4c52-a072-bf10848ed658" },
                    { "3", "51681ea7-f777-49a2-8d5e-9d807d1493f7" },
                    { "3", "57eb8344-013c-4c62-a24a-925e2fe93d39" },
                    { "2", "58181f28-91f9-4a64-a3df-ef909f046b33" },
                    { "2", "67db0983-40c0-449b-b077-544d4885abac" },
                    { "3", "684f3a7b-5ade-4c07-8c53-00aa790d8054" },
                    { "3", "697dfeeb-677b-4d1e-889e-1df078918597" },
                    { "3", "6a8d59a0-0f17-432a-a049-af5c524d7abe" },
                    { "3", "782d1e28-0c82-4dc8-b601-64865932fb9c" },
                    { "3", "82a556f8-6d4a-4291-9d7c-49890d51ace0" },
                    { "3", "92ac3120-4d66-4ecf-baee-130bfd5015ed" },
                    { "3", "a732a1ac-8f5d-4a04-ba29-292878f48467" },
                    { "1", "a77d7612-28ed-47a4-8c92-44bd14f76b8d" },
                    { "3", "ae16d477-0ce6-4ed5-aeb8-7475ea2a9d28" },
                    { "1", "b064362a-c0da-4b6f-bd6b-126608bfee9d" },
                    { "3", "b2a4de94-bfda-4610-8114-24402f2009c3" },
                    { "3", "b82f8b82-4567-4326-8b62-d7356fe255df" },
                    { "2", "c63626b0-9fe9-4333-af7c-e763ad93ed38" },
                    { "3", "cfd46f59-5307-40a7-a02c-a57085883d64" },
                    { "3", "d05295b9-3eca-485e-86c9-8fdf720ee39f" },
                    { "3", "d42868ec-505d-4c9c-83a6-4c10735fdb13" },
                    { "3", "d5c0d689-46b4-46be-9a76-90cd6d6d18ad" },
                    { "3", "d8060eb6-81a4-46b0-9897-3f5ed97cc286" },
                    { "3", "dcc38bd9-a063-4b5d-97e6-8620a437de02" },
                    { "3", "dddd68cc-25bc-4b8d-a1f0-37a1a1229808" },
                    { "3", "edb5265c-3efc-4b8f-994e-35cda8cb665d" },
                    { "3", "ef44e7db-09ee-4faf-879c-23bf88c6ea8d" },
                    { "3", "fb3d84e4-bbec-4e1f-8105-6d6eaecc4086" },
                    { "3", "fca954eb-2eef-4190-904a-2580754b0ce1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId");
        }
    }
}
