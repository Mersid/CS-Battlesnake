using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_Battlesnake
{
	public class Response
	{
		public string ResponseText { get; }

		private Response(string text)
		{
			ResponseText = text;
		}
		public static Response Up => new Response("up");
		public static Response Down => new Response("down");
		public static Response Left => new Response("left");
		public static Response Right => new Response("right");
		

		public static implicit operator string(Response response) => response.ResponseText;
	}
}
