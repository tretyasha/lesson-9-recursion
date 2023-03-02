# lesson-9-recursion
// Найти сумму элементов от M до N, N и M заданы
int SumRec(int n, int m)
{
    if (n == 0) return 0;
    else return SumRec(n - 1, m) + n;
}
Console.WriteLine(SumRec(9, 1));

// Показать натуральные числа от M до N, N и M заданы
string NumbersRec(int n, int m)
{
    if (n <= m) return NumbersRec(n + 1, m) + $"{n}";
    else return String.Empty;
}
Console.WriteLine(NumbersRec(1, 9));

// Найти сумму цифр числа

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sum = Summ(number);
int Summ(int number)
{
    if (number > 0)
        return
        number % 10 + Summ(number / 10);
    else
        return 0;
}
Console.WriteLine($" {sum}");

// Написать программу вычисления функции Аккермана
int Akk(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akk(n - 1, 1);
    if (n > 0 && m > 0) return Akk(n - 1, Akk(n, m - 1));
    return Akk(n, m);
}
Console.WriteLine(Akk(2, 1));

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

// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем
int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintNumber(int numberFirst, int numberSecond, int score)
{
    int temporary = 0;
    if (score > 0)
    {
        Console.Write(numberFirst + numberSecond + " ");
        temporary = numberFirst;
        numberFirst = numberSecond;
        numberSecond += temporary;
        PrintNumber(numberFirst, numberSecond, score -= 1);
    }
}
int numberFirst = GetNumber("Введите число M: ");
int numberSecond = GetNumber("Введите число N: ");
int score = GetNumber("Введите количество раз, сколько раз мы выведем число: ");
PrintNumber(numberFirst, numberSecond, score);
