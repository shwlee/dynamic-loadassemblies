using System.Collections.Generic;

namespace Node.Defines.Defines
{
	public interface INode
	{
		string Id { get; }

		string Name { get; set; }

		string Type { get; set; }

		List<string> Children { get; set; }

		NodePosition Position { get; set; }

		string GetJson();
	}
}
