namespace TryCatchFail.LearnStructureMap.Lesson3.WebForms.Services
{
	public class RudeWelcomeMessageProvider : IWelcomeMessageProvider
	{
		public string GetWelcomeMessage()
		{
			return "Hey there, jerk.";
		}
	}
}