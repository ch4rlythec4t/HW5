using System;
class Program
{
    static int[] CreateArray()
    {
        Console.WriteLine("Введите длину массива: ");
        newArrayLength = Convert.ToInt32.(Console.ReadLine());

        int[] newArray = new int[newArrayLength];
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = new Random().Next();
        }

        return newArray;
    }

    int[] MuliplicationPairArray(int[] Array)
    {

    }
    static void Main()
    {

    }
}