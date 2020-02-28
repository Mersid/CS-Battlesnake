using CS_Battlesnake.JsonModels.Receive;
using CS_Battlesnake.Structures;

namespace CS_Battlesnake
{
	public interface IGameInstance
	{
		GameBoard GameBoard { get; }

		void Update(BaseModel baseModel);
		Response GetResponse();
	}
}