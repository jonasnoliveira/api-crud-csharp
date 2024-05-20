using System.Net;
using System.Numerics;

namespace ApiCrud.Students
{
    public class Student
    {
        public Guid Id { get; init; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Cpf { get; set; } = string.Empty;
        public bool Status { get; private set; }

        public Student(string name, int age, string email, string phone, string address, string cpf)
        {
            Id = Guid.NewGuid();
            Name = name;
            Age = age;
            Email = email;
            Phone = phone;
            Address = address;
            Cpf = cpf;
            Status = true;
        }

        public void UpdateStudent (string name, int age, string email, string phone, string address, string cpf)
        {
            Name = name;
            Age = age;
            Email = email;
            Phone = phone;
            Address = address;
        }

        public void DeleteStudent ()
        {
            Status = false;
        }
    }
}
