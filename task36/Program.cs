//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
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
int sumELements(int[] array)
{
    int sum = 0;
    for( int i = 1; i < array.Length;)
    {
        sum += array[i];
        i = i +2;
    }
    return sum;
}
int lengthOfArray = ReadNumber("Задайте длину массива");
int leftBorder = ReadNumber("Задайте левую границу");
int rightBorder = ReadNumber("Задайте правую границу");

int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);

Console.WriteLine($"[{string.Join(", ", myArray)}]");
int sum = sumELements(myArray);
Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");
