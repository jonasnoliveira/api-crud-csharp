using ApiCrud.DataBase;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Students
{
    public static class StudentRoutes
    {
        public static void AddStudentRoutes(this WebApplication app)
        {
            var routesStudents = app.MapGroup("students");


            routesStudents.MapPost("", async (AddStudentRequest request, AppDbContext context, CancellationToken ct) =>
            {
                var existStudant = await context.Students.AnyAsync(student => student.Name == request.Name, ct);

                if (existStudant)
                {
                    return Results.Conflict(error: "Estudante existente!");
                }

                var newStudant = new Student(request.Name, request.Age); 
                
                await context.Students.AddAsync(newStudant, ct);
                await context.SaveChangesAsync(ct);

                var returnStudent = new StudentDto(newStudant.Id , newStudant.Name, newStudant.Age);

                return Results.Ok(returnStudent);
            });

            routesStudents.MapGet("", async (AppDbContext context, CancellationToken ct) =>
            {
                var students = await context.Students.
                Where(student => student.Status).
                Select(student => new StudentDto(student.Id, student.Name, student.Age)).
                ToListAsync(ct);

                return students;
            });

            routesStudents.MapPut("{id}", async (Guid id, UpdateStudentRequest request, AppDbContext context, CancellationToken ct) =>
            {
                var student = await context.Students.SingleOrDefaultAsync(student => student.Id == id, ct);

                if (student == null) 
                    return Results.NotFound();

                student.UpdateStudent(request.Name, request.Age);

                await context.SaveChangesAsync(ct);
                return Results.Ok(new StudentDto(student.Id, student.Name, student.Age));
            });

            routesStudents.MapDelete("{id}", async (Guid id, AppDbContext context, CancellationToken ct) =>
            {
                var student = await context.Students.SingleOrDefaultAsync(student => student.Id == id, ct);

                if (student == null)
                    return Results.NotFound("Estudante inexisteente");

                student.DeleteStudent();

                await context.SaveChangesAsync(ct);
                return Results.Ok("Estudante desativado com sucesso");
            });
        }
    }
}
