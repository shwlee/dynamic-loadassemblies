using System;
using System.Collections.Generic;

namespace Node.Defines.Defines
{
	[Serializable]
	public class NodeGroups
	{
		public List<Nodes.Node> Receivers { get; set; }

		public List<Nodes.Node> Executors { get; set; }

		public List<Nodes.Node> Repeaters { get; set; }
	}
}
