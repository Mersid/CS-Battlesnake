using System.Collections.Generic;
using System.Linq;
using CS_Battlesnake.JsonModels;
using CS_Battlesnake.JsonModels.Receive;

namespace CS_Battlesnake.Structures
{
	public class Snake
	{
		public string Id { get; }
		public string Name { get; }
		public int Health { get; }
		public List<Point> Body { get; }
		public Point Head => Body.First();

		public Snake(SnakeModel snakeModel)
		{
			Id = snakeModel.Id;
			Name = snakeModel.Name;
			Health = snakeModel.Health;
			Body = snakeModel.Body.AsPoints();
		}


		public static bool operator ==(Snake left, Snake right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(Snake left, Snake right)
		{
			return !(left == right);
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Snake)) return false;
			Snake other = (Snake) obj;

			return
				Id == other.Id &&
				Name == other.Name &&
				Health == other.Health;
		}

		public override int GetHashCode()
		{
			return Id.GetHashCode();
		}
	}
}
