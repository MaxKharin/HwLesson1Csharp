// Задача 2: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter first number, please.");
string firstNum = Console.ReadLine();
int first = int.Parse(firstNum);
Console.WriteLine("Enter second number, please.");
string secondNum = Console.ReadLine();
int second = int.Parse(secondNum);
Console.WriteLine("Enter third number, please.");
string thirdNum = Console.ReadLine();
int third = int.Parse(thirdNum);

if (first > second && first > third)
{
    Console.WriteLine($"{first} is the biggest number");
}

else if(second > first && second > third)
{
    Console.WriteLine($"{second} is the biggest number");
}
else if(second == first && second == third)
{
    Console.WriteLine($"All entered numbers are equal");
}
else if(first == second && first > third)
{
    Console.WriteLine($"{first} is equal to {second} and is bigger than {third}");
}
else if(first == third && first > second)
{
    Console.WriteLine($"{first} is equal to {third} and is bigger than {second}");
}
else if(second == third && second > first)
{
    Console.WriteLine($"{second} is equal to {third} and is bigger than {first}");
}
else
{
    Console.WriteLine($"{third} is the biggest number");
}
