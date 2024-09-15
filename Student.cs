using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SinhVien
{
    class Student
    {
        //1. Field
        private string studentID;
        private string fullName;
        private int age;
        //2. Property
        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public int Age {get => age; set => age = value; }
        //3.Constructor
        public Student()

{
        }
        public Student(string studentID, string fullName, int age)
        {
            this.studentID = studentID;
            this.fullName = fullName;
            this.age = age;
        }
        //4. Methods
        public void Input()
        {
            Console.Write("Nhập ID:");
            StudentID = Console.ReadLine();
            Console.Write("Nhập Họ tên Sinh viên:");
            FullName = Console.ReadLine();
            do
            {
                Console.Write("Nhập tuổi: ");
                Age = int.Parse(Console.ReadLine());
                if (Age < 0)
                Console.WriteLine("Bạn nhập sai vui lòng nhập lại!");
            } while (Age < 0);
        }
        public void Show()
        {
            Console.WriteLine($"ID: {StudentID}, Tên: {fullName}, Tuổi: {Age}");
        }
    }
}
