using System;
namespace C1912L_AP_1
{
    public class session_2
    {

        public string formatText(string text)
        {
            string rs = string.Empty;
            text = ' ' + text;
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsLower(text[i]))
                {
                    if (text[i - 1] == ' ') rs += text[i].ToString().ToUpper();
                    else rs += text[i];
                }
                else if (char.IsUpper(text[i]))
                {
                    if (text[i - 1] != ' ') rs += text[i].ToString().ToLower();
                    else rs += text[i];
                }
                else if (text[i - 1] != ' ') rs += text[i];
            }
            return rs.Trim();
        }
        public int[] sortIntArray(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        public int[] initiaLArray()
        {
            Console.Write("Input size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Input number {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }



    }
}
