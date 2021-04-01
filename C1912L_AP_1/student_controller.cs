using System;
using System.Collections.Generic;
using System.Linq;

namespace C1912L_AP_1
{
    class student_controller
    {
        static void Main(string[] args)
        {
            show();
        }

        public static void show()
        {
            List<Student> students;
            List<Diem> dts;
            while (true)
            {
                Console.WriteLine("Chon thao tac");
                Console.WriteLine("1. Initial Student");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Nhap diem");
                Console.WriteLine("4. In ds hoc sinh");
                Console.Write("Lua chon cua ban la: ");
                int choose = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choose)
                {
                    case 1:
                        Console.Write("So luong hoc sinh: ");
                        int num = int.Parse(Console.ReadLine());
                        students = Students.InitialStudents(num);
                        Students.PrintStudent();
                        break;
                    case 2:
                        students = Students.AddStudent();
                        Students.PrintStudent();
                        break;
                    case 3:
                        dts = DsDiem.NhapDiem();
                        break;
                    case 4:
                        DsDiem.sortList();
                        break;

                }
            }
        }
    }

    class Student
    {
        public string studentName { get; set; }
        public int studentID { get; set; }
        public int age { get; set; }
    }

    class Diem
    {
        public int studentID { get; set; }
        public string subject { get; set; }
        public int score { get; set; }
        public int heso { get; set; }
    }

    class DsDiem
    {
        public static List<Diem> dts;

        public static List<Diem> NhapDiem()
        {
            if (dts == null) dts = new List<Diem>();
            Diem dt = new Diem();
            Console.WriteLine("Nhap thong tin diem thi");
            Console.Write("Student ID: ");
            dt.studentID = int.Parse(Console.ReadLine());
            List<Student> students = Students.students;
            bool has = students.Any(item => item.studentID == dt.studentID);
            if (has == false)
            {
                Console.WriteLine("khong ton tai hoc sinh nay");
                NhapDiem();
            }
            else
            {
                Console.Write("Subject: ");
                dt.subject = Console.ReadLine();
                Console.Write("Score: ");
                dt.score = int.Parse(Console.ReadLine());
                Console.Write("he so: ");
                dt.heso = int.Parse(Console.ReadLine());
                dts.Add(dt);
            }

            return dts;
        }

        public static void sortList()
        {
            Console.WriteLine("Ban muon loc ds sinh vien co diem >= bao nhieu");
            int num = int.Parse(Console.ReadLine());
            List<Diem> sortedList = dts.Where(item => item.score >= num).ToList();
            Print(sortedList);

        }

        public static void Print(List<Diem> dts)
        {

            dts.ForEach(item => Console.WriteLine("Hoc sinh ID: {0} co diem mon {1} la {2}", item.studentID, item.subject, item.score));

        }
    }

    class Students
    {
        public static List<Student> students;
        public static List<Student> InitialStudents(int num)
        {
            students = new List<Student>();
            Console.WriteLine("Nhap thong tin sinh vien");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Sinh vien thu {0}", i + 1);
                AddStudent();
            }
            return students;
        }
        public static List<Student> AddStudent()
        {
            Student student = new Student();
            Console.Write("Student Name: ");
            student.studentName = Console.ReadLine();
            Console.Write("Student Age: ");
            student.age = int.Parse(Console.ReadLine());
            student.studentID = students.Count();
            students.Add(student);
            return students;
        }

        public static void PrintStudent()
        {
            students.ForEach(item => Console.WriteLine("Hoc sinh ma {0}: Name {1}", item.studentID, item.studentName));
        }
    }
}
