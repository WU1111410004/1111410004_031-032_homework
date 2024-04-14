using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1111410004_吳宜蓁032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字: ");
            int num = Convert.ToInt32(Console.ReadLine());

            string[] symbol = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] value = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string roman = "";

            if(num < 1 || num > 3999)
            {
                Console.WriteLine("請輸入1~3999之間的數字");
                return;
            }

            for (int i = 0; i < symbol.Length; i++)
            {
                while (num >= value[i])
                {
                    roman += symbol[i];
                    num -= value[i]; 
                }
            }
            Console.WriteLine("轉羅馬符號為: " + roman);
            Console.ReadLine();
        }
    }
}
