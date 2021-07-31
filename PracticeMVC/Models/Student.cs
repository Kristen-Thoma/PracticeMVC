using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeMVC.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CareerPath { get; set; }
        public string JoinDate { get; set; }

        public int Id { get; }
        static private int nextId = 1;

        public Student(string firstName, string lastName, string careerPath, string joinDate) :this()
        {
            FirstName = firstName;
            LastName = lastName;
            CareerPath = careerPath;
            JoinDate = joinDate;
        }

        public Student()
        {
            Id = nextId;
            nextId++;
        }
    }
}
