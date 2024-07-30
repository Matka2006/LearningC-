

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FibArray = new[] { 0, 1, 1, 2, 3, 5, 8, 13 };

            string[] Month = new[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "November", "December" };

            double[][] Degrees = {
                new[] { Math.Pow(2, 1), Math.Pow(3, 1), Math.Pow(4, 1) },
                new[] { Math.Pow(2, 2), Math.Pow(3, 2), Math.Pow(4, 2) },
                new[] { Math.Pow(2, 3), Math.Pow(3, 3), Math.Pow(4, 3) } };

            Console.WriteLine(Degrees[0][1]);

            double[][] JuggedArray = {
                new double[] { 1, 2, 3, 4, 5 },
                new double[] { Math.E, Math.PI },
                new double[] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) } };

            Console.WriteLine(JuggedArray[1][1]);

            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };

            Array.Copy(array, array2, 2);

            Array.Resize(ref array, 10);
            foreach (int i in array)
            {
                Console.WriteLine(array[8]);
                Console.Read();
            }

        }
    }
}



