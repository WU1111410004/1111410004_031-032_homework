using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
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
         #讓使用者輸入多個單字，Split是用空格分割開單字

         Console.WriteLine("請輸入要查找的一個字母(僅限小寫): ");
         char ch = Convert.ToChar(Console.ReadLine());
         #讓使用者輸入要查找的字母，將字元轉換字串才可以使用ReadLine換行，用ReadKey也可以但會重複你所輸入的字元

         
         if (words.Length < 1 || words.Length > 50)
         {
            Console.WriteLine("單字數量少於1個也不能不能超過50個，請重新輸入");
            return;
         }
         #讓使用者輸入的單字數量少於1個也不能不能超過50個，return超過則不再執行以下程式

         if (!char.IsLower(ch))
         {
            Console.WriteLine("尋找的字母必須是一個小寫字母，請重新輸入");
            return;
         }
         #IsLower判斷使用者輸入的字元是否為一個小寫字母，return超過則不再執行以下程式

         for (int i = 0; i < words.Length; i++) #將words所有單字全部執行一遍
         {
            int index = words[i].IndexOf(ch); #查找目前第i個words單字中是否存在ch這個字元的字母
            if (words[i].Contains(ch)) #如果目前第i個words單字中存在ch這個字元的字母，則回傳下列的輸出
            {
                Console.WriteLine($"{words[i]}中有{ch},{ch}索引為: {i}");
            }
            else #如果目前第i個words單字中沒存在ch這個字元的字母，則回傳下列的輸出
            {
                Console.WriteLine($"{words[i]}中沒有{ch},{ch}索引為: {null}");
            }
         }
         Console.Read();
      }
  }
}
