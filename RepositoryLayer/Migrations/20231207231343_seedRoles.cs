using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace RepositoryLayer.Migrations
{
    public partial class seedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table : "AspNetRoles",
                columns: new [] {"Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] {Guid.NewGuid().ToString(), "Admin" , "User".ToUpper(), Guid.NewGuid().ToString() }
                );
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { Guid.NewGuid().ToString(), "Doctor", "Doctor".ToUpper(), Guid.NewGuid().ToString() }
                );
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { Guid.NewGuid().ToString(), "Patient", "Patient".ToUpper(), Guid.NewGuid().ToString() }
                );

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [AspNetRoles]");

        }
    }
}
