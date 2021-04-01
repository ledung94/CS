using System;
using System.Linq;

namespace C1912L_AP_1
{
    public class session_4
    {
        public struct Student
        {
            public string name;
            public int age;
            public int score;
        }

        public Student[] initialStudents(int num)
        {
            Student[] students = new Student[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Nhap hoc sinh thu {i + 1}:");
                Console.Write("name: ");
                students[i].name = Console.ReadLine();
                Console.Write("age: ");
                students[i].age = int.Parse(Console.ReadLine());
                Console.Write("score: ");
                students[i].score = int.Parse(Console.ReadLine());
            }

            return students;
        }

        public void printStudents(Student[] students)
        {
            Console.WriteLine("------ Danh sach hoc sinh ------");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Hoc sinh thu {i + 1}: Name: {students[i].name} Age: {students[i].age} Score: {students[i].score}");
            }
        }

        public void findMaxAge(Student[] students)
        {
            int max = 0, index = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (max < students[i].age)
                {
                    max = students[i].age;
                    index = i;
                }
            }

            Console.WriteLine($"Hoc sinh thu {index + 1} co tuoi lon nhat la {max}");
        }

        public void findSecondScore(Student[] students)
        {
            int max1 = 0, max2 = 0, index1 = 0, index2 = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (max1 < students[i].score)
                {
                    max2 = max1;
                    index2 = index1;
                    max1 = students[i].score;
                    index1 = i;
                }
                else
                {
                    if (max2 < students[i].score)
                    {
                        max2 = students[i].score;
                        index2 = i;
                    }
                }
            }

            Console.WriteLine($"Hoc sinh thu {index2 + 1} co diem {max2} lon thu nhi");

        }

        public void findSecondScore2(Student[] students, int num)
        {
            int max = 0, index = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (max < students[i].score)
                {
                    max = students[i].score;
                    index = i;
                }
            }

            if (students.Length == num)
            {
                Student[] n_students = students.Where(e => e.score != max).ToArray();
                findSecondScore2(n_students, num);
            }
            else
            {
                Console.WriteLine($"Hoc sinh {index + 1} co diem lon nhat la {max}");//bug: luc nay index cua element da thay doi...
            }

        }

        public Student[] filterStudents(Student[] students)
        {
            //sd System.Linq
            Student[] filterStudent = students.Where(e => e.score >= 7).ToArray();
            return filterStudent;
        }

        public void printFilterStudents(Student[] students)
        {
            Console.WriteLine("--- Danh sach hoc sinh co diem >= 7 ---");

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].score >= 7)
                {
                    Console.WriteLine($"Hoc sinh thu {i + 1}: Name {students[i].name}; Score {students[i].score}");
                }
            }
        }
    }
}
