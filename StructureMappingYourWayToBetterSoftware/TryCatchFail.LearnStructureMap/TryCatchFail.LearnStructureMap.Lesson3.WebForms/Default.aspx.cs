using System;
using System.Web.UI;
using StructureMap;
using TryCatchFail.LearnStructureMap.Lesson3.WebForms.IoC;
using TryCatchFail.LearnStructureMap.Lesson3.WebForms.Services;

namespace TryCatchFail.LearnStructureMap.Lesson3.WebForms
{
	public partial class _Default : StructureMapPageBase
	{
		public IWelcomeMessageProvider WelcomeMessageProvider { get; set; }

		protected void Page_Load(object sender, EventArgs e)
		{
			for (var i = 0; i < 10; i++)
			{
				lblWelcomeMessage.Text += ObjectFactory.GetInstance<IWelcomeMessageProvider>().GetWelcomeMessage() + "<br/>";
			}
		}
	}
}