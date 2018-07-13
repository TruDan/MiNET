namespace MiNET.Blocks
{
	public class WoodenPressurePlate : Block
	{
		public WoodenPressurePlate() : this(72) { }
		
		protected WoodenPressurePlate(int id) : base(id)
		{
			IsTransparent = true;
			IsSolid = false;
			BlastResistance = 2.5f;
			Hardness = 0.5f;
		}
	}
}