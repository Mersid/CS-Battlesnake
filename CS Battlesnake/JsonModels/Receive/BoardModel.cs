using System.Collections.Generic;

namespace CS_Battlesnake.JsonModels.Receive
{
	/// <summary>
	/// Model for the board section of the JSON. See BaseModel.cs
	/// </summary>
	public class BoardModel
	{
		public int Height { get; set; }
		public int Width { get; set; }
		public List<PointModel> Food { get; set; }
		public List<SnakeModel> Snakes { get; set; }
	}
}
