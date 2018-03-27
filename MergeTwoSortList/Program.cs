using System;

namespace MergeTwoSortList
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            var j = 0;
            var k = 0;

            var arr1 = new int[] { 21, 23, 24, 40, 75, 76, 78, 77, 900, 2100, 2200, 2300, 2400, 7000 };
            var arr2 = new int[] { 10, 11, 41, 50, 65, 86, 98, 101, 190, 1100, 1200, 3000, 5000 };

            var N1 = arr1.Length;
            var N2 = arr2.Length;
            var N3 = N1 + N2;

            var arr3 = new int[N3];


            while (i < N1 && j < N2)
            {
                if (arr1[i] < arr2[j])
                {
                    arr3[k] = arr1[i];
                    i++;
                } else
                {
                    arr3[k] = arr2[j];
                    j++;
                }
                k++;
            }
            while( i < N1)
            {
                arr3[k] = arr1[i];
                i++;
                k++;
            }
            while(j < N2)
            {
                arr3[k] = arr2[j];
                j++;
                k++;
            }
            for (int h = 0; h < N3; h++)
            {
                Console.WriteLine(arr3[h]);
            }
            Console.ReadLine();
        }
    }
}
