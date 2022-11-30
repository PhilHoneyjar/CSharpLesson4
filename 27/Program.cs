// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int SumNumber(int number)
{
    int sum = 0;

    for (int i = number % 10; number > 0; i = number % 10)
    {
        number = number / 10;
        sum = sum + i;
    }

    return sum;
}

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());


Console.Write("Sum of digits: " + SumNumber(a));