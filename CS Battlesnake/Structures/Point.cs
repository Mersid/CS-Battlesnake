using CS_Battlesnake.JsonModels;
using CS_Battlesnake.JsonModels.Receive;

namespace CS_Battlesnake.Structures
{
	public struct Point
	{
		public int X, Y;
		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		public static implicit operator Point(PointModel pointModel) => new Point(pointModel.X, pointModel.Y);
	}
}
