namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int sum1 = Add(num1, num2);
            Console.WriteLine(sum1);

            decimal decimal1 = 3.5m;
            decimal decimal2 = 2.7m;
            decimal sum2 = Add(decimal1, decimal2);
            Console.WriteLine(sum2);

            int num3 = 8;
            int num4 = 12;
            bool includeDollars = true;
            string result = Add(num3, num4, includeDollars);
            Console.WriteLine(result);
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static decimal Add(decimal decimal1, decimal decimal2)
        {
            return decimal1 + decimal2;
        }

        static string Add(int num1, int num2, bool includeDollars)
        {
            int sum = num1 + num2;
            if (includeDollars)
            {
                if (sum == 1)
                {
                    return sum + " dollar";
                }
                else
                {
                    return sum + " dollars";
                }
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
