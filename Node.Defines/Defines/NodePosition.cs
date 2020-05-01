namespace Node.Defines.Defines
{
	public struct NodePosition
	{
		public double X;

		public double Y;

		public NodePosition(double x, double y)
		{
			X = x;
			Y = y;
		}

		public static NodePosition Create(double x, double y)
		{
			var position = new NodePosition(x, y);
			return position;
		}
	}
}
