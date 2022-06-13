// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter your number, please");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);
Console.WriteLine("Your numbers are: ");

for (int i = 1; i <= num; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i}");
    }
}