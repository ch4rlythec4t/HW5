using System;
class Program
{
    static int[] CreateArray()
    {
        int NewArrayLenght = 123;
        int[] NewArray = new int[NewArrayLenght];

        for (int i = 0; i < NewArrayLenght; i++)
        {
            NewArray[i] = new Random().Next(999);
        }

        return NewArray;
    }
    static void WriteArray(int[] Array)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            if (i == 0) Console.Write("[" + Array[i] + ", ");
            else if (i == Array.Length-1) Console.Write(Array[i] + "]");
            else Console.Write(Array[i] + ", ");
        }
    }
    static int CountElements(int[] Array)
    {
        int Count = 0;

        for (int i = 0; i < Array.Length; i++)
        {
            if ((Array[i] >= 10)&& (Array[i] <= 99)) Count++;
        }

        return Count;
    }
    static void Main()
    {
        int[] TempArray = CreateArray();
        WriteArray(TempArray);
        Console.Write(" -> " + CountElements(TempArray));
    }
}