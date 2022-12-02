/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/
Console.WriteLine("Введите номер дня неднли");
int num = Convert.ToInt32(Console.ReadLine());
if (num>=6 && num<=7)
{
    Console.WriteLine("Сегодня выходной");
}
else if (num>=1 && num<=5)
{
    Console.WriteLine("Сегодня на работу");
}
else 
{
    Console.WriteLine("В неделе только 7 дней)");
}
