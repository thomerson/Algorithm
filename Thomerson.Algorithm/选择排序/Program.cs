using System;
using System.Collections.Generic;

//首先在未排序序列中找到最小（大）元素，存放到排序序列的起始位置，
//然后，再从剩余未排序元素中继续寻找最小（大）元素，然后放到已排序序列的末尾
namespace 选择排序
{
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

        static List<int> Sort(List<int> list)
        {
            var minIndex = 0;
            var temp = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    temp = list[minIndex];
                    list[minIndex] = list[i];
                    list[i] = temp;
                }
            }
            return list;
        }
    }
}
