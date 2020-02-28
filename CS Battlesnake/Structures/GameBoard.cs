using System;
using System.Collections.Generic;
using CS_Battlesnake.JsonModels;
using CS_Battlesnake.JsonModels.Receive;

namespace CS_Battlesnake.Structures
{
	/// <summary>
	/// Container for the data needed to represent the data sent over from Battlesnake. <br /> 
	/// Does not contain any response logic.
	/// </summary>
	public class GameBoard
	{
		public string Id { get; private set; }
		public int Turn { get; private set; }
		public int Width { get; private set; }
		public int Height { get; private set; }
		public List<Point> Food { get; private set; } = new List<Point>();
		public List<Snake> Snakes { get; private set; } = new List<Snake>();
		public Snake Player { get; private set; }

		public GameBoard(BaseModel model)
		{
			Update(model);
		}

		public void Update(BaseModel model)
		{
			Id = model.Game.Id;
			Turn = model.Turn;
			Width = model.Board.Width;
			Height = model.Board.Height;
			Food = model.Board.Food.AsPoints();
			Snakes = model.Board.Snakes.AsSnakes();
			Player = model.You.ToSnake();
		}

		
	}
}
