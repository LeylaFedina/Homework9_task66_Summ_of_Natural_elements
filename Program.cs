/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetSumOfNumbers(int M, int N)
{
    if (M == N) return N;
    else if (M > N) return N + GetSumOfNumbers(M, N + 1); 
    else return N + GetSumOfNumbers(M, N - 1);
}
Console.Write("M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумму натуральных элементов в промежутке от {M} до {N} = {GetSumOfNumbers(M, N)}");



