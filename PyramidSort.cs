using System;

namespace RPM {
    public class PyramidSort {
        public delegate bool Comparison(int x, int y);

        public static void HeapSort(int[] array, Comparison comparison) {
            for (int i = array.Length / 2 - 1; i >= 0; i--)
                Heapify(array, array.Length, i, comparison);

            for (int i = array.Length - 1; i > 0; i--) {
                (array[0], array[i]) = (array[i], array[0]);
                Heapify(array, i, 0, comparison);
            }
        }

        static void Heapify(int[] array, int n, int i, Comparison comparison) {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && comparison(array[l], array[largest]))
                largest = l;

            if (r < n && comparison(array[r], array[largest]))
                largest = r;

            if (largest != i) {
                (array[i], array[largest]) = (array[largest], array[i]);
                Heapify(array, n, largest, comparison);
            }
        }
    }

    public class PyramidSortUsage {
        public static void Run() {
            int[] array = [3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5];

            PyramidSort.HeapSort(array, (a, b) => a > b);
            Console.WriteLine("По возрастанию: " + string.Join(", ", array));


            PyramidSort.HeapSort(array, (a, b) => a < b);
            Console.WriteLine("По убыванию: " + string.Join(", ", array));
        }
    }
}