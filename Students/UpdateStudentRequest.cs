namespace ApiCrud.Students
{
    public record UpdateStudentRequest(string Name, sbyte Age, string Email, string Phone, string Address, string Cpf);
}
