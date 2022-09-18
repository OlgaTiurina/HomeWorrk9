// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задайте значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

string SumNumber(int m, int n)
{
    string result = string.Empty;
    int count = 0;
    if(m < n)
    {
        for(int i = m; i <= n; i++)
        {
            count = count + i;
            result = $"Сумма всех натуральных элементов в промежутке от {m} до {n} равна {count}";
        }
        return result;
    }

    else if(m > n)
    {
        for(int i = m; i >= n; i--)
        {
            count = count + i;
            result = $"Сумма всех натуральных элементов в промежутке от {m} до {n} равна {count}";
        }
        return result;
    }

    else if(m == n)
    {
        result = "Введённые числа M и N равны!";
    }
    return result;
}

string result = SumNumber(m, n);
Console.WriteLine(result);
Console.WriteLine();
