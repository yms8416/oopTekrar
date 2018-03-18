using BilgeAdam.OOP.Generics.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.OOP.Generics
{
    public class ComplexTypes
    {
        public static IEnumerable<Student> SaveStudents()
        {
            var students = new HashSet<Student>(new StudentComparer());
            var a1 = new Student(5) { FirstName = "Can", LastName = "PERK" };
            var a2 = new Student(5) { FirstName = "Can", LastName = "PERK" };
            var a3 = new Student(5) { FirstName = "Can", LastName = "PERK" };
            var a4 = new Student(5) { FirstName = "Can", LastName = "PERK" };
            var b1 = new Student(1) { FirstName = "Ömer", LastName = "KORKMAZ" };
            var b2 = new Student(2) { FirstName = "Ömer", LastName = "KORKMAZ" };
            var b3 = new Student(2) { FirstName = "Ömer", LastName = "KORKMAZ" };
            var b4 = new Student(2) { FirstName = "Ömer", LastName = "KORKMAZ" };
            var c = new Student() { FirstName = "Elham", LastName = "NADERİ" };
            var d = new Student() { FirstName = "Ege", LastName = "ERTUĞRUL" };
            var e = new Student() { FirstName = "Burcu", LastName = "YİĞİT" };

            var h1 = a1.GetHashCode();
            students.Add(a1);
            students.Add(a2);
            students.Add(a3);
            students.Add(a4);
            students.Add(b1);
            students.Add(b2);
            students.Add(b3);
            students.Add(b4);
            students.Add(c);
            students.Add(d);
            students.Add(e);
            //farklı bir kaç işlem - 100 satır kod daha
            
            return students;
        }
    }

    public class Student
    {
        public Student()
        {
            number = generator.Next(1, 390);
        }
        public Student(int number)
        {
            this.number = number;
        }
        
        public int Number
        {
            get
            {
                return number;
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int number;
        private static Random generator = new Random();
    }
}
