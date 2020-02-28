using System.Collections.Generic;
using System.Linq;
using CS_Battlesnake.Structures;

namespace CS_Battlesnake.JsonModels.Receive
{
	/// <summary>
	/// Extension methods for casting various models to their structure representation.
	/// </summary>
	public static class ModelExtensions
	{
		public static Snake ToSnake(this SnakeModel snakeModel)
		{
			return new Snake(snakeModel);
		}

		public static List<Point> AsPoints(this List<PointModel> pointModels)
		{
			return pointModels.Select(pointModel => (Point) pointModel).ToList();
		}

		public static List<Snake> AsSnakes(this List<SnakeModel> snakeModels)
		{
			return snakeModels.Select(ToSnake).ToList();
		}
	}
}
