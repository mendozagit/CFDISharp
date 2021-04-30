using Microsoft.EntityFrameworkCore.Migrations;

namespace CFDISharp.Winforms.Migrations
{
    public partial class InitialCDFISharp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SatFiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Base64File = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatFiles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SatFiles",
                columns: new[] { "Id", "Base64File", "Type" },
                values: new object[] { -1, "MIIFyDCCA7CgAwIBAgIUMzAwMDEwMDAwMDA0MDAwMDI0NDMwDQYJKoZIhvcNAQELBQAwggErMQ8wDQYDVQQDDAZBQyBVQVQxLjAsBgNVBAoMJVNFUlZJQ0lPIERFIEFETUlOSVNUUkFDSU9OIFRSSUJVVEFSSUExGjAYBgNVBAsMEVNBVC1JRVMgQXV0aG9yaXR5MSgwJgYJKoZIhvcNAQkBFhlvc2Nhci5tYXJ0aW5lekBzYXQuZ29iLm14MR0wGwYDVQQJDBQzcmEgY2VycmFkYSBkZSBjYWRpejEOMAwGA1UEEQwFMDYzNzAxCzAJBgNVBAYTAk1YMRkwFwYDVQQIDBBDSVVEQUQgREUgTUVYSUNPMREwDwYDVQQHDAhDT1lPQUNBTjERMA8GA1UELRMIMi41LjQuNDUxJTAjBgkqhkiG9w0BCQITFnJlc3BvbnNhYmxlOiBBQ0RNQS1TQVQwHhcNMTkwNjE3MjA0MDUxWhcNMjMwNjE3MjA0MDUxWjCB7zEqMCgGA1UEAxMhWEVOT04gSU5EVVNUUklBTCBBUlRJQ0xFUyBTIERFIENWMSowKAYDVQQpEyFYRU5PTiBJTkRVU1RSSUFMIEFSVElDTEVTIFMgREUgQ1YxKjAoBgNVBAoTIVhFTk9OIElORFVTVFJJQUwgQVJUSUNMRVMgUyBERSBDVjElMCMGA1UELRMcWElBMTkwMTI4SjYxIC8gS0FITzY0MTEwMUIzOTEeMBwGA1UEBRMVIC8gS0FITzY0MTEwMUhOVExLUzA2MSIwIAYDVQQLExlYZW5vbiBJbmR1c3RyaWFsIEFydGljbGVzMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAiJQ5YcSgjwsGf29+3go7VGdtMZCcH9wUpn46ZMAlFwUojnCPTvwJ3+cSwjqJnw8ahr3DuRwekvGR4BJAb5b9Xi8kyoiWtwcGOSWxO38Bp9J1e/BO9HMbQBPAtLDuG47oqnH8zWLOeaoYRJDpARw4RX1ko2+9tbj0ntBtM7Vk1E8EWiA/h2Meq0LIv1+ySGTUrEW46FM01J5pzELv5XupBghuJxR5DG9fiOW7u3dR5s3tZoVLwA1KdjJtY0mmnfCwxg6i5AqhvY+FAI5D6CF6/lHA8PWg63WasvrhuIv70xCLjgPT/j00ZcPrLvBf1DefGVic980Ch/SDvC+MdJ1F5wIDAQABox0wGzAMBgNVHRMBAf8EAjAAMAsGA1UdDwQEAwIGwDANBgkqhkiG9w0BAQsFAAOCAgEACjfTPoKY2N5MxjmAMltd5XZCV1vgAwEtrIRYTodhE8R0Tp1QanAXb0luPyBv5hIXWK4VqAI4fcTtP+n7kkrwfha6ErkPWFNJWJm8ZsMmby/3WgVoJkOFyRYQqr5Il3N6wMa5kiDBtDRbqB3iEXmvtrvjWSHyxAER+zo3jWGFlhBZ0nQNRtjx8sPFihVc5TUH682HJiU4oWvT63Dnra8ncqiW/uCuY86crnUq0fW7Lw/3+PY5xXjNxR/Hh3sUPITfJrGaLWurD1J9npr9yGAJ6t9zrhhZnepIC0DUMc5+j4pg1DrO32jzwUOLQqErDizh84NoJCWwbg+US8wi3zD0ZKiDv7XsTNWAW2Ap2JkzykKHjFTZiEm3uZOkJNfcu3o+kefr5HfXFT+iN9K5FUEhaQwgUeZBRJ8V5F6gmhz3d6ixVbiZoFNhYR8e2k8gF9gGrVMrEbJGQrl+6+ZYQLFiauXeG7fu1svk19PuyredRJGnseJqyV4RzcRGhJA+cLnmpdDOTEhignnvnhEuY6HVRYYXhOTyeeluET7KRCxbJGqO7TdWgjrHL3HRbNE4NY5GAdOZuLaWxElG5ZVCHqtG0Nh7UQAhcz+EKyZBAewv5XuH0OomZXw6mM2mY2soL6z1224NusM8/BbJcYTQUlAEKblEChhGK1XlxiVOU2nc9KE=", "cer" });

            migrationBuilder.InsertData(
                table: "SatFiles",
                columns: new[] { "Id", "Base64File", "Type" },
                values: new object[] { -2, "MIIFDjBABgkqhkiG9w0BBQ0wMzAbBgkqhkiG9w0BBQwwDgQIAgEAAoIBAQACAggAMBQGCCqGSIb3DQMHBAgwggS/AgEAMASCBMh4EHl7aNSCaMDA1VlRoXCZ5UUmqErAbucoZQObOaLUEgEZxy2sVwcFoLUO6F8GwkjCqMfUFqJtAFOCWuQN7HOwS7cvKXJdOrTPxrfYyA3pnAzHu/USC2W1WR6lVzjNiUkecMApa5nGySFGqMVJf4zcVsPd5WCrd5VdjQRtSG1zSQjiwHaFVzAm0OCSY0RhUymnOXlDjYYEA3Jk69OnmVf9wfvnUbDSsWldlmYjpScPWWb+DRTLcKWHkIT8q4pYmx26LZ/bEJq2NEv4KachyrzyLEsEBC09qFAyTxIPxiDMTGNpRChD5BvC+CU4+Af+YCqu77YhAocCQo1MgrrkJ3LLIMi55mxmftvd05uNZrViI1NAqHS2fVlklY/KOj97tFHvquPnG+4Q9jObwIb9lQhbRizk4sbGlHZ/qnREbPLNrv4JghCpwrRHLVM2+A+gY2pFoXVwf8daH/rPsyFVqjE9ZcVVa9WZQCO5h+PlTKh2LU8zgSCJvJe7Up4AEYtMfcW+HYlaGyb2TCHag6olgrxRU2caQwbK7/L3lgq3seFyJxVGXKhT4Rk+I5ZCk17LZeUfuxtXmIh0dSUzr39Ze0yriV2gLGFMHq5QI5TVJeiLThGugvz9gxPeFNbcS6VlkFZZRLgk3gmZSpaqHuKfxilREDCDGyhlkUYI6gpRhiAIQV5L2P6XKvKwTAH6Mijj0FbBLS6W2jnXUhXa1nd2Ch1o7GajjKrSY58zy9NKDaJljHGFDnoBFpq4nWqze1VAktD+s90hp8At8NldgYgwTyd1vtQdZKad5jk4iLuJCsMBtXuKleSaIIYZRWvMFqR8qs0PnDswogoCggzcMbE6aCD8lF97keLSEZ34QScLTBhkoLcCzgn6oT5qRrumAhw4yXr+N3W9YlFg6hC1LquyVA/sMhETj2N+ED4M9/4I3nt5HJfTJCuHTOct3ZjOLKMZJ+VN5KpMfRsahllDdpD0Lzcech/y9tTpguSasIp3GCnKxr79Wx3c3IeZHImZoi78WLOGMp6KYWD8CSS5UnqZR5b1Bs2i7u9ccR3M96Fb15drk3mutOyJixwWpIRhTJO/EgPWiUnL2IJWPuFZp0kZx1we9HQtL0xhOlymZKnZ6vulraTraJVKHBEPjlevaYEiP1jPMPxW+7dWBbz3rHh2P0mDOuZj9bKPKuH3aLn6uTDk7RRJQeNJJLJJZsXciL7sJHYpz/cYlLSPDV2RbutXp6WbRazljO7qEbBTkNo3uHdObyCmnofe0i1dku5Kh3JRMwNZ5LoFtLRLwGHj6Oqj3+vHz/lKjKVHajC3YUShNZrKZ0AepEIGajg7E5CZDXgLZxECjvhr6RcUx5G0vjp2iOf98MhAjFWCcNBDUnUcJviYnA4OtIFFHXMN75iIO7wJQymb7OXhGr93JMsjA4/Dtsq5O23rpjzrys9HzTIGABYbMdWp7n8kP127IgKIcRlQV3ts7PO7ATgRG83yYVoGZrOk50RePyK55nzEmct4GQiLsFVkzo8ucLNQmGGbO44Cd9oToOC+CawpOsQtvzqwGLQDDfbJtwI8uBEoCeObo7c/qqdCj+8oPEfMTYyLj+/g5/DhxalMK9i4m7WdMTQDo4MmdJtP6cXZgXc=", "key" });

            migrationBuilder.InsertData(
                table: "SatFiles",
                columns: new[] { "Id", "Base64File", "Type" },
                values: new object[] { -3, "MTIzNDU2Nzhh", "pass" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SatFiles");
        }
    }
}
