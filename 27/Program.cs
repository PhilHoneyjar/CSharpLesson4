// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (a > 0)
{
int i = a % 10;
a = a / 10;
sum = sum + i;
}
Console.Write("Sum of digits: " + sum);