using System;
namespace C1912L_AP_1
{
    public class session_1
    {


        public bool isPrime(int number)
        {
            bool rs = false;
            if (number < 2) rs = false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    rs = false;
                    break;
                }
            }
            return rs;
        }

    }
}
