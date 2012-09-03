using System;
using System.Web;
using StructureMap;
using TryCatchFail.LearnStructureMap.Lesson3.WebForms.Services;

namespace TryCatchFail.LearnStructureMap.Lesson3.WebForms
{
	public class Global : HttpApplication
	{
		void Application_Start(object sender, EventArgs e)
		{
			ObjectFactory.Initialize(cfg =>
			                         	{
			                         		cfg.For<IWelcomeMessageProvider>().HttpContextScoped().Use<GuidWelcomeMessageProvider>();

											cfg.SetAllProperties(x => x.WithAnyTypeFromNamespaceContainingType<IWelcomeMessageProvider>());
			                         	});
		}

		void Application_End(object sender, EventArgs e)
		{
			//  Code that runs on application shutdown

		}

		void Application_Error(object sender, EventArgs e)
		{
			// Code that runs when an unhandled error occurs

		}

		void Session_Start(object sender, EventArgs e)
		{
			// Code that runs when a new session is started

		}

		void Session_End(object sender, EventArgs e)
		{
			// Code that runs when a session ends.
			// Note: The Session_End event is raised only when the sessionstate mode
			// is set to InProc in the Web.config file. If session mode is set to StateServer
			// or SQLServer, the event is not raised.

		}
	}
}
