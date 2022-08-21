using System;
class Program
{
    static int[] CreateArray(int NewArrayLenght)
    {
        int[] NewArray = new int[NewArrayLenght];
        for (int i = 0; i < NewArrayLenght; i++)
        {
            NewArray[i] = new Random().Next(-99, 99);
        }

        return NewArray;
    }

    static int SumElementOddPossition(int[] SearchArray)
    {
        int SearchSum = 0;
        for (int i = 1; i < SearchArray.Length; i = i + 2)
        {
            SearchSum = SearchSum + SearchArray[i];
        }

        return SearchSum;
    }

    static void WriteArray(int[] Array)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            if (i == 0) Console.Write("[" + Array[i] + ", ");
            else if (i == Array.Length - 1) Console.Write(Array[i] + "]");
            else Console.Write(Array[i] + ", ");
        }
    }
    static void Main()
    {
        Console.Write("Ведите длину массива: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int[] Array = CreateArray(NewArrayLenght: N);
        int Sum = SumElementOddPossition(SearchArray: Array);
        WriteArray(Array: Array);
        Console.Write(" -> " + Sum);
    }
}