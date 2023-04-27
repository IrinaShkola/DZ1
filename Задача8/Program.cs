// Напишите программу, которая на вход принимает число N, а на выходе показывает чётные числа от 1доN.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.Write("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
for (int i=1; i<=N; i++)
{
if(i%2==0)
{Console.Write("{0}",i);}
}
