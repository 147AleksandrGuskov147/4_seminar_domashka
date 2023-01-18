// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] array = new int[];

Console.Write("Введите размер масcива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for(int i = 0; i < array.Length; i++)
{
    Console.Write("Введите элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
