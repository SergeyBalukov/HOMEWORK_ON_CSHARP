// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введи номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Этот день выходной");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Такого дня не существует");
    }
    else Console.WriteLine("Этот день не выходной");
}

CheckingTheDayOfTheWeek(dayNumber);