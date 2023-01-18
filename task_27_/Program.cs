// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// for (count = 0; N > 0; count++)
// {
//     B = N%10;
// }
// Console.WriteLine(count);

int Sum(int N)
{
    int sum = 0;
    while(N > 0)
    {
        int count=N%10;
        sum=count+sum;
        N=N/10; 
    }
    return sum;
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = Sum(N);
Console.Write("Сумма элементо числа " + N + " = " + sum);
