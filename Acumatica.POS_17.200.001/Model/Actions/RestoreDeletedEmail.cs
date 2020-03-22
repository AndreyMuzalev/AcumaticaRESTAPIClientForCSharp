using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class RestoreDeletedEmail : EntityAction<Email>
	{
		public RestoreDeletedEmail(Email entity) : base(entity)
		{ }
		public RestoreDeletedEmail() : base()
		{ }
	}
}
