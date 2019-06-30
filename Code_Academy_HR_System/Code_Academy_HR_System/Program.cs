using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Academy_HR_System
{
    partial class Program
    {
        static void Main(string[] args)
        {
            GroupType dizayn = new GroupType("Dizayn",3000);
            GroupType programming = new GroupType("Programming",4000);
         
            Student orxan = new Student("Orxan","Abbasli","orxan.m@mail.ru","Ali", programming);
            Student gunay = new Student("Gunay", "Memmedova", "gunay.m@mail.ru", "Ali", programming);
            Student aytac = new Student("Aytac","Imanli", "aytac.@mail.ru","Ali",dizayn);
            
            orxan.Bill = 4000;
            gunay.Bill = 4000;
            aytac.Bill = 3000;

            Group code_academy_pr = new Group("P111", programming);
            
            code_academy_pr.AddStudent(orxan);
            code_academy_pr.AddStudent(gunay);
            code_academy_pr.AddStudent(aytac);
            code_academy_pr.GetAllStudents();
            Console.ReadLine();
        }
    }
}
