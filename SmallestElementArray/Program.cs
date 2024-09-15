using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements in the array:");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int[] array = new int[n];
        
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        int smallestElement = FindSmallestElement(array);

        Console.WriteLine($"The smallest element in the array is: {smallestElement}");
    }

    static int FindSmallestElement(int[] array)
    {
        int smallest = array[0];
        
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < smallest)
            {
                smallest = array[i];
            }
        }
        
        return smallest;
    }
}