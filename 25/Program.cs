// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Degree(int a, int b)
{
    int result = a;
    for (int i = b; i > 1; i--)
    {
        result = result * a;
    }
    return result;
}


System.Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число В");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Degree(a, b));