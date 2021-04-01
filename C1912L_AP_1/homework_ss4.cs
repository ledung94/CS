using System;
namespace C1912L_AP_1
{
    public class homwork_ss4
    {
        public double GetFactorial(int num)
        {
            double result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }

        public void GiaiPTBacHai(int a, int b, int c)
        {
            if (a == 0)
            {
                if (b == 0) Console.WriteLine("Phuong trinh vo nghiem");
                else Console.WriteLine("Phuong trinh cos 1 nghiem la {0}", -c / (float)b);
            }
            else
            {
                int delta = b * b - 4 * a * c;
                if (delta > 0) Console.WriteLine($"Phuong trinh co 2 nghiem: Nghiem 1 la : {(-b + Math.Sqrt(delta)) / (float)(2 * a)} va Nghiem 2 la : {(-b - Math.Sqrt(delta)) / (float)(2 * a)}");
                else if (delta == 0) Console.WriteLine($"Phuong trinh co 1 nghiem duy nhat la {-b / (float)(2 * a)}");
                else Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
    }
}
