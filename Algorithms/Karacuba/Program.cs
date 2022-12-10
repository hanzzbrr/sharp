// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine($"2222 * 4444 is equal to {RecIntMult(2222, 4444)}");
Console.WriteLine($"1234 * 5768 is equal to {RecIntMult(1234, 5768)}");
Console.WriteLine($"22 * 57 is equal to {RecIntMult(22, 57)}");

// ab  1234   a = 12, b = 34
// --  ----
// cd  4444   c = 44, d = 44

int RecIntMult(int x, int y)
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

        int ac = RecIntMult(a, c);

        int ad = RecIntMult(a, d);
        int bc = RecIntMult(b, c);

        int bd = RecIntMult(b, d);

        var result = (int)Math.Pow(10, n) * ac + (int)Math.Pow(10, n / 2) * (ad + bc) + bd;
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

(int, int) GetHalfDigits(int a, int n)
{
    int div = (int)Math.Pow(10, n / 2);
    return (a / div, a % div);
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