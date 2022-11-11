using System;
using System.Collections.Generic;

namespace baiTapOopLopBegin2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. list đẻ lưu sinh viên
            var students = new List<Student>();
            // 2. thêm sinh viên
            GetStudentInput(students);
            // 3. cập nhật dữ liệu người dùng bằng id
            Update(students);
            // 4. xóa dữ liệu theo id
            Delete(students);

            Console.ReadKey();
        }

        private static void Delete(List<Student> students)
        {
            // 4.1 tìm kiếm được thằng cần xóa
            var studentWillBeDeleted = Find(students);
            // 4.2 xóa nó khỏi danh sách 
            if (studentWillBeDeleted != null)
            {
                students.Remove(studentWillBeDeleted);
            }
        }

        public static void Update(List<Student> students)
        {
            var student = Find(students);
            if (student != null)
            { 
                // 3.2 cập nhật lại dữ liệu cho thằng đó
                Console.WriteLine("Bạn muốn cập nhật dữ liệu nào?");
                Console.WriteLine("Input: 1-name; 2-sex; 3-tuoi; 4-diemToan; 5-diemLy ;6-Diem Hoa");
                var inputWhatToUpdate = Convert.ToInt32(Console.ReadLine());
                switch (inputWhatToUpdate)
                {
                    case 1:
                        Console.WriteLine("Nhập tên mới:");
                        student.Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Nhập sex mới:");
                        student.Sex = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Nhập tuổi mới:");
                        student.Age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Nhập điểm toán mới:");
                        student.DiemToan = Convert.ToDouble(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Nhập đỉem lý mới:");
                        student.DiemLy =Convert.ToDouble(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Nhập điểm hóa mới:");
                        student.DiemHoa = Convert.ToDouble(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Sai dữ liệu nhập vào");
                        break;
                }
            }
        }

        public static Student Find(List<Student> students)
        {
            // 3.1 tìm kiếm ra thằng cần cập nhật
            Student result = null;
            Console.WriteLine("Bạn muốn tìm kiếm theo id nào?");
            var id = Convert.ToInt32(Console.ReadLine());
            foreach (var student in students)
            {
                if (student.ID == id)
                {
                    result = student;
                }
            }

            if (result == null)
            {
                Console.WriteLine("Không tìm thấy");
            }

            return result;
        }

        public static void GetStudentInput(List<Student> students)
        {
            // 2. hỏi người dùng cần thêm bao nhiêu sinh vien 
            Console.WriteLine("Bạn muốn thêm bao nhiều sinh viên ?");
            var numberOfStudents = Convert.ToInt32(Console.ReadLine());
            // 3. xử lý vòng lặp để tạo ra sinh viên
            for (int i = 0;i < numberOfStudents;i++)
            {
                // 3.1 yêu cầu người dùng nhập vào những thông tin cần thiêt đẻ tạo ra sinh viên
                Console.WriteLine("Tên bạn là gì?");
                string name = Console.ReadLine();
                
                Console.WriteLine("Gới Tính bạn là gì?");
                string sex = Console.ReadLine();
                
                Console.WriteLine("Tuổi bạn là gì?");
                int age = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Điểm toán của ban là gì?");
                double diemToan = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Điểm lý của ban là gì?");
                double diemLy = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Điểm hóa của ban là gì?");
                double diemHoa = Convert.ToDouble(Console.ReadLine());
                // 3.2 khởi tạo ra 1 thằng student
                var student = new Student(Utility.GenerateId(students), name, sex, age, diemToan, diemLy, diemHoa);
                // 3.2 lưu thằng student này vào trong list ở muc 1
                students.Add(student);
            }
        }
    }
}