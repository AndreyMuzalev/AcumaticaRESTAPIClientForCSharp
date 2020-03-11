using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class ValidateBusinessAccountAddresses : EntityAction<BusinessAccount>
	{
		public ValidateBusinessAccountAddresses(BusinessAccount entity) : base(entity)
		{ }
		public ValidateBusinessAccountAddresses() : base()
		{ }
	}
}