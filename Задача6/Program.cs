// Напишите программу, которая на вход принимает число и выдает, является ли число четным(делится ли оно без остатка)
// 4-> да
// -3 -> нет
// 7 -> нет
Console.Write("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(number/2);
if (number%2 == 0)
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}