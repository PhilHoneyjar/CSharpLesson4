// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

int Power(int a, int b)
{
    int answer = 1;

    for (int i = 1; i <= b; i++)
    {
        answer *= a;
    }
    return answer;
}

Console.Write("Input A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B: ");
int b = Convert.ToInt32(Console.ReadLine());

int answer = Power(a, b);

Console.Write("A ^ B = " + answer);