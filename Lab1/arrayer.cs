using System;
using static System.Math;

namespace Lab1
{
    public class arrayer
    {
        private double[] arr;
        arrayer(double[] arr)
        {
            this.arr = arr;
        }
        int[] mm = new int[] { 0, 0 };
        public double Product { get; private set; }
        public double Sum { get; private set; }
        public void arrayThingify(double[] arr, string yo)
        {
            Sum = arr[0];
            Product = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                Sum += arr[i];
                if (arr[i] < arr[mm[0]])
                {
                    mm[0] = i;
                }
                if (arr[i] > arr[mm[1]])
                {
                    mm[1] = i;
                }
            }
            if (mm[0] > mm[1])
            {
                int a = mm[1];
                mm[1] = mm[0];
                mm[0] = a;
            }
            for (int i = mm[0] + 1; i < mm[1]; i++)
            {
                Product *= arr[i];
            }
        }
        
        public double[] sort()
        {
            for (int i = 1; i < arr.Length; i++)
            {
                double x = arr[i];

                int j = Abs(Array.BinarySearch(arr, 0, i, x) + 1);

                Array.Copy(arr, j, arr,j + 1, i - j);

                arr[j] = x;
                
            }
            return arr;
        }
    }
}
