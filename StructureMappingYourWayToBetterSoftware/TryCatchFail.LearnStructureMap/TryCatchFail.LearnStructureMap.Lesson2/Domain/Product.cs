namespace TryCatchFail.LearnStructureMap.Lesson2.Domain
{
	public class Product
	{
		public int ID { get; set; }

		public override string ToString()
		{
			return "Product " + ID;
		}
	}
}