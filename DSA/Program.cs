using System;

namespace DSA
{
  public class Program
    {
        //Write a function rotate(ar[], d, n) that rotates arr[] of size n by d elements. 

        static void leftrotate(int[] arr, int d, int n)
        {
            for (int i = 0; i < d; i++)
                rotate(arr, n);
        }
         static void rotate(int[] arr, int lent)
        {
            
            int temp = arr[0];
            for (int i = 0; i < lent - 1; i++)
            {
                arr[i] = arr[i + 1];
               
            }
            arr[lent - 1] = temp;
        }

        static void PrintArray(int[] arr, int size)
        {
         
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7};
            leftrotate(arr, 2, 7);
            PrintArray(arr, 7);

        }
    }
}
