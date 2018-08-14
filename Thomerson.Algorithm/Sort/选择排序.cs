using System;
using System.Collections.Generic;
using System.Text;


/* *******
 * 首先在未排序序列中找到最小（大）元素，存放到排序序列的起始位置，
 * 然后，再从剩余未排序元素中继续寻找最小（大）元素，
 * 放到已排序序列的末尾。以此类推，直到所有元素均排序完毕。 
 * *****/

namespace Sort
{
    class SelectionSort
    {


        public static List<int> Sort(List<int> list)
        {
            var temp = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                var min = list[i];
                var minIndex = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (min > list[j])
                    {
                        minIndex = j;
                        min = list[j];
                    }
                }
                temp = list[i];
                list[i] = list[minIndex];
                list[minIndex] = temp;

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
