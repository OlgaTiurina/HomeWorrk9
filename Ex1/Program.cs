// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке 
// от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Задайте значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNumbers(m, n);
Console.WriteLine();

void PrintNumbers(int m, int n)
{
    if(m < n)
    {
        for(int i = m; i <= n; i++)
        {
            Console.Write($"{i},  ");
        }
    }

    else if(m > n)
    {
        for(int i = m; i >= n; i--)
        {
            Console.Write($"{i},  ");
        }
    }

    else if(m == n)
    {
        Console.WriteLine("Введённые числа M и N равны!");
    }
}
