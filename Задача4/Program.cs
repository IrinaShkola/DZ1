// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Write ("Введите число A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число C");
int numC = Convert.ToInt32(Console.ReadLine());
if (numA>numB&&numB>numC)
{
    Console.Write($"max={numA}");
}
else if (numA<numB&&numB>numC)
{
    Console.Write($"max={numB}");
}
else if (numB<numC&&numC>numA)
{
    Console.Write($"max={numC}");
}