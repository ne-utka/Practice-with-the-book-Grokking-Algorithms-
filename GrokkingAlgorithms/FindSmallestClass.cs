namespace PracticsGrokaemAlg.GrokkingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;

public class FindSmallestClass
{
    public static int FindSmallest(int[] arr)
    {
        int smallest = arr[0];
        int smallest_index = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < smallest)
            {
                smallest = arr[i];
                smallest_index = i;
            }
        }
        return smallest_index;
    }
}


