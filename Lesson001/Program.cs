//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите три разных целых числа:");
int number1 = 0; int number2 = 0; int number3 = 0;
int max = 0;
bool check1 = false; bool check2 = false; bool check3 = false;
check1 = int.TryParse(Console.ReadLine()!, out number1);
check2 = int.TryParse(Console.ReadLine()!, out number2);
check3 = int.TryParse(Console.ReadLine()!, out number3);

if (number1 == number2 || number1 == number3 || number2 == number3)
{
    Console.Write($"Нужно ввести три разных числа!"); 
    return;
}

if (check1 && check2 && check3)
{
    if (number1 > number2) 
    {
        if (number1 > number3) max = number1;
        else max = number3;
    }
    else
    {
        if (number2 > number3) max = number2;
        else max = number3;
    }
    Console.Write($"Наибольшее число — {max}.");  
}
else
{
    Console.Write("Данные введены некорректно!");
}