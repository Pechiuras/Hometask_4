// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Math.Pow(ЗАПРЕЩЕНО)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), F = 1, i = 2;
// while (i <= n)
// {
//     F = F * i;
//     i++; //i = i + 1
   
// }
// Console.WriteLine(F);

Console.Clear();
Console.Write("Введите число 1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int m = Convert.ToInt32(Console.ReadLine());
int p = 1, i = 1;
while (i <=m)
{
   p = p * n;
   i++;
}
Console.WriteLine(p);
