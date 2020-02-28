using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS_Battlesnake.JsonModels.Receive;
using CS_Battlesnake.Structures;

namespace CS_Battlesnake
{
	public static class Factory
	{
		public static GameInstance CreateGameInstance(BaseModel baseModel)
		{
			return new GameInstance(baseModel);
		}

		public static GameBoard CreateGameBoard(BaseModel model)
		{
			return new GameBoard(model);
		}
	}
}
