using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.POS_17_200_001.Model;

namespace Acumatica.POS_17_200_001.Api
{
	public partial class KitAssemblyAllocationApi : EntityAPI<KitAssemblyAllocation>
	{
		public KitAssemblyAllocationApi(Configuration configuration) : base(configuration)
		{ }
	}
}