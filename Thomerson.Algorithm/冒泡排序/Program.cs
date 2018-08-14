using System;
using System.Collections.Generic;


//基本思想：每次比较相邻的两个 元素，按需调整顺序
//核心:双重嵌套循环
//如果有 n 个数进行排序，只需将 n-1 个数归位，即要进行 n-1 趟操作，而每一趟开始都从第 1 位进行相邻的两个数 进行比较，将小的那个数放在后面，已经归位的就不用进行比较。
namespace 冒泡排序
{
    //附近交换排序
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var list = new List<int>() { 12, 35, 1, 99, 18, 76 };

            list = Sort(list);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static List<int> Sort(List<int> list)
        {
            var temp = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }
    }
}
