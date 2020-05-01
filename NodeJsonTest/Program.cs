using Newtonsoft.Json;
using Node.Defines.Defines;
using Samples.Receivers;
//using ServiceStack;
//using ServiceStack.Text;
using System;
using System.Collections.Generic;
//using System.Text.Json;

namespace NodeJsonTest
{
	public class Program
	{
		static void Main(string[] args)
		{
			var tcp = new Tcp { Name = "tcp receiver", Port = 50934, Host = "localhost" };
			tcp.Children.Add(Guid.NewGuid().ToString());

			var groups = new NodeGroups();
			groups.Receivers = new List<Node.Defines.Nodes.Node>();
			groups.Receivers.Add(tcp);

			var json = JsonConvert.SerializeObject(groups, Formatting.Indented, new JsonSerializerSettings
			{
				TypeNameHandling = TypeNameHandling.All
			});
			//var json = System.Text.Json.JsonSerializer.Serialize(tcp);


			//JsConfig.IncludeTypeInfo = true;
			//var json = JsonSerializer.SerializeToString(groups);
			//var json = tcp.ToJson();

			Console.WriteLine(json);
		}
	}
}
