using System;

namespace TryCatchFail.LearnStructureMap.Lesson2.Infrastructure
{
	public class Logger : ILogger
	{
		public void WriteLine(string format, params object[] args)
		{
			Console.WriteLine(format, args);
		}
	}
}