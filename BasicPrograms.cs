using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class BasicPrograms
    {
       public int GetLargestElement(int[] arr)
        {
            int max = arr[0];
            for (int i = 1;i<arr.Length;i++)
            {
                if (arr[i] > max) {
                    max = arr[i];
                }
            }
            return max;
        }

        public int GetSmallestElement(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public void BubbleSort(int[] arr)
        {
            int n=arr.Length-1;
            for (int i = 0; i < n; i++)
            {
              
                for (int j = 0; j < n - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j]= arr[j + 1];
                        arr[j+1]= temp;
                    }
                }
            }
            Console.WriteLine(arr[0] + " " + arr[arr.Length - 1]);
                  
        }

        public int SumOfElements(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

    }
}
