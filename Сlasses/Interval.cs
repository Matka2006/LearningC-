namespace Сlasses
{
	public struct Interval
	{
		private int _minValue;
        private int _maxValue;
		private static Random random = new Random();

		public Interval(int minValue, int maxValue): this((double)minValue, (double)maxValue)
		{
			_minValue = minValue;
			_maxValue = maxValue;
		}

		public Interval(double minValue, double maxValue)
		{
			if (minValue > maxValue)
			{
				this._minValue = _maxValue;
				this._maxValue = _minValue;
			}
			else
			{
                this._minValue = _minValue;
                this._maxValue = _maxValue;
            }
		}

		public Interval(double value): this(value, value)
		{
		}

		private double Min => _minValue;
		private double Max => _maxValue;
		private double Average => (_minValue + _maxValue) / 2;

		public double Get()
		{
			return random.NextDouble() * (_maxValue - _minValue) + _minValue;
		}
	}
}

