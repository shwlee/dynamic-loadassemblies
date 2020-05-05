using Node.Defines.Defines;
using System;
using System.Collections.Generic;

namespace Node.Defines.Nodes
{
	public abstract class BaseNode : Node
	{
		protected BaseNode()
		{
			this.Children = new List<string>();
			this.Type = GetType().ToString();
		}

		protected void WriteLog(LogLevels level, string message, Exception exception = null)
		{

		}
	}
}
