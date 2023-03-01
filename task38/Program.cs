//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}


int[] GetRandomArray(int length, int leftRange, int rightRange)
{

    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }

    return array;
}
(int, int) maxAndMin(int[] array)
{
    int max = array[0];
    int min = array[0];
    
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
    }
   
    return (max, min);
}
int lengthOfArray = ReadNumber("Задайте длину массива");
int leftBorder = ReadNumber("Задайте левую границу");
int rightBorder = ReadNumber("Задайте правую границу");

int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);

Console.WriteLine($"[{string.Join(", ", myArray)}]");
(int max, int min) = maxAndMin(myArray);
Console.WriteLine($"Максимальный элемент = {max}");
Console.WriteLine($"Минимальный элемент = {min}");
Console.WriteLine($"Разность макс и мин = {max - min}");