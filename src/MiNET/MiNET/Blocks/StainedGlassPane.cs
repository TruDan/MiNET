using MiNET.Items;

namespace MiNET.Blocks
{
	public class StainedGlassPane : Block
	{
		public StainedGlassPane() : this(160) { }

		protected StainedGlassPane(int id) : base(id)
		{
			IsTransparent = true; // I should hope so at least
			BlastResistance = 1.5f;
		}

		public override Item[] GetDrops(Item tool)
		{
			return new Item[0]; // No drops
		}
	}
}