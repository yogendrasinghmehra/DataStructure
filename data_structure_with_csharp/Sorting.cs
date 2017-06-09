using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_with_csharp
{
    public class Sorting
    {
        public int[] BubbleSort(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool swaped = false;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swaped = true;
                    }

                }
                if (swaped == false)
                {
                    break;
                }
            }

            return arr;

        }
        public int[] SelectionSort(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                int min = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                    }

                }
                arr[i] = min;

            }
            return arr;

        }
        public int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;

        }
    }
}
