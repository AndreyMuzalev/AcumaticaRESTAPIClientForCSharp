using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_18_200_001.Model;

namespace Acumatica.Default_18_200_001.Api
{
	public partial class InvoiceTaxDetailApi : EntityAPI<InvoiceTaxDetail>
	{
		public InvoiceTaxDetailApi(Configuration configuration) : base(configuration)
		{ }
	}
}