using System;

namespace GeometryTasks
{
	public class Segment
	{
		public Vector Begin;
		public Vector End;
	}
	public class Vector
	{
		public double X;
		public double Y;
	}
	public class Geometry
	{
		public static double GetLength(Vector first)
		{
			return Math.Sqrt(first.X * first.X + first.Y * first.Y);
		}
		public static double GetLength(Segment first)
		{
			return Math.Sqrt((first.Begin.X - first.End.X) * (first.Begin.X - first.End.X) +
			(first.Begin.Y - first.End.Y) * (first.Begin.Y - first.End.Y));
		}
		public static bool IsVectorInSegment(Vector first, Segment second)
		{
			if (second.Begin.X == second.End.X)
			{
				if (second.Begin.Y < second.End.Y)
				{
					if (first.X <= second.Begin.X) return true;
					else return false;
				}
				else {
					if (first.X >= second.Begin.X) return true;
					else return false;
				}
			}
			else if (second.Begin.Y == second.End.Y)
			{
				if (second.Begin.X < second.End.X)
				{
					if (first.Y >= second.Begin.Y) return true;
					else return false;
				}
				else
				{
					if (first.Y <= second.Begin.Y) return true;
					else return false;
				}
			}
			else if (second.Begin.X < second.End.X)
			{
				double k = (second.End.Y - second.Begin.Y) / ((double)second.End.X - second.Begin.X);
				double b1 = second.Begin.Y - k * second.Begin.X;
				if (k * first.X + b1 <= first.Y) return true;
				else return false;
			}
			else
			{
				double k = (second.End.Y - second.Begin.Y) / ((double)second.End.X - second.Begin.X);
				double b1 = second.Begin.Y - k * second.Begin.X;
				if (k * first.X + b1 >= first.Y) return true;
				else return false;
			}
		}
		public static Vector Add(Vector first, Vector second)
		{
			Vector result = new Vector();
			result.X = first.X + second.X;
			result.Y = first.Y + second.Y;
			return result;
		}
	}
}