namespace TryCatchFail.LearnStructureMap.Lesson3.Mvc.Services
{
	public class PoliteWelcomeMessageProvider : IWelcomeMessageProvider
	{
		public string GetWelcomeMessage()
		{
			return "Hello there, good sir!";
		}
	}
}