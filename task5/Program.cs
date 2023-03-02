// Написать программу возведения числа А в целую стень B
Console.Write("Введите A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите B: ");
int B = int.Parse(Console.ReadLine());

int result = Degree(A, B);
int Degree(int A, int B)
{
    if (B > 1)
        return A * Degree(A, B - 1);
    else
        return A;
}

Console.WriteLine($" {result}");