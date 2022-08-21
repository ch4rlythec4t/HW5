using System;
class Program
{
    static int[] CreateArray()
    {
        Console.Write("Ведите длину массива: ");
        int NewArrayLenght = Convert.ToInt32(Console.ReadLine());
        int[] NewArray = new int[NewArrayLenght];
        for (int i = 0; i < NewArrayLenght; i++)
        {
            NewArray[i] = new Random().Next(10);
        }

        return NewArray;
    }

    static int[] MultiplyPairArray(int[] Array)
    {   int MultiplyArrayLenght = (Array.Length % 2 == 0) ? (Array.Length / 2): ((Array.Length / 2)+1);
        int[] MultiplyArray = new int[MultiplyArrayLenght];
        for (int i = 0; i < MultiplyArrayLenght; i++)
        {
          
          MultiplyArray[i] = (Array.Length % 2 != 0) && (i == (Array.Length / 2)) ?  Array[i] : (Array[i] * Array[Array.Length - 1- i]);
        }

        return MultiplyArray;
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
        int[] Array = CreateArray();
        int[] ResaultArray = MultiplyPairArray(Array);
        WriteArray(Array: Array);
        Console.Write( " -> ");
        WriteArray(Array: ResaultArray);
    }
}