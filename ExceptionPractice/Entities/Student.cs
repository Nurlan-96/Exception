using ExceptionPractice.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractice.Entities
{
    public class Student:IService
    {
        private static int _id;
        public int Id { get; }

        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }
        public int Point { get; set; }

        public Student(string name, string surname, int age, int point)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Age = age;
            Point = point;
        }

        public void ShowInfo()
        {
            Console.WriteLine(Id + " " + Name + " " + Surname + " " + Age + " " + Point);
        }
    }
}
