namespace ApiCrud.Students
{
    public record AddStudentRequest(string Name, sbyte Age, string Email, string Phone, string Address, string Cpf);
}
