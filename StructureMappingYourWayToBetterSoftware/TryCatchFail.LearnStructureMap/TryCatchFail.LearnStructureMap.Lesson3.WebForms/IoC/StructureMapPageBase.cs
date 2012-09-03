using System.Web.UI;
using StructureMap;

namespace TryCatchFail.LearnStructureMap.Lesson3.WebForms.IoC
{
	public abstract class StructureMapPageBase : Page
	{
		protected StructureMapPageBase()
		{
			ObjectFactory.BuildUp(this);
		}
	}
}