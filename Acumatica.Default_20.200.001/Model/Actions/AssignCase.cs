using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class AssignCase : EntityAction<Case>
	{
		public AssignCase(Case entity) : base(entity)
		{ }
		public AssignCase() : base()
		{ }
	}
}
