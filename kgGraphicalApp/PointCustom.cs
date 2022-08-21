namespace kgGraphicalApp
{
	public struct PointCustom
	{
		public float X { get; set; } 
		public float Y { get; set; }

		public PointCustom(float x, float y)
		{
			this.X = x;
			this.Y = y;
		}

		public void ToInt()
		{
			this.X = (int) X;
			this.Y = (int) Y;
		}


		public PointCustom(int x, int y) : this((float) x, (float) y)
		{
		}

		public PointCustom Add(PointCustom a)
		{
			return new PointCustom(this.X + a.X, this.Y + a.Y);
		}

		public PointCustom Subtract(PointCustom a)
		{
			return new PointCustom(this.X - a.X, this.Y - a.Y);
		}

		public PointCustom Multiply(float a)
		{
			return new PointCustom(this.X * a, this.Y * a);
		}

		public float Dot(PointCustom a)
		{
			return this.X * a.X + this.Y * a.Y;
		}

		public float Cross(PointCustom a)
		{
			return this.X * a.Y - this.Y * a.X;
		}

		public override string ToString()
		{
			return $"{this.X} {this.Y}";
		}

		public static PointCustom operator +(PointCustom first, PointCustom second)
		{
			return new PointCustom((int)first.X + second.X, (int)first.Y + second.Y);
		}

		public static PointCustom operator /(PointCustom first, int num)
		{
			return new PointCustom((int)first.X / num, (int)first.Y / num);
		}
		
		public static PointCustom operator -(PointCustom first, int num)
		{
			return new PointCustom((int)first.X - num, (int)first.Y - num);
		}
		public static PointCustom operator +(PointCustom first, int num)
		{
			return new PointCustom((int)first.X + num, (int)first.Y + num);
		}
	}
}