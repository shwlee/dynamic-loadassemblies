using Node.Defines.Defines;
using Node.Defines.Nodes;

namespace Samples.Receivers
{
	public class Tcp : BaseReceiver
	{
		[NodeMember]
		public string Host { get; set; }

		[NodeMember]
		public int Port { get; set; }
	}
}
