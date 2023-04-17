class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите возраст от 1 до 99");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0} {1} ", a.ToWord(),
           ((a / 10 == 1) || (a - 1) % 10 > 3) ? "лет" : ((a % 10 == 1) ? "год" : "года"));
        Console.Read();
    }
}
static class IntToString
{
    static string[] decade = new[] { "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
    private static string[] ten = new[] { "десять", "одинадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
    static string[] ones = new[] { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

    public static string ToWord(this int n)
    {
        if (n / 10 == 1) return ten[n % 10];
        if (n / 10 == 0) return ones[n % 10];
        return decade[n / 10 - 2] + " " + ones[n % 10];
    }
}