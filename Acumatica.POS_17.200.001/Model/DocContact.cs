using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class DocContact : Entity
	{

		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue Attention { get; set; }

		[DataMember(Name="BusinessName", EmitDefaultValue=false)]
		public StringValue BusinessName { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue Email { get; set; }

		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue Phone1 { get; set; }

	}
}