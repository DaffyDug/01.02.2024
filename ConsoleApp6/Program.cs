using System;
//сылочные и значимые типы данных. прочитать поподробнее что это такое. 
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            //RandomARR(arr);
            //Sort_ARR(arr);
            //Print_ARR(arr);

            plus_ARR(5, arr);
        }

        static void RandomARR(int[] arr)
        {
            Random random = new Random();
            int value = random.Next(0, 40);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(value);
            }
        }

        static bool Dada(int a2, int[] arr)
        {
            bool result = false;

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == a2)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        static void Swap(int[] arr, int a, int a2)
        {
            int temp = arr[a];
            arr[a] = arr[a2];
            arr[a2] = temp;
        }

        static void Sort_ARR(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        Swap(arr, i, j);
                    }
                }
            }
        }
        static void Print_ARR(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static void plus_ARR(int a, int[] arr)
        {
            int[] arr2 = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            arr2[arr2.Length - 1] = a;
        }

    }
}
