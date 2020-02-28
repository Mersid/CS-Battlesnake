
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using CS_Battlesnake.JsonModels;
using CS_Battlesnake.JsonModels.Receive;
using CS_Battlesnake.Structures;

namespace CS_Battlesnake
{
	/// <summary>
	/// Represents an instance of the game.
	/// </summary>
	public class GameInstance : IGameInstance
	{
		public GameBoard GameBoard { get; }

		public GameInstance(BaseModel baseModel)
		{
			GameBoard = Factory.CreateGameBoard(baseModel);
		}

		public void Update(BaseModel baseModel)
		{
			GameBoard.Update(baseModel);
		}

		public Response GetResponse()
		{
			return (GameBoard.Turn % 4) switch
			{
				0 => Response.Up,
				1 => Response.Right,
				2 => Response.Down,
				3 => Response.Left,
				_ => Response.Down,
			};
		}
	}
}
