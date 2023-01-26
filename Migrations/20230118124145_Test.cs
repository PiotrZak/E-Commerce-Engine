using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotnetCourse.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrls", "Location", "MainImageUrl", "Name", "Price", "Rating" },
                values: new object[,]
                {
                    { new Guid("0c3f1e93-6572-4878-af98-5ff8edc06c50"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage1.jpg", "The Mandarin Oriental Hotel", 447m, 2.7363551782760425 },
                    { new Guid("10315682-b8af-4a32-9092-9cbed32bdf53"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage2.jpg", "The St. Regis Hotel", 263m, 1.6768115927331817 },
                    { new Guid("19cbe83f-5aca-4e0b-a59c-ec0b78cfd482"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage1.jpg", "The Banyan Tree Hotel", 140m, 3.2437035286509279 },
                    { new Guid("1bdafe54-4654-498e-8c24-ccd0f92224e5"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage4.jpg", "The Aman Hotel", 138m, 2.3886312781368551 },
                    { new Guid("1d77138c-b61a-48d5-a09c-14a89b48815f"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage2.jpg", "The Banyan Tree Hotel", 399m, 4.4430327052175622 },
                    { new Guid("1e0ba401-9eb8-454c-9f46-50eb94520ba5"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage3.jpg", "The Mandarin Hotel", 221m, 3.2070255464816526 },
                    { new Guid("1f777171-e28b-413f-815d-d7029138e2ac"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage2.jpg", "The Rosewood Hotel", 105m, 4.6355124197852842 },
                    { new Guid("2139430d-8caa-4733-9d27-2045ad708387"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Sydney", "mainimage3.jpg", "Le Meridien Hotel", 468m, 3.4578365070147314 },
                    { new Guid("24e14f65-8c93-42f9-b0c5-99d3269443e1"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage5.jpg", "The Shangri-La Hotel", 237m, 1.4898333257659069 },
                    { new Guid("25e6e3c5-ca60-45eb-a819-f8941a9fa996"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage5.jpg", "The Oberoi Hotel", 292m, 2.480953968134421 },
                    { new Guid("26c4afb5-0f91-466d-995c-ddd037ae2379"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage2.jpg", "Four Seasons Hotel", 424m, 0.62964295692538419 },
                    { new Guid("298f20d2-d7a9-4c57-9d2f-3f40a7b4081b"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage1.jpg", "The Wydham Hotel", 348m, 1.0596571342447207 },
                    { new Guid("2cd098c0-e3c8-49b4-a99f-4aecaa4657d0"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage1.jpg", "W Hotels", 160m, 3.8055630115266483 },
                    { new Guid("2eabeecf-9bd1-45b0-97f5-4ae3b4d69d64"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage3.jpg", "Grand Hotel", 349m, 3.2634150561536792 },
                    { new Guid("2eb21fec-103f-45ae-9428-d5ddab0ef9c6"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage2.jpg", "The Banyan Tree Hotel", 208m, 4.560913160011733 },
                    { new Guid("304c020f-6764-48c1-be2a-1c3730269599"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Sydney", "mainimage2.jpg", "The Oberoi Hotel", 110m, 1.6335877876507761 },
                    { new Guid("37caa274-f401-4b10-b027-ff8beaf4742d"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage2.jpg", "The Oberoi Hotel", 130m, 2.96608136636931 },
                    { new Guid("37cb8cba-3a9f-4210-b416-94413641c7b8"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage2.jpg", "The Belmond Hotel", 381m, 0.32465728363133384 },
                    { new Guid("37e4062e-0496-4388-ae49-33215bc7e996"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage3.jpg", "Hilton Hotel", 223m, 2.327587164577432 },
                    { new Guid("3835ba13-454e-4aaa-9bd3-127b78b62a11"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage4.jpg", "The Belmond Hotel", 342m, 0.41586485512879523 },
                    { new Guid("3938889b-ccc5-4ac6-8d41-601e2ec62b4d"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage2.jpg", "The Park Hyatt Hotel", 288m, 4.8830146343958223 },
                    { new Guid("3ef86faf-a3ea-4eca-b478-a9c7f5b3257f"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage5.jpg", "The Crowne Plaza Hotel", 191m, 0.4411414763766186 },
                    { new Guid("43bf66f0-a4f6-4b30-8091-57035dfc2f5c"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage5.jpg", "The Fairmont Hotel", 274m, 4.7361755713110814 },
                    { new Guid("43cccdea-a156-4d4a-941c-25c77aae6bf7"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage4.jpg", "The Westin Hotel", 385m, 1.3242939385693102 },
                    { new Guid("45afebad-9624-4e2b-8594-18b059cec920"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Sydney", "mainimage2.jpg", "Marriott Hotel", 296m, 1.5512670443505043 },
                    { new Guid("4aa832f6-1f4d-4554-a3bd-153f94c01128"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage1.jpg", "The Rosewood Hotel", 158m, 2.6448203194875175 },
                    { new Guid("4ac6bcbc-cdc1-4bf6-bd5b-25a90f6af902"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage2.jpg", "InterContinental Hotel", 236m, 0.19371283242591131 },
                    { new Guid("4b80eda2-4959-43fb-8f26-798a6c26f203"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage1.jpg", "The Shangri-La Hotel", 167m, 2.2354370781512527 },
                    { new Guid("4d930a9b-c49a-4e54-90b6-8b290e1f1312"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage5.jpg", "The Rosewood Hotel", 431m, 0.056430175749687117 },
                    { new Guid("50a1665d-18bd-468f-9262-294fd7bddd9c"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage3.jpg", "The Banyan Tree Hotel", 196m, 0.73238405437384579 },
                    { new Guid("52d05aad-dbda-4ab2-beaf-9df4f05f7c53"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Sydney", "mainimage4.jpg", "The Westin Hotel", 368m, 2.7581180224036279 },
                    { new Guid("56d292c2-4458-429e-939e-4d050db4893e"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Sydney", "mainimage2.jpg", "The Hyatt Hotel", 381m, 2.971903382872326 },
                    { new Guid("56d470fa-f120-4656-b833-5375fea2305d"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage5.jpg", "The Sofitel Hotel", 383m, 1.0418386524479812 },
                    { new Guid("5a2e2e2d-6385-406c-abe8-e4c9df1fc7f7"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage4.jpg", "The Aman Hotel", 119m, 2.6177745671926274 },
                    { new Guid("5af63be9-fce7-4f22-aa42-7ea751ca02b1"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage5.jpg", "The Westin Hotel", 473m, 0.17476209765484363 },
                    { new Guid("6230748e-31d8-4590-8ea4-d48d5123f7aa"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Sydney", "mainimage5.jpg", "The Aman Hotel", 400m, 0.7659330227718808 },
                    { new Guid("64f27b9c-69b1-44fe-8430-d021f0ebf59a"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage2.jpg", "The Banyan Tree Hotel", 127m, 0.98387639044586139 },
                    { new Guid("67733825-37e5-4c24-96ce-5d9e83f2dee4"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage2.jpg", "The Shangri-La Hotel", 293m, 3.6361978234664409 },
                    { new Guid("67a1f6b0-c0ff-4447-925b-968fb334a935"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage4.jpg", "The Raffles Hotel", 331m, 1.6414571781486775 },
                    { new Guid("6a487b8e-2742-41b8-9d02-fce250f8a8d8"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage2.jpg", "The Crowne Plaza Hotel", 330m, 4.6958129591951945 },
                    { new Guid("6aa30a1d-0acb-441e-99ae-bc03e7e72fc7"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage3.jpg", "The Rosewood Hotel", 161m, 2.411906994248016 },
                    { new Guid("6ab23088-5359-4197-9182-f0c83dfd7a63"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage2.jpg", "The Luxury Collection Hotel", 361m, 3.9964427961441067 },
                    { new Guid("6d09cb8d-a909-4ad2-a1ff-ae3103ba3ca2"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Sydney", "mainimage1.jpg", "The Park Hyatt Hotel", 437m, 3.8653059856613909 },
                    { new Guid("6ee24d2b-1372-483d-a762-b3c746486a4e"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage5.jpg", "The Plaza", 380m, 1.0249065250666289 },
                    { new Guid("727d50da-3c0c-4433-9139-7aecb94bf965"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage4.jpg", "Hotel Ritz", 132m, 0.14880170663821302 },
                    { new Guid("77901e92-f384-44bb-80bc-fc40c77b97a0"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage1.jpg", "The Belmond Hotel", 204m, 3.735211276038247 },
                    { new Guid("7bf5b1d0-6ae3-4e23-885c-17c246b41866"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Sydney", "mainimage1.jpg", "The Peninsula Hotel", 296m, 3.213820773426677 },
                    { new Guid("7bfd4983-7144-4bb7-88d2-de8b03a2164c"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Sydney", "mainimage4.jpg", "Marriott Hotel", 481m, 0.04668487385506348 },
                    { new Guid("7d55363e-8ab4-43e0-b5ea-b8fde8196fdc"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage3.jpg", "The Belmond Hotel", 445m, 2.6758687757048167 },
                    { new Guid("7e9463a8-b50e-4978-bdc3-cd5cc26b0a5d"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Sydney", "mainimage4.jpg", "The Aman Hotel", 137m, 0.36901979221033221 },
                    { new Guid("7f0bc9ae-ad2f-4b08-b52f-c2cd924a0c91"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage2.jpg", "The Waldorf Astoria Hotel", 402m, 1.3972875254402113 },
                    { new Guid("80b56c2b-8df1-47d3-9e1b-2b28f88af0e4"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Sydney", "mainimage2.jpg", "The Belmond Hotel", 406m, 4.8074682575738068 },
                    { new Guid("880ea1b7-2cb7-4c55-a402-e5117151168c"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage4.jpg", "The Belmond Hotel", 321m, 2.6868767203221458 },
                    { new Guid("889d97e5-7c26-4f8d-9cc9-3b61036723f6"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage4.jpg", "The Rosewood Hotel", 351m, 1.9625095676774551 },
                    { new Guid("8a5dfff1-efb3-47ae-a63d-78c1dd4b972b"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage1.jpg", "The Shangri-La Hotel", 402m, 3.4571681778416528 },
                    { new Guid("8abecd2c-51f6-458e-b6fe-efea00681a63"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage4.jpg", "The Rosewood Hotel", 167m, 3.1980276845811768 },
                    { new Guid("8e189002-a661-4255-a234-cfd61770f820"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage2.jpg", "The Mandarin Hotel", 440m, 1.6360086270501677 },
                    { new Guid("90818a8f-99e3-47b9-ad5d-23ed2bc0c4d2"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage2.jpg", "Grand Hotel", 204m, 2.8027834909100973 },
                    { new Guid("9159bbe6-e4f2-4be3-b59d-e8e9bd63e562"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage2.jpg", "The Aman Hotel", 333m, 4.51150818817435 },
                    { new Guid("93666af0-f6ef-4de9-b9ea-3fd2d7e7082b"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage2.jpg", "The Mandarin Oriental Hotel", 418m, 0.27966654668481306 },
                    { new Guid("947d975f-8c26-4df3-bb56-ed3b60d2b2b7"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Sydney", "mainimage1.jpg", "The Westin Hotel", 387m, 2.1200643741677343 },
                    { new Guid("95b910e8-abf6-4ae5-a17f-9e2bac2c5d9b"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage5.jpg", "The Banyan Tree Hotel", 147m, 1.3546786927965404 },
                    { new Guid("9698de08-7a28-4feb-ab2b-590e34b5d0e6"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Sydney", "mainimage5.jpg", "The Rosewood Hotel", 223m, 4.6881415519880409 },
                    { new Guid("983b5d89-7b34-4a0f-9398-2d332db2c593"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage3.jpg", "The Crowne Plaza Hotel", 131m, 3.48427576573952 },
                    { new Guid("9922c755-3800-4f92-a49b-4ca7fa39242f"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage2.jpg", "The Park Hyatt Hotel", 212m, 3.1886608229385822 },
                    { new Guid("9bb8750a-fb7c-41f5-a0a1-4f7756a5024d"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage4.jpg", "The Belmond Hotel", 491m, 1.0902490111213181 },
                    { new Guid("9e8f1ff8-5f9d-4c26-8dd7-027ca1e0378a"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage4.jpg", "The Oberoi Hotel", 376m, 0.48190649143888153 },
                    { new Guid("a1787ef2-907f-48cd-a942-50d3ef63c375"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage3.jpg", "Four Seasons Hotel", 379m, 1.3459474557443647 },
                    { new Guid("a7fbb982-0c73-4ab6-9e81-95100132f4cf"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage5.jpg", "The Oberoi Hotel", 371m, 3.9375722541715366 },
                    { new Guid("ac50fd8f-3278-4103-bad7-a3ffec3c8c1a"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage3.jpg", "Four Seasons Hotel", 148m, 1.7409405746732216 },
                    { new Guid("acdf6b66-9fdf-4352-8d32-5b6c872fab33"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage2.jpg", "The Novotel Hotel", 113m, 3.2615209660425131 },
                    { new Guid("ae27ea83-51c4-4eb4-a64f-a15fea3691de"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage5.jpg", "Sheraton Hotel", 347m, 4.8154301218481033 },
                    { new Guid("af51c8f4-447a-4d33-a76a-0c7410bfb9d9"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage5.jpg", "Sheraton Hotel", 322m, 1.376245053522176 },
                    { new Guid("af62554e-4ea8-4607-a12c-c7a5cd7ce241"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage4.jpg", "The Crowne Plaza Hotel", 369m, 4.2483525474083628 },
                    { new Guid("b4649f28-a73b-4b97-97a0-6414168c76de"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage3.jpg", "The St. Regis Hotel", 330m, 2.4812646535635889 },
                    { new Guid("b711e593-fba4-4733-ae7b-8068e868b3a6"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage1.jpg", "The Sofitel Hotel", 383m, 1.9997162572757832 },
                    { new Guid("bec413ed-9b01-4687-9615-6fa782acae3a"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage4.jpg", "The Aman Hotel", 155m, 3.0522732783925295 },
                    { new Guid("c20af97a-ffc9-4086-ba4e-4f77883ea9ed"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage2.jpg", "The Rosewood Hotel", 430m, 4.4256072248646108 },
                    { new Guid("c5720a1e-8af5-49d0-81e9-8582ef8b9bba"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage3.jpg", "The Hyatt Hotel", 497m, 0.81827211656685106 },
                    { new Guid("c5e07a9b-4ac6-40b8-a8e3-8bc9e6fe459a"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage5.jpg", "The Belmond Hotel", 222m, 0.4191440892252829 },
                    { new Guid("c67a0e0a-ea0d-4a26-b1c9-84266bbf092e"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage2.jpg", "The Aman Hotel", 343m, 1.9835551254441441 },
                    { new Guid("c97ba8f5-c0d5-41db-b78c-094dc8fe07e0"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage3.jpg", "The Sofitel Hotel", 480m, 2.5641288050764626 },
                    { new Guid("cc9b1c96-6c10-4b53-9a4b-48ef236ac73d"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Sydney", "mainimage1.jpg", "The Luxury Collection Hotel", 369m, 2.0351333863377583 },
                    { new Guid("cd6e4c8f-8cdf-4875-8107-6dac28cf93ce"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Sydney", "mainimage1.jpg", "The Banyan Tree Hotel", 329m, 1.7967318522350673 },
                    { new Guid("d198a1cd-2084-47d5-80d8-840031d85c47"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage2.jpg", "The Radisson Hotel", 428m, 1.3455270738867131 },
                    { new Guid("d422784d-8d9c-46a4-a1f6-baf814fefeb0"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage4.jpg", "The Mandarin Hotel", 113m, 1.1486088723780634 },
                    { new Guid("dd148dda-0dd6-4251-98fe-4cf3779fe447"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage2.jpg", "The Raffles Hotel", 350m, 0.76452244439324024 },
                    { new Guid("ddb92d26-13ae-42a8-a096-2773aac8f810"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage5.jpg", "The Peninsula Hotel", 146m, 1.555313802858918 },
                    { new Guid("de3911c1-2262-481d-8c56-536c47fada5a"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage2.jpg", "The Plaza", 278m, 0.34448340340057171 },
                    { new Guid("def9ee3a-c2c1-4b50-a08d-6a72a2e65c19"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage2.jpg", "The Banyan Tree Hotel", 200m, 3.5190963925601899 },
                    { new Guid("e2701f19-c1c0-4a0b-aac2-58a809774a16"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Paris", "mainimage4.jpg", "The Banyan Tree Hotel", 398m, 3.7871473058479808 },
                    { new Guid("e7e7a59c-1597-4beb-a05b-4f7869e512ac"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage3.jpg", "The Westin Hotel", 114m, 3.2249690868565937 },
                    { new Guid("e9ca63e9-9ffd-4aa2-8211-d84bcadcc102"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage5.jpg", "The Hyatt Hotel", 171m, 4.2942656060575519 },
                    { new Guid("f413d279-af4b-474d-9700-f534164c1499"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage3.jpg", "Sheraton Hotel", 240m, 2.965560630854883 },
                    { new Guid("f683c8fd-9983-4c9c-b502-f1e6a3c83bf1"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage4.jpg", "The Savoy", 154m, 2.8229659021162234 },
                    { new Guid("f6a6da35-559b-4be2-b02b-f06819a76273"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Tokyo", "mainimage2.jpg", "The St. Regis Hotel", 376m, 4.2502591753913848 },
                    { new Guid("f7c9895b-d1c6-4a33-a3a1-cf8d560e3d16"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "New York", "mainimage2.jpg", "The Oberoi Hotel", 130m, 4.8572405264996421 },
                    { new Guid("fadf533e-a696-44c9-a31e-c12594cffff3"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "Sydney", "mainimage4.jpg", "The Aman Hotel", 493m, 4.9305042894758664 },
                    { new Guid("fb39f680-6717-4c96-a3b5-34144cce1a26"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage4.jpg", "The St. Regis Hotel", 353m, 1.9571988992406557 },
                    { new Guid("feafb570-d946-4a00-9440-26b1d98af8a8"), "System.Linq.Enumerable+SelectArrayIterator`2[System.String,System.String]", "London", "mainimage4.jpg", "Grand Hotel", 440m, 3.7008693838653466 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
