using System;
class Program
{
    static int[] CreateArray(int ArrayLength)
    {
        int[] CreateArray = new int[ArrayLength];
      
        for (int i = 0; i < ArrayLength; i++)
        {
            CreateArray[i] = new Random().Next(100, 999);
        
        }

        return CreateArray;
    }

    static int CountMultiplyOfTwoArray(int[] MultiplyOfTwoArray)
    {

        int CountMultiplyOfTwo = 0;
        for (int i = 0; i < MultiplyOfTwoArray.Length; i++)
        {
            if ((MultiplyOfTwoArray[i] % 2) == 0) CountMultiplyOfTwo++;
        }

        return CountMultiplyOfTwo;
    }
    static void WriteArray(int[] WriteArray)
    {
        for (int i = 0; i < WriteArray.Length; i++)
        {
            if (i == 0) Console.Write("[" + WriteArray[i] + ", ");
            else if (i == WriteArray.Length - 1) Console.Write(WriteArray[i] + "]");
            else Console.Write(WriteArray[i] + ", ");
        }
    }

    static void Main()
    {
        Console.Write("Введите длину массива: ");

        int N = Convert.ToInt32(Console.ReadLine());
        int[] Array = CreateArray(N);
        int Count = CountMultiplyOfTwoArray(MultiplyOfTwoArray: Array);

        WriteArray(WriteArray: Array);
        Console.Write(" -> " + Count);
    }
}