namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool isCheck)
        {
            var sum = x + y;

            if (isCheck == true && sum > 1)// and operator saying if ischeck is true and sum is greater than 1, both have to be true to print the statement 
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                Console.WriteLine("Better Luck Next time");
                return sum.ToString();
          
            }


        }
        static void Main(string[] args)
        {
            var x = 2;
            var y = 3;
            Console.WriteLine(Add(x,y));
      

            var b = 26.4m;
            var c = 5.6m;
            Console.WriteLine(Add(b,c));

            var a = 10;
            var h = 12;
            Console.WriteLine(Add(a, h, true));

            var f = 1;
            var k = 0;
            Console.WriteLine(Add(f, k, true));


        }
    }
}
