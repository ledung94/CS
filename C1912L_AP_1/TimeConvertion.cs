using System;
using System.Text.RegularExpressions;

namespace C1912L_AP_1
{
    public class TimeConvertion
    {
        public TimeConvertion()
        {
            static string timeConversion(string s)
            {
                /*
                 * Write your code here.
                 */
                Regex AM_rgx = new Regex(@"^\d{2}:\d{2}:\d{2}AM$");
                Regex PM_rgx = new Regex(@"^\d{2}:\d{2}:\d{2}PM$");
                string rs = s.Remove(s.Length - 2);
                string[] split_s = rs.Split(':');
                foreach (var item in split_s)
                {
                    Console.WriteLine(item);
                }
                if (AM_rgx.IsMatch(s))
                {
                    if (split_s[0] == "12") split_s[0] = "00";
                    rs = string.Join(":", split_s);
                }
                else if (PM_rgx.IsMatch(s))
                {
                    if (Convert.ToInt32(split_s[0]) < 12) split_s[0] = (Convert.ToInt32(split_s[0]) + 12).ToString();
                    rs = string.Join(":", split_s);
                }
                else
                {
                    rs = "Wrong format";
                }
                return rs;
            }
        }
    }
}
    
