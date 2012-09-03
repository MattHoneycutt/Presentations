using TryCatchFail.LearnStructureMap.Lesson4.Domain;

namespace TryCatchFail.LearnStructureMap.Lesson4.Services
{
	public class ProductAuthorizer : IProductAuthorizer
	{
		public bool IsUserAuthorizedToAccessProduct(User user, int productID)
		{
			if (user.UserName == "Admin")
			{
				return true;
			}
			else
			{
				return false;	
			}
		}
	}
}