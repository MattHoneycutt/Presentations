namespace TryCatchFail.LearnStructureMap.Lesson3.Mvc.Services
{
	public class RudeWelcomeMessageProvider : IWelcomeMessageProvider
	{
		public string GetWelcomeMessage()
		{
			return "Hey there, jerk.";
		}
	}
}