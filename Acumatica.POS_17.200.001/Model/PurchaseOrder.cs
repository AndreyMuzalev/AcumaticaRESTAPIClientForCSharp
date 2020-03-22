using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class PurchaseOrder : Entity
	{

		[DataMember(Name="ControlTotal", EmitDefaultValue=false)]
		public DecimalValue ControlTotal { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue Date { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<PurchaseOrderDetail> Details { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="LineTotal", EmitDefaultValue=false)]
		public DecimalValue LineTotal { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue OrderNbr { get; set; }

		[DataMember(Name="OrderTotal", EmitDefaultValue=false)]
		public DecimalValue OrderTotal { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue Owner { get; set; }

		[DataMember(Name="PromisedOn", EmitDefaultValue=false)]
		public DateTimeValue PromisedOn { get; set; }

		[DataMember(Name="ShippingInstructions", EmitDefaultValue=false)]
		public ShippingInstructions ShippingInstructions { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue TaxTotal { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue VendorID { get; set; }

		[DataMember(Name="VendorRef", EmitDefaultValue=false)]
		public StringValue VendorRef { get; set; }

	}
}