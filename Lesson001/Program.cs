//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число:");
int number1 = 0;
bool check1 = int.TryParse(Console.ReadLine()!, out number1);

if (check1)
{
    Console.Write("Чётные числа: ");
    for (int i = 1; i <= number1; i++)
    {
        if (i % 2 == 0) Console.Write($"{i}, ");    
    }
}
else
{
    Console.Write("Некорректный ввод данных!"); 
}