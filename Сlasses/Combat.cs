using System;
namespace Сlasses
{
    using System.Collections.Generic;

    public class Combat
    {
        private List<Rate> rates; // Используем List для динамического размера

        public Combat()
        {
            rates = new List<Rate>();
        }

        public void StartCombat(Unit unit1, Unit unit2)
        {
            Random random = new Random();

            while (unit1.Health > 0 && unit2.Health > 0)
            {
                int randomNumber = random.Next(1, 11);
                int damage = random.Next(10, 31); // Урон от 10 до 30

                if (randomNumber % 2 == 0) // Четное число
                {
                    unit1.Health -= damage;
                    rates.Add(new Rate(unit2, damage, unit1.Health));
                }
                else // Нечетное число
                {
                    unit2.Health -= damage;
                    rates.Add(new Rate(unit1, damage, unit2.Health));
                }
            }
        }

        public void ShowResults()
        {
            foreach (var rate in rates)
            {
                Console.WriteLine(rate);
            }

            if (rates.Count > 0)
            {
                var lastRate = rates[rates.Count - 1];
                Console.WriteLine($"Победитель: {lastRate.Unit.Name}");
            }
        }
    }
}

