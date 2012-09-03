namespace TryCatchFail.LearnStructureMap.Lesson3.WinForms.Services
{
	public class RudeWelcomeMessageProvider : IWelcomeMessageProvider
	{
		public string GetWelcomeMessage()
		{
			return "Hey there, jerk.";
		}
	}
}