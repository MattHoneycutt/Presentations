namespace TryCatchFail.LearnStructureMap.Lesson2.Infrastructure
{
	public interface ILogger
	{
		void WriteLine(string format, params object[] args);
	}
}