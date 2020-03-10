using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class AssignCase : EntityAction<Case>
	{
		public AssignCase(Case entity) : base(entity)
		{ }
		public AssignCase() : base()
		{ }
	}
}
