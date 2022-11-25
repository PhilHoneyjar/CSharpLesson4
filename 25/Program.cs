// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.Write("Input A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B: ");
int b = Convert.ToInt32(Console.ReadLine());
int j = a;

for (int i = 1; i < b; i++)
{
j = j * a;
}
Console.Write("A ^ B = " + j);