using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_training.Process
{
    public class Day2 : IDay2// interface
    {
        public int max(int[] nums)
        {

            int m = 0; 
            for (int i=0; i < nums.Length; i++)
            {
                if (m < nums[i])
                {
                    m = nums[i];
                }
            }
            return m;
        }

        public int min(int[] nums)
        {
            int m = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (m > nums[i])
                {
                    m = nums[i];
                }
            }
            return m;
        }

        public int minus(int a, int b)
        {
            return a - b;
        }

        public int multi(int a, int b)
        {
            return a * b;
        }

        public int[] sortAsc(int[] arr)
        {
            var a = arr.ToArray();
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        var tem = a[j];
                        a[j] = a[i];
                        a[i] = tem;
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(arr[i]);
            }
            return arr;
        }

        public int[] sortDesc(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        var tem = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tem;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            return arr;
        }

        public float sub(int a, int b)
        {
            return a / b;
        }

        public int sum(int a, int b)
        {
            return a + b;
        }
    }
}
