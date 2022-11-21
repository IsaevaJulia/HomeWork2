//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

/*
int SecondNumb(int num)
{
    int sot = num / 100;
    int ed = num % 10;
    int rezult = (num - (sot * 100) - ed) / 10;
    return rezult;
}

int random = new Random().Next(100, 1000);
int resultat = SecondNumb(random);

Console.WriteLine($"{random} -> {resultat}");
*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/*
Console.Write("Введите число ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);

if (NumberText.Length > 2)
{
  Console.WriteLine($"третья цифра -> {NumberText[2]}");
}
else {
  Console.WriteLine($"-> третьей цифры нет");
}
*/


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет


void WeekN(int Num)
{
    if (Num < 5)
    {
        Console.WriteLine($"День недели рабочий");
    }
    else
    {
        Console.WriteLine($"День недели выходной");
    }
}

Console.Write("Введите число ");
int Number = Convert.ToInt32(Console.ReadLine());

WeekN(Number);




