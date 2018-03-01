using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace aitutor.Migrations
{
    public partial class UpdatedPropertyCaseing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lecture_Courses_CourseId",
                table: "Lecture");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Lecture",
                newName: "Courseid");

            migrationBuilder.RenameIndex(
                name: "IX_Lecture_CourseId",
                table: "Lecture",
                newName: "IX_Lecture_Courseid");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Courses",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Courses",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lecture_Courses_Courseid",
                table: "Lecture",
                column: "Courseid",
                principalTable: "Courses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lecture_Courses_Courseid",
                table: "Lecture");

            migrationBuilder.RenameColumn(
                name: "Courseid",
                table: "Lecture",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Lecture_Courseid",
                table: "Lecture",
                newName: "IX_Lecture_CourseId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Courses",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Courses",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lecture_Courses_CourseId",
                table: "Lecture",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
