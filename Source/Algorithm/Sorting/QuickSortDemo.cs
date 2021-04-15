using System;

namespace Algorithm.Sorting
{
    public class QuickSortDemo
    {
        public void Execute()
        {
            var arr = new int[] { 8, 9, 4 , 7, 6, 33, 2, 0 };
            QuickSort(arr, 0, arr.Length-1);

            Console.WriteLine(string.Join(',', arr));
        }

        private void QuickSort(int[] arr, int low, int high)
        {
            if(low<high)
            {
                var partitioningPosition = Partition(arr, low, high);

                // recursive call for left partition and right partition
                QuickSort(arr, low, partitioningPosition-1);
                QuickSort(arr, partitioningPosition + 1, high);
            }
        }

        private int Partition(int[] a,int low, int high) // my partition logic inspired by udemy course
        {
            int pivotPosition = low;
            int pivot = a[pivotPosition];
            while (low < high)
            {
                do { low++; } while (a[low] <= pivot && low < a.Length - 1);

                while (a[high] > pivot && high > 0)
                    high--;

                if (low < high)
                    swap(a, low, high); //swap
            }
            swap(a, pivotPosition, high);
            return high;
        }

        private void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
