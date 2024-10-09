using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class Sort
    {
        List<int> BubbleSort(List<int> listToSort)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1;i<listToSort.Count;i++)
                {
                    if (listToSort[i - 1] > listToSort[i])
                    { 
                        int temp = listToSort[i];
                        listToSort[i] = listToSort[i - 1];
                        listToSort[i-1] = temp;
                        swapped = true;
                    }    
                }

            } while (swapped);
            return listToSort;
        }
        List<int> QuickSortLomuto(List<int> listToSort)
        {
            if (listToSort.Count <= 1)
            {
                return listToSort;
            }

            int pivot = listToSort[listToSort.Count - 1];
            List<int> less = new List<int>();
            List<int> greater = new List<int>();

            for (int i = 0; i < listToSort.Count - 1; i++)
            {
                if (listToSort[i] <= pivot)
                {
                    less.Add(listToSort[i]);
                }
                else
                {
                    greater.Add(listToSort[i]);
                }
            }
            List<int> sortedList = [.. QuickSortLomuto(less), pivot, .. QuickSortLomuto(greater)];

            return sortedList;
        }
        List<int> QuickSortHoare(List<int> listToSort)
        {
            if (listToSort.Count <= 1)
            {
                return listToSort; // Jeśli lista ma 0 lub 1 element, jest już posortowana
            }

            int pivot = listToSort[0];
            List<int> less = new List<int>();
            List<int> greater = new List<int>();

            for (int i = 1; i < listToSort.Count; i++)
            {
                if (listToSort[i] < pivot)
                {
                    less.Add(listToSort[i]);
                }
                else
                {
                    greater.Add(listToSort[i]);
                }
            }

            // Rekurencyjne wywołanie QuickSort dla mniejszych i większych elementów
            List<int> sortedList = new List<int>();
            sortedList.AddRange(QuickSortHoare(less));
            sortedList.Add(pivot);
            sortedList.AddRange(QuickSortHoare(greater));

            return sortedList;
        }
    }
}
