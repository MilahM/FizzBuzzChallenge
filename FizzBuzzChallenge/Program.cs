namespace FizzBuzzChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {

         Console.WriteLine(FizzBuzz(15));
           
        }

        public static string FizzBuzz(int num)
        {
            var answer = "";

            if (num % 3 == 0 && num % 5 == 0)
            {
                return "fizzbuzz";
            }
            if (num % 3 == 0)
            {
                return "fizz";
            }
            if (num % 5 == 0)
            {
                return "buzz";
            }
            return answer;

        }
    }
}