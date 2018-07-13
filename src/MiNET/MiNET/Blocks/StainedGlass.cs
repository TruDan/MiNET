namespace MiNET.Blocks
{
	public class StainedGlass : Glass
	{
		public StainedGlass() : this(241) { }

		protected StainedGlass(int id) : base(id)
		{
			IsTransparent = true;
			BlastResistance = 1.5f;
			Hardness = 0.3f;
			IsBlockingSkylight = false;
		}
	}
}