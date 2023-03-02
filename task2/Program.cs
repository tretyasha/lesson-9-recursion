// Показать натуральные числа от M до N, N и M заданы
string NumbersRec(int n, int m)
{
    if (n <= m) return NumbersRec(n + 1, m) + $"{n}";
    else return String.Empty;
}
Console.WriteLine(NumbersRec(1, 9));
