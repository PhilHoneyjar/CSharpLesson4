// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int[] GetFillArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
    }

    return array;
}

string PrintArray(int[] array)
{
    return String.Join(", ", array);
}

int[] mainArray = GetFillArray(8);
System.Console.WriteLine(PrintArray(mainArray));