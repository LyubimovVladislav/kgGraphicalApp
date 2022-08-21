using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

namespace kgGraphicalApp
{
	public class CustomLine
	{
		private int _coefficientX, _coefficientY;
		private bool _isSwitched;
		private int _canonicalX;
		private int _canonicalY;

		private readonly List<Rectangle> _empty = new List<Rectangle>();

		public CustomLine()
		{
			_empty.Clear();
		}

		public List<Rectangle> DdaLine(int originX, int originY, int destinationX, int destinationY)
		{
			List<Rectangle> rectangles = new List<Rectangle>();


			// Coordinates of line ends - (originX,originY) and (destinationX,destinationY)

			ConvertToCanonical(originX, originY, destinationX, destinationY);


			// if line is only one pixel, then return only one pixel
			if (_canonicalX == 0 && _canonicalY == 0)
			{
				rectangles.Add(new Rectangle(originX, originY, 1, 1));
				return rectangles;
			}

			int x = 0;
			int y = 0;
			float ordinate = (float) _canonicalY / (float) _canonicalX;
			float deltaOrdinate = (float) _canonicalY / (float) _canonicalX;


			while (x < _canonicalX)
			{
				rectangles.Add(_isSwitched
					? new Rectangle(originX + (y * _coefficientX), originY + (x * _coefficientY), 1, 1)
					: new Rectangle(originX + (x * _coefficientX), originY + (y * _coefficientY), 1, 1));

				if (ordinate > (1f / 2f))
				{
					// d : Diagonal offset
					x++;
					y++;

					// because offset happen on 'y' by one
					ordinate += deltaOrdinate - 1;
				}
				else
				{
					// s : horizontal offset
					x++;
					ordinate += deltaOrdinate;
				}
			}

			return rectangles;
		}

		private void ConvertToCanonical(int originX, int originY, int destinationX, int destinationY)
		{
			_coefficientX = 1;
			_coefficientY = 1;
			_isSwitched = false;

			_canonicalX = destinationX - originX;
			_canonicalY = destinationY - originY;
			if (_canonicalX < 0)
			{
				_coefficientX = -1;
				_canonicalX *= -1;
			}

			if (_canonicalY < 0)
			{
				_coefficientY = -1;
				_canonicalY *= -1;
			}

			if (_canonicalX >= _canonicalY) return;
			int temp = _canonicalX;
			_canonicalX = _canonicalY;
			_canonicalY = temp;
			_isSwitched = true;
		}

		private (float, float) ConvertToCanonical(float originX, float originY, float destinationX, float destinationY)
		{
			_coefficientX = 1;
			_coefficientY = 1;
			_isSwitched = false;

			float canonicalX = destinationX - originX;
			float canonicalY = destinationY - originY;
			if (canonicalX < 0)
			{
				_coefficientX = -1;
				canonicalX *= -1;
			}

			if (canonicalY < 0)
			{
				_coefficientY = -1;
				canonicalY *= -1;
			}

			if (canonicalX >= canonicalY)
				return (canonicalX, canonicalY);
			_isSwitched = true;
			return (canonicalY, canonicalX);
		}

		public List<Rectangle> BresenhamLine(int originX, int originY, int destinationX, int destinationY)
		{
			List<Rectangle> rectangles = new List<Rectangle>();

			ConvertToCanonical(originX, originY, destinationX, destinationY);
			if (_canonicalX == 0 && _canonicalY == 0)
			{
				rectangles.Add(new Rectangle(originX, originY, 1, 1));
				return rectangles;
			}
			
			int e = 2 * _canonicalY - _canonicalX;
			int deltaEs = 2 * _canonicalY;
			int deltaEd = 2 * _canonicalY - 2 * _canonicalX;

			int x = 0;
			int y = 0;

			while (x < _canonicalX)
			{
				rectangles.Add(_isSwitched
					? new Rectangle(originX + (y * _coefficientX), originY + (x * _coefficientY), 1, 1)
					: new Rectangle(originX + (x * _coefficientX), originY + (y * _coefficientY), 1, 1));

				if (e > 0)
				{
					x++;
					y++;
					e += deltaEd;
				}
				else
				{
					x++;
					e += deltaEs;
				}
			}

			return rectangles;
		}

		public List<Rectangle> NonIntegerEnd(float originX, float originY, float destinationX, float destinationY)
		{
			List<Rectangle> rectangles = new List<Rectangle>();
			(float, float) destCanonical = ConvertToCanonical(originX, originY, destinationX, destinationY);
			int c = 10000;
			int x = 0;
			int y = 0;

			if (destCanonical.Item1 < 1 && destCanonical.Item2 < 1)
			{
				rectangles.Add(new Rectangle((int) originX, (int) originY, 1, 1));
				return rectangles;
			}

			float deltaH = c / destCanonical.Item1;
			float deltaV = c / destCanonical.Item2;

			float h = deltaH * (1 - ((float)Math.Truncate(originX) - originX));
			float v = deltaV * (1 - ((float)Math.Truncate(originY) - originY));
			
			if (h >= c)
				h = c -1;
			if (v >= c)
				v = c -1;
			

			while ((h < c) & (v < c))
			{
				rectangles.Add(_isSwitched
					? new Rectangle((int) originX + (y * _coefficientX), (int) originY + (x * _coefficientY), 1, 1)
					: new Rectangle((int) originX + (x * _coefficientX), (int) originY + (y * _coefficientY), 1, 1));

				if (h < v)
				{
					x++;
					h += deltaH;
				}
				else if (h > v)
				{
					y++;
					v += deltaV;
				}
				else
				{
					rectangles.Add(_isSwitched
						? new Rectangle((int) originX + (y * _coefficientX), (int) originY + ((x + 1) * _coefficientY),
							1, 1)
						: new Rectangle((int) originX + (x * _coefficientX), (int) originY + ((y + 1) * _coefficientY),
							1, 1));
					x++;
					y++;
					h += deltaH;
					v += deltaV;
				}
			}

			return rectangles;
		}

		public List<Rectangle> BresenhamCircle(int originX, int originY, int destinationX, int destinationY)
		{
			List<Rectangle> rectangles = new List<Rectangle>();

			int radius = (int) FindLineLength(originX, originY, destinationX, destinationY);

			int x = -radius;
			int y = 0;

			int f = 1 - radius;
			int deltaFs = 3;
			int deltaFd = 5 - 2 * radius;

			while (x + y <= 0) // needs to be <=0 otherwise the circle wouldn't be complete
			{
				rectangles.Add(new Rectangle(originX + y, originY + x, 1, 1));
				rectangles.Add(new Rectangle(originX + x, originY + y, 1, 1));
				rectangles.Add(new Rectangle(originX + y, originY - x, 1, 1));
				rectangles.Add(new Rectangle(originX + x, originY - y, 1, 1));

				rectangles.Add(new Rectangle(originX - y, originY + x, 1, 1));
				rectangles.Add(new Rectangle(originX - x, originY + y, 1, 1));
				rectangles.Add(new Rectangle(originX - y, originY - x, 1, 1));
				rectangles.Add(new Rectangle(originX - x, originY - y, 1, 1));

				if (f > 0)
				{
					// d: Диагональное смещение
					f += deltaFd;
					x++;
					y++;
					deltaFs += 2;
					deltaFd += 4;
				}
				else
				{
					// s: Вертикальное смещение
					f += deltaFs;
					y++;
					deltaFs += 2;
					deltaFd += 2;
				}
			}

			return rectangles;
		}

		private static double FindLineLength(float originX, float originY, float destinationX, float destinationY)
		{
			return Math.Sqrt(Math.Pow(destinationX - originX, 2) + Math.Pow(destinationY - originY, 2));
		}

		private static double FindLineLength(Segment segment)
		{
			return FindLineLength((int) segment.A.X, (int) segment.A.Y, (int) segment.B.X, (int) segment.B.Y);
		}

		private double FindPathLength(List<Point> points)
		{
			double pathLen = 0;
			for (int i = 0; i < points.Count - 1; i++)
			{
				pathLen += FindLineLength(points[i].X, points[i].Y,
					points[i + 1].X, points[i + 1].Y);
			}

			return pathLen;
		}

		private int Factorial(int n)
		{
			int result = 1;
			for (int i = 1; i <= n; i++)
				result *= i;
			return result;
		}

		private double BernsteinPolynomial(int i, int n, double t)
		{
			return ((double) Factorial(n) / (Factorial(i) * Factorial(n - i))) * Math.Pow(t, i) *
			       Math.Pow(1 - t, n - i);
		}

		public List<Rectangle> BezierCurve(List<Point> points)
		{
			double step = 1f / FindPathLength(points);
			List<Rectangle> result = new List<Rectangle>();

			for (double t = 0; t < 1; t += step)
			{
				double xTmp = 0, yTmp = 0;
				for (int i = 0; i < points.Count; i++)
				{
					double b = BernsteinPolynomial(i, points.Count - 1, t);
					xTmp += points[i].X * b;
					yTmp += points[i].Y * b;
				}

				result.Add(new Rectangle((int) xTmp, (int) yTmp, 1, 1));
			}

			return result;
		}


		public List<Rectangle> CyrusBeckClip(Segment subject, Segment[] edges)
		{
			var subjDir = subject.Direction;
			var tA = 0.0f;
			var tB = 1.0f;
			foreach (var edge in edges)
			{
				switch (Math.Sign(edge.Normal.Dot(subjDir)))
				{
					case -1:
					{
						var t = subject.IntersectionParameter(edge);
						if (t > tA)
						{
							tA = t;
						}

						break;
					}
					case +1:
					{
						var t = subject.IntersectionParameter(edge);
						if (t < tB)
						{
							tB = t;
						}

						break;
					}
					case 0:
					{
						if (!edge.OnLeft(subject.A))
						{
							return _empty;
						}

						break;
					}
				}
			}

			if (tA > tB)
			{
				return _empty;
			}

			subject = subject.Morph(tA, tB);
			return BresenhamLine((int) subject.A.X, (int) subject.A.Y, (int) subject.B.X, (int) subject.B.Y);
		}

		private static uint GetCode(PointCustom point, Rectangle edge)
		{
			uint code = 0;
			if (point.X < edge.Left)
				code += 1;
			if (point.Y < edge.Top)
				code += 8;
			if (point.X > edge.Right)
				code += 4;
			if (point.Y > edge.Bottom)
				code += 2;
			return code;
		}

		public List<Rectangle> CohenSutherlandClip(Segment seg, Rectangle rect)
		{
			while (GetCode(seg.A, rect) > 0 | GetCode(seg.B, rect) > 0)
			{
				if ((GetCode(seg.A, rect) & GetCode(seg.B, rect)) > 0)
					return _empty;
				if (GetCode(seg.A, rect) == 0)
					seg.Swap();
				if ((GetCode(seg.A, rect) & 1) > 0)
				{
					seg.A.Y += (seg.B.Y - seg.A.Y) * (rect.Left - seg.A.X) / (seg.B.X - seg.A.X);
					seg.A.X = rect.Left;
				}
				else if ((GetCode(seg.A, rect) & 8) > 0)
				{
					seg.A.X += (seg.B.X - seg.A.X) * (rect.Top - seg.A.Y) / (seg.B.Y - seg.A.Y);
					seg.A.Y = rect.Top;
				}
				else if ((GetCode(seg.A, rect) & 4) > 0)
				{
					seg.A.Y += (seg.B.Y - seg.A.Y) * (rect.Right - seg.A.X) / (seg.B.X - seg.A.X);
					seg.A.X = rect.Right;
				}
				else if ((GetCode(seg.A, rect) & 2) > 0)
				{
					seg.A.X += (seg.B.X - seg.A.X) * (rect.Bottom - seg.A.Y) / (seg.B.Y - seg.A.Y);
					seg.A.Y = rect.Bottom;
				}
			}

			return BresenhamLine((int) seg.A.X, (int) seg.A.Y, (int) seg.B.X, (int) seg.B.Y);
		}

		public List<Rectangle> MiddlePointClip(Segment seg, Rectangle rect)
		{
			if (FindLineLength(seg) <= 2)
				return _empty;
			if ((GetCode(seg.A, rect) & GetCode(seg.B, rect)) != 0)
				return _empty;
			if ((GetCode(seg.A, rect) == 0 & GetCode(seg.B, rect) == 0))
			{
				return BresenhamLine((int) seg.A.X, (int) seg.A.Y, (int) seg.B.X, (int) seg.B.Y);
			}

			List<Rectangle> temp = new List<Rectangle>();
			temp.AddRange(MiddlePointClip(new Segment(seg.A, ((seg.A + seg.B) / 2)), rect));
			temp.AddRange(MiddlePointClip(new Segment(((seg.A + seg.B) / 2), seg.B), rect));
			return DropDuplicates(temp);
		}
		

		private List<Rectangle> DropDuplicates(List<Rectangle> list)
		{
			return list.Distinct().ToList();
		}
	}
}