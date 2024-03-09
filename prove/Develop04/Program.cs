// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Develop04 World!");

//         Student s1 = new Student("id1", "Bob", "CSE");
//         Faculty f1 = new Faculty("id2", "Sue", "BioAg");

//         List<Person> people = new List<Person>();
//         people.Add(s1);
//         people.Add(f1);

//         foreach (var person in people)
//         {
//             System.Console.WriteLine("does this work");
//             System.Console.WriteLine($"{person.DisplayInfo()}")
//             if (person is Student)
//             {
//                 Student student = (Student)person;
//                 student.Display();
//             }
//             else
//             {
//                 Faculty faculty = (Faculty)person;
//             }
//         }
//     }
// }

// class Person {
//     private string id;
//     private string name;

//     public Person(string id, string name) {
//         this.id = id;
//         this.name = name;
//     }

//     public string DisplayInfo()
//     {
//         return $"{name}; {id}";
//     }
// }

// class Student : Person
// {
//     private string major;

//     public Student(string id, string name, string major) : base(id, name)
//     {
//         this.id = id;
//         this.name = name;
//         this.major = major;
//     }

//     protected string DisplayInfo()
//     {
//         System.Console.WriteLine();
//     }
// }

// class Faculty : Person
// {
//     private string department;

//     public Faculty(string id, string name, string department) : base(id, name) {
//         thid.department = department;
//     }

// }