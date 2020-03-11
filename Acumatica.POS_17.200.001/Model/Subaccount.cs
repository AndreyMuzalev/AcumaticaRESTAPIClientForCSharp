using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class Subaccount : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Secured", EmitDefaultValue=false)]
		public BooleanValue Secured { get; set; }

		[DataMember(Name="SubaccountCD", EmitDefaultValue=false)]
		public StringValue SubaccountCD { get; set; }

		[DataMember(Name="SubaccountID", EmitDefaultValue=false)]
		public IntValue SubaccountID { get; set; }

	}
}