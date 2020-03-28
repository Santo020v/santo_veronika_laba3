using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3._3
{
    //Дана послідовність цілих чисел. Знайти кількість її від'ємних елементів, а також їх суму. Якщо від'ємні елементи відсутні, то двічі вивести 0. (1)
   //- First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault (поелементні операції)
   //- Count, Sum, Average, Max, Min, Aggregate(агрегування); • Range(генерування послідовностей). 

    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> nums = Enumerable.Range(-10, 20);

            foreach (int i in nums)
                Console.Write(i + "  ");
            Console.WriteLine("   ");
            int znak =(from i in nums where i < 0 select i).Count();
            int nol = (from i in nums where i < 0 select i).Sum();
            Console.WriteLine("Count: " + znak);
            Console.WriteLine("Sum: " + nol);
            bool result1 = nums.All(u => u >= 0);
            if(result1)
                Console.WriteLine("00");             
        }
    }
}
