using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_Battlesnake.JsonModels.Send
{
	/// <summary>
	/// The response to a call to the /start endpoint.
	/// </summary>
	public class StartModel
	{
		public string Color { get; set; }
		public string HeadType { get; set; }
		public string TailType { get; set; }
	}
}
