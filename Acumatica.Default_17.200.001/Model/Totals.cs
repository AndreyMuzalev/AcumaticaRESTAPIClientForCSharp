/* 
 * Default/17.200.001
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Acumatica.RESTClient.Model;
using System.ComponentModel.DataAnnotations;


namespace Acumatica.Default_17_200_001.Model
{
    /// <summary>
    /// Totals
    /// </summary>
    [DataContract]
    public partial class Totals : Entity,  IEquatable<Totals>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Totals" /> class.
        /// </summary>
        /// <param name="discountTotal">discountTotal.</param>
        /// <param name="freight">freight.</param>
        /// <param name="freightCost">freightCost.</param>
        /// <param name="freightCostIsuptodate">freightCostIsuptodate.</param>
        /// <param name="freightTaxCategory">freightTaxCategory.</param>
        /// <param name="lineTotalAmount">lineTotalAmount.</param>
        /// <param name="miscTotalAmount">miscTotalAmount.</param>
        /// <param name="orderVolume">orderVolume.</param>
        /// <param name="orderWeight">orderWeight.</param>
        /// <param name="packageWeight">packageWeight.</param>
        /// <param name="premiumFreight">premiumFreight.</param>
        /// <param name="taxTotal">taxTotal.</param>
        /// <param name="unbilledAmount">unbilledAmount.</param>
        /// <param name="unbilledQty">unbilledQty.</param>
        /// <param name="unpaidBalance">unpaidBalance.</param>
        public Totals(DecimalValue discountTotal = default(DecimalValue), DecimalValue freight = default(DecimalValue), DecimalValue freightCost = default(DecimalValue), BooleanValue freightCostIsuptodate = default(BooleanValue), StringValue freightTaxCategory = default(StringValue), DecimalValue lineTotalAmount = default(DecimalValue), DecimalValue miscTotalAmount = default(DecimalValue), DecimalValue orderVolume = default(DecimalValue), DecimalValue orderWeight = default(DecimalValue), DecimalValue packageWeight = default(DecimalValue), DecimalValue premiumFreight = default(DecimalValue), DecimalValue taxTotal = default(DecimalValue), DecimalValue unbilledAmount = default(DecimalValue), DecimalValue unbilledQty = default(DecimalValue), DecimalValue unpaidBalance = default(DecimalValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.DiscountTotal = discountTotal;
            this.Freight = freight;
            this.FreightCost = freightCost;
            this.FreightCostIsuptodate = freightCostIsuptodate;
            this.FreightTaxCategory = freightTaxCategory;
            this.LineTotalAmount = lineTotalAmount;
            this.MiscTotalAmount = miscTotalAmount;
            this.OrderVolume = orderVolume;
            this.OrderWeight = orderWeight;
            this.PackageWeight = packageWeight;
            this.PremiumFreight = premiumFreight;
            this.TaxTotal = taxTotal;
            this.UnbilledAmount = unbilledAmount;
            this.UnbilledQty = unbilledQty;
            this.UnpaidBalance = unpaidBalance;
        }
        
        /// <summary>
        /// Gets or Sets DiscountTotal
        /// </summary>
        [DataMember(Name="DiscountTotal", EmitDefaultValue=false)]
        public DecimalValue DiscountTotal { get; set; }

        /// <summary>
        /// Gets or Sets Freight
        /// </summary>
        [DataMember(Name="Freight", EmitDefaultValue=false)]
        public DecimalValue Freight { get; set; }

        /// <summary>
        /// Gets or Sets FreightCost
        /// </summary>
        [DataMember(Name="FreightCost", EmitDefaultValue=false)]
        public DecimalValue FreightCost { get; set; }

        /// <summary>
        /// Gets or Sets FreightCostIsuptodate
        /// </summary>
        [DataMember(Name="FreightCostIsuptodate", EmitDefaultValue=false)]
        public BooleanValue FreightCostIsuptodate { get; set; }

        /// <summary>
        /// Gets or Sets FreightTaxCategory
        /// </summary>
        [DataMember(Name="FreightTaxCategory", EmitDefaultValue=false)]
        public StringValue FreightTaxCategory { get; set; }

        /// <summary>
        /// Gets or Sets LineTotalAmount
        /// </summary>
        [DataMember(Name="LineTotalAmount", EmitDefaultValue=false)]
        public DecimalValue LineTotalAmount { get; set; }

        /// <summary>
        /// Gets or Sets MiscTotalAmount
        /// </summary>
        [DataMember(Name="MiscTotalAmount", EmitDefaultValue=false)]
        public DecimalValue MiscTotalAmount { get; set; }

        /// <summary>
        /// Gets or Sets OrderVolume
        /// </summary>
        [DataMember(Name="OrderVolume", EmitDefaultValue=false)]
        public DecimalValue OrderVolume { get; set; }

        /// <summary>
        /// Gets or Sets OrderWeight
        /// </summary>
        [DataMember(Name="OrderWeight", EmitDefaultValue=false)]
        public DecimalValue OrderWeight { get; set; }

        /// <summary>
        /// Gets or Sets PackageWeight
        /// </summary>
        [DataMember(Name="PackageWeight", EmitDefaultValue=false)]
        public DecimalValue PackageWeight { get; set; }

        /// <summary>
        /// Gets or Sets PremiumFreight
        /// </summary>
        [DataMember(Name="PremiumFreight", EmitDefaultValue=false)]
        public DecimalValue PremiumFreight { get; set; }

        /// <summary>
        /// Gets or Sets TaxTotal
        /// </summary>
        [DataMember(Name="TaxTotal", EmitDefaultValue=false)]
        public DecimalValue TaxTotal { get; set; }

        /// <summary>
        /// Gets or Sets UnbilledAmount
        /// </summary>
        [DataMember(Name="UnbilledAmount", EmitDefaultValue=false)]
        public DecimalValue UnbilledAmount { get; set; }

        /// <summary>
        /// Gets or Sets UnbilledQty
        /// </summary>
        [DataMember(Name="UnbilledQty", EmitDefaultValue=false)]
        public DecimalValue UnbilledQty { get; set; }

        /// <summary>
        /// Gets or Sets UnpaidBalance
        /// </summary>
        [DataMember(Name="UnpaidBalance", EmitDefaultValue=false)]
        public DecimalValue UnpaidBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Totals {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  DiscountTotal: ").Append(DiscountTotal).Append("\n");
            sb.Append("  Freight: ").Append(Freight).Append("\n");
            sb.Append("  FreightCost: ").Append(FreightCost).Append("\n");
            sb.Append("  FreightCostIsuptodate: ").Append(FreightCostIsuptodate).Append("\n");
            sb.Append("  FreightTaxCategory: ").Append(FreightTaxCategory).Append("\n");
            sb.Append("  LineTotalAmount: ").Append(LineTotalAmount).Append("\n");
            sb.Append("  MiscTotalAmount: ").Append(MiscTotalAmount).Append("\n");
            sb.Append("  OrderVolume: ").Append(OrderVolume).Append("\n");
            sb.Append("  OrderWeight: ").Append(OrderWeight).Append("\n");
            sb.Append("  PackageWeight: ").Append(PackageWeight).Append("\n");
            sb.Append("  PremiumFreight: ").Append(PremiumFreight).Append("\n");
            sb.Append("  TaxTotal: ").Append(TaxTotal).Append("\n");
            sb.Append("  UnbilledAmount: ").Append(UnbilledAmount).Append("\n");
            sb.Append("  UnbilledQty: ").Append(UnbilledQty).Append("\n");
            sb.Append("  UnpaidBalance: ").Append(UnpaidBalance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Totals);
        }

        /// <summary>
        /// Returns true if Totals instances are equal
        /// </summary>
        /// <param name="input">Instance of Totals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Totals input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.DiscountTotal == input.DiscountTotal ||
                    (this.DiscountTotal != null &&
                    this.DiscountTotal.Equals(input.DiscountTotal))
                ) && base.Equals(input) && 
                (
                    this.Freight == input.Freight ||
                    (this.Freight != null &&
                    this.Freight.Equals(input.Freight))
                ) && base.Equals(input) && 
                (
                    this.FreightCost == input.FreightCost ||
                    (this.FreightCost != null &&
                    this.FreightCost.Equals(input.FreightCost))
                ) && base.Equals(input) && 
                (
                    this.FreightCostIsuptodate == input.FreightCostIsuptodate ||
                    (this.FreightCostIsuptodate != null &&
                    this.FreightCostIsuptodate.Equals(input.FreightCostIsuptodate))
                ) && base.Equals(input) && 
                (
                    this.FreightTaxCategory == input.FreightTaxCategory ||
                    (this.FreightTaxCategory != null &&
                    this.FreightTaxCategory.Equals(input.FreightTaxCategory))
                ) && base.Equals(input) && 
                (
                    this.LineTotalAmount == input.LineTotalAmount ||
                    (this.LineTotalAmount != null &&
                    this.LineTotalAmount.Equals(input.LineTotalAmount))
                ) && base.Equals(input) && 
                (
                    this.MiscTotalAmount == input.MiscTotalAmount ||
                    (this.MiscTotalAmount != null &&
                    this.MiscTotalAmount.Equals(input.MiscTotalAmount))
                ) && base.Equals(input) && 
                (
                    this.OrderVolume == input.OrderVolume ||
                    (this.OrderVolume != null &&
                    this.OrderVolume.Equals(input.OrderVolume))
                ) && base.Equals(input) && 
                (
                    this.OrderWeight == input.OrderWeight ||
                    (this.OrderWeight != null &&
                    this.OrderWeight.Equals(input.OrderWeight))
                ) && base.Equals(input) && 
                (
                    this.PackageWeight == input.PackageWeight ||
                    (this.PackageWeight != null &&
                    this.PackageWeight.Equals(input.PackageWeight))
                ) && base.Equals(input) && 
                (
                    this.PremiumFreight == input.PremiumFreight ||
                    (this.PremiumFreight != null &&
                    this.PremiumFreight.Equals(input.PremiumFreight))
                ) && base.Equals(input) && 
                (
                    this.TaxTotal == input.TaxTotal ||
                    (this.TaxTotal != null &&
                    this.TaxTotal.Equals(input.TaxTotal))
                ) && base.Equals(input) && 
                (
                    this.UnbilledAmount == input.UnbilledAmount ||
                    (this.UnbilledAmount != null &&
                    this.UnbilledAmount.Equals(input.UnbilledAmount))
                ) && base.Equals(input) && 
                (
                    this.UnbilledQty == input.UnbilledQty ||
                    (this.UnbilledQty != null &&
                    this.UnbilledQty.Equals(input.UnbilledQty))
                ) && base.Equals(input) && 
                (
                    this.UnpaidBalance == input.UnpaidBalance ||
                    (this.UnpaidBalance != null &&
                    this.UnpaidBalance.Equals(input.UnpaidBalance))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.DiscountTotal != null)
                    hashCode = hashCode * 59 + this.DiscountTotal.GetHashCode();
                if (this.Freight != null)
                    hashCode = hashCode * 59 + this.Freight.GetHashCode();
                if (this.FreightCost != null)
                    hashCode = hashCode * 59 + this.FreightCost.GetHashCode();
                if (this.FreightCostIsuptodate != null)
                    hashCode = hashCode * 59 + this.FreightCostIsuptodate.GetHashCode();
                if (this.FreightTaxCategory != null)
                    hashCode = hashCode * 59 + this.FreightTaxCategory.GetHashCode();
                if (this.LineTotalAmount != null)
                    hashCode = hashCode * 59 + this.LineTotalAmount.GetHashCode();
                if (this.MiscTotalAmount != null)
                    hashCode = hashCode * 59 + this.MiscTotalAmount.GetHashCode();
                if (this.OrderVolume != null)
                    hashCode = hashCode * 59 + this.OrderVolume.GetHashCode();
                if (this.OrderWeight != null)
                    hashCode = hashCode * 59 + this.OrderWeight.GetHashCode();
                if (this.PackageWeight != null)
                    hashCode = hashCode * 59 + this.PackageWeight.GetHashCode();
                if (this.PremiumFreight != null)
                    hashCode = hashCode * 59 + this.PremiumFreight.GetHashCode();
                if (this.TaxTotal != null)
                    hashCode = hashCode * 59 + this.TaxTotal.GetHashCode();
                if (this.UnbilledAmount != null)
                    hashCode = hashCode * 59 + this.UnbilledAmount.GetHashCode();
                if (this.UnbilledQty != null)
                    hashCode = hashCode * 59 + this.UnbilledQty.GetHashCode();
                if (this.UnpaidBalance != null)
                    hashCode = hashCode * 59 + this.UnpaidBalance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}