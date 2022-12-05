/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите число: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int N);

if (!isParsedN)
{
    Console.WriteLine("Должно быть введено число");
    return;
}

if (CheckOfPalindrome(N) == N)
{
    Console.WriteLine("да");    
}
else
{
    Console.WriteLine("нет"); 
}



int CheckOfPalindrome(int N)
{
    int count = 1;
    int limit = (int)Math.Floor(Math.Log10(N) + 1);
    int result = 0;
    while (count < limit)
    { 
        int new_N = N / (int)Math.Pow(10, count - 1);
        int remainder = new_N % 10;
        result = result + (remainder * (int)Math.Pow(10, limit - count));       
        count ++;
    }
    result = result + N / (int)Math.Pow(10, limit-1); 
    return result; 
}



