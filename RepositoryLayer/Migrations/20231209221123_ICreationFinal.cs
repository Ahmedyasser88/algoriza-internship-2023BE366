using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class ICreationFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_AspNetUsers_User_Id",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Specialization_Specialize_Id",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_AspNetUsers_User_Id",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Discount_Discount_Id",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Time_Appointments_Appointment_Id",
                table: "Time");

            migrationBuilder.AddColumn<int>(
                name: "Booking_Status",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentStatus",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_AspNetUsers_User_Id",
                table: "Doctor",
                column: "User_Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Specialization_Specialize_Id",
                table: "Doctor",
                column: "Specialize_Id",
                principalTable: "Specialization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_AspNetUsers_User_Id",
                table: "Patient",
                column: "User_Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Discount_Discount_Id",
                table: "Patient",
                column: "Discount_Id",
                principalTable: "Discount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Time_Appointments_Appointment_Id",
                table: "Time",
                column: "Appointment_Id",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_AspNetUsers_User_Id",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Specialization_Specialize_Id",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_AspNetUsers_User_Id",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Discount_Discount_Id",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Time_Appointments_Appointment_Id",
                table: "Time");

            migrationBuilder.DropColumn(
                name: "Booking_Status",
                table: "Bookings");

            migrationBuilder.AlterColumn<string>(
                name: "AppointmentStatus",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_AspNetUsers_User_Id",
                table: "Doctor",
                column: "User_Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Specialization_Specialize_Id",
                table: "Doctor",
                column: "Specialize_Id",
                principalTable: "Specialization",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_AspNetUsers_User_Id",
                table: "Patient",
                column: "User_Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Discount_Discount_Id",
                table: "Patient",
                column: "Discount_Id",
                principalTable: "Discount",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Time_Appointments_Appointment_Id",
                table: "Time",
                column: "Appointment_Id",
                principalTable: "Appointments",
                principalColumn: "Id");
        }
    }
}
