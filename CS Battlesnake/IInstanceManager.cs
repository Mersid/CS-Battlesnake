using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS_Battlesnake.JsonModels.Receive;

namespace CS_Battlesnake
{
	public interface IInstanceManager
	{
		IList<IGameInstance> GameInstances { get; }

		void StartInstance(BaseModel baseModel);

		/// <summary>
		/// Updates the appropriate game instance using information from BaseModel
		/// </summary>
		/// <param name="baseModel"></param>
		void UpdateInstance(BaseModel baseModel);

		/// <summary>
		/// Returns the move decided by the AI for the specified board, identified using the game and snake id.
		/// </summary>
		/// <returns></returns>
		Response GetResponse(BaseModel baseModel);

		void EndInstance(BaseModel model);
	}
}
