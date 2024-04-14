using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111410004_吳宜蓁032
{
       Console.WriteLine("請輸入數字: ");
       int num = Convert.ToInt32(Console.ReadLine());
       #Convert.ToInt32將整數轉字串類型，因ReadLine只讀字串型態

       string[] symbol = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
       int[] value = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
       #將題目所有的包括例外的數字與相應的符號都用陣列儲存好方便做迴圈，因羅馬符號是由大數字減小數字，所以由大到小排序

       string roman = "";
       #將以下轉換的羅馬符號存放到空字串用的

       if(num < 1 || num > 3999)
       {
           Console.WriteLine("請輸入1~3999之間的數字");
           return;
       }
       #設定輸入範圍為1~3999，如不符合設定return不執行以下程式

       for (int i = symbol.Length - 1; i >= 0; i--) #symbol.Length是字串的總長，也就是將羅馬符號從最後一個開始round一遍
       {
           while (num >= value[i]) #檢查輸入的數字是否大於或等於value中的值，如果是則執行裡面的程式
           {
               roman += symbol[i];
               num -= value[i];
           }
           #將當前羅馬符號加到roman字串中，並從輸入的數字中減去相應的值，直到輸入的數字不再大於或等於當前值，就可以轉移到下一個值
       }
       Console.WriteLine("轉羅馬符號為: " + roman);
       Console.ReadLine();
    }
}
