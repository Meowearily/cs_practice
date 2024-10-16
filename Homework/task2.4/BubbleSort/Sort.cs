using System;
using System.Runtime.CompilerServices;

class Sort
{
    int[] array;
    int temp, counter;
    public Sort(int[] array)
    {
        this.array = array;
    }


    public void BubbleSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            counter = 0;
            for (int j = 0; j < array.Length - i; j++)
            if (array[j] > array[j+1])
            {
                temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
                counter++;
            }

            if (counter == 0)
            {
                break;
            } else
            {
                ArrayPrint(array);
            }
        }

        
    }

    public void ArrayPrint(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
}