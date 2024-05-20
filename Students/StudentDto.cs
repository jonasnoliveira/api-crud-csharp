namespace ApiCrud.Students
{
    public record StudentDto(Guid Id, string Name, int Age, string Email, string Phone, string Address, string Cpf);
}
