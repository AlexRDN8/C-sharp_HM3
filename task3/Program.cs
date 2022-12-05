/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int N);
int[] squareOfNumber = getSquareOfNumber(N);
PrintArray(squareOfNumber);



if (!isParsedN)
{
    Console.WriteLine("Должно быть введено число");
    return;
}

int[] getSquareOfNumber(int N)
{
    int[] array = new int[N];
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = (int)(Math.Pow(index+1, 3));
        index ++;               
    }
    return array;         
}

void PrintArray (int [] array)
{
    for (int index = 0; index < array.Length; index ++)
    {
        Console.WriteLine($"{array[index]} ");
    }
    Console.WriteLine();
}
