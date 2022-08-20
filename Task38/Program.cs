using System;
class Program
{
    static int[] CreateArray()
    {
        Console.Write("Введите элементы массива через запятую: ");
        string StringArray = Console.ReadLine();
        string[] NewCreateStringArray = new string[StringArray.Length];

        int CountNum = 0;

        // string[] NewCreateStringArray = StringArray.Split(',');

        foreach (var item in StringArray)
        {
            if ((item != ',')) NewCreateStringArray[CountNum] += item.ToString();
            else CountNum++;
        }

        int[] NewCreateIntArray = new int[CountNum + 1];

        for (int i = 0; i <= CountNum; i++)
        {
            NewCreateIntArray[i] = Convert.ToInt32(NewCreateStringArray[i]);
        }

        return NewCreateIntArray;
    }

    static void ArrayWrite(int[] Array)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            if (i == 0) Console.Write("[" + Array[i] + ", ");
            else if (i == Array.Length - 1) Console.Write(Array[i] + "]");
            else Console.Write(Array[i] + ", ");
        }
    }

    static int SerchMaxElement(int[] SearchArray)
    {
        int Max = SearchArray[0];
        for (int i = 1; i < SearchArray.Length; i++)
        {
            Max = Math.Max(SearchArray[i], Max);
        }
        return Max;
    }
    static int SerchMinElement(int[] SearchArray)
    {
        int Min = SearchArray[0];
        for (int i = 1; i < SearchArray.Length; i++)
        {
            Min = Math.Min(SearchArray[i], Min);
        }
        return Min;
    }

    static void Main()
    {
        int[] ArrayResult = CreateArray();
        ArrayWrite(ArrayResult);
        Console.Write(" -> " + (SerchMaxElement(ArrayResult) - SerchMinElement(ArrayResult)));
    }
}