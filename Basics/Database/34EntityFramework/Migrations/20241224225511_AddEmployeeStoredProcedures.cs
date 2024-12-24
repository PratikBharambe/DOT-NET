using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _34EntityFramework.Migrations
{
    public partial class AddEmployeeStoredProcedures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Stored procedure for getting employee by id
            migrationBuilder.Sql(@"
            CREATE PROCEDURE GetEmployeeById
            @Id INT
            AS
            BEGIN
            SELECT * FROM Emp
            WHERE Id = @Id
            END
            ");

            // Stored procedure for getting employees whoes address starts with given alphabet
            migrationBuilder.Sql(@"
            CREATE PROCEDURE GetEmployeesByAddressStartsWith
            @StartLetter NVARCHAR(1)
            AS
            BEGIN
            SELECT * FROM Emp
            WHERE Address LIKE @StartLetter + '%'
            END
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE GetEmployeeById");
            migrationBuilder.Sql("DROP PROCEDURE GetEmployeesByAddressStartsWith");
        }
    }
}
