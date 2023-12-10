using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class ICreation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Discount_DiscountId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Doctor_DoctorId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Doctor_DoctorsId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_DoctorsId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "DoctorsId",
                table: "Bookings");

            migrationBuilder.AlterColumn<string>(
                name: "Dcotor_Id",
                table: "Bookings",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Dcotor_Id",
                table: "Bookings",
                column: "Dcotor_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Discount_DiscountId",
                table: "Appointments",
                column: "DiscountId",
                principalTable: "Discount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Doctor_DoctorId",
                table: "Appointments",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Doctor_Dcotor_Id",
                table: "Bookings",
                column: "Dcotor_Id",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Discount_DiscountId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Doctor_DoctorId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Doctor_Dcotor_Id",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_Dcotor_Id",
                table: "Bookings");

            migrationBuilder.AlterColumn<string>(
                name: "Dcotor_Id",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorsId",
                table: "Bookings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_DoctorsId",
                table: "Bookings",
                column: "DoctorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Discount_DiscountId",
                table: "Appointments",
                column: "DiscountId",
                principalTable: "Discount",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Doctor_DoctorId",
                table: "Appointments",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Doctor_DoctorsId",
                table: "Bookings",
                column: "DoctorsId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
