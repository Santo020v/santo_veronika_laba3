
using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace laba3._2
{
    //Створити словник з двох списків без втрати дублікатів. Вхідний словник: ['Class-V', 'Class-VI', 'Class-VII', 'Class-VIII'], [1, 2, 2, 3] 
    //Результат програми: Словник {'Class-VII': {2}, 'Class-VI': {2}, 'Class-VIII': {3}, 'Class-V': {1}}

    class Program
    {
        static void Main(string[] args)
        {
            List<string> listof = new List<string>()
            {
              "Class-V",
              "Class-VI",
              "Class-VII",
              "Class-VIII",
            };
            string[] arr = listof.ToArray();
            List<int> list1 = new List<int>()
            {
                1,
                2,
                2,
                3
            };
            int[] arr1 = list1.ToArray();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add(arr[0], arr1[0]);
            dic.Add(arr[1], arr1[1]);
            dic.Add(arr[2], arr1[2]);
            dic.Add(arr[3], arr1[3]);

                string json = JsonConvert.SerializeObject(dic);
                Console.WriteLine(json);
            Console.ReadKey();
        }
    }
}
