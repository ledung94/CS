using System;
namespace C1912L_AP_1
{
    public class PhanSo
    {
        public int tuSo;
        public int mauSo;
        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }
        public static bool isValid(int tuSo, int mauSo)
        {
            bool result = true;
            if (tuSo < 0 || mauSo <= 0) result = false;
            return result;
        }
        public static int BoiSo(int a, int b)
        {
            int boiSo = 1;
            for (int i = Math.Max(a, b); i <= a * b; i++)
            {
                if (i % a == 0 && i % b == 0)
                {
                    boiSo = i;
                    break;
                }
            }
            return boiSo;
        }
        public static void Sum(PhanSo ps1, PhanSo ps2)
        {
            int boiSo = BoiSo(ps1.mauSo, ps2.mauSo);
            Console.WriteLine($"Tong cua 2 phan so la: {ps1.tuSo * boiSo / ps1.mauSo + ps2.tuSo * boiSo / ps2.mauSo}/{boiSo}");
        }

        public static void Minus(PhanSo ps1, PhanSo ps2)
        {
            int boiSo = BoiSo(ps1.mauSo, ps2.mauSo);
            Console.WriteLine($"Tong cua 2 phan so la: {ps1.tuSo * boiSo / ps1.mauSo - ps2.tuSo * boiSo / ps2.mauSo}/{boiSo}");
        }

        public static void Tich(PhanSo ps1, PhanSo ps2)
        {
            int boiSo = BoiSo(ps1.mauSo, ps2.mauSo);
            Console.WriteLine($"Tong cua 2 phan so la: {ps1.tuSo * ps2.tuSo}/{ps1.mauSo * ps1.mauSo}");
        }
    }
}
