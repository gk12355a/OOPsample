using System;
using System;
using System.Collections.Generic;

public class Student
{
    // Dữ liệu thành viên
    public string SID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double GPA { get; set; }

    // Phương thức hiển thị thông tin sinh viên
    public void DisplayInfo()
    {
        Console.WriteLine("Ma sinh vien: " + SID);
        Console.WriteLine("Ten sinh vien: " + Name);
        Console.WriteLine("Khoa: " + Department);
        Console.WriteLine("Điem TB: " + GPA);
    }
}

public class Tester
{
    public static void Main()
    {
        // Nhập số lượng sinh viên
        Console.Write("Nhap so luong sinh vien: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Tạo danh sách sinh viên
        List<Student> students = new List<Student>();

        // Nhập thông tin cho từng sinh viên
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap thong tin cho sinh vien thu {i + 1}:");

            Student student = new Student();

            Console.Write("Ma sinh vien: ");
            student.SID = Console.ReadLine();

            Console.Write("Ten sinh vien: ");
            student.Name = Console.ReadLine();

            Console.Write("Khoa: ");
            student.Department = Console.ReadLine();

            Console.Write("Điem TB: ");
            student.GPA = Convert.ToDouble(Console.ReadLine());

            // Thêm sinh viên vào danh sách
            students.Add(student);
        }

        // Hiển thị thông tin chi tiết của các sinh viên
        Console.WriteLine("\nDanh sach sinh vien:");
        foreach (Student student in students)
        {
            student.DisplayInfo();
            Console.WriteLine();
        }
    }
}