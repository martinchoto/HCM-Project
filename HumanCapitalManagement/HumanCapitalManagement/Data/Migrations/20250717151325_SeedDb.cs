using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HumanCapitalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5aac5564-86db-4233-98dc-34d335c6e444");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f742d469-60cc-4627-a553-4f6e407204e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "f2efefae-3150-42b5-9088-f62379b6a60b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[,]
                {
                    { "009458af-40c0-4a7c-9300-e47976528523", "2e3a4924-1338-4c53-816e-addb1ee3777c", "johndoe11@personal.gmail", "JOHNDOE11@PERSONAL.GMAIL", "JOHNDOE11", "AQAAAAIAAYagAAAAEIWFQhI56XgBBuCgX0sLClOsnh5fTznOa6+97WsNSHkL15z/gPLK0OpX27Poc0ElPQ==", "257abef1-303c-4fd6-b281-511aae7d406e", "JohnDoe11" },
                    { "026e3971-3780-4328-88c3-5c1bd38cd2c3", "23f53322-f17f-42a9-bba7-87f5d95cbc48", "johndoe7@personal.gmail", "JOHNDOE7@PERSONAL.GMAIL", "JOHNDOE7", "AQAAAAIAAYagAAAAEGYzIk1AaR+Zki2319eu+cSz2siCzXtohtJEF6O6wMyG67NZZwYJ8VgVIqzQkhX9Fg==", "21dbadfb-44c1-4f59-8447-a44ba7e3678f", "JohnDoe7" },
                    { "040a0e5e-f7ce-4ded-af4b-f1b5e33aaf42", "839c2c62-4dc6-4960-bbd9-5c0b175be060", "johndoe5@personal.gmail", "JOHNDOE5@PERSONAL.GMAIL", "JOHNDOE5", "AQAAAAIAAYagAAAAEPr5FUGgnqv4DxXjdVPsyMEEKLivuUaQjBu2ltndcflDbPnRhuUYUVOpY3lv350mtA==", "90298aae-adc4-46c8-8fb4-3ea22fcc036b", "JohnDoe5" },
                    { "0e251df9-cbdb-4da3-81b1-397386effd8d", "b57159a0-c0d8-424e-bc13-35e0d89350e8", "johndoe30@personal.gmail", "JOHNDOE30@PERSONAL.GMAIL", "JOHNDOE30", "AQAAAAIAAYagAAAAEIQBq58LaYu/iY/qJ42U9thpzr9nPiE1ulmA8uGM9P3kAIiXkAYb7O2N2i5j3CcTQg==", "95fd1af9-2055-46c1-97e7-8571da793722", "JohnDoe30" },
                    { "0f5240c5-b7c9-4c22-b4b8-df9b5d9c0a77", "e0855a2b-7e23-45cc-aab8-645e30b92c59", "johndoe39@personal.gmail", "JOHNDOE39@PERSONAL.GMAIL", "JOHNDOE39", "AQAAAAIAAYagAAAAEAS7c+t6Oo2Q59L0or3ZANO0IhdJ9l8XwhpVPN0sPZ0bBnvCZGEP4GW4KoaSn35ItQ==", "93683e31-700e-410a-9ca1-6a23f733d926", "JohnDoe39" },
                    { "1037430f-09d0-4d04-b069-90590151685e", "00d0388b-cc08-430c-b989-8969a312efa6", "johndoe12@personal.gmail", "JOHNDOE12@PERSONAL.GMAIL", "JOHNDOE12", "AQAAAAIAAYagAAAAEBgVHCETk8xT9mSxSMceiaIpLhcEdpCZVjk4ARsxwWkW9pTYCfqmqR9Xq+zfMfMnRA==", "a486004e-e3e3-49cb-9c17-7405e8b0b4ad", "JohnDoe12" },
                    { "13d86597-6417-426c-bb16-ac9e7f371728", "a9212ffa-4981-4a7a-aaf1-1a0410ea1413", "johndoe19@personal.gmail", "JOHNDOE19@PERSONAL.GMAIL", "JOHNDOE19", "AQAAAAIAAYagAAAAEFbSaAwaf5F+S+c0j15Bpb3KdlnPEHUj3QEeWSsiSX+gLiTwSecr9Dgm6D9CXlFPSQ==", "440c92b1-8f88-447d-aa4e-57ab11ba9a94", "JohnDoe19" },
                    { "1ba06199-67e8-4577-bc94-acace488ad33", "d0bdaabe-8148-4416-929f-ce6381281ad4", "johndoe34@personal.gmail", "JOHNDOE34@PERSONAL.GMAIL", "JOHNDOE34", "AQAAAAIAAYagAAAAECCzUYeVbwMDbEKbCxBUcC43KwxEGH6sOs16RdBBdKIlJ0VNQBCVtpL8a+r+jLRlVg==", "c602f8e8-30d9-4315-a9bb-fb71ba41c9bd", "JohnDoe34" },
                    { "21eb63b8-0a3c-4887-8ea0-eaf7a11266ba", "4a62cc4a-ee4d-4ea1-ae33-21b303e2ba4d", "johndoe17@personal.gmail", "JOHNDOE17@PERSONAL.GMAIL", "JOHNDOE17", "AQAAAAIAAYagAAAAEDNAyBM1f/wukFyYXIXCkEymj2KVpQVgnxoAxA5bbVDnaajW9YYrJNCq/WsTxuMIcA==", "a6dfa18d-505e-4ee3-95fa-393c051fa68d", "JohnDoe17" },
                    { "26f8970b-4857-46f9-9389-2f71c21e9295", "0635a3f0-6cf2-41a7-8578-c6e899bdf6ac", "johndoe14@personal.gmail", "JOHNDOE14@PERSONAL.GMAIL", "JOHNDOE14", "AQAAAAIAAYagAAAAECVcoO5CFpioUsVsIVIzPjRxMVJ8MYtAf2sIpp0nRMfLZ5FF5ggi/C5CQZfRBqfjBA==", "7201aefc-028c-483b-aff6-61db7957b288", "JohnDoe14" },
                    { "2bad1a92-a028-4688-93ba-299295a9aa76", "ec45e964-ddc8-4300-9602-1b7d1e7ffb49", "johndoe25@personal.gmail", "JOHNDOE25@PERSONAL.GMAIL", "JOHNDOE25", "AQAAAAIAAYagAAAAEHSzR2t5zpONw5JQmkgHiUwctEYJFEvYh6xE22OnWY1r/PccbVOOpaKswqzJebCyvQ==", "4bfc0cbe-659f-41b9-9d04-86654d87ae34", "JohnDoe25" },
                    { "2bda7639-9d19-49a6-a570-19d578f4389a", "9d2eaa1a-ba07-4227-b658-5f191db1e68d", "johndoe33@personal.gmail", "JOHNDOE33@PERSONAL.GMAIL", "JOHNDOE33", "AQAAAAIAAYagAAAAELdkgohbW69jP+NIIVoPlBiriSRtcazoRzMZFOtogjwk+fWttZZJ98nq7Tu9K9/5iQ==", "fdb51d0e-569d-4309-a58e-a48d19331005", "JohnDoe33" },
                    { "3a3b2773-5cc6-4ba8-903b-31b2cfaf006d", "2cf3689f-135f-41de-a620-4dfefcb190c0", "johndoe48@personal.gmail", "JOHNDOE48@PERSONAL.GMAIL", "JOHNDOE48", "AQAAAAIAAYagAAAAEKbakZ3nnhcGAByoxlMnzEyTWB/EZtS5EI6Oz5IWTbKf3TGnUC4PobhhDbqU5fispg==", "03397af5-175b-415c-a8ac-9b8987a1fc60", "JohnDoe48" },
                    { "3cce224a-e144-4dcd-8256-63c7c40f44ef", "7db87307-d06b-4178-9b6b-ca22142b4442", "johndoe50@personal.gmail", "JOHNDOE50@PERSONAL.GMAIL", "JOHNDOE50", "AQAAAAIAAYagAAAAEOXhAU74syTbRG4jVzwWDWY2cI3Oqn80yAQQ8X3cUpqEIfwpS0iEBXQT3zOeWdavuQ==", "8c70dc9d-6384-49ae-bf8b-8495f82d871e", "JohnDoe50" },
                    { "42190612-182a-4a7a-a06a-4bf0d43498c7", "42e78e19-36f2-417b-8e36-5b741e9134de", "johndoe37@personal.gmail", "JOHNDOE37@PERSONAL.GMAIL", "JOHNDOE37", "AQAAAAIAAYagAAAAEM18pAAHp3PTdZg3gZAPD5ExJVzFP6sWPiipyvlFNip/05Q1x0IoW3dCCmmCS79ZiA==", "a5d1140c-8de0-46bd-8c2c-c89b503a45a1", "JohnDoe37" },
                    { "566260d5-ac1e-4afb-9c10-c3e200afa0f3", "081449bf-335e-41e7-a57c-92edd3d89bb7", "johndoe22@personal.gmail", "JOHNDOE22@PERSONAL.GMAIL", "JOHNDOE22", "AQAAAAIAAYagAAAAENy0zyTirY+0Gd5dMXwVOj0RlI7TkgrG0i023nQVeol+Cn9w2ra9N3wbW9RtBeV7vQ==", "8a6b30fe-3e32-4e64-918d-1c639f628643", "JohnDoe22" },
                    { "57387e9a-9a9d-448b-a646-972a2517584b", "a6845e29-67ff-4d7c-8e2e-ea18ac626f8a", "johndoe38@personal.gmail", "JOHNDOE38@PERSONAL.GMAIL", "JOHNDOE38", "AQAAAAIAAYagAAAAED7qJnruo0ktKYMXX437VyRUqC/yZ1cnsJLuFAFRbHPOj47IkiJXsD1bU8WD5Y86Ug==", "277ccf56-c4ce-480a-bbe6-49dc072cb112", "JohnDoe38" },
                    { "5a734a3e-8720-460f-86af-36e2a1018ba8", "c70bdfc8-ae5c-4db6-b3fb-85a4618c5e0e", "johndoe6@personal.gmail", "JOHNDOE6@PERSONAL.GMAIL", "JOHNDOE6", "AQAAAAIAAYagAAAAEAd/7rBaQncD5wKt45qFC6c97HXEPjwiaQ4EKcUC0m43xHYpU2XcIi1vGKep5ZSo1A==", "18173264-4db9-4457-9d5c-063e235bfacf", "JohnDoe6" },
                    { "6222a67e-989f-4d70-a857-495a3fcfdfb3", "c4319ca1-acc2-448b-9251-09668db264e3", "johndoe26@personal.gmail", "JOHNDOE26@PERSONAL.GMAIL", "JOHNDOE26", "AQAAAAIAAYagAAAAEMUPhKTOjpsfqs8w8QoelR3xAnjXuLiF8P2FSGq6hwwO0mGW201B7IQMO23njEy/Gg==", "aa548955-90f0-4b58-bbe8-badf7dc029c2", "JohnDoe26" },
                    { "7307b064-713d-4dee-8482-bc27678b7a00", "2d5975a9-ede8-4ad4-9e53-f4ff3e370068", "johndoe18@personal.gmail", "JOHNDOE18@PERSONAL.GMAIL", "JOHNDOE18", "AQAAAAIAAYagAAAAECFO+q3KCPTenfqqCMrlLS4QE1UmQjnjA1jiS2dxae/dIJGmH6VrY9hcVy+Ajn0iKw==", "e56d16b2-3a9e-46bc-9db0-92e47068dd5e", "JohnDoe18" },
                    { "734ce118-ab9b-49c4-8467-992cd37a8f64", "b832d7ee-e93a-4ec7-9ce9-ca4e801a3bf4", "johndoe44@personal.gmail", "JOHNDOE44@PERSONAL.GMAIL", "JOHNDOE44", "AQAAAAIAAYagAAAAEGXhIvon3bm6BBhwUvberLP+fCm++Bcj/+oT5RTrj72kU8WzzRuPv7ZNN/bRI7eI8w==", "0a7f7f93-360a-48e9-b03e-059925d5cb8d", "JohnDoe44" },
                    { "77819772-2107-48c1-96b5-8f7ede009c39", "e1c5b6ce-11ea-4a25-b512-3eec2647fc24", "johndoe2@personal.gmail", "JOHNDOE2@PERSONAL.GMAIL", "JOHNDOE2", "AQAAAAIAAYagAAAAEBZ/81Iu4PolQ5PQtHSQQHqQg5eZ7jMyMBDmWjdknAY7BnMtWUJ5j9yGpd6CA8rALg==", "ddbf2730-4ace-4e2f-9884-9da7a2650a62", "JohnDoe2" },
                    { "7f7c54d1-de99-47c1-99dc-0a0ab74a9ea8", "44e58c36-b6a6-4955-97b9-61642192ff8b", "johndoe32@personal.gmail", "JOHNDOE32@PERSONAL.GMAIL", "JOHNDOE32", "AQAAAAIAAYagAAAAEDu7ivHuTreAu0VCbUelNCbIiDSeAZVH1sxuVoICtuwZ8JwYBn4nJjGp1GddSYxGjA==", "af3d07e2-e14e-48da-9def-f15beb0cead9", "JohnDoe32" },
                    { "82327ea9-d4ce-40d4-a11e-19b037c8f615", "b03167a7-5327-48b8-a54c-8c6980e40cd4", "johndoe23@personal.gmail", "JOHNDOE23@PERSONAL.GMAIL", "JOHNDOE23", "AQAAAAIAAYagAAAAEDZm0ghYDRoqvoIRvDlsn/5oaiCGBHyWtnGUL3u/D0vrOwiIGfLtov+mwTK0K1lMOQ==", "9e26aaa7-3c9a-467f-b9c0-81bb93fb3705", "JohnDoe23" },
                    { "89589b78-3cfc-420c-b159-44d7bc15737b", "1f8bd987-02d0-487f-ba6f-9b7b36c7b740", "johndoe27@personal.gmail", "JOHNDOE27@PERSONAL.GMAIL", "JOHNDOE27", "AQAAAAIAAYagAAAAEGqmxg0D4XIMgHhjZEOeDmZ915FQsyCgum4/RY+PTbx9Mm+kX054iEJ2pyEk6QTolw==", "8f12689c-065a-4230-92db-b2b661b34c46", "JohnDoe27" },
                    { "8a386ecb-3e8e-413f-a520-c32d8f86d0b4", "1acf8005-8661-4aa7-aa9d-516080f9ccb7", "johndoe43@personal.gmail", "JOHNDOE43@PERSONAL.GMAIL", "JOHNDOE43", "AQAAAAIAAYagAAAAEICcarmvwHTaXUncFyixdYpQdTHVnL3b9cXfnrJmSEOotIuRG7hZbbzy+arO4A9n/g==", "9f642294-6d5b-48a5-8d8f-ab46f4c03ad8", "JohnDoe43" },
                    { "8c0e8e33-afad-4e69-98c5-9f0cd07a0f9f", "7f7e0284-92d9-4bf0-bf97-021e842d84de", "johndoe3@personal.gmail", "JOHNDOE3@PERSONAL.GMAIL", "JOHNDOE3", "AQAAAAIAAYagAAAAEOwj23o3+8vU/yCHqV3OTBIBwIvd24qosr1+T4dUooFf5rze/PdfQEn7ivw1MkVqFA==", "3d47f35c-a7d1-4276-92ec-b01061e2d448", "JohnDoe3" },
                    { "8c920c04-89e1-46c3-8b52-dee3b528f6f7", "5bde3c41-cceb-4b47-b0bb-6256079e37ba", "johndoe31@personal.gmail", "JOHNDOE31@PERSONAL.GMAIL", "JOHNDOE31", "AQAAAAIAAYagAAAAEGhweHosxyh4Q7KEaL3lOoNsVSywvpd6AefYZBTTYF/Y9EIE5olXlsjjfA1zOZzthQ==", "7897963d-77b3-4bb3-83f0-4731e6deae2b", "JohnDoe31" },
                    { "908fbda3-dce0-45ed-ac03-7148326006ee", "3d9d23be-195c-40c5-a6ab-bcea4de3349b", "johndoe16@personal.gmail", "JOHNDOE16@PERSONAL.GMAIL", "JOHNDOE16", "AQAAAAIAAYagAAAAECYqMTk4Zr17+/h+dTDs8mLURU0LVVp8ODQXGEaMeygCFuLW8Unx3ETEnAjSkIPRNA==", "b9673271-c09d-45cd-9902-2bd8ba7fdc76", "JohnDoe16" },
                    { "937b77b9-8940-41ef-ab75-8980498ad7de", "83212deb-0938-420b-a563-1cbaedf6d59d", "johndoe8@personal.gmail", "JOHNDOE8@PERSONAL.GMAIL", "JOHNDOE8", "AQAAAAIAAYagAAAAEMxrSwZJYUhpeq3iK9Jbl6qOfkhUZfhX6ROBgUQDnDPikAQTycG4cnnCLeqI3Jsltg==", "a0f0039b-a391-4b97-b4fa-e1ae3a6899d0", "JohnDoe8" },
                    { "9614c9ac-3010-4737-92d9-eadf3c93cfea", "b9ca8716-d937-4558-b8d3-95bd831f3735", "johndoe24@personal.gmail", "JOHNDOE24@PERSONAL.GMAIL", "JOHNDOE24", "AQAAAAIAAYagAAAAEGAzhVHMpF8rr2z5Ad92mGVGCVCATO/zDmQ5+D0dsyDKwptY4E21b0R+WXfKuDC00w==", "4e404a6d-f565-4480-a238-68766f6d3c6f", "JohnDoe24" },
                    { "ad3601d2-3a37-48a7-85a3-81b3ff26dfd0", "b3abf00f-bad5-4088-a37d-15736186255a", "johndoe29@personal.gmail", "JOHNDOE29@PERSONAL.GMAIL", "JOHNDOE29", "AQAAAAIAAYagAAAAEGW2huLF3rSC5SayhUkYgUhN9YMHqOilfLx8bnV6FXD69Q3prH70qW4FYJhnX+5Cqg==", "add49d22-feb5-44a3-80e8-f389495ccb4e", "JohnDoe29" },
                    { "aefcd97e-81f9-4305-a574-d9cfd5a29361", "1cb978e4-9110-4276-9bb4-480cb72dfbd2", "johndoe15@personal.gmail", "JOHNDOE15@PERSONAL.GMAIL", "JOHNDOE15", "AQAAAAIAAYagAAAAEEOXoufl5QI1cZJmBDqiXx7EVKGWCTvU0SAok7UA1mj8unK+EPX/+AUANCLb4euzHw==", "61c4e163-56f9-4c66-a998-9ab2c1f0eff0", "JohnDoe15" },
                    { "b30a7b36-5516-48cc-9a0b-6cce3e0323af", "bd41c242-9d01-4131-9ce5-ca12bf258457", "johndoe49@personal.gmail", "JOHNDOE49@PERSONAL.GMAIL", "JOHNDOE49", "AQAAAAIAAYagAAAAEKV5Hm3YpITryhQ836C+GhQ4Hx+ACFahejNbJWlkgJTyI//IilvIMRS2jW3dIpm7yA==", "efe54817-97ab-4aac-baa4-75914e036766", "JohnDoe49" },
                    { "b50189b2-1e85-476f-b43b-7be200eb5a40", "dbad5283-61ef-4a42-b304-b855a26589c2", "johndoe4@personal.gmail", "JOHNDOE4@PERSONAL.GMAIL", "JOHNDOE4", "AQAAAAIAAYagAAAAEHxZucVS6IkLNQiVKoLMwWfy2isoEuC9c5LAQZ/26GS2Wvh0vAClLqhcimTgnPIUCA==", "28c54755-beab-4594-8172-9cc87fe8e45c", "JohnDoe4" },
                    { "bdcceafd-4cd8-447f-a4e6-e2b60ab7641c", "3587e85f-6edb-47e0-9eb6-2c4e068e395d", "johndoe47@personal.gmail", "JOHNDOE47@PERSONAL.GMAIL", "JOHNDOE47", "AQAAAAIAAYagAAAAEEj9WuQfHolTtU3vniMddAeug0PoBInv6fU4gDjGLDgPx7b570zUmnAtm6qKbdPVYg==", "79d8ec7c-6717-460d-aefa-85e3ff5d0d34", "JohnDoe47" },
                    { "c35f3a93-ebe3-447d-b4a5-c1c713060f69", "d988e3cc-cd75-4685-90cd-140bcf529ec9", "johndoe28@personal.gmail", "JOHNDOE28@PERSONAL.GMAIL", "JOHNDOE28", "AQAAAAIAAYagAAAAEE/omMNFVPfGbnGKhyWZxQBSfcduyJHGcoPoYK1ZgNqK0Gyx8faMaEvPtptZjFVVDA==", "0ae42760-311a-427c-994b-9eb55f3e9126", "JohnDoe28" },
                    { "c8356b13-720b-4b43-a1a4-86688b7cc726", "ddca7a4f-8048-450a-b165-837b82c42abf", "johndoe35@personal.gmail", "JOHNDOE35@PERSONAL.GMAIL", "JOHNDOE35", "AQAAAAIAAYagAAAAELy/X/OX/hsw9ggLpgtJBxoQcQvAj1Yx6su1rUipc8OOX2ybwaaS2Im3o9SOnbinAw==", "0a865ce4-a5d7-472e-b789-f925bee35d49", "JohnDoe35" },
                    { "cd46004a-3500-4029-8fc4-c42cda168214", "44cabd9c-8401-4d26-b68a-2dffcafd5aa6", "johndoe36@personal.gmail", "JOHNDOE36@PERSONAL.GMAIL", "JOHNDOE36", "AQAAAAIAAYagAAAAEBjMCqY9zc8bwq7DIyeBPVmTFM9Odaq0IOz/0WkKAGrphYVXNZZug+W8+DY+MBG+uA==", "5d47be9f-87cb-4d09-894c-a3595087c51c", "JohnDoe36" },
                    { "d0c6b2a5-8191-473e-bde4-cec7c1a4a865", "4254c049-1cbc-41e5-a9e5-7341edd0ddd0", "johndoe1@personal.gmail", "JOHNDOE1@PERSONAL.GMAIL", "JOHNDOE1", "AQAAAAIAAYagAAAAENwGpHBHjr5c+56qCTNGRRFgoRj3tppNE/+0YcKv/R94Z9sdJdv5XuNZiyiPA27f/w==", "15b3ddf0-7057-4931-a164-18ec0812c275", "JohnDoe1" },
                    { "da8b00d6-c4a6-48f6-b97b-fe9a52586e5e", "62fa3b28-625f-4628-90db-c47f71dc7521", "johndoe21@personal.gmail", "JOHNDOE21@PERSONAL.GMAIL", "JOHNDOE21", "AQAAAAIAAYagAAAAENYju82oQ+Kj3kos3ao9Pu9mhIUViRMcZZ/wUy9hJsJ+/2GmaVBf7YfqUx67ZfEjLw==", "ae187493-2856-4f41-95e8-3d874f8ef0ee", "JohnDoe21" },
                    { "e059c377-1e51-4c73-a867-38b7a9c0eec3", "1913c95e-2d2e-4023-bebe-bc8acbf64703", "johndoe20@personal.gmail", "JOHNDOE20@PERSONAL.GMAIL", "JOHNDOE20", "AQAAAAIAAYagAAAAEBmI3g8a5AN/UfWB4g5OGHV9Zrwzjoh5AGV++9Hk987hXVKaQA30aqSg0Bjpy2pIUQ==", "b1972935-db89-46d5-bfcc-854a79752a0b", "JohnDoe20" },
                    { "e1822941-e544-4b87-8fb4-9c04bca75113", "fcd7bba8-dc60-4ba7-adce-86b413e437c3", "johndoe13@personal.gmail", "JOHNDOE13@PERSONAL.GMAIL", "JOHNDOE13", "AQAAAAIAAYagAAAAEAKZdK7EyoTcC8LzpQmx64bE1brCmk5vOXLgRm7jNd5m7f/oyMOt/aN9naLvs4PP4w==", "a37b7d15-a612-4c3e-9a2b-99c025d4bcc3", "JohnDoe13" },
                    { "e188573e-fb64-4593-8ef4-d3d0071fc7e6", "918434e1-33e1-43f8-8386-d733c69e8ea6", "johndoe10@personal.gmail", "JOHNDOE10@PERSONAL.GMAIL", "JOHNDOE10", "AQAAAAIAAYagAAAAEI6h7WdB8yq44eRqtglsSqliuwX+LRVndw2vbq6vbZmxQ/qX3gXDcqyC/ttKFmxbsQ==", "c38023fe-cb7f-45e8-a1fb-2a50e59e99d4", "JohnDoe10" },
                    { "e5546bd2-c013-487e-bf37-ceafeafd4d1c", "d51cdeaf-4b7a-4609-ab30-7dc69e298f97", "johndoe41@personal.gmail", "JOHNDOE41@PERSONAL.GMAIL", "JOHNDOE41", "AQAAAAIAAYagAAAAEAnYLgaSb2WhgOK124QCoMcH3fUabaV0bRK9Zk9l8oo+dwfjZClHpBac6//vFcfpvw==", "03ef627f-a10a-4ccb-baac-a64367a31127", "JohnDoe41" },
                    { "ec8dc965-cf56-47b1-a2e5-2acb304aea6d", "eb097430-bf1b-48df-a134-e3aeae44bd38", "johndoe46@personal.gmail", "JOHNDOE46@PERSONAL.GMAIL", "JOHNDOE46", "AQAAAAIAAYagAAAAEJeV5V3+GpCQCGe/bjLd6FUCKoXC9Ro7pyBr472NsLDsdIjdYiGGhDsdb0AXmX593Q==", "c7f149cf-a7c8-4c0d-937d-5782b1dcebb8", "JohnDoe46" },
                    { "ee32d4e5-bd77-4f96-8739-ee95fbc35969", "f25602b8-fac3-4b47-b2e2-d72af036fdb7", "johndoe40@personal.gmail", "JOHNDOE40@PERSONAL.GMAIL", "JOHNDOE40", "AQAAAAIAAYagAAAAEMEdGhU/rok8TS38BIyuW2NJgoLX+5v9q9gIiF+G0lVNxow+wjcwaN7Th93nL8OHQQ==", "a33d7a81-3392-4b1b-87a8-bf57ee24b0c2", "JohnDoe40" },
                    { "f7f76ab7-9f72-4acc-af3b-b1e0dd52d8c2", "28fa30ed-86d2-4959-b377-710efb36698d", "johndoe9@personal.gmail", "JOHNDOE9@PERSONAL.GMAIL", "JOHNDOE9", "AQAAAAIAAYagAAAAEHV9AUHy0dZPK9et8aeDNXi3g1XENBcD1uLN8VLl6459rIZgVEDVeT0MsPatnTWqjA==", "142ec75d-0419-4edd-a7b3-fd7826990eef", "JohnDoe9" },
                    { "fa89aa42-ec85-4e8c-91c1-eaea93b64ef4", "f44837d5-2d8f-42ea-bdd4-9612e18cbb9c", "johndoe42@personal.gmail", "JOHNDOE42@PERSONAL.GMAIL", "JOHNDOE42", "AQAAAAIAAYagAAAAEDFAP2u/G6XkoXINwxp3eZVEcKW09c5gaLvD4jJ4N/IoZkicgZs6PJgydm1UU7LDYA==", "45e22e56-3f38-4543-b065-5d64c1a78394", "JohnDoe42" },
                    { "fdb5ed59-7b70-4616-8869-ee5ca03cc20d", "1b0d9050-d124-4198-b962-15518cfc9a9d", "johndoe45@personal.gmail", "JOHNDOE45@PERSONAL.GMAIL", "JOHNDOE45", "AQAAAAIAAYagAAAAECZzma6cTYXhzmU2EsxjvvlLR2E3yKg+hemLGPIBHHYU+Kb13VwTcF0ynOb2i+y/MA==", "0ce7541b-ce80-4e2c-9294-024e35df5c7b", "JohnDoe45" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Human Resources" },
                    { 2, "Finance" },
                    { 3, "IT" },
                    { 4, "Marketing" },
                    { 5, "Sales" },
                    { 6, "Operations" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyEmail", "DepartmentId", "FirstName", "JobTitle", "LastName", "Salary", "UserId" },
                values: new object[,]
                {
                    { 1, "johndoe1@company.gmail", 2, "John", "Finance Manager", "Doe", 3121.5m, "d0c6b2a5-8191-473e-bde4-cec7c1a4a865" },
                    { 2, "johndoe2@company.gmail", 3, "John", "IT Manager", "Doe", 6678.0m, "77819772-2107-48c1-96b5-8f7ede009c39" },
                    { 3, "johndoe3@company.gmail", 4, "John", "Marketing Manager", "Doe", 3297.0m, "8c0e8e33-afad-4e69-98c5-9f0cd07a0f9f" },
                    { 4, "johndoe4@company.gmail", 5, "John", "Sales Manager", "Doe", 3988.5m, "b50189b2-1e85-476f-b43b-7be200eb5a40" },
                    { 5, "johndoe5@company.gmail", 6, "John", "Operations Manager", "Doe", 3766.5m, "040a0e5e-f7ce-4ded-af4b-f1b5e33aaf42" },
                    { 6, "johndoe6@company.gmail", 1, "John", "HR Manager", "Doe", 2620.5m, "5a734a3e-8720-460f-86af-36e2a1018ba8" },
                    { 7, "johndoe7@company.gmail", 2, "John", "Accountant", "Doe", 2069m, "026e3971-3780-4328-88c3-5c1bd38cd2c3" },
                    { 8, "johndoe8@company.gmail", 3, "John", "System Admin", "Doe", 4444m, "937b77b9-8940-41ef-ab75-8980498ad7de" },
                    { 9, "johndoe9@company.gmail", 4, "John", "Marketing Specialist", "Doe", 2131m, "f7f76ab7-9f72-4acc-af3b-b1e0dd52d8c2" },
                    { 10, "johndoe10@company.gmail", 5, "John", "Business Developer", "Doe", 2860m, "e188573e-fb64-4593-8ef4-d3d0071fc7e6" },
                    { 11, "johndoe11@company.gmail", 6, "John", "Facilities Manager", "Doe", 2912m, "009458af-40c0-4a7c-9300-e47976528523" },
                    { 12, "johndoe12@company.gmail", 1, "John", "HR Generalist", "Doe", 1604m, "1037430f-09d0-4d04-b069-90590151685e" },
                    { 13, "johndoe13@company.gmail", 2, "John", "Accountant", "Doe", 2136m, "e1822941-e544-4b87-8fb4-9c04bca75113" },
                    { 14, "johndoe14@company.gmail", 3, "John", "Database Admin", "Doe", 4559m, "26f8970b-4857-46f9-9389-2f71c21e9295" },
                    { 15, "johndoe15@company.gmail", 4, "John", "SEO Analyst", "Doe", 2036m, "aefcd97e-81f9-4305-a574-d9cfd5a29361" },
                    { 16, "johndoe16@company.gmail", 5, "John", "Business Developer", "Doe", 2759m, "908fbda3-dce0-45ed-ac03-7148326006ee" },
                    { 17, "johndoe17@company.gmail", 6, "John", "Supply Chain Analyst", "Doe", 2536m, "21eb63b8-0a3c-4887-8ea0-eaf7a11266ba" },
                    { 18, "johndoe18@company.gmail", 1, "John", "Compensation Analyst", "Doe", 1636m, "7307b064-713d-4dee-8482-bc27678b7a00" },
                    { 19, "johndoe19@company.gmail", 2, "John", "Accountant", "Doe", 2031m, "13d86597-6417-426c-bb16-ac9e7f371728" },
                    { 20, "johndoe20@company.gmail", 3, "John", "Network Engineer", "Doe", 4411m, "e059c377-1e51-4c73-a867-38b7a9c0eec3" },
                    { 21, "johndoe21@company.gmail", 4, "John", "Social Media Manager", "Doe", 2163m, "da8b00d6-c4a6-48f6-b97b-fe9a52586e5e" },
                    { 22, "johndoe22@company.gmail", 5, "John", "Sales Representative", "Doe", 2597m, "566260d5-ac1e-4afb-9c10-c3e200afa0f3" },
                    { 23, "johndoe23@company.gmail", 6, "John", "Supply Chain Analyst", "Doe", 2812m, "82327ea9-d4ce-40d4-a11e-19b037c8f615" },
                    { 24, "johndoe24@company.gmail", 1, "John", "Training Specialist", "Doe", 1554m, "9614c9ac-3010-4737-92d9-eadf3c93cfea" },
                    { 25, "johndoe25@company.gmail", 2, "John", "Financial Analyst", "Doe", 2107m, "2bad1a92-a028-4688-93ba-299295a9aa76" },
                    { 26, "johndoe26@company.gmail", 3, "John", "Database Admin", "Doe", 4626m, "6222a67e-989f-4d70-a857-495a3fcfdfb3" },
                    { 27, "johndoe27@company.gmail", 4, "John", "SEO Analyst", "Doe", 2138m, "89589b78-3cfc-420c-b159-44d7bc15737b" },
                    { 28, "johndoe28@company.gmail", 5, "John", "Sales Representative", "Doe", 3789m, "c35f3a93-ebe3-447d-b4a5-c1c713060f69" },
                    { 29, "johndoe29@company.gmail", 6, "John", "Operations Specialist", "Doe", 2655m, "ad3601d2-3a37-48a7-85a3-81b3ff26dfd0" },
                    { 30, "johndoe30@company.gmail", 1, "John", "Compensation Analyst", "Doe", 1644m, "0e251df9-cbdb-4da3-81b1-397386effd8d" },
                    { 31, "johndoe31@company.gmail", 2, "John", "Accountant", "Doe", 2060m, "8c920c04-89e1-46c3-8b52-dee3b528f6f7" },
                    { 32, "johndoe32@company.gmail", 3, "John", "System Admin", "Doe", 4554m, "7f7c54d1-de99-47c1-99dc-0a0ab74a9ea8" },
                    { 33, "johndoe33@company.gmail", 4, "John", "Marketing Specialist", "Doe", 2023m, "2bda7639-9d19-49a6-a570-19d578f4389a" },
                    { 34, "johndoe34@company.gmail", 5, "John", "Account Executive", "Doe", 2176m, "1ba06199-67e8-4577-bc94-acace488ad33" },
                    { 35, "johndoe35@company.gmail", 6, "John", "Facilities Manager", "Doe", 2797m, "c8356b13-720b-4b43-a1a4-86688b7cc726" },
                    { 36, "johndoe36@company.gmail", 1, "John", "Training Specialist", "Doe", 1608m, "cd46004a-3500-4029-8fc4-c42cda168214" },
                    { 37, "johndoe37@company.gmail", 2, "John", "Auditor", "Doe", 2076m, "42190612-182a-4a7a-a06a-4bf0d43498c7" },
                    { 38, "johndoe38@company.gmail", 3, "John", "Database Admin", "Doe", 4814m, "57387e9a-9a9d-448b-a646-972a2517584b" },
                    { 39, "johndoe39@company.gmail", 4, "John", "Social Media Manager", "Doe", 2109m, "0f5240c5-b7c9-4c22-b4b8-df9b5d9c0a77" },
                    { 40, "johndoe40@company.gmail", 5, "John", "Sales Representative", "Doe", 3870m, "ee32d4e5-bd77-4f96-8739-ee95fbc35969" },
                    { 41, "johndoe41@company.gmail", 6, "John", "Supply Chain Analyst", "Doe", 2724m, "e5546bd2-c013-487e-bf37-ceafeafd4d1c" },
                    { 42, "johndoe42@company.gmail", 1, "John", "Recruiter", "Doe", 1609m, "fa89aa42-ec85-4e8c-91c1-eaea93b64ef4" },
                    { 43, "johndoe43@company.gmail", 2, "John", "Financial Analyst", "Doe", 2189m, "8a386ecb-3e8e-413f-a520-c32d8f86d0b4" },
                    { 44, "johndoe44@company.gmail", 3, "John", "Software Developer", "Doe", 4981m, "734ce118-ab9b-49c4-8467-992cd37a8f64" },
                    { 45, "johndoe45@company.gmail", 4, "John", "Content Writer", "Doe", 2176m, "fdb5ed59-7b70-4616-8869-ee5ca03cc20d" },
                    { 46, "johndoe46@company.gmail", 5, "John", "Account Executive", "Doe", 4010m, "ec8dc965-cf56-47b1-a2e5-2acb304aea6d" },
                    { 47, "johndoe47@company.gmail", 6, "John", "Operations Specialist", "Doe", 2602m, "bdcceafd-4cd8-447f-a4e6-e2b60ab7641c" },
                    { 48, "johndoe48@company.gmail", 1, "John", "Training Specialist", "Doe", 1642m, "3a3b2773-5cc6-4ba8-903b-31b2cfaf006d" },
                    { 49, "johndoe49@company.gmail", 2, "John", "Accountant", "Doe", 2156m, "b30a7b36-5516-48cc-9a0b-6cce3e0323af" },
                    { 50, "johndoe50@company.gmail", 3, "John", "System Admin", "Doe", 4265m, "3cce224a-e144-4dcd-8256-63c7c40f44ef" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "009458af-40c0-4a7c-9300-e47976528523");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "026e3971-3780-4328-88c3-5c1bd38cd2c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "040a0e5e-f7ce-4ded-af4b-f1b5e33aaf42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e251df9-cbdb-4da3-81b1-397386effd8d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f5240c5-b7c9-4c22-b4b8-df9b5d9c0a77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1037430f-09d0-4d04-b069-90590151685e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13d86597-6417-426c-bb16-ac9e7f371728");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ba06199-67e8-4577-bc94-acace488ad33");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21eb63b8-0a3c-4887-8ea0-eaf7a11266ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26f8970b-4857-46f9-9389-2f71c21e9295");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2bad1a92-a028-4688-93ba-299295a9aa76");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2bda7639-9d19-49a6-a570-19d578f4389a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a3b2773-5cc6-4ba8-903b-31b2cfaf006d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cce224a-e144-4dcd-8256-63c7c40f44ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42190612-182a-4a7a-a06a-4bf0d43498c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "566260d5-ac1e-4afb-9c10-c3e200afa0f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57387e9a-9a9d-448b-a646-972a2517584b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a734a3e-8720-460f-86af-36e2a1018ba8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6222a67e-989f-4d70-a857-495a3fcfdfb3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7307b064-713d-4dee-8482-bc27678b7a00");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "734ce118-ab9b-49c4-8467-992cd37a8f64");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77819772-2107-48c1-96b5-8f7ede009c39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f7c54d1-de99-47c1-99dc-0a0ab74a9ea8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82327ea9-d4ce-40d4-a11e-19b037c8f615");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89589b78-3cfc-420c-b159-44d7bc15737b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a386ecb-3e8e-413f-a520-c32d8f86d0b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c0e8e33-afad-4e69-98c5-9f0cd07a0f9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c920c04-89e1-46c3-8b52-dee3b528f6f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "908fbda3-dce0-45ed-ac03-7148326006ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "937b77b9-8940-41ef-ab75-8980498ad7de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9614c9ac-3010-4737-92d9-eadf3c93cfea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad3601d2-3a37-48a7-85a3-81b3ff26dfd0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aefcd97e-81f9-4305-a574-d9cfd5a29361");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b30a7b36-5516-48cc-9a0b-6cce3e0323af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b50189b2-1e85-476f-b43b-7be200eb5a40");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bdcceafd-4cd8-447f-a4e6-e2b60ab7641c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c35f3a93-ebe3-447d-b4a5-c1c713060f69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8356b13-720b-4b43-a1a4-86688b7cc726");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd46004a-3500-4029-8fc4-c42cda168214");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0c6b2a5-8191-473e-bde4-cec7c1a4a865");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da8b00d6-c4a6-48f6-b97b-fe9a52586e5e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e059c377-1e51-4c73-a867-38b7a9c0eec3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1822941-e544-4b87-8fb4-9c04bca75113");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e188573e-fb64-4593-8ef4-d3d0071fc7e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5546bd2-c013-487e-bf37-ceafeafd4d1c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec8dc965-cf56-47b1-a2e5-2acb304aea6d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee32d4e5-bd77-4f96-8739-ee95fbc35969");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7f76ab7-9f72-4acc-af3b-b1e0dd52d8c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa89aa42-ec85-4e8c-91c1-eaea93b64ef4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fdb5ed59-7b70-4616-8869-ee5ca03cc20d");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "186feb8e-58ba-4a77-8f06-029c7104abe8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "b0dbda95-3420-4986-b3b8-331c672316e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "fb8c4b31-3d0a-4cfd-a0d7-6f8f055d1913");
        }
    }
}
