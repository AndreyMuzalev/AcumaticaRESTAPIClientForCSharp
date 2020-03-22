using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.POS_17_200_001.Model;

namespace Acumatica.POS_17_200_001.Api
{
	public class ItemsDetailsApi : EntityAPI<ItemsDetails>
	{
		public ItemsDetailsApi(Configuration configuration) : base(configuration)
		{ }
	}
}