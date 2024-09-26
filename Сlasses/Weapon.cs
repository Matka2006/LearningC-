namespace Сlasses
{
	public class Weapon
	{
		public string Name { get; }
		private float MinDamage { get; set; }
		private float MaxDamage { get; set; }

		

		public Weapon(string name)
		{
			Name = name;
		}

		public Weapon(float minDamage, float maxDamage, string name) : this("Weapon")
		{
			MinDamage = minDamage;
			MaxDamage = maxDamage;
			SetDamageParams(minDamage, maxDamage);
		}

		public void SetDamageParams(float minDamage, float maxDamage)
		{
			if (minDamage >= maxDamage)
			{
				maxDamage = minDamage;
				minDamage = maxDamage;
				Console.WriteLine("Damage Parametrs are not correct");
			}

			if (minDamage < 1f)
			{
				minDamage = 1f;
				Console.WriteLine("A forced setting of the minimum value occurred");
			}

			if (maxDamage <= 1f)
			{
				maxDamage = 10f;
				Console.WriteLine("A forced setting of the maximum value occurred");
			}
		}

		public float GetDamage()
		{
			return (MinDamage + MaxDamage) / 2;
		}
	}
}

