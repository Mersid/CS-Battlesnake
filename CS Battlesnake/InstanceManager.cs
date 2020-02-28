using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using CS_Battlesnake.JsonModels.Receive;

namespace CS_Battlesnake
{
	public class InstanceManager : IInstanceManager
	{

		public IList<IGameInstance> GameInstances { get; }
		

		public InstanceManager(IList<IGameInstance> gameInstances)
		{
			GameInstances = gameInstances;
		}

		public void StartInstance(BaseModel baseModel)
		{
			GameInstances.Add(Factory.CreateGameInstance(baseModel));
		}

		public void UpdateInstance(BaseModel baseModel)
		{
			// Sometimes, an instance may not be started before being updated, in which case, quickly add it.
			IGameInstance gameInstance = GetInstance(baseModel);
			if (gameInstance == null)
			{
				StartInstance(baseModel);
			}
			else
			{
				gameInstance.Update(baseModel);
			}
		}

		public Response GetResponse(BaseModel baseModel)
		{
			return GetInstance(baseModel).GetResponse();
		}

		public void EndInstance(BaseModel model)
		{
			GameInstances.Remove(GetInstance(model));
		}

		public IGameInstance GetInstance(BaseModel baseModel)
		{
			return GetInstance(baseModel.Game.Id, baseModel.You.Id);
		}

		private IGameInstance GetInstance(string gameId, string snakeId)
		{
			return GameInstances.ToImmutableList().FirstOrDefault(e => e.GameBoard.Id == gameId && e.GameBoard.Player.Id == snakeId);
		}
	}
}
