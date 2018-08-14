using System;
using System.Collections.Generic;
using System.Text;


/* **********
 * 冒泡排序是一种简单的排序算法。
 * 它重复地走访过要排序的数列，一次比较两个元素，
 * 如果它们的顺序错误就把它们交换过来。
 * 走访数列的工作是重复地进行直到没有再需要交换，
 * 也就是说该数列已经排序完成。这个算法的名字由来是因为越小的元素会经由交换慢慢“浮”到数列的顶端
 * ********/
namespace Sort
{
    class BubbleSort
    {
        public (int, int) Test()
        {
            return (1, 1);
        }

        public static List<int> Sort(List<int> list)
        {
            var temp = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                //比较相邻的两个元素，如果前面的比后面的大，则交换位置
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] < list[j + 1])
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }

                Console.Write("Order Number :" + i + ": ");
                //console
                foreach (var item in list)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
            return list;
        }
    }
}
