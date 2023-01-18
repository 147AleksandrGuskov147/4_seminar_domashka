// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (без использования Math.Pow)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень возведения: ");
int B = Convert.ToInt32(Console.ReadLine());
int count = A;

for(int i = 2; i <= B; i++)
    {
        count*=A;
    }

Console.WriteLine(A + " в степени " + B + " = " + count);