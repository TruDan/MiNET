namespace MiNET.Blocks
{
	public class Log2 : Block
	{
		public Log2() : this(162) { }

		protected Log2(int id) : base(id)
		{
			BlastResistance = 10;
			Hardness        = 2;
			IsFlammable     = true;
		}
	}
}