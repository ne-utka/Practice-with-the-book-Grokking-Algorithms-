using System;
using System.Linq;

// Метод для поиска индекса наименьшего элемента в массиве
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int[] arr = numbers.Select(int.Parse).ToArray();
        int smallestIndex = FindSmallest(arr);
        Console.WriteLine("Наименьший элемент:  {arr[smallestIndex]}");
        Console.WriteLine("Индекс наименьшего элемента: {arr[smallestIndex]}");
        Console.WriteLine("Весь массив: " + string.Join(" ", arr));
    }
    
    static int FindSmallest(int[] arr)
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