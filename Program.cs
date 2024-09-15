using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; Console.InputEncoding = Encoding.Unicode;
            List<Student> students = new List<Student>();
            int n;
            Console.WriteLine("Nhập số lượng thông tin học sinh:");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin cho học sinh thứ {i + 1}:");
                Student student = new Student(); 
                student.Input();
                students.Add(student);
            }

            //Menu
            int chon;
            do
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Hiển thị danh sách học sinh");
                Console.WriteLine("2. Tìm học sinh có tuổi từ 15 đến 18");
                Console.WriteLine("3. Tìm học sinh có tên bắt đầu bằng chữ 'A'");
                Console.WriteLine("4. Tính tổng tuổi của tất cả học sinh");
                Console.WriteLine("5. Tìm học sinh có tuổi lớn nhất");
                Console.WriteLine("6. Sắp xếp danh sách học sinh theo tuổi tăng dần");
                Console.WriteLine("0. Thoát chương trình");
                Console.Write("Nhập lựa chọn của bạn: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        Console.WriteLine("\nDanh sách học sinh đã nhập:");
                        foreach (var student in students)
                        {
                            student.Show();
                        }
                        break;

                    case 2:
                        FindStudentsAge15To18(students);
                        break;
                    case 3:
                        PrintStudentNameA(students);
                        break;
                    case 4:
                        SumAgeStudent(students);
                        break;
                    case 5:
                        FindStudentMaxAge(students);
                        break ;
                    case 6:
                        SortStudentAge(students);
                        break;
                    case 0:
                        Console.WriteLine("Thoát chương trình");
                        break;
                    default: Console.WriteLine("Lựa chọn không hợp lệ.Vui lòng chọn lại.");
                        break;
                }

            }while(chon != 0);
        }

        // Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18.
        static void FindStudentsAge15To18(List<Student> students)
        {
            var studentsAge15To18 = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();

            Console.WriteLine("\nDanh sách học sinh có tuổi từ 15 đến 18:");
            if (studentsAge15To18.Any())
            {
                foreach (var student in studentsAge15To18)
                {
                    student.Show();
                }
            }
            else
            {
                Console.WriteLine("Không có học sinh nào trong độ tuổi từ 15 đến 18.");
            }
        }
        // Tìm và in ra học sinh có tên bắt đầu bằng chữ "A".
        static void PrintStudentNameA(List<Student> students)
        {
            var studentsNameStartWithA = students
                .Where(s => s.FullName.Trim().StartsWith("A", StringComparison.OrdinalIgnoreCase))
                .ToList();

            Console.WriteLine("\nDanh sách học sinh có tên bắt đầu bằng chữ 'A':");
            if (studentsNameStartWithA.Any())
            {
                foreach (var student in studentsNameStartWithA)
                {
                    student.Show();
                }
            }
            else
            {
                Console.WriteLine("Không có học sinh nào có tên bắt đầu bằng chữ A");
            }
        }

        //Tính tổng tuổi của tất cả học sinh trong danh sách.
        static void SumAgeStudent(List<Student> students)
        {
            int SumAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTổng tuổi của tất cả học sinh: {SumAge}");
        }

        //Tìm và in ra học sinh có tuổi lớn nhất.
        static void FindStudentMaxAge(List<Student> students)
        {
            var studentsMaxAge = students.OrderByDescending(s => s.Age).First();
            Console.WriteLine("Học sinh có tuổi lớn nhất: ");
            studentsMaxAge.Show();
        }

        //Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp.
        static void SortStudentAge (List<Student> students)
        {
            var sortStudent = students.OrderBy(s => s.Age).ToList();
            Console.WriteLine("\nDanh sách học sinh sau khi sắp xếp theo tuổi tăng dần:");
            foreach (var student in sortStudent) {
                student.Show();
            }
         }
    }
}
