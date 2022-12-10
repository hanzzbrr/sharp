// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine($"2222 * 4444 is equal to {RecIntKacu(2222, 4444)}"); // 9 874 568
Console.WriteLine($"1234 * 5768 is equal to {RecIntKacu(1234, 5768)}"); // 7 117 712
Console.WriteLine($"22 * 57 is equal to {RecIntKacu(22, 57)}"); // 1 254

// ab  1234   a = 12, b = 34
// --  ----
// cd  4444   c = 44, d = 44

int RecIntKacu(int x, int y)
{
    // check exceptions
    int n = CountDigits(x);

    // base check
    if (n == 1)
    {
        return x * y;
    }
    else
    {
        int a = GetFirstHalf(x, n);
        int b = GetSecondHalf(x, n);

        int c = GetFirstHalf(y, n);
        int d = GetSecondHalf(y, n);

        int p = a + b;
        int q = c + d;

        int ac = RecIntKacu(a, c);
        int bd = RecIntKacu(b, d);

        //int ad = RecIntKacu(a, d);
        //int bc = RecIntKacu(b, c);

        int pq = RecIntKacu(p, q);


        //var result = (int)Math.Pow(10, n) * ac + (int)Math.Pow(10, n / 2) * (ad + bc) + bd;
        var result = (int)Math.Pow(10, n) * ac + (int)Math.Pow(10, n / 2) * (pq - ac - bd) + bd;
        return result;
    }
}

int CountDigits(int n)
{
    int count = 0;
    do
    {
        n /= 10;
        ++count;
    } while (n != 0);

    return count;
}

int GetFirstHalf(int a, int n)
{
    int div = (int)Math.Pow(10, n / 2);
    return a / div;
}

int GetSecondHalf(int a, int n)
{
    int div = (int)Math.Pow(10, n / 2);
    return a % div;
}