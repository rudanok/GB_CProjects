//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число:");
double number1 = 0;
bool check1 = false;
check1 = double.TryParse(Console.ReadLine()!, out number1);

if (check1)
{
    if (number1 % 2 == 0) Console.Write($"Число {number1} является чётным.");
    else Console.Write($"Число {number1} является нечётным.");   
}
else
{
    Console.Write("Некорректный ввод данных!"); 
}