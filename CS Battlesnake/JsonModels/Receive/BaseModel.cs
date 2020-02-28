namespace CS_Battlesnake.JsonModels.Receive
{
	/// <summary>
	/// Base model that is directly cast from JSON in the network controller.
	/// The name of the submodels directly maps to the immediate subsection of the JSON found at
	/// https://docs.battlesnake.com/snake-api
	/// </summary>
	public class BaseModel
	{
		public GameModel Game { get; set; }
		public int Turn { get; set; }
		public BoardModel Board { get; set; }
		public SnakeModel You { get; set; }
	}
}
