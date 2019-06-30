using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Academy_HR_System
{
    class Group
    {
        private static int ID;

        public string GrName { get; set; }

        public GroupType GroupTypegr { get; set; }
        public string GrAddress { get; set; }

        private Student[] students;


        public Group(string grname, GroupType groupTypegr)
        {
            ID++;
            GrName = grname;
            GroupTypegr = groupTypegr;
            students = new Student[0];
        }

        public void AddStudent(Student student)
        {


            if (students.Length <= 16)
            {

                

                
                if (GroupTypegr.Price <= student.Bill || GroupTypegr.Type == student.Type.Type)
                {
                    Array.Resize(ref students, students.Length + 1);
                    students[students.Length - 1] = student;
                }
                else
                {
                    Console.WriteLine("Kifayet qeder pulunuz yoxdu.");
                }


            }
            else
            {
                Console.WriteLine("Student sayi 16-dan cox ola bilmez");
            }
        }

        public void GetAllStudents()
        {
            foreach (var item in students)
            {
                Console.WriteLine($"Name:{item.Name}, Surname{item.Surname}, Email{item.Email}, Odenisi {item.Bill} ");
            }
        }

    }
}
