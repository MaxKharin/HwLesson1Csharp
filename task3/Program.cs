// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Enter your number, please");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);
if (num % 2 == 0)
{
    Console.WriteLine($"{num} is an even number");
}
else
{
    Console.WriteLine($"{num} is an odd number");
}