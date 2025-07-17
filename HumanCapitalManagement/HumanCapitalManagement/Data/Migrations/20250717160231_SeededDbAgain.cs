using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HumanCapitalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeededDbAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "74f1f99a-0e65-446b-b47f-bcf84d854b1d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "b55e7f94-56e4-4355-b09d-591d6b80d91b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "65198b62-10b9-4760-a95c-6836821e1a18");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[,]
                {
                    { "003fbf32-bc9f-47e3-95cc-69f026437353", "5a145b81-2d01-48c4-ac3a-950f0a234e7a", "johndoe21@personal.gmail", "JOHNDOE21@PERSONAL.GMAIL", "JOHNDOE21", "AQAAAAIAAYagAAAAEED+aRHxcXJc8d4vbmhIREuA5dTz7O6TXs/O4rwcQiW1saPteKvB0d+euJGskq4F9Q==", "57e86ac1-82de-4c01-93ca-693553ac3d76", "JohnDoe21" },
                    { "03d2df2f-2b82-47f5-a4cb-b902983e27d7", "fbc0826c-93a0-47d6-9386-43123bbbecff", "johndoe9@personal.gmail", "JOHNDOE9@PERSONAL.GMAIL", "JOHNDOE9", "AQAAAAIAAYagAAAAEJ4BvMKRsvcYWuX3+rb5kIWVtGETyHTy+rmo9c+hQSTAZ5+6dbuw76M+NdLXT9Wg7g==", "b08b02d8-cde0-4ed4-a95c-d121abaad18f", "JohnDoe9" },
                    { "06b45b7c-0ce5-4ae1-b22c-c49048bf1ee0", "89c7d39a-2ea3-4ef0-8236-cd0e24817ba2", "johndoe43@personal.gmail", "JOHNDOE43@PERSONAL.GMAIL", "JOHNDOE43", "AQAAAAIAAYagAAAAEFVYwM6dYrSx6HPKYyr7N6GICyLFo/W56QHWhiNQlWqgQP46iRc5aXvfn0WyhOUrAg==", "c0d2dc84-ba7a-4a9e-b3bd-9b4ca9ec3269", "JohnDoe43" },
                    { "08431c71-0402-4723-9eb4-ceaf5f0b691c", "17a33af6-328e-4f40-9608-e83ef44c80b6", "johndoe10@personal.gmail", "JOHNDOE10@PERSONAL.GMAIL", "JOHNDOE10", "AQAAAAIAAYagAAAAEMcOWuHQg2IBBd7WB5eH9Cf58FATazVbfuZK5UhTwRkFMyBFUZ0+MvCUhZn4ULmlmQ==", "caaaff43-8375-4482-910e-00895a91f58a", "JohnDoe10" },
                    { "10ebc514-f8d2-44cb-aa74-9bf59e51d23d", "cf2b9e4a-abd6-4644-8564-c941d6d6652f", "johndoe17@personal.gmail", "JOHNDOE17@PERSONAL.GMAIL", "JOHNDOE17", "AQAAAAIAAYagAAAAECt50dhnXk2EVK7JBqW9t+DJepNcD2Cs2i4YcQJXmGZSDRjFMCkfQHtS/QrJO0X/2g==", "3d4c7f85-f504-4d49-8497-d38212ce0752", "JohnDoe17" },
                    { "1390a1b9-ae19-4b47-ab5a-0f5ed9d5bc28", "8749ac49-c002-4d89-8e0e-16636bd8f65b", "johndoe49@personal.gmail", "JOHNDOE49@PERSONAL.GMAIL", "JOHNDOE49", "AQAAAAIAAYagAAAAENVAhXAMNFapO3QZkzEbj8PYch5xqCgxLinYWM9x7pyr4c6AjZ1Gz3mzDVRcgocmZg==", "b701bdf7-98bc-493d-9665-6c8df1819206", "JohnDoe49" },
                    { "1918af0e-eb9b-42b4-b4f0-668ac161a7e4", "57837603-45ea-4b70-a0a6-4b42c336ac7a", "johndoe18@personal.gmail", "JOHNDOE18@PERSONAL.GMAIL", "JOHNDOE18", "AQAAAAIAAYagAAAAEBzvD6CqKsF03HSGPlhmxbpICGZ6j5URJ3oBb1DZmEpsI0GYp0/AD4alh2Yqg/nqRQ==", "7e55b3e5-613a-4c69-ae2f-fa146d39e81d", "JohnDoe18" },
                    { "1e64def5-b5be-45f7-8f75-36c2a84cc4a0", "45eddbf1-69d6-4b8e-9672-3626a04086c5", "johndoe4@personal.gmail", "JOHNDOE4@PERSONAL.GMAIL", "JOHNDOE4", "AQAAAAIAAYagAAAAEH0fE4OsatArH1W9hw7nqBg3u7PwuQ2ELpJW6H23Fh0D5Lq5kH3lgy88k7Dbr89/xw==", "508ed0e3-dfaa-405a-8360-21e9abfa5d88", "JohnDoe4" },
                    { "1f7b8188-0e7c-4764-a453-7b3dfb396dda", "319d5319-1c30-47d4-9c7f-08c43a7eb6ac", "johndoe2@personal.gmail", "JOHNDOE2@PERSONAL.GMAIL", "JOHNDOE2", "AQAAAAIAAYagAAAAEGz6cXQmW9Q4M3VrLR56EzLr7rNeVKPVZat9ttPQy8J5VsMOqV36NO8iPUDWCNwmdw==", "c9462029-d19b-4a22-bf75-d1f48ddeb1ab", "JohnDoe2" },
                    { "2cc909ea-29bb-4eeb-84fc-90cd4abbdc5d", "5fc9ebad-bd05-4925-a204-1779c6d91473", "johndoe14@personal.gmail", "JOHNDOE14@PERSONAL.GMAIL", "JOHNDOE14", "AQAAAAIAAYagAAAAEB6S/HHwZbGyg7l6mOYOGr/qvdCuTM7hONliDxe0Q9TLaWYZj5KPoeNrSVwmS+2Hag==", "0d994f91-ad77-47a1-8c76-701080faa459", "JohnDoe14" },
                    { "375e73d8-865d-45bd-bf29-4a3c769107fc", "b492c363-d27a-42ce-b36f-e7808d5a3587", "johndoe36@personal.gmail", "JOHNDOE36@PERSONAL.GMAIL", "JOHNDOE36", "AQAAAAIAAYagAAAAEDsm2+2dCN8HzdLgURicj1gMBtslht47nxXm2OPckOdi69bg3ONoyPIIrDDKhYYnrA==", "fe91c580-616f-4c46-adc6-68014adee63a", "JohnDoe36" },
                    { "4049d633-303e-43df-be36-9ed75daf55a0", "9283a0d3-3cb1-4b74-99eb-1fd051885f51", "johndoe20@personal.gmail", "JOHNDOE20@PERSONAL.GMAIL", "JOHNDOE20", "AQAAAAIAAYagAAAAEFBUrejX4p3LAwnm6Z3bDWgbCEtByYr9/qm93eyKDrsWta+wIkuvb/DdKl+B8BUu8g==", "8cc68dc2-d96b-4890-a3f2-87d95ca2d679", "JohnDoe20" },
                    { "454f813d-08d9-48eb-8f4f-db046fb742f8", "4e07c1ed-500a-4887-a6b2-123e3bec8aa2", "johndoe32@personal.gmail", "JOHNDOE32@PERSONAL.GMAIL", "JOHNDOE32", "AQAAAAIAAYagAAAAEAGlECe22CmC21O0ZzNnU1uIkL8Wru0yoKlhy4mVBr+EaNGKzw8jlrStuuTu1QKncQ==", "11e29a74-20c0-4469-a54b-1633a73b63ed", "JohnDoe32" },
                    { "4f499d5c-4f35-46aa-b921-c1f797dbbcc2", "6e62f99f-5cae-43ac-b073-e8f97ccf9090", "johndoe38@personal.gmail", "JOHNDOE38@PERSONAL.GMAIL", "JOHNDOE38", "AQAAAAIAAYagAAAAEOmNLSldteXJ19hXi6jhc6OQEw31xdRU9ZDkWcQR0GP7h4XvsUpJvTilFZ3hfcxVvw==", "e61aa120-cb69-4f03-ad56-61b785ab7673", "JohnDoe38" },
                    { "4fa52168-45f9-405c-aee5-a198c6d7b29e", "4eacb302-55c4-4055-b3b3-ed85d4334d33", "johndoe24@personal.gmail", "JOHNDOE24@PERSONAL.GMAIL", "JOHNDOE24", "AQAAAAIAAYagAAAAEOrJe9WFJYVJEZGR/EZASn+MtYi25QSbVhkR9X8SiCTOm82cxNoP3Em8j8x2Rbn8Zw==", "f2b6d412-8571-46e8-8e8e-36c1ef1b8bd6", "JohnDoe24" },
                    { "50dd659a-5c61-40bc-bb9b-938bb656251a", "d5bf356f-9320-4a34-98ad-20616eccce18", "johndoe7@personal.gmail", "JOHNDOE7@PERSONAL.GMAIL", "JOHNDOE7", "AQAAAAIAAYagAAAAEJ5afttZx0L7Mz6hegrNMQQ57P0OsHeekDR40I7jRxLPy8ate8C1CzUbJF+KM8c4jw==", "a0f87ede-814b-45c5-872b-c6307c4011b2", "JohnDoe7" },
                    { "52f3a972-a5d6-41fa-8c5e-f684a0770235", "ef87516e-cd63-48d5-ade5-4f8e025652e3", "johndoe46@personal.gmail", "JOHNDOE46@PERSONAL.GMAIL", "JOHNDOE46", "AQAAAAIAAYagAAAAEL70lTmZsX9S8Y2eXPP2iv34Rs2kUs1r390QuC71dpPBDm/lPtbOYMwLAgsWezrq6Q==", "37ae45af-a646-4d55-89cc-0181b70d61b8", "JohnDoe46" },
                    { "5da6430c-eac0-433d-a4c2-427fa40a937e", "f3df1ee4-352c-4176-b406-3456a615acd4", "johndoe22@personal.gmail", "JOHNDOE22@PERSONAL.GMAIL", "JOHNDOE22", "AQAAAAIAAYagAAAAEMB3gDADywhEVyujCQiZH6xEuHMpM8/DVL2uhC71RXX8qZsxsFBJ4xd0IdsoIlYUSg==", "de21e002-0d39-40da-a3a3-82c4c35b38fb", "JohnDoe22" },
                    { "600dc378-22f7-4cee-8c1c-56a0411c1560", "bd0ea42f-2b6d-43dd-bb8a-f4eea6f4ef32", "johndoe37@personal.gmail", "JOHNDOE37@PERSONAL.GMAIL", "JOHNDOE37", "AQAAAAIAAYagAAAAEKJm7gOWBAmwmdR3zEmaBli8xlJEXb+cnI+oUJkDjwZo2unmod+R2vsDrrpfOovLUA==", "a450443b-bdcc-45d2-bda6-e6b339d9d1b8", "JohnDoe37" },
                    { "63583698-0976-493d-86dc-f862c471f36f", "bb0cbf39-adae-430d-92e0-672218755650", "johndoe45@personal.gmail", "JOHNDOE45@PERSONAL.GMAIL", "JOHNDOE45", "AQAAAAIAAYagAAAAEAAlVM5tq5RIIM3ikcpopHWH8OOnmyp99RrMsZwCeFxeVInud2Wa44Mkn9U7iifIXw==", "b646666e-809c-4140-9816-68d58f878fb2", "JohnDoe45" },
                    { "64566c45-5a21-4f9a-a074-7719a36d719e", "8f237a57-feab-4f45-a341-329398a027e8", "johndoe3@personal.gmail", "JOHNDOE3@PERSONAL.GMAIL", "JOHNDOE3", "AQAAAAIAAYagAAAAECHPcv5poaDXb+6lPdXEeB8Uqm+9lshE5YUIRfoNYp3udDLZGj++np97BVkJJZLZ3Q==", "01302b7a-b2f3-4141-9ea4-9e0f7e6966ef", "JohnDoe3" },
                    { "75ee5357-ff22-4147-9969-c292aa655614", "3e0a946f-3ec7-42aa-90d3-a062cd01b649", "johndoe13@personal.gmail", "JOHNDOE13@PERSONAL.GMAIL", "JOHNDOE13", "AQAAAAIAAYagAAAAEI4aqs+gYwp580p5Ue1+bXwYHMbNCNFXEMfWnjrGf1AjlhoBvZRwFXu2oDuWZu3f4Q==", "f8a4db76-48e7-42fb-9b5d-7a00651a5d2f", "JohnDoe13" },
                    { "7a855d4d-897f-4f23-b2e5-a0c1d4000b50", "020bd9fe-dbd8-4055-a5da-89a1c16b020d", "johndoe41@personal.gmail", "JOHNDOE41@PERSONAL.GMAIL", "JOHNDOE41", "AQAAAAIAAYagAAAAEDjMMOZvIVko/WG+WfUjo7QJEeA2EkgTRWQUazPxp22ILlkbSbMB8Nz5aGd65tmxZw==", "4f11d58a-a256-4d73-b2fb-3a9a95b201c3", "JohnDoe41" },
                    { "7c2c59f6-0d6f-4d8b-a913-d57ba217ecd3", "b9e85fb5-bc25-45a9-9f6a-3a919d17a1f3", "johndoe15@personal.gmail", "JOHNDOE15@PERSONAL.GMAIL", "JOHNDOE15", "AQAAAAIAAYagAAAAEIPzT2jxesXtU+A1WlmwnZUr8Qa3qhxOYvzGKZNyHPWiu8fY9S/Uuf+Up+n3mUB7dA==", "80244bd6-18c4-4ceb-a68e-4d460023a2b9", "JohnDoe15" },
                    { "811863c7-ba6c-49b3-91b4-357d29a9f559", "f2e185c4-e0ca-4b91-b068-94c43e61fa53", "johndoe16@personal.gmail", "JOHNDOE16@PERSONAL.GMAIL", "JOHNDOE16", "AQAAAAIAAYagAAAAEFrsL45h5bVBw5QMqg/mWHsMT01apVkQP3s/fqpii9WN0x0R8zeGAt61VgIUB+Eqvg==", "e8ff4a8f-ffd7-42f6-85e0-669943f4b2f0", "JohnDoe16" },
                    { "8534c31b-00ba-4308-82b8-b8aebd523c03", "90ff8b38-425c-4850-9618-e3b4b4d0db6f", "johndoe35@personal.gmail", "JOHNDOE35@PERSONAL.GMAIL", "JOHNDOE35", "AQAAAAIAAYagAAAAEGawPX7y1bV1JjUQOQlHu7Tm228zFRDm1dVDcrXa3jldHJ2AhIiyDWC1oP3MfKNVeQ==", "f4ac85b9-ab68-4875-9dcc-84c4d9a5f61f", "JohnDoe35" },
                    { "8f56f664-b90d-4881-b228-6d48672ea436", "f2145f01-2089-4f2a-b435-b8bf078b9af0", "johndoe40@personal.gmail", "JOHNDOE40@PERSONAL.GMAIL", "JOHNDOE40", "AQAAAAIAAYagAAAAEMzdpicgw63ZOuLks/IYqlUlQG/cZ4y9VdGh497nLU5LDtBEm6rIoMNKYCpBp/ovBA==", "852665ec-6a66-497f-87cd-c3f2aeb56a5c", "JohnDoe40" },
                    { "97405820-3645-4509-9519-5dcf956dab91", "d23e0ff4-4959-493f-a932-4f983b444615", "johndoe47@personal.gmail", "JOHNDOE47@PERSONAL.GMAIL", "JOHNDOE47", "AQAAAAIAAYagAAAAED+j/wwYZbOZAvgylPAc0N409dI7KZkSglQAyD0uB7AF6HV7ITYRra72RkkOczM10g==", "5258002d-c7fd-4993-81c8-b9dd6da19e53", "JohnDoe47" },
                    { "9df12ac9-105f-4f8e-bd62-f09295e227f3", "9fa28b8d-1bb3-409a-8135-9313336e5c3f", "johndoe29@personal.gmail", "JOHNDOE29@PERSONAL.GMAIL", "JOHNDOE29", "AQAAAAIAAYagAAAAEJfD4RPWqBej/LQdTISfqIYMP3eiCHhmGUyLCtGPH4mATmbFaTvzvyxa5xeaVQyBTg==", "18e77fd5-ec9f-418a-9986-48b21d84a658", "JohnDoe29" },
                    { "9e6b0919-fd9c-4a2c-ac57-8035d1c4b22d", "ec1d95a8-7f59-40bc-b7b9-772895767e4f", "johndoe27@personal.gmail", "JOHNDOE27@PERSONAL.GMAIL", "JOHNDOE27", "AQAAAAIAAYagAAAAELqY7g6COVB/YbSqYmUKQ1ZS+sLo6NCJbhE4FjgDrGmKFTWc6HfFgH5vfVrjz6iMFQ==", "35f5b111-ca2f-455d-ba41-637a9a7bdf22", "JohnDoe27" },
                    { "a25c0148-7e24-4f5f-bbb1-d68b08f81775", "c08c31a7-8bbf-48f9-947a-99e9b9c008fc", "johndoe31@personal.gmail", "JOHNDOE31@PERSONAL.GMAIL", "JOHNDOE31", "AQAAAAIAAYagAAAAEJeK7bXABfXqnscwgvd5g2jMB0zAuDTrkmMqA4mtg9ZX39BGLG++WyuRHDEU2epJnw==", "19b45a39-7be7-411f-99f6-fb0c7ba4fbf2", "JohnDoe31" },
                    { "a5c15c79-e6e2-4f27-b9c2-a6c7a75a4af5", "0bff92b6-eedd-4951-8c05-b7c0223b9eb1", "johndoe39@personal.gmail", "JOHNDOE39@PERSONAL.GMAIL", "JOHNDOE39", "AQAAAAIAAYagAAAAEMTHCQbHHBXd/dcI693z+m2xDWDyXxNkSMvWw7opj98Z4RJJszsyWFzJU5ByLEW1Bw==", "5af0f075-0cc4-4631-a107-14e86bafd2a7", "JohnDoe39" },
                    { "a634b94b-02d6-4480-9ee5-f133e7fb97c4", "4e818ff1-4465-4cfa-b312-aac5181cc1c3", "johndoe44@personal.gmail", "JOHNDOE44@PERSONAL.GMAIL", "JOHNDOE44", "AQAAAAIAAYagAAAAEE2xNm4jfiL8wnYxSZmsWRj7e4T0TPilr+Bjp6GNFyeZqa6vUuA7t+ya4tTVO7Wl9w==", "8997ac47-f408-411b-90b3-7793b8be9691", "JohnDoe44" },
                    { "aa6823c8-854f-46f9-af6e-9aa3a1674f62", "4e25402f-cca4-417b-92f1-036622cb4377", "johndoe50@personal.gmail", "JOHNDOE50@PERSONAL.GMAIL", "JOHNDOE50", "AQAAAAIAAYagAAAAEMo2IytCiUJkPbzyIw1EcwswnAZYn9WzPxWQs60acYI7nq90M2U6UVD2oOmD2WcF+Q==", "6da1ccbf-623a-48d6-b253-76ed4a02fbe1", "JohnDoe50" },
                    { "af1f1382-3d0a-404e-a479-44941fbcdb67", "1830cb28-d1dd-4504-a2bb-cd47a01209bc", "johndoe33@personal.gmail", "JOHNDOE33@PERSONAL.GMAIL", "JOHNDOE33", "AQAAAAIAAYagAAAAEH8PSrMYch0gqAjlNCd/jTWObAAh1rh7xm/NnnBylmKZ48iSbEiTd1JGODVa+tR9DQ==", "d6baa66b-1f10-4df7-8889-8f33b1739302", "JohnDoe33" },
                    { "af4820c9-c023-40e6-ac3c-32915ed3a7e5", "e91b6ad5-298f-47ab-bb70-a91fc5d5bc28", "johndoe6@personal.gmail", "JOHNDOE6@PERSONAL.GMAIL", "JOHNDOE6", "AQAAAAIAAYagAAAAECQiAZeQQH7TdZPqSWzm1rXketyg6PcFf5nzeHJ2iY47hFi7ndFxiQ3Akg4wDr2EjQ==", "4489e0a0-4a31-440a-afa2-936c900087ad", "JohnDoe6" },
                    { "c0d00f17-d7d8-4f79-98fb-80f8db38a1fe", "1b1a65e2-7ee1-495b-982b-70dcdd833770", "johndoe25@personal.gmail", "JOHNDOE25@PERSONAL.GMAIL", "JOHNDOE25", "AQAAAAIAAYagAAAAEBAKBNCkXtueG7kaTkt17kCG19k27Nm6KR7DuC8di2PL0EAwiBj/Z7Bgl+B1aYg7Cg==", "141102d4-c930-4c57-be16-ba54e81d4deb", "JohnDoe25" },
                    { "c3d80974-4f53-436d-b258-562cccbb5911", "bdfb2103-1ba1-48ef-90be-eca268fbe595", "johndoe12@personal.gmail", "JOHNDOE12@PERSONAL.GMAIL", "JOHNDOE12", "AQAAAAIAAYagAAAAEHCazXFtZTzd0VIoDVEbkGUxfdmNRrdLldaeY/tit4sJ0lYNJhRfxOkvVayrQFBZnw==", "32a83758-c9a3-4ca7-a5fb-ddafb0b5e55e", "JohnDoe12" },
                    { "c9cc4223-eee3-4826-92fa-b774c4c608a3", "1a434772-5fba-4259-8401-b4d2c348996b", "johndoe1@personal.gmail", "JOHNDOE1@PERSONAL.GMAIL", "JOHNDOE1", "AQAAAAIAAYagAAAAEFZN+NtQDPYfmtvWllSbqbtg6iFF71p2IZPMgTI5khlc0xcHqZa1rRKOCIZ5kdfk/Q==", "544b1c81-523a-4034-88bd-a0660328e583", "JohnDoe1" },
                    { "cabb8b7e-9ca8-4673-9da1-e0a5d25aebe3", "56137324-c014-4eaa-a74d-89e5ce1b41da", "johndoe23@personal.gmail", "JOHNDOE23@PERSONAL.GMAIL", "JOHNDOE23", "AQAAAAIAAYagAAAAEGAJkskxH8pbxVZHdz//2x+xCNn3CHYZd8v5JppCrN7aT+LcdH9bzj67WrqdrdJnZQ==", "b4392a7b-15c5-4f4a-86f9-d03f5f7f5499", "JohnDoe23" },
                    { "ce98b90c-6807-42a1-901f-9b5a37ae9b0f", "3358a880-1f1d-4ce7-8577-2cc57406e1e1", "johndoe30@personal.gmail", "JOHNDOE30@PERSONAL.GMAIL", "JOHNDOE30", "AQAAAAIAAYagAAAAEKFhup7xO4gnkceqvbSPCaIujuk+UY272hpWpTs6X7Zz8FMqhAzBMetR1aahYNW19g==", "fc3de848-9da8-40e2-bbe8-261a6f9de9ca", "JohnDoe30" },
                    { "d04f0de8-0c22-4d56-9545-552bbba6c4a9", "cc4fc7ba-3eba-4db8-8dd3-4b1517ea5db0", "johndoe8@personal.gmail", "JOHNDOE8@PERSONAL.GMAIL", "JOHNDOE8", "AQAAAAIAAYagAAAAEDuDCzHWo61j5yj3oqH8gDGqLKeTgoQ488xF3xiRujkOdgb8bLMvZnskn5iQ5Bv3CA==", "7c851a03-0bc2-4d2a-ab08-58cab6bff500", "JohnDoe8" },
                    { "d4d9beae-bd9a-4e69-ba80-0f6df463048f", "e6d996ad-0122-405d-ac27-f8241c8e84e8", "johndoe19@personal.gmail", "JOHNDOE19@PERSONAL.GMAIL", "JOHNDOE19", "AQAAAAIAAYagAAAAEKmvcFRsFmL/E5hf4NfbFn3S9gQbzZgG7jDK9wZIFW7yHX+q0EDlVOxelgFoJEv6jw==", "eb99b75a-1069-404a-abc1-b8a44afdea87", "JohnDoe19" },
                    { "d8c8aabe-e15d-464d-9ce5-23fd418a330a", "c63ae02d-fa22-43c2-a7eb-337aac99d540", "johndoe34@personal.gmail", "JOHNDOE34@PERSONAL.GMAIL", "JOHNDOE34", "AQAAAAIAAYagAAAAEDNLUyhFUL5Gofilge17gpiH1tHLSyZattiaCSzOJsMw9R8Fe4KFyn2R2eofARkVvw==", "8f884a79-25e4-4676-a901-97e736e717c9", "JohnDoe34" },
                    { "d990afdc-96c1-406f-8b62-d8e0a1c0f676", "b2343fd2-5711-41b5-85e2-8f0350fb7d4a", "johndoe11@personal.gmail", "JOHNDOE11@PERSONAL.GMAIL", "JOHNDOE11", "AQAAAAIAAYagAAAAENHgZhSNsJt5vplKdYIoZbo/DjXAMXweEuka5WffKhfZ9AwbSTzM1LtroVp5YgoadA==", "3de6d414-b79c-4ab6-b20e-b7aa6db9f0a4", "JohnDoe11" },
                    { "db7aa3da-3c17-4f6c-94bc-898c08b14009", "591e4c80-5171-4755-aecb-f4dcfc062221", "johndoe28@personal.gmail", "JOHNDOE28@PERSONAL.GMAIL", "JOHNDOE28", "AQAAAAIAAYagAAAAEIiMUhm0mCAEptK1ZJA8W4p1wtrMnaC4wZsjffQDtuvF8Mt6YpAMiZ5B0PAw0VqO6w==", "affa6f48-057d-48b7-a63d-7ba7690b81ae", "JohnDoe28" },
                    { "e150cea2-ef1d-4f95-aea1-207cc74bd3e5", "340d93b4-4588-4080-bcba-d8687a6f9d53", "johndoe48@personal.gmail", "JOHNDOE48@PERSONAL.GMAIL", "JOHNDOE48", "AQAAAAIAAYagAAAAECKrDDAYrIZzysp+qZaHT3joCV5BMUtB/UhuFC3Q/pnGiOYYJnSYOWLERlSQv9CLJA==", "06ec2cd1-a2a4-40a4-9528-0a7b4df8a185", "JohnDoe48" },
                    { "f1df7b6c-af5e-4d0a-9d20-510088708682", "f7afbf96-8d22-455d-9fdf-0b4595105df2", "johndoe5@personal.gmail", "JOHNDOE5@PERSONAL.GMAIL", "JOHNDOE5", "AQAAAAIAAYagAAAAEKl/jgyAmTSf5yogrWQOvmE90EEO2GjIH0XAIL/dSdXblTXcf6TPHYJHMnyzfi7vug==", "d961d972-44cf-4410-9ca1-ec0dc8a64eb8", "JohnDoe5" },
                    { "fd01736c-538a-4d84-9c2e-6f9479493fa1", "e7a5c25b-f212-4c87-88f9-774aed1201fb", "johndoe42@personal.gmail", "JOHNDOE42@PERSONAL.GMAIL", "JOHNDOE42", "AQAAAAIAAYagAAAAEJawIIMt3E5Y6ytBNYELW2p64pIuKiAAs/KCa7cDw90Pvf2JaMoaG8qAKocPFIgS0Q==", "33e66a6b-c8e9-49d3-a5ef-5b28739d0374", "JohnDoe42" },
                    { "fdacb9cb-2d8b-496a-bc6c-122aacd910d7", "c8175451-7e86-46e9-8cea-14241d032813", "johndoe26@personal.gmail", "JOHNDOE26@PERSONAL.GMAIL", "JOHNDOE26", "AQAAAAIAAYagAAAAEAwIyfFJfEBv/3Jvzlj7n1SsfNuu+Kq6xNok1XG9lO5jImaaZC6wB85Usj8L9tYokg==", "86ba2fb5-e5ed-4fd3-8683-dd42dba38a4a", "JohnDoe26" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3", "003fbf32-bc9f-47e3-95cc-69f026437353" },
                    { "3", "03d2df2f-2b82-47f5-a4cb-b902983e27d7" },
                    { "3", "06b45b7c-0ce5-4ae1-b22c-c49048bf1ee0" },
                    { "3", "08431c71-0402-4723-9eb4-ceaf5f0b691c" },
                    { "3", "10ebc514-f8d2-44cb-aa74-9bf59e51d23d" },
                    { "3", "1390a1b9-ae19-4b47-ab5a-0f5ed9d5bc28" },
                    { "1", "1918af0e-eb9b-42b4-b4f0-668ac161a7e4" },
                    { "2", "1e64def5-b5be-45f7-8f75-36c2a84cc4a0" },
                    { "2", "1f7b8188-0e7c-4764-a453-7b3dfb396dda" },
                    { "3", "2cc909ea-29bb-4eeb-84fc-90cd4abbdc5d" },
                    { "1", "375e73d8-865d-45bd-bf29-4a3c769107fc" },
                    { "3", "4049d633-303e-43df-be36-9ed75daf55a0" },
                    { "3", "454f813d-08d9-48eb-8f4f-db046fb742f8" },
                    { "3", "4f499d5c-4f35-46aa-b921-c1f797dbbcc2" },
                    { "1", "4fa52168-45f9-405c-aee5-a198c6d7b29e" },
                    { "3", "50dd659a-5c61-40bc-bb9b-938bb656251a" },
                    { "3", "52f3a972-a5d6-41fa-8c5e-f684a0770235" },
                    { "3", "5da6430c-eac0-433d-a4c2-427fa40a937e" },
                    { "3", "600dc378-22f7-4cee-8c1c-56a0411c1560" },
                    { "3", "63583698-0976-493d-86dc-f862c471f36f" },
                    { "2", "64566c45-5a21-4f9a-a074-7719a36d719e" },
                    { "3", "75ee5357-ff22-4147-9969-c292aa655614" },
                    { "3", "7a855d4d-897f-4f23-b2e5-a0c1d4000b50" },
                    { "3", "7c2c59f6-0d6f-4d8b-a913-d57ba217ecd3" },
                    { "3", "811863c7-ba6c-49b3-91b4-357d29a9f559" },
                    { "3", "8534c31b-00ba-4308-82b8-b8aebd523c03" },
                    { "3", "8f56f664-b90d-4881-b228-6d48672ea436" },
                    { "3", "97405820-3645-4509-9519-5dcf956dab91" },
                    { "3", "9df12ac9-105f-4f8e-bd62-f09295e227f3" },
                    { "3", "9e6b0919-fd9c-4a2c-ac57-8035d1c4b22d" },
                    { "3", "a25c0148-7e24-4f5f-bbb1-d68b08f81775" },
                    { "3", "a5c15c79-e6e2-4f27-b9c2-a6c7a75a4af5" },
                    { "3", "a634b94b-02d6-4480-9ee5-f133e7fb97c4" },
                    { "3", "aa6823c8-854f-46f9-af6e-9aa3a1674f62" },
                    { "3", "af1f1382-3d0a-404e-a479-44941fbcdb67" },
                    { "1", "af4820c9-c023-40e6-ac3c-32915ed3a7e5" },
                    { "3", "c0d00f17-d7d8-4f79-98fb-80f8db38a1fe" },
                    { "1", "c3d80974-4f53-436d-b258-562cccbb5911" },
                    { "2", "c9cc4223-eee3-4826-92fa-b774c4c608a3" },
                    { "3", "cabb8b7e-9ca8-4673-9da1-e0a5d25aebe3" },
                    { "1", "ce98b90c-6807-42a1-901f-9b5a37ae9b0f" },
                    { "3", "d04f0de8-0c22-4d56-9545-552bbba6c4a9" },
                    { "3", "d4d9beae-bd9a-4e69-ba80-0f6df463048f" },
                    { "3", "d8c8aabe-e15d-464d-9ce5-23fd418a330a" },
                    { "3", "d990afdc-96c1-406f-8b62-d8e0a1c0f676" },
                    { "3", "db7aa3da-3c17-4f6c-94bc-898c08b14009" },
                    { "1", "e150cea2-ef1d-4f95-aea1-207cc74bd3e5" },
                    { "2", "f1df7b6c-af5e-4d0a-9d20-510088708682" },
                    { "1", "fd01736c-538a-4d84-9c2e-6f9479493fa1" },
                    { "3", "fdacb9cb-2d8b-496a-bc6c-122aacd910d7" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyEmail", "DepartmentId", "FirstName", "JobTitle", "LastName", "Salary", "UserId" },
                values: new object[,]
                {
                    { 101, "johndoe1@company.gmail", 2, "John", "Finance Manager", "Doe", 3213.0m, "c9cc4223-eee3-4826-92fa-b774c4c608a3" },
                    { 102, "johndoe2@company.gmail", 3, "John", "IT Manager", "Doe", 6084.0m, "1f7b8188-0e7c-4764-a453-7b3dfb396dda" },
                    { 103, "johndoe3@company.gmail", 4, "John", "Marketing Manager", "Doe", 3159.0m, "64566c45-5a21-4f9a-a074-7719a36d719e" },
                    { 104, "johndoe4@company.gmail", 5, "John", "Sales Manager", "Doe", 3069.0m, "1e64def5-b5be-45f7-8f75-36c2a84cc4a0" },
                    { 105, "johndoe5@company.gmail", 6, "John", "Operations Manager", "Doe", 4179.0m, "f1df7b6c-af5e-4d0a-9d20-510088708682" },
                    { 106, "johndoe6@company.gmail", 1, "John", "HR Manager", "Doe", 2343.0m, "af4820c9-c023-40e6-ac3c-32915ed3a7e5" },
                    { 107, "johndoe7@company.gmail", 2, "John", "Tax Specialist", "Doe", 2062m, "50dd659a-5c61-40bc-bb9b-938bb656251a" },
                    { 108, "johndoe8@company.gmail", 3, "John", "Database Admin", "Doe", 4962m, "d04f0de8-0c22-4d56-9545-552bbba6c4a9" },
                    { 109, "johndoe9@company.gmail", 4, "John", "SEO Analyst", "Doe", 2161m, "03d2df2f-2b82-47f5-a4cb-b902983e27d7" },
                    { 110, "johndoe10@company.gmail", 5, "John", "Sales Representative", "Doe", 3047m, "08431c71-0402-4723-9eb4-ceaf5f0b691c" },
                    { 111, "johndoe11@company.gmail", 6, "John", "Operations Specialist", "Doe", 2672m, "d990afdc-96c1-406f-8b62-d8e0a1c0f676" },
                    { 112, "johndoe12@company.gmail", 1, "John", "HR Generalist", "Doe", 1646m, "c3d80974-4f53-436d-b258-562cccbb5911" },
                    { 113, "johndoe13@company.gmail", 2, "John", "Financial Analyst", "Doe", 2023m, "75ee5357-ff22-4147-9969-c292aa655614" },
                    { 114, "johndoe14@company.gmail", 3, "John", "System Admin", "Doe", 4832m, "2cc909ea-29bb-4eeb-84fc-90cd4abbdc5d" },
                    { 115, "johndoe15@company.gmail", 4, "John", "Content Writer", "Doe", 2037m, "7c2c59f6-0d6f-4d8b-a913-d57ba217ecd3" },
                    { 116, "johndoe16@company.gmail", 5, "John", "Sales Engineer", "Doe", 2659m, "811863c7-ba6c-49b3-91b4-357d29a9f559" },
                    { 117, "johndoe17@company.gmail", 6, "John", "Facilities Manager", "Doe", 2978m, "10ebc514-f8d2-44cb-aa74-9bf59e51d23d" },
                    { 118, "johndoe18@company.gmail", 1, "John", "Compensation Analyst", "Doe", 1570m, "1918af0e-eb9b-42b4-b4f0-668ac161a7e4" },
                    { 119, "johndoe19@company.gmail", 2, "John", "Tax Specialist", "Doe", 2010m, "d4d9beae-bd9a-4e69-ba80-0f6df463048f" },
                    { 120, "johndoe20@company.gmail", 3, "John", "Network Engineer", "Doe", 4582m, "4049d633-303e-43df-be36-9ed75daf55a0" },
                    { 121, "johndoe21@company.gmail", 4, "John", "SEO Analyst", "Doe", 2113m, "003fbf32-bc9f-47e3-95cc-69f026437353" },
                    { 122, "johndoe22@company.gmail", 5, "John", "Sales Engineer", "Doe", 2043m, "5da6430c-eac0-433d-a4c2-427fa40a937e" },
                    { 123, "johndoe23@company.gmail", 6, "John", "Supply Chain Analyst", "Doe", 2686m, "cabb8b7e-9ca8-4673-9da1-e0a5d25aebe3" },
                    { 124, "johndoe24@company.gmail", 1, "John", "Recruiter", "Doe", 1548m, "4fa52168-45f9-405c-aee5-a198c6d7b29e" },
                    { 125, "johndoe25@company.gmail", 2, "John", "Tax Specialist", "Doe", 2043m, "c0d00f17-d7d8-4f79-98fb-80f8db38a1fe" },
                    { 126, "johndoe26@company.gmail", 3, "John", "System Admin", "Doe", 4174m, "fdacb9cb-2d8b-496a-bc6c-122aacd910d7" },
                    { 127, "johndoe27@company.gmail", 4, "John", "SEO Analyst", "Doe", 2153m, "9e6b0919-fd9c-4a2c-ac57-8035d1c4b22d" },
                    { 128, "johndoe28@company.gmail", 5, "John", "Sales Representative", "Doe", 3344m, "db7aa3da-3c17-4f6c-94bc-898c08b14009" },
                    { 129, "johndoe29@company.gmail", 6, "John", "Operations Specialist", "Doe", 2880m, "9df12ac9-105f-4f8e-bd62-f09295e227f3" },
                    { 130, "johndoe30@company.gmail", 1, "John", "Recruiter", "Doe", 1548m, "ce98b90c-6807-42a1-901f-9b5a37ae9b0f" },
                    { 131, "johndoe31@company.gmail", 2, "John", "Accountant", "Doe", 2124m, "a25c0148-7e24-4f5f-bbb1-d68b08f81775" },
                    { 132, "johndoe32@company.gmail", 3, "John", "Software Developer", "Doe", 4010m, "454f813d-08d9-48eb-8f4f-db046fb742f8" },
                    { 133, "johndoe33@company.gmail", 4, "John", "Social Media Manager", "Doe", 2170m, "af1f1382-3d0a-404e-a479-44941fbcdb67" },
                    { 134, "johndoe34@company.gmail", 5, "John", "Business Developer", "Doe", 4800m, "d8c8aabe-e15d-464d-9ce5-23fd418a330a" },
                    { 135, "johndoe35@company.gmail", 6, "John", "Facilities Manager", "Doe", 2643m, "8534c31b-00ba-4308-82b8-b8aebd523c03" },
                    { 136, "johndoe36@company.gmail", 1, "John", "HR Generalist", "Doe", 1693m, "375e73d8-865d-45bd-bf29-4a3c769107fc" },
                    { 137, "johndoe37@company.gmail", 2, "John", "Tax Specialist", "Doe", 2046m, "600dc378-22f7-4cee-8c1c-56a0411c1560" },
                    { 138, "johndoe38@company.gmail", 3, "John", "Database Admin", "Doe", 4185m, "4f499d5c-4f35-46aa-b921-c1f797dbbcc2" },
                    { 139, "johndoe39@company.gmail", 4, "John", "Content Writer", "Doe", 2044m, "a5c15c79-e6e2-4f27-b9c2-a6c7a75a4af5" },
                    { 140, "johndoe40@company.gmail", 5, "John", "Business Developer", "Doe", 4318m, "8f56f664-b90d-4881-b228-6d48672ea436" },
                    { 141, "johndoe41@company.gmail", 6, "John", "Supply Chain Analyst", "Doe", 2982m, "7a855d4d-897f-4f23-b2e5-a0c1d4000b50" },
                    { 142, "johndoe42@company.gmail", 1, "John", "Compensation Analyst", "Doe", 1724m, "fd01736c-538a-4d84-9c2e-6f9479493fa1" },
                    { 143, "johndoe43@company.gmail", 2, "John", "Accountant", "Doe", 2167m, "06b45b7c-0ce5-4ae1-b22c-c49048bf1ee0" },
                    { 144, "johndoe44@company.gmail", 3, "John", "Software Developer", "Doe", 4646m, "a634b94b-02d6-4480-9ee5-f133e7fb97c4" },
                    { 145, "johndoe45@company.gmail", 4, "John", "Social Media Manager", "Doe", 2173m, "63583698-0976-493d-86dc-f862c471f36f" },
                    { 146, "johndoe46@company.gmail", 5, "John", "Sales Representative", "Doe", 3173m, "52f3a972-a5d6-41fa-8c5e-f684a0770235" },
                    { 147, "johndoe47@company.gmail", 6, "John", "Supply Chain Analyst", "Doe", 2829m, "97405820-3645-4509-9519-5dcf956dab91" },
                    { 148, "johndoe48@company.gmail", 1, "John", "Recruiter", "Doe", 1537m, "e150cea2-ef1d-4f95-aea1-207cc74bd3e5" },
                    { 149, "johndoe49@company.gmail", 2, "John", "Financial Analyst", "Doe", 2153m, "1390a1b9-ae19-4b47-ab5a-0f5ed9d5bc28" },
                    { 150, "johndoe50@company.gmail", 3, "John", "Database Admin", "Doe", 4415m, "aa6823c8-854f-46f9-af6e-9aa3a1674f62" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "003fbf32-bc9f-47e3-95cc-69f026437353" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "03d2df2f-2b82-47f5-a4cb-b902983e27d7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "06b45b7c-0ce5-4ae1-b22c-c49048bf1ee0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "08431c71-0402-4723-9eb4-ceaf5f0b691c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "10ebc514-f8d2-44cb-aa74-9bf59e51d23d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "1390a1b9-ae19-4b47-ab5a-0f5ed9d5bc28" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1918af0e-eb9b-42b4-b4f0-668ac161a7e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "1e64def5-b5be-45f7-8f75-36c2a84cc4a0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "1f7b8188-0e7c-4764-a453-7b3dfb396dda" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "2cc909ea-29bb-4eeb-84fc-90cd4abbdc5d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "375e73d8-865d-45bd-bf29-4a3c769107fc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "4049d633-303e-43df-be36-9ed75daf55a0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "454f813d-08d9-48eb-8f4f-db046fb742f8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "4f499d5c-4f35-46aa-b921-c1f797dbbcc2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "4fa52168-45f9-405c-aee5-a198c6d7b29e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "50dd659a-5c61-40bc-bb9b-938bb656251a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "52f3a972-a5d6-41fa-8c5e-f684a0770235" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "5da6430c-eac0-433d-a4c2-427fa40a937e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "600dc378-22f7-4cee-8c1c-56a0411c1560" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "63583698-0976-493d-86dc-f862c471f36f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "64566c45-5a21-4f9a-a074-7719a36d719e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "75ee5357-ff22-4147-9969-c292aa655614" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "7a855d4d-897f-4f23-b2e5-a0c1d4000b50" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "7c2c59f6-0d6f-4d8b-a913-d57ba217ecd3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "811863c7-ba6c-49b3-91b4-357d29a9f559" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "8534c31b-00ba-4308-82b8-b8aebd523c03" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "8f56f664-b90d-4881-b228-6d48672ea436" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "97405820-3645-4509-9519-5dcf956dab91" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "9df12ac9-105f-4f8e-bd62-f09295e227f3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "9e6b0919-fd9c-4a2c-ac57-8035d1c4b22d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "a25c0148-7e24-4f5f-bbb1-d68b08f81775" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "a5c15c79-e6e2-4f27-b9c2-a6c7a75a4af5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "a634b94b-02d6-4480-9ee5-f133e7fb97c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "aa6823c8-854f-46f9-af6e-9aa3a1674f62" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "af1f1382-3d0a-404e-a479-44941fbcdb67" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "af4820c9-c023-40e6-ac3c-32915ed3a7e5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "c0d00f17-d7d8-4f79-98fb-80f8db38a1fe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "c3d80974-4f53-436d-b258-562cccbb5911" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "c9cc4223-eee3-4826-92fa-b774c4c608a3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "cabb8b7e-9ca8-4673-9da1-e0a5d25aebe3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "ce98b90c-6807-42a1-901f-9b5a37ae9b0f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "d04f0de8-0c22-4d56-9545-552bbba6c4a9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "d4d9beae-bd9a-4e69-ba80-0f6df463048f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "d8c8aabe-e15d-464d-9ce5-23fd418a330a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "d990afdc-96c1-406f-8b62-d8e0a1c0f676" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "db7aa3da-3c17-4f6c-94bc-898c08b14009" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "e150cea2-ef1d-4f95-aea1-207cc74bd3e5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "f1df7b6c-af5e-4d0a-9d20-510088708682" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "fd01736c-538a-4d84-9c2e-6f9479493fa1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "fdacb9cb-2d8b-496a-bc6c-122aacd910d7" });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "003fbf32-bc9f-47e3-95cc-69f026437353");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03d2df2f-2b82-47f5-a4cb-b902983e27d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06b45b7c-0ce5-4ae1-b22c-c49048bf1ee0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08431c71-0402-4723-9eb4-ceaf5f0b691c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10ebc514-f8d2-44cb-aa74-9bf59e51d23d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1390a1b9-ae19-4b47-ab5a-0f5ed9d5bc28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1918af0e-eb9b-42b4-b4f0-668ac161a7e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e64def5-b5be-45f7-8f75-36c2a84cc4a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f7b8188-0e7c-4764-a453-7b3dfb396dda");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cc909ea-29bb-4eeb-84fc-90cd4abbdc5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "375e73d8-865d-45bd-bf29-4a3c769107fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4049d633-303e-43df-be36-9ed75daf55a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "454f813d-08d9-48eb-8f4f-db046fb742f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f499d5c-4f35-46aa-b921-c1f797dbbcc2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fa52168-45f9-405c-aee5-a198c6d7b29e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50dd659a-5c61-40bc-bb9b-938bb656251a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52f3a972-a5d6-41fa-8c5e-f684a0770235");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5da6430c-eac0-433d-a4c2-427fa40a937e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "600dc378-22f7-4cee-8c1c-56a0411c1560");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63583698-0976-493d-86dc-f862c471f36f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64566c45-5a21-4f9a-a074-7719a36d719e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75ee5357-ff22-4147-9969-c292aa655614");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a855d4d-897f-4f23-b2e5-a0c1d4000b50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c2c59f6-0d6f-4d8b-a913-d57ba217ecd3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "811863c7-ba6c-49b3-91b4-357d29a9f559");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8534c31b-00ba-4308-82b8-b8aebd523c03");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f56f664-b90d-4881-b228-6d48672ea436");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97405820-3645-4509-9519-5dcf956dab91");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9df12ac9-105f-4f8e-bd62-f09295e227f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e6b0919-fd9c-4a2c-ac57-8035d1c4b22d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a25c0148-7e24-4f5f-bbb1-d68b08f81775");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5c15c79-e6e2-4f27-b9c2-a6c7a75a4af5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a634b94b-02d6-4480-9ee5-f133e7fb97c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa6823c8-854f-46f9-af6e-9aa3a1674f62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af1f1382-3d0a-404e-a479-44941fbcdb67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af4820c9-c023-40e6-ac3c-32915ed3a7e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0d00f17-d7d8-4f79-98fb-80f8db38a1fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d80974-4f53-436d-b258-562cccbb5911");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9cc4223-eee3-4826-92fa-b774c4c608a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cabb8b7e-9ca8-4673-9da1-e0a5d25aebe3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce98b90c-6807-42a1-901f-9b5a37ae9b0f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d04f0de8-0c22-4d56-9545-552bbba6c4a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4d9beae-bd9a-4e69-ba80-0f6df463048f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8c8aabe-e15d-464d-9ce5-23fd418a330a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d990afdc-96c1-406f-8b62-d8e0a1c0f676");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db7aa3da-3c17-4f6c-94bc-898c08b14009");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e150cea2-ef1d-4f95-aea1-207cc74bd3e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1df7b6c-af5e-4d0a-9d20-510088708682");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd01736c-538a-4d84-9c2e-6f9479493fa1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fdacb9cb-2d8b-496a-bc6c-122aacd910d7");

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

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyEmail", "DepartmentId", "FirstName", "JobTitle", "LastName", "Salary", "UserId" },
                values: new object[,]
                {
                    { 1, "johndoe1@company.gmail", 2, "John", "Finance Manager", "Doe", 1000m, "8e26b9bb-7b46-40c3-8fc8-fbd6fe9a8a9d" },
                    { 2, "johndoe2@company.gmail", 3, "John", "IT Manager", "Doe", 1000m, "60196d57-2732-4556-894b-f2b5609f3d87" },
                    { 3, "johndoe3@company.gmail", 4, "John", "Marketing Manager", "Doe", 1000m, "d7abfc8f-0127-41b2-a4f2-95cbf92ed801" },
                    { 4, "johndoe4@company.gmail", 5, "John", "Sales Manager", "Doe", 1000m, "43231ac9-35f9-43e4-97b2-1540df38e6c0" },
                    { 5, "johndoe5@company.gmail", 6, "John", "Operations Manager", "Doe", 1000m, "4dc44674-0684-43b0-a952-cc082172b066" },
                    { 6, "johndoe6@company.gmail", 1, "John", "HR Manager", "Doe", 1000m, "cb6d4329-ffaf-4085-b662-9766570d9cc8" },
                    { 7, "johndoe7@company.gmail", 2, "John", "Auditor", "Doe", 1000m, "f7441654-a602-4506-b2ef-47a91b9ecec3" },
                    { 8, "johndoe8@company.gmail", 3, "John", "Database Admin", "Doe", 1000m, "cc48ee11-e34a-442b-a28b-fefef684e1a0" },
                    { 9, "johndoe9@company.gmail", 4, "John", "Social Media Manager", "Doe", 1000m, "336b79d6-019f-4b48-9e8c-a04510feae31" },
                    { 10, "johndoe10@company.gmail", 5, "John", "Business Developer", "Doe", 1000m, "5dcd8aca-6f47-461e-903c-2364fcd683a4" },
                    { 11, "johndoe11@company.gmail", 6, "John", "Facilities Manager", "Doe", 1000m, "964daed0-a468-47ac-996d-a563b8425d4c" },
                    { 12, "johndoe12@company.gmail", 1, "John", "Recruiter", "Doe", 1000m, "eadc203d-19eb-4c32-9c73-24bfb5f55ab2" },
                    { 13, "johndoe13@company.gmail", 2, "John", "Accountant", "Doe", 1000m, "f4d51f84-ce01-4e08-8df9-7e69e8927c68" },
                    { 14, "johndoe14@company.gmail", 3, "John", "Network Engineer", "Doe", 1000m, "b22c75d7-8a62-4c7e-8ea4-14874f8f8bf4" },
                    { 15, "johndoe15@company.gmail", 4, "John", "SEO Analyst", "Doe", 1000m, "14809f8c-758c-44a0-adab-fdc97efd3e53" },
                    { 16, "johndoe16@company.gmail", 5, "John", "Sales Engineer", "Doe", 1000m, "a0baba74-cebe-4d07-a04b-dfc9ff5161b2" },
                    { 17, "johndoe17@company.gmail", 6, "John", "Supply Chain Analyst", "Doe", 1000m, "0cc08ba4-fbb8-4eb7-ae22-0a4f2847ae1f" },
                    { 18, "johndoe18@company.gmail", 1, "John", "Training Specialist", "Doe", 1000m, "75ab1c0a-5fae-41d5-ab19-27c84c7d9c5c" },
                    { 19, "johndoe19@company.gmail", 2, "John", "Accountant", "Doe", 1000m, "b9e3146e-91b5-4e22-b89a-4f24b9bfc190" },
                    { 20, "johndoe20@company.gmail", 3, "John", "Network Engineer", "Doe", 1000m, "9f04f907-786f-4246-89aa-8461e1bd9a93" },
                    { 21, "johndoe21@company.gmail", 4, "John", "Content Writer", "Doe", 1000m, "ac5d71ee-8fcc-4ae3-a083-e064b003ce79" },
                    { 22, "johndoe22@company.gmail", 5, "John", "Sales Representative", "Doe", 1000m, "eb6d2eb7-9de0-4e36-9979-61d7386ccf6d" },
                    { 23, "johndoe23@company.gmail", 6, "John", "Facilities Manager", "Doe", 1000m, "911f2f71-ae3c-46fa-ac17-a84439f753a3" },
                    { 24, "johndoe24@company.gmail", 1, "John", "Training Specialist", "Doe", 1000m, "03ab8010-b248-4dab-9a41-559d28420223" },
                    { 25, "johndoe25@company.gmail", 2, "John", "Auditor", "Doe", 1000m, "6f0eb648-32af-4ca9-ad35-36f3be64361d" },
                    { 26, "johndoe26@company.gmail", 3, "John", "Software Developer", "Doe", 1000m, "671bc962-e0b6-4978-9e0b-f8f9dfe6ba9f" },
                    { 27, "johndoe27@company.gmail", 4, "John", "SEO Analyst", "Doe", 1000m, "f358e708-cf4e-404f-be67-bb08f1abab8b" },
                    { 28, "johndoe28@company.gmail", 5, "John", "Business Developer", "Doe", 1000m, "95c5ce35-bb57-4a1c-a46c-4dddf2d27f49" },
                    { 29, "johndoe29@company.gmail", 6, "John", "Facilities Manager", "Doe", 1000m, "ebc12b62-e34c-44b5-81db-bd39c6266faa" },
                    { 30, "johndoe30@company.gmail", 1, "John", "Recruiter", "Doe", 1000m, "f21c8d38-01ad-48d0-823e-9bfc87cc0c3f" },
                    { 31, "johndoe31@company.gmail", 2, "John", "Tax Specialist", "Doe", 1000m, "41095bb3-be03-4acc-ba45-204d5d2bc979" },
                    { 32, "johndoe32@company.gmail", 3, "John", "System Admin", "Doe", 1000m, "854a7fcf-b7de-4f98-8959-82b19e5f51d1" },
                    { 33, "johndoe33@company.gmail", 4, "John", "Content Writer", "Doe", 1000m, "ffb4270c-015f-4b09-918c-7055eccaf56d" },
                    { 34, "johndoe34@company.gmail", 5, "John", "Sales Representative", "Doe", 1000m, "e23a01a4-d4e7-4ca1-8a34-feced727de45" },
                    { 35, "johndoe35@company.gmail", 6, "John", "Supply Chain Analyst", "Doe", 1000m, "98577e21-d7c5-43e1-809b-b897bd6e8d48" },
                    { 36, "johndoe36@company.gmail", 1, "John", "HR Generalist", "Doe", 1000m, "cfb51b51-97aa-4292-8236-ba00563744e3" },
                    { 37, "johndoe37@company.gmail", 2, "John", "Financial Analyst", "Doe", 1000m, "92b768b1-c160-4991-841d-61e786ce1f83" },
                    { 38, "johndoe38@company.gmail", 3, "John", "System Admin", "Doe", 1000m, "adb79f8a-04cc-4320-a669-3527751fb661" },
                    { 39, "johndoe39@company.gmail", 4, "John", "Marketing Specialist", "Doe", 1000m, "0b288183-f4a6-4826-a55c-09ee2e774ae3" },
                    { 40, "johndoe40@company.gmail", 5, "John", "Sales Representative", "Doe", 1000m, "68a091f0-c52b-4e66-8708-063b647b0738" },
                    { 41, "johndoe41@company.gmail", 6, "John", "Operations Specialist", "Doe", 1000m, "8c6f5260-9cb7-4492-841d-94715ac68294" },
                    { 42, "johndoe42@company.gmail", 1, "John", "Training Specialist", "Doe", 1000m, "cc690ba1-2fb2-4b1a-a699-490f5663b3f0" },
                    { 43, "johndoe43@company.gmail", 2, "John", "Financial Analyst", "Doe", 1000m, "49dd9b3d-ad8d-4a31-be3e-cec276584193" },
                    { 44, "johndoe44@company.gmail", 3, "John", "System Admin", "Doe", 1000m, "aa4cb9ff-b7f7-46f2-8427-9740e5964c2c" },
                    { 45, "johndoe45@company.gmail", 4, "John", "Content Writer", "Doe", 1000m, "f5146290-f855-462e-b649-cd7abb0e987c" },
                    { 46, "johndoe46@company.gmail", 5, "John", "Business Developer", "Doe", 1000m, "dda7bec6-43ae-4387-b6a4-6c21bac91243" },
                    { 47, "johndoe47@company.gmail", 6, "John", "Supply Chain Analyst", "Doe", 1000m, "34c335e3-e880-420a-9af3-b753225d8db4" },
                    { 48, "johndoe48@company.gmail", 1, "John", "Recruiter", "Doe", 1000m, "e32adeae-2de5-4679-a944-ceb9ef19f154" },
                    { 49, "johndoe49@company.gmail", 2, "John", "Auditor", "Doe", 1000m, "563d2cae-cb0a-468c-9ad9-9b9f5ac67521" },
                    { 50, "johndoe50@company.gmail", 3, "John", "Database Admin", "Doe", 1000m, "0c884718-abe3-4396-9fa3-ff5adabc48c1" }
                });
        }
    }
}
