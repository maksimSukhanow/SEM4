// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



int[] CreateArray(int length, int minNum,int maxNum)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minNum,maxNum+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length-1]} ");
    System.Console.Write("]");
}





System.Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Минимальное значение числа массива");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Максимальное значение числа массива");
int c = Convert.ToInt32(Console.ReadLine());

PrintArray(CreateArray(a,b,c));
