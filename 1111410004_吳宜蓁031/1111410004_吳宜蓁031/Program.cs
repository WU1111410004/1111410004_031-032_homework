using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1111410004_吳宜蓁031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入幾個單字(空格區分開): ");
            string[] words = Console.ReadLine().Split();
            Console.WriteLine("請輸入要查找的一個字母(僅限小寫): ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (words.Length < 1 || words.Length > 50)
            {
                Console.WriteLine("單字數量少於1個也不能不能超過50個，請重新輸入");
                return;
            }

            if (!char.IsLower(ch))
            {
                Console.WriteLine("尋找的字母必須是一個小寫字母，請重新輸入");
                return;
            }

            for (int i = 0; i < words.Length; i++)
            {
                int index = words[i].IndexOf(ch);
                if (words[i].Contains(ch))
                {
                    Console.WriteLine($"{words[i]}中有{ch},{ch}索引為: {i}");
                }
                else
                {
                    Console.WriteLine($"{words[i]}中沒有{ch},{ch}索引為: {null}");
                }
            }
        Console.Read();
        }
    }
}
