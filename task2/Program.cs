// Найти сумму элементов от M до N, N и M заданы
int SumRec(int n, int m)
{
    if (n == 0) return 0;
    else return SumRec(n - 1, m) + n;
}
Console.WriteLine(SumRec(9, 1));
