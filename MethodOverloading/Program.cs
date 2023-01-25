namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int numb1, int numb2)
        {
            return numb1 + numb2;

        }

        public static decimal Add(decimal numb1, decimal numb2)
        {
            return numb1 + numb2;
        }

        public static string Add(int numb1, int numb2, bool isTrue)
        {
            var sum = 0;
            var response = "";
            if (isTrue)
            {
                sum = numb1 + numb2;
                if (sum == 1)
                {
                   response = $"{sum} dollar.";
                }
                else
                {
                    response = $"{sum} dollars.";
                }
            }
            return response;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(Add(0, 1, true));


            Console.WriteLine(Add(5, 7, true));


            Console.WriteLine(Add(-6, 3, true));

        }
    }
}
