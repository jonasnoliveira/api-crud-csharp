namespace ApiCrud.Students
{
    public record AddStudentRequest(string Name, int Age, string Email, string Phone, string Address, string Cpf);
}
