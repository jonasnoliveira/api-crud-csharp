namespace ApiCrud.Students
{
    public class Student
    {
        public Guid Id { get; init; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool Status { get; private set; }

        public Student(string name, int age)
        {
            Name = name;
            Id = Guid.NewGuid();
            Age = age;
            Status = true;
        }

        public void UpdateStudent (string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DeleteStudent ()
        {
            Status = false;
        }
    }
}
