namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prev = 0;
            int current = 1;
            int temp;
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(current);
                temp = current;
                current += prev;
                prev = temp;
            }

            Console.ReadKey();

            for (int i = 0; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            int[] num = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i <= 5; i += 1)
            {
                foreach (int g in num)
                {
                    Console.WriteLine(g * i);
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

