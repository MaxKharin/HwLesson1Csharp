// Задача 1: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter first number, please");
string firstNum = Console.ReadLine();
int first = int.Parse(firstNum);
Console.WriteLine("Enter second number, please");
string secondNum = Console.ReadLine();
int second = int.Parse(secondNum);

if (first > second)
{
    Console.WriteLine($"{first} is bigger than {second}");
}
else if(first == second)
{
    Console.WriteLine($"{first} is equal to {second}");
}
else
{
    Console.WriteLine($"{second} is bigger than {first}");
}