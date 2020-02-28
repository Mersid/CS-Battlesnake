using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CS_Battlesnake.JsonModels;
using CS_Battlesnake.JsonModels.Receive;
using CS_Battlesnake.JsonModels.Send;
using CS_Battlesnake.Structures;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CS_Battlesnake
{
	/// <summary>
	/// Defines the endpoints of the web server. Non-static instances will not be saved when the method exits.
	/// </summary>
	[Route("/")]
	public class NetworkController : Controller
	{
		private static IInstanceManager _instanceManager; // DI-injected item.

		public NetworkController(IInstanceManager instanceManager)
		{
			_instanceManager = instanceManager;
		}

		[HttpPost("start")]
		public StartModel Start([FromBody] BaseModel model)
		{
			_instanceManager.StartInstance(model);

			return null; // TODO: Implement.
		}

		[HttpPost("end")]
		public void End([FromBody] BaseModel model)
		{
		}

		[HttpPost("move")]
		public MoveModel Move([FromBody] BaseModel model)
		{
			_instanceManager.UpdateInstance(model);

			return new MoveModel()
			{
				Move = _instanceManager.GetResponse(model)
			};
		}

		[HttpPost("echo")]
		public BaseModel Echo([FromBody] BaseModel model)
		{
			return model;
		}

		[Route("teapot")]
		public string Teapot()
		{
			HttpContext.Response.StatusCode = 418;
			return "HTTP 418 I'm a teapot.";
		}

		[HttpPost("ping")]
		public void Ping()
		{
		}
	}
}
