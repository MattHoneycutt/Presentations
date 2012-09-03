namespace TryCatchFail.LearnStructureMap.Lesson3.WebForms.Services
{
	public class PoliteWelcomeMessageProvider : IWelcomeMessageProvider
	{
		public string GetWelcomeMessage()
		{
			return "Hello there, good sir!";
		}
	}
}