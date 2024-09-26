using Сlasses;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Подготовка к бою...");
            Console.WriteLine("Введите имя бойца:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите начальное здоровье бойца (10-100):");
            int.TryParse(Console.ReadLine(), out int health);
            if (health < 10 || health > 100)
            {
                Console.WriteLine("Введенные данные здоровья не корректны, попробуйте еще раз: ");
                string healthSecond;
                do
                {
                    healthSecond = Console.ReadLine();
                } while (int.Parse(healthSecond) is < 10 or > 100);
            }
            Console.WriteLine("Введите значение брони шлема от 0, до 1:");
            int.TryParse(Console.ReadLine(), out int helm);
            if (helm is < 0 or > 1)
            {
                Console.WriteLine("Введенные данные значения брони шлема не корректны, попробуйте еще раз: ");
                string helmSecond;
                do
                {
                    helmSecond = Console.ReadLine();
                } while (int.Parse(helmSecond) is < 0 or > 1);
            }
            Console.WriteLine("Введите значение брони кирасы от 0, до 1:");
            int.TryParse(Console.ReadLine(), out int shell);
            if (helm is < 0 or > 1)
            {
                Console.WriteLine("Введенные данные значения брони кирасы не корректны, попробуйте еще раз: ");
                string shellSecond;
                do
                {
                    shellSecond = Console.ReadLine();
                } while (int.Parse(shellSecond) is < 0 or > 1);
            }
            Console.WriteLine("Введите значение брони сапог от 0, до 1:");
            int.TryParse(Console.ReadLine(), out int boots);
            if (boots is < 0 or > 1)
            {
                Console.WriteLine("Введенные данные значения брони сапог не корректны, попробуйте еще раз: ");
                string bootsSecond;
                do
                {
                    bootsSecond = Console.ReadLine();
                } while (int.Parse(bootsSecond) is < 0 or > 1);
            }
            Console.WriteLine("Укажите минимальный урон оружия (0-20):");
            int.TryParse(Console.ReadLine(), out int minDamage);
            if (minDamage is < 0 or > 20)
            {
                Console.WriteLine("Введенные данные значения минимального урона не корректны, попробуйте еще раз: ");
                string min;
                do
                {
                    min = Console.ReadLine();
                } while (int.Parse(min) is < 0 or > 20);
            }
            Console.WriteLine("Укажите максимальный урон оружия (20-40): ");
            int.TryParse(Console.ReadLine(), out int maxDamage);
            if (minDamage is < 20 or > 40)
            {
                Console.WriteLine("Введенные данные значения максимального урона не корректны, попробуйте еще раз: ");
                string max;
                do
                {
                    max = Console.ReadLine();
                } while (int.Parse(max) is < 20 or > 40);
            }

            var unit = new Unit(name, health);

        }
    }
}

