using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] array = new int[] {1,2,3,4,5,6};


            int i=p.jumpSearch(array,5);
            if (i != -1)
            {
                Console.WriteLine("Element "+array[i]+" present at index "+i+"");
            }
            else
            {
                Console.WriteLine("Element not present in the given array!!!");
            }
            Console.ReadLine();
        }


     #region LinearSearch
        public int linearSearch(int[] arr, int x)
        {
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
     #endregion LinearSearch

     #region BinarySearch
        public int binarySearch(int[] arr, int key)
        {
            int s= 0;
            int e = arr.Length - 1;
            while (s<=e)
            {
                int mid = (s + e) / 2;
                if (arr[mid] == key)
                    return mid;
                else
                {
                    if (key > arr[mid])
                        s = mid+1;
                    else
                        e = mid-1;                    
                }                
            }
            return -1;
            
        }
     #endregion BinarySearch

     #region InterpolationSearch
        public void interpolationSearch()
        {

        }
     #endregion InterpolationSearch


     #region JumpSearch
        public int jumpSearch(int[] arr, int x)
        {
            int l = arr.Length;
            int step = Convert.ToInt32(Math.Sqrt(l));
            int node = 0;
            while (arr[node]<x)
            {
                node += step;
            }

            //node -= step;
            for (int i = node; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
        #endregion JumpSearch



    }
}
