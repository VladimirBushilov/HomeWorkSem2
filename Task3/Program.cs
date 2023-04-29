// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру от 1-7: ");
int num = Convert.ToInt32(System.Console.ReadLine());

if (num >= 1 && num <= 5)
{
    System.Console.WriteLine("Рабочий день");
}
else if (num == 6 || num == 7)
{
    System.Console.WriteLine("Выходной");
}
else 
{
    System.Console.WriteLine("Не номер дня недели");
}