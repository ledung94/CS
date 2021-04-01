using System;

namespace C1912L_AP_1
{
    class Program
    {
        static void _Main(string[] args)
        {
            //session 1

            /*Console.Write("Input a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            session_1 session_1 = new session_1();
            if (session_1.isPrime(number)) Console.WriteLine($"{number} is a prime");
            else Console.WriteLine($"{number} is not a prime");*/


            //session 2


            /*session_2 session_2 = new session_2();
            Console.Write("Input a text line: ");
            Console.WriteLine($"After format: {session_2.formatText(Console.ReadLine())}");

            int[] array = session_2.sortIntArray(session_2.initiaLArray());
            Console.Write($"Sorted array: {string.Join(",",array)}");*/




            //session 4

            /*session_4 ss4 = new session_4();

             Student[] students = ss4.initialStudents(3);//Khoi tao student list
             ss4.printStudents(students);// in student list
             ss4.findMaxAge(students);// tim hs lon tuoi nhat
             ss4.printFilterStudents(students);//filter hs co diem >= 7 theo 2 cach
             Student[] filterStudents = ss4.filterStudents(students);
             ss4.printStudents(filterStudents);
             */

            //home work ss4 Tinh giai thua + giai pt bac 2
            /*
            homwork_ss4 hs4 = new homwork_ss4();
            Console.Write("Input a number: ");
            int num = int.Parse(Console.ReadLine());
            double result = hs4.GetFactorial(num);
            Console.WriteLine($"Result is: {result}");

            Console.WriteLine("nhap 3 so de giai pt bac 2");
            Console.Write("So thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("So thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("So thu ba: ");
            int c = int.Parse(Console.ReadLine());
            hs4.GiaiPTBacHai(a, b, c);
            */

            //session 5: Phan so
            /*
            Console.WriteLine("Nhap 2 phan so");
            List<PhanSo> ls = new List<PhanSo>();//co the dung array
            for (int i = 0; i < 2; i++)
            {
                int mauSo;
                int tuSo;
                do
                {
                    Console.WriteLine($"Nhap phan so thu {i + 1}");
                    Console.Write("Tu so: ");
                    tuSo = int.Parse(Console.ReadLine());
                    Console.Write("Mau so: ");
                    mauSo = int.Parse(Console.ReadLine());
                    ls.Add(new PhanSo(tuSo, mauSo));
                } while (!PhanSo.isValid(tuSo, mauSo));
            }

            PhanSo.Sum(ls[0], ls[1]);
            PhanSo.Minus(ls[0], ls[1]);
            PhanSo.Tich(ls[0], ls[1]);
            */

        }






    }
}
