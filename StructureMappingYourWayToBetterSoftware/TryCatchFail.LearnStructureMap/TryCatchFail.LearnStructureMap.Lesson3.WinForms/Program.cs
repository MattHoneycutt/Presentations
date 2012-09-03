using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StructureMap;
using TryCatchFail.LearnStructureMap.Lesson3.WinForms.Services;

namespace TryCatchFail.LearnStructureMap.Lesson3.WinForms
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			ObjectFactory.Configure(cfg =>
			                        	{
			                        		cfg.For<IWelcomeMessageProvider>().Use<GuidWelcomeMessageProvider>();

											cfg.SetAllProperties(x => x.WithAnyTypeFromNamespaceContainingType<IWelcomeMessageProvider>());
			                        	});

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
