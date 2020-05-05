using Newtonsoft.Json;
using Samples.Receivers;
//using ServiceStack;
//using ServiceStack.Text;
using System;

namespace NodeJsonTest
{
	public class Program
	{
		static void Main(string[] args)
		{
			var tcp = new Tcp { Name = "tcp receiver", Port = 50934, Host = "localhost" };
			tcp.Children.Add(Guid.NewGuid().ToString());

			var json = tcp.GetJson();
			//var json = JsonConvert.SerializeObject(tcp, Formatting.Indented, new JsonSerializerSettings
			//{
			//	TypeNameHandling = TypeNameHandling.All
			//});

			//var groups = new NodeGroups();
			//groups.Receivers = new List<Node.Defines.Nodes.Node>();
			//groups.Receivers.Add(tcp);

			//var json = JsonConvert.SerializeObject(groups, Formatting.Indented, new JsonSerializerSettings
			//{
			//	TypeNameHandling = TypeNameHandling.All
			//});
			//var json = System.Text.Json.JsonSerializer.Serialize(tcp);


			//JsConfig.IncludeTypeInfo = true;
			//var json = JsonSerializer.SerializeToString(groups);
			//var json = tcp.ToJson();

			Console.WriteLine(json);
		}
	}
}
