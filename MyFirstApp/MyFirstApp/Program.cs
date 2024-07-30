namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var last = 1;
            for (int i = 0; i <= 34; i += last)
            {
                Console.WriteLine(i);
                last = i;
                Console.Read();
            }

            for (int i = 0; i <= 20; i += 2)
            {
                Console.WriteLine(i);
                Console.Read();
            }

            int[] num = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i <= 5; i += 1)
            {
                foreach (int g in num)
                {
                    Console.WriteLine(g * i);
                    Console.Read();
                }
            }

            string password;
            do
            {
                password = Console.ReadLine();
            } while (password != "qwerty");



        }
    }
}



