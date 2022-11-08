using System;
using System.Collections.Generic;

namespace baiTapOopLopBegin2
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            
            var student = new Student(Utility.GenerateId(students), "Tri", "male",3,4,5,5);
            students.Add(student);
            var student1 = new Student(Utility.GenerateId(students), "Phong", "male",3,4,5,5);
            students.Add(student1);
            var student2 = new Student(Utility.GenerateId(students), "son", "male",3,4,5,5);
            students.Add(student2);

            Console.ReadKey();
        }
    }
}