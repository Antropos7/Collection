using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Homer
{
    public class Program
    {
        static List<Group> list = new List<Group>();
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            var group1 = new Group
            {
                Name = "Ruslan",
            };
            AddGroup(group1);
            var group2 = new Group
            {
                Name = "Ruslan"
            };
            AddGroup(group2);
            foreach (var group in list)
            {
                Console.WriteLine(group.GetDetails());
            }
            var student1 = new Student
            {
                Name = "Ruslan",
                Surname = "Murtuzaliyev",
                PIN = 11135115
            };
            AddStudent(student1);
            var student2 = new Student
            {
                Name = "AAmil",
                Surname = "Salamov",
                PIN = 12133913

            };
            AddStudent(student2);
            var student3 = new Student
            {
                Name = "Tets1",
                Surname = "Test2",
                PIN = 121337613
            };
            AddStudent(student3);
            foreach (var student in students)
            {
                Console.WriteLine(student.GetNameSurname());
            }
            Console.WriteLine($"Name contains 'a': " + GetCount());
        }


        static void AddStudent(Student student)
        {
            var isOnList = students.Any(k => k.PIN == student.PIN);
            if (!isOnList)
            {
                students.Add(student);
            }
        }

        static void AddGroup(Group group)
        {
            var isOnList = list.Any(l => l.Name == group.Name);
            if (!isOnList)
            {
                list.Add(group);
            }
        }

        static int GetCount()
        {
            int count = students.Count(s => s.Name.ToLower().Contains('a'));
            return count;

        }


    }
}