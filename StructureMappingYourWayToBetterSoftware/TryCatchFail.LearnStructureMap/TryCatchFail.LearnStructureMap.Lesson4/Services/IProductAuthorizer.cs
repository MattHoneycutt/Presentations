using TryCatchFail.LearnStructureMap.Lesson4.Domain;

namespace TryCatchFail.LearnStructureMap.Lesson4.Services
{
	public interface IProductAuthorizer
	{
		bool IsUserAuthorizedToAccessProduct(User user, int productID);
	}
}