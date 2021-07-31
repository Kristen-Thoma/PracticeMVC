using PracticeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeMVC.Data
{
    public class StudentData
    {
        // store students
        private static Dictionary<int, Student> Students = new Dictionary<int, Student>();

        // add students
        public static void Add(Student newStudent)
        {
            Students.Add(newStudent.Id, newStudent);
        }

        // retrieve the students
        public static IEnumerable<Student> GetAll()
        {
            return Students.Values;
        }

        //retrieve a single student
        public static Student GetById(int id)
        {
            return Students[id];
        }
            
        //remove a student
        public static void Remove(int id)
        {
            Students.Remove(id);
        }

    }
}
