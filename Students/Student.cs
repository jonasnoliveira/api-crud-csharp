namespace ApiCrud.Students
{
    public class Student
    {
        public Guid Id { get; init; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public string Cpf { get; private set; }
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
            Cpf = cpf;
        }

        public void DeleteStudent ()
        {
            Status = false;
        }
    }
}
