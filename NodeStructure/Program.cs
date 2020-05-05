using Newtonsoft.Json;
using Node.Defines.Defines;
using ServiceStack.Text;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

namespace NodeStructure
{
	class Program
	{
		static void Main(string[] args)
		{
			//var json = JsonConvert.SerializeObject(tcp, Formatting.Indented, new JsonSerializerSettings
			//{
			//	TypeNameHandling = TypeNameHandling.Objects
			//});

			//Console.WriteLine(json);
			//var directory = "D:\\Samples\\netCoreTest\\NodeStructure\\bin\\Debug\\netcoreapp3.1\\NodeStructure.dll";
			//Assembly.GetEntryAssembly().Location
			var directory = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Samples");
			var files = Directory.GetFiles(directory, "*.dll", SearchOption.TopDirectoryOnly);
			var assemblies = files.Select(f =>
			{
				var loader = new NodeLoadContext(f);
				return loader.LoadFromAssemblyPath(f);
			}).ToArray();
			//var assemblies = files.Select(AssemblyLoadContext.Default.LoadFromAssemblyPath).ToArray();

			//var assemblies = files.Select(Assembly.LoadFile);

			Console.WriteLine("~~~");

			//var tcp = JsonConvert.DeserializeObject(Samples.TcpJson);			
			//var node = System.Text.Json.JsonSerializer.Deserialize<INode>(Samples.TcpJson);
			var node = JsonConvert.DeserializeObject<INode>(Samples.TcpJson, new JsonSerializerSettings
			{
				TypeNameHandling = TypeNameHandling.Objects,
				ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
			});
			//var tcp = JsonSerializer.DeserializeFromString<NodeGroups>(Samples.TcpJson);
			//var baseNode = JsonConvert.DeserializeObject<BaseNode>(Samples.TcpJson);
			//var receiver = JsonConvert.DeserializeObject<BaseReceiver>(Samples.TcpJson);

			Console.Read();
		}
	}
}
