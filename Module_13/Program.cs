using System;

namespace Module_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(checkArray(arr));
            Array.Reverse(arr);
            Console.WriteLine(checkArray(arr));
        }

        private static bool checkArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1]) return true;
            }

            return false;
        }
    }
}
