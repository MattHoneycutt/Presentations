using System;

namespace TryCatchFail.LearnStructureMap.Lesson3.WebForms.Services
{
	public class GuidWelcomeMessageProvider : IWelcomeMessageProvider
	{
		public Guid _guid = Guid.NewGuid();

		public string GetWelcomeMessage()
		{
			return "Hi there, " + _guid;
		}
	}
}