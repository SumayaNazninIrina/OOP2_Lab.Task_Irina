using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "irina";
            s.Id = "19-39486-1";
            s.Department = "CSE";
            s.Cgpa = 3.50f;
            s.ShowInfo();
            Triangle t = new Triangle();
            t.X = 10;
            t.X = 12;
            t.Z = 14;
            t.ShowInfo();
            t.TestTriangle();
            Account a = new Account();
            a.AccName = "My Account";
            a.AcId = "1";
            a.Balance = 2000;
            a.Deposit(500;
            a.Withdraw(200);
            Course c = new Course();
            c.CourseName = "OOP2";
            c.CourseId = "1011";
            c.CourseCredit = 3;
            c.ShowCourseInfo();
        }
    }

}
