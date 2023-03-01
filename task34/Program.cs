//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}


int[] GetRandomArray(int length, int leftBorder, int rightBorder)
{
    int leftRange = 100;
    int rightRange = 1000;

    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange);
    }

    return array;
}

int evenNumbers(int[] array)
{
    int sumnum = 0;
    for(int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        sumnum += 1;
    }
 
}
return sumnum;
}
int lengthOfArray = ReadNumber("Задайте длину массива");
int leftBorder = 100;
int rightBorder = 1000;
int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);
Console.WriteLine($"[{string.Join(", ", myArray)}]");
int sumnum = evenNumbers (myArray);
Console.WriteLine($"Колличество четных чисел в массиве = {sumnum}");