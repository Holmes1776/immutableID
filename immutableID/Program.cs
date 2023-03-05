using System;
namespace recordDemo
{
    class Program
    {
        public record Student
        {
            public int Id { get; init; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // default constructor
            public Student()
            {
                Id = 0;
                FirstName = "";
                LastName = "";
            }

            public Student(int i)
            {
                Id = i;
                FirstName = string.Empty;
                LastName = string.Empty;
            }
            // parameterized constructor
            public Student(int i, string First, string Last)
            {
                Id = i;
                FirstName = First;
                LastName = Last;
            }
        }
        public static void Main()
        {
            Student student1 = new(34);
            student1.FirstName = "John";
            student1.LastName = "Wick";
            Console.WriteLine(student1);
            Student student2 = new(7, "James", "Bond");
            Console.WriteLine(student2);
        }

    }
}