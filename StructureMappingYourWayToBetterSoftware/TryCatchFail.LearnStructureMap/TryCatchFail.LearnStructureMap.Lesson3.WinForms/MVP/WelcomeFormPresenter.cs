using TryCatchFail.LearnStructureMap.Lesson3.WinForms.Services;

namespace TryCatchFail.LearnStructureMap.Lesson3.WinForms.MVP
{
	internal class WelcomeFormPresenter
	{
		private readonly IWelcomeForm _view;
		private readonly IWelcomeMessageProvider _welcomeMessageProvider;

		public WelcomeFormPresenter(IWelcomeForm view, IWelcomeMessageProvider welcomeMessageProvider)
		{
			_view = view;
			_welcomeMessageProvider = welcomeMessageProvider;
		}

		public void OnLoad()
		{
			_view.WelcomeMessage = _welcomeMessageProvider.GetWelcomeMessage();
		}
	}
}