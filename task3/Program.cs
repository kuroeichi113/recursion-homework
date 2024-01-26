int[] array = { 5, 8, 7, 4, 9 };
PrintArrayReverse(array, array.Length - 1);


void PrintArrayReverse(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write($"{array[index]} ");
        PrintArrayReverse(array, index - 1);
    }
}


