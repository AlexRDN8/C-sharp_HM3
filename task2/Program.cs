/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int xA = InputCoordinates("X", "A");
int yA = InputCoordinates("Y","A");
int zA = InputCoordinates("Z","A");
int xB = InputCoordinates("X","B");
int yB = InputCoordinates("Y","B");
int zB = InputCoordinates("Z","B");
double distance = getDistanceBetweenPoints(xA, yA, zA, xB, yB, zB);
Console.WriteLine(distance);



int InputCoordinates(string axis, string point)
{
    Console.WriteLine($"Введите координаты {axis} точки {point} ");
    bool isParsedNum = int.TryParse(Console.ReadLine(), out int Num);
    if (isParsedNum)
    {
        return Num;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение");
        return -1;
    }
}

double getDistanceBetweenPoints (double xA, double yA, double zA, double xB, double yB, double zB)
{
    double calculating = ((xB - xA) * (xB - xA)) + ((yB - yA) * (yB - yA)) + ((zB - zA) * (zB - zA));
    double distance = Math.Sqrt(calculating);
    return distance;
}