namespace Сlasses
{
	public struct Rate
	{
		public Unit Unit { get; set; }
		public int _damage { get; set; }
		public double _health { get; set; }

		public Rate(Unit unit, int damage, double health)
		{
			Unit = unit;
			_damage = damage;
			_health = Math.Round(health, 2);
		}
	}
}

