using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public partial class ReleaseCashSale : EntityAction<CashSale>
	{
		public ReleaseCashSale(CashSale entity) : base(entity)
		{ }
		public ReleaseCashSale() : base()
		{ }
	}
}