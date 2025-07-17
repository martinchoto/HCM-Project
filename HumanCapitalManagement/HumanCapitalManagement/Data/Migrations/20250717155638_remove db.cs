using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HumanCapitalManagement.Migrations
{
    /// <inheritdoc />
    public partial class removedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
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
                value: "68adc11b-f170-497a-b638-7dd448c097f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7d0377e2-0a41-4a35-add7-7833d0b790f7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "c0ac04fe-3694-4b6e-aff7-75b54d3f448b");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "8e26b9bb-7b46-40c3-8fc8-fbd6fe9a8a9d" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "60196d57-2732-4556-894b-f2b5609f3d87" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "d7abfc8f-0127-41b2-a4f2-95cbf92ed801" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "43231ac9-35f9-43e4-97b2-1540df38e6c0" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "4dc44674-0684-43b0-a952-cc082172b066" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "cb6d4329-ffaf-4085-b662-9766570d9cc8" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Auditor", 1000m, "f7441654-a602-4506-b2ef-47a91b9ecec3" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "cc48ee11-e34a-442b-a28b-fefef684e1a0" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "336b79d6-019f-4b48-9e8c-a04510feae31" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Business Developer", 1000m, "5dcd8aca-6f47-461e-903c-2364fcd683a4" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Facilities Manager", 1000m, "964daed0-a468-47ac-996d-a563b8425d4c" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Recruiter", 1000m, "eadc203d-19eb-4c32-9c73-24bfb5f55ab2" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Accountant", 1000m, "f4d51f84-ce01-4e08-8df9-7e69e8927c68" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "b22c75d7-8a62-4c7e-8ea4-14874f8f8bf4" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "14809f8c-758c-44a0-adab-fdc97efd3e53" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Sales Engineer", 1000m, "a0baba74-cebe-4d07-a04b-dfc9ff5161b2" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Supply Chain Analyst", 1000m, "0cc08ba4-fbb8-4eb7-ae22-0a4f2847ae1f" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "75ab1c0a-5fae-41d5-ab19-27c84c7d9c5c" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Accountant", 1000m, "b9e3146e-91b5-4e22-b89a-4f24b9bfc190" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "9f04f907-786f-4246-89aa-8461e1bd9a93" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "ac5d71ee-8fcc-4ae3-a083-e064b003ce79" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Sales Representative", 1000m, "eb6d2eb7-9de0-4e36-9979-61d7386ccf6d" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "911f2f71-ae3c-46fa-ac17-a84439f753a3" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Training Specialist", 1000m, "03ab8010-b248-4dab-9a41-559d28420223" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "6f0eb648-32af-4ca9-ad35-36f3be64361d" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "671bc962-e0b6-4978-9e0b-f8f9dfe6ba9f" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "SEO Analyst", 1000m, "f358e708-cf4e-404f-be67-bb08f1abab8b" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Business Developer", 1000m, "95c5ce35-bb57-4a1c-a46c-4dddf2d27f49" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "ebc12b62-e34c-44b5-81db-bd39c6266faa" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Recruiter", 1000m, "f21c8d38-01ad-48d0-823e-9bfc87cc0c3f" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Tax Specialist", 1000m, "41095bb3-be03-4acc-ba45-204d5d2bc979" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "System Admin", 1000m, "854a7fcf-b7de-4f98-8959-82b19e5f51d1" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "ffb4270c-015f-4b09-918c-7055eccaf56d" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Sales Representative", 1000m, "e23a01a4-d4e7-4ca1-8a34-feced727de45" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Supply Chain Analyst", 1000m, "98577e21-d7c5-43e1-809b-b897bd6e8d48" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1000m, "cfb51b51-97aa-4292-8236-ba00563744e3" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Financial Analyst", 1000m, "92b768b1-c160-4991-841d-61e786ce1f83" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "System Admin", 1000m, "adb79f8a-04cc-4320-a669-3527751fb661" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Marketing Specialist", 1000m, "0b288183-f4a6-4826-a55c-09ee2e774ae3" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Sales Representative", 1000m, "68a091f0-c52b-4e66-8708-063b647b0738" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Operations Specialist", 1000m, "8c6f5260-9cb7-4492-841d-94715ac68294" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Training Specialist", 1000m, "cc690ba1-2fb2-4b1a-a699-490f5663b3f0" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Financial Analyst", 1000m, "49dd9b3d-ad8d-4a31-be3e-cec276584193" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "System Admin", 1000m, "aa4cb9ff-b7f7-46f2-8427-9740e5964c2c" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Content Writer", 1000m, "f5146290-f855-462e-b649-cd7abb0e987c" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Business Developer", 1000m, "dda7bec6-43ae-4387-b6a4-6c21bac91243" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Supply Chain Analyst", 1000m, "34c335e3-e880-420a-9af3-b753225d8db4" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Recruiter", 1000m, "e32adeae-2de5-4679-a944-ceb9ef19f154" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Auditor", 1000m, "563d2cae-cb0a-468c-9ad9-9b9f5ac67521" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Database Admin", 1000m, "0c884718-abe3-4396-9fa3-ff5adabc48c1" });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

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
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 4459m, "ede19227-19da-4fec-beda-b850b6e7ab32" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2122m, "15eb705f-2cfd-4f5f-a968-fcfd0f03ed2f" });

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
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Supply Chain Analyst", 2829m, "e5bf254d-d447-47a6-b954-da6f5387fd99" });

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
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 4823m, "79dff8cb-f4c4-46b3-8f45-d3a5d391df63" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2139m, "bac88557-3c4a-479f-aca6-6581b7a8b277" });

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
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Facilities Manager", 2844m, "a0eb4e7f-8412-4df6-b5f2-1e792c42f300" });

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
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 4229m, "cbdc9fbe-cef2-46a9-ac15-48ace5910dfa" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2149m, "dbef78ce-687f-4011-89fc-3e0456745f6b" });

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
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 2949m, "3e31cd67-e9aa-49f0-911b-6d96c855b8cf" });

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
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Database Admin", 4350m, "88ae37bf-3708-439a-a634-100418cfbb46" });

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
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Sales Engineer", 3070m, "aa74bd83-2bdc-4a51-bd29-02f05d1ef82c" });

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
                columns: new[] { "Salary", "UserId" },
                values: new object[] { 1646m, "aad09454-bf66-4dc8-ab1c-4e145da36b46" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Auditor", 2072m, "09459024-e5a6-444e-bbbe-e94700ddcee7" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Network Engineer", 4098m, "b11cc300-81bb-46dd-ba40-27e533501b67" });

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
                columns: new[] { "JobTitle", "Salary", "UserId" },
                values: new object[] { "Tax Specialist", 2060m, "c8343387-5046-4233-9990-5cefd61ce6ad" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
