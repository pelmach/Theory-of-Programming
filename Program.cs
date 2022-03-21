public class ConsloleApp4
{
    public static void Main(String[] args)
    {
        First();
        Second();
        Third();
        Fourth();
        Fifth();

    }
    static void First()
    {
        double exp = 0.0001;
        int n = 1;
        double a = Math.Pow(-1, n - 1) / n * Math.Pow(2, n);
        double result = 0;
        while (exp <= Math.Abs(a))
        {
            a = Math.Pow(-1, n - 1) / (n * Math.Pow(2, n));
            result += a;
            n++;
        }
        Console.WriteLine("First result = " + result);
    }
    static void Second()
    {

        double x = Convert.ToDouble(Console.ReadLine());
        int index = 1;
        double result = 0;
        int factorial = 1;
        for (int k = 1; k <= 6; k++)
        { 
            if (k % 2 == 0)
            {
                result -= Math.Pow(x, index) / factorial;
            }
            else
            {
                result += Math.Pow(x, index) / factorial;
            }
            factorial = factorial * (index + 1) * (index + 2);
            index += 2;
        }
        Console.WriteLine("Second result = " + result);
    }
    static void Third()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int index = 1;
        double result = 0;
        int k = 1;
        int factorial = 1;
        while ((2 * n - 1) >= index)
        {
            result += Math.Pow(-1, k - 1) * factorial;
            factorial = factorial * (index + 1) * (index + 2);
            index += 2;
            k++;
        }
        Console.WriteLine("Third result = " + result);
    }
    static void Fourth()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int max = 0;
        while (n > 0)
        {
            if (n % 10 > max)
            {
                max = n % 10;
                n /= 10;
            }
            else
            {
                n /= 10;
            }
        }
        Console.WriteLine("Fourth result = " + max);
    }
    static void Fifth()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int num = 0;
        while (x > 0)
        {
            num = num * 10 + (x % 10);
            x /= 10;
        }
        Console.WriteLine("Fifth result = " + num);
    }
}