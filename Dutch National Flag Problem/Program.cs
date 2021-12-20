using System;

namespace Dutch_National_Flag_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 1, 2, 2, 1, 0, 0, 2, 0, 1, 1, 0 };

            threeWayPartition(A);
        }

        public static void threeWayPartition(int[] arr)
        {
            int start = 0;
            int mid = 0;
            int pivot = 1;
            int len = arr.Length-1;

            while (mid<=len)
            {
                if (arr[mid] > pivot)
                {
                    Swap(arr, mid, len);
                    len--;
                }
                else if (arr[mid] < pivot)
                {
                    Swap(arr, mid, start);
                    mid++;
                    start++;
                }
                else
                    mid++;
            }
            Console.WriteLine(String.Join(", ", arr));
        }

        public static void Swap(int[] arr,int  X,int Y)
        {
            int tmp = arr[X];
            arr[X] = arr[Y];
            arr[Y] = tmp;
        }
    }
}
