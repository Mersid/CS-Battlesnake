using System.Collections.Generic;

namespace CS_Battlesnake.JsonModels.Receive
{
	/// <summary>
	/// Model for the snake and you section of the JSON. See BaseModel.cs
	/// </summary>
	public class SnakeModel
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public int Health { get; set; }
		public List<PointModel> Body { get; set; }
	}
}
