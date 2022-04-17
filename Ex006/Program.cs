// 5. Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


int x = new Random().Next(0, 5);
int y = new Random().Next(0, 5);
System.Console.WriteLine(x);
System.Console.WriteLine(y);
// int a = 525;
// int b = 25;

// if (a == b * b ^ b == a * a)
// {
//        System.Console.WriteLine("Одно квадрат другого");
// }
// else
// {
//     System.Console.WriteLine("Не квадрат");
// }

void Kvadrat(int a, int b)
{
    if (a == b * b || b == a * a)
    {
        System.Console.WriteLine("Одно квадрат другого");
    }
    else
    {
        System.Console.WriteLine("Не квадрат");
    }
}
Kvadrat(x, y);