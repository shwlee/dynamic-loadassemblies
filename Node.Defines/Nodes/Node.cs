using Node.Defines.Defines;
using System;
using System.Collections.Generic;

namespace Node.Defines.Nodes
{
	[Serializable]
	public abstract class Node : INode
	{
		public string Id { get; set; } = Guid.NewGuid().ToString();

		public string Name { get; set; }

		public string Type { get; set; }

		public List<string> Children { get; set; }

		public NodePosition Position { get; set; }
	}
}
