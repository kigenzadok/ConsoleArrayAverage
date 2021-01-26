using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleP
{
    class Program
    {
        public static void Main(string[] args)
        {

            int[] arr = { 2, 3, 4, 1, 5 };
            int x = 2;  // x is number of contiguous elements to average 
            int n = arr.Length; //n is the length
            Console.WriteLine();
            findMaxAverage(arr, x, n);

        }
        static double findMaxAverage(int[] arr, int x, int n)
        {
            double sum = 0;
            for(int i=0; i<x; i++)
            {
                sum += (double)(arr[i])/ x; //calculate the average of the first 2 numbers
            }
            double max_avg = sum;
            for (int i = x; i < n; i++)
            {
                    sum -= (double)(arr[i - x]) / x;
                    sum += (double)(arr[i]) / x;  //add the current element so it always compute the average of the x elements
                    max_avg = Math.Max(max_avg, sum); // to maximize the max
                    Console.WriteLine("The max " + max_avg); // display the max average
            } 
            return max_avg;
           
        }
    }
        

}
