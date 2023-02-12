using System;

namespace InsertionSortAlgorithm
{
    public  class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4,5,8,0,10,3}; 
            InsertSort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        private static void InsertSort(int[] a)
        {
            int cnt = a.Length;
            int key;
            for(int i = 1; i < cnt; i++)
            {
                key = a[i];
                int j = i- 1;
                while (j >= 0&& a[j ]>key)
                {
                    a[j+1] = a[j];
                    j=j- 1;
                }
                a[j+1] = key;
            }
        }
    }
}
