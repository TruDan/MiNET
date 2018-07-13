namespace MiNET.Blocks
{
	public class GlassPane : Block
	{
		public GlassPane() : this(102) { }
		
		protected GlassPane(int id) : base(id)
		{
			IsTransparent = true;
			BlastResistance = 1.5f;
			Hardness = 0.3f;
		}
	}
}