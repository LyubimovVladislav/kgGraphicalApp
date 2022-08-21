namespace kgGraphicalApp
{
	public struct Segment
	{
		public PointCustom A, B;

		public Segment(PointCustom a, PointCustom b)
		{
			A = a;
			B = b;
		}

		public void Swap()
		{
			PointCustom temp = A;
			A = B;
			B = temp;
		}

		public Segment(int origX, int origY, int destX, int destY) : this(new PointCustom(origX, origY),
			new PointCustom(destX, destY))
		{
		}


		public bool OnLeft(PointCustom p)
		{
			var ab = new PointCustom(B.X - A.X, B.Y - A.Y);
			var ap = new PointCustom(p.X - A.X, p.Y - A.Y);
			return ab.Cross(ap) >= 0;
		}

		public PointCustom Normal => new PointCustom(B.Y - A.Y, A.X - B.X);

		public PointCustom Direction => new PointCustom(B.X - A.X, B.Y - A.Y);

		public float IntersectionParameter(Segment that)
		{
			var segment = this;
			var edge = that;

			var segmentToEdge = edge.A.Subtract(segment.A);
			var segmentDir = segment.Direction;
			var edgeDir = edge.Direction;

			var t = edgeDir.Cross(segmentToEdge) / edgeDir.Cross(segmentDir);

			if (float.IsNaN(t))
			{
				t = 0;
			}

			return t;
		}

		public Segment Morph(float tA, float tB)
		{
			var d = Direction;
			return new Segment(A.Add(d.Multiply(tA)), A.Add(d.Multiply(tB)));
		}

		public static Segment operator +(Segment first, Segment second)
		{
			return new Segment(first.A + second.A, first.B + second.B);
		}
		
		public static Segment operator +(Segment first, int num)
		{
			return new Segment(first.A + num, first.B + num);
		}
		
		public static Segment operator -(Segment first, int num)
		{
			return new Segment(first.A - num, first.B - num);
		}
	}
}