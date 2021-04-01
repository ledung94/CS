using System;
using System.Collections.Generic;
using System.Linq;

namespace C1912L_AP_1
{
    class book_controller
    {
        static void __Main(string[] args)
        {

            NStudent.Students students = new NStudent.Students();
            Book.Books books = new Book.Books();
            List<Rent.Rent> ds = new List<Rent.Rent>();
            do
            {
                Rent.Rent.rentBook(ds);
                Rent.Rent.print(ds);
            } while (true);

        }
    }
}

namespace Book
{
    class Book
    {
        public string bookName { get; set; }
        public string author { get; set; }
        public int quantity { get; set; }
        public int bookID { get; set; }

        public static List<Book> initialBook(int num)
        {
            List<Book> books = new List<Book>();
            for (int i = 0; i < num; i++)
            {
                Book book = new Book();
                Console.WriteLine("Nhap sach thu {0}", i + 1);
                Console.Write("Ten sach: ");
                book.bookName = Console.ReadLine();
                Console.Write("Ten tac gia: ");
                book.author = Console.ReadLine();
                Console.Write("so luong: ");
                book.quantity = int.Parse(Console.ReadLine());
                book.bookID = i;
                books.Add(book);
            }
            return books;
        }
    }

    class Books
    {
        public static List<Book> books { get; set; }

        public Books()
        {
            Console.Write("Nhap sp luong sach: ");
            int num = int.Parse(Console.ReadLine());
            books = Book.initialBook(num);
        }
    }
}

namespace NStudent
{
    class Student
    {
        public string studentName { get; set; }
        public string studentClass { get; set; }
        public int studentID { get; set; }

        public static List<Student> initialStudent(int num)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < num; i++)
            {
                Student student = new Student();
                Console.WriteLine("Nhap hoc sinh thu {0}", i + 1);
                Console.Write("Ten hoc sinh: ");
                student.studentName = Console.ReadLine();
                Console.Write("Ten lop: ");
                student.studentClass = Console.ReadLine();
                student.studentID = i;
                students.Add(student);
            }
            return students;
        }
    }
    class Students
    {
        public static List<Student> students { get; set; }

        public Students()
        {
            Console.Write("Nhap sp luong hoc sinh: ");
            int num = int.Parse(Console.ReadLine());
            students = Student.initialStudent(num);
        }

    }
}

namespace Rent
{
    class Rent
    {
        public int studentID { get; set; }
        public int bookID { get; set; }
        public int amount { get; set; }
        public string date { get; set; }


        public static List<Rent> rentBook(List<Rent> ls)
        {
            Rent rc = new Rent();
            Console.WriteLine("Chi tiet don muon sach:");
            Console.Write("ID cua sinh vien: ");
            rc.studentID = int.Parse(Console.ReadLine());
            Console.Write("ID cua sach: ");
            rc.bookID = int.Parse(Console.ReadLine());
            Console.Write("so luong: ");
            rc.amount = int.Parse(Console.ReadLine());
            Console.Write("ngay tra: ");
            rc.date = Console.ReadLine();
            updateQuantity(rc);
            ls.Add(rc);
            return ls;
        }

        public static void updateQuantity(Rent rc)
        {
            Book.Book book = Book.Books.books.Single(item => item.bookID == rc.bookID);
            if (rc.amount > book.quantity) return;
            book.quantity -= rc.amount;
        }
        public static void print(List<Rent> ls)
        {
            Console.WriteLine("=====Danh sach hoc sinh muon sach=====");
            ls.ForEach(ele => {
                Book.Book book = Book.Books.books.Single(item => item.bookID == ele.bookID);
                NStudent.Student student = NStudent.Students.students.Single(item => item.studentID == ele.studentID);
                Console.WriteLine("Hoc sinh {0} muon sach {1} (con lai {2} cuon sach) vao ngay {3}", student.studentName, book.bookName, book.quantity, ele.date);
            });
        }
    }


}
