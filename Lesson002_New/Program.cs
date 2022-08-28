//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int number = new Random().Next(100000);
string numberStr = number.ToString();
if (numberStr.Length < 3)
{
    Console.Write($"{number} -> третьей цифры нет");
}
else
{
    Console.Write($"{number} -> {numberStr[2]}");
}