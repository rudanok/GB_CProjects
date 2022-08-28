//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два целых числа:");
int number1 = 0;
int number2 = 0;
bool check1 = int.TryParse(Console.ReadLine()!, out number1);
bool check2 = int.TryParse(Console.ReadLine()!, out number2);

if (check1 && check2)
{
    if (number1 > number2) Console.Write($"Число {number1} больше, чем число {number2}.");
    if (number1 < number2) Console.Write($"Число {number2} больше, чем число {number1}.");
    if (number1 == number2) Console.Write("Введённые числа равны.");    
}
else
{
    Console.Write("Некорректный ввод данных!");
}

