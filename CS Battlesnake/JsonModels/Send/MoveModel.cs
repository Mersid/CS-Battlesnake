using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_Battlesnake.JsonModels.Send
{
	/// <summary>
	/// The marshaled data to send back as a response to a call from the /move endpoint.
	/// </summary>
	public class MoveModel
	{
		public string Move { get; set; }
		public string Shout { get; set; }
	}
}
