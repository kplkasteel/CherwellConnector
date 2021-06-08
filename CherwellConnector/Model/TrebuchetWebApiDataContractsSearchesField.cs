/* 
 * 
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// TrebuchetWebApiDataContractsSearchesField
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsSearchesField :  IEquatable<TrebuchetWebApiDataContractsSearchesField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsSearchesField" /> class.
        /// </summary>
        /// <param name="caption">caption.</param>
        /// <param name="currencyCulture">currencyCulture.</param>
        /// <param name="currencySymbol">currencySymbol.</param>
        /// <param name="decimalDigits">decimalDigits.</param>
        /// <param name="defaultSortOrderAscending">defaultSortOrderAscending.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="fieldName">fieldName.</param>
        /// <param name="fullFieldId">fullFieldId.</param>
        /// <param name="hasDefaultSortField">hasDefaultSortField.</param>
        /// <param name="fieldId">fieldId.</param>
        /// <param name="isBinary">isBinary.</param>
        /// <param name="isCurrency">isCurrency.</param>
        /// <param name="isDateTime">isDateTime.</param>
        /// <param name="isFilterAllowed">isFilterAllowed.</param>
        /// <param name="isLogical">isLogical.</param>
        /// <param name="isNumber">isNumber.</param>
        /// <param name="isShortDate">isShortDate.</param>
        /// <param name="isShortTime">isShortTime.</param>
        /// <param name="isVisible">isVisible.</param>
        /// <param name="sortable">sortable.</param>
        /// <param name="sortOrder">sortOrder.</param>
        /// <param name="storageName">storageName.</param>
        /// <param name="wholeDigits">wholeDigits.</param>
        public TrebuchetWebApiDataContractsSearchesField(string caption = default(string), string currencyCulture = default(string), string currencySymbol = default(string), int? decimalDigits = default(int?), bool? defaultSortOrderAscending = default(bool?), string displayName = default(string), string fieldName = default(string), string fullFieldId = default(string), bool? hasDefaultSortField = default(bool?), string fieldId = default(string), bool? isBinary = default(bool?), bool? isCurrency = default(bool?), bool? isDateTime = default(bool?), bool? isFilterAllowed = default(bool?), bool? isLogical = default(bool?), bool? isNumber = default(bool?), bool? isShortDate = default(bool?), bool? isShortTime = default(bool?), bool? isVisible = default(bool?), bool? sortable = default(bool?), string sortOrder = default(string), string storageName = default(string), int? wholeDigits = default(int?))
        {
            this.Caption = caption;
            this.CurrencyCulture = currencyCulture;
            this.CurrencySymbol = currencySymbol;
            this.DecimalDigits = decimalDigits;
            this.DefaultSortOrderAscending = defaultSortOrderAscending;
            this.DisplayName = displayName;
            this.FieldName = fieldName;
            this.FullFieldId = fullFieldId;
            this.HasDefaultSortField = hasDefaultSortField;
            this.FieldId = fieldId;
            this.IsBinary = isBinary;
            this.IsCurrency = isCurrency;
            this.IsDateTime = isDateTime;
            this.IsFilterAllowed = isFilterAllowed;
            this.IsLogical = isLogical;
            this.IsNumber = isNumber;
            this.IsShortDate = isShortDate;
            this.IsShortTime = isShortTime;
            this.IsVisible = isVisible;
            this.Sortable = sortable;
            this.SortOrder = sortOrder;
            this.StorageName = storageName;
            this.WholeDigits = wholeDigits;
        }
        
        /// <summary>
        /// Gets or Sets Caption
        /// </summary>
        [DataMember(Name="caption", EmitDefaultValue=false)]
        public string Caption { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCulture
        /// </summary>
        [DataMember(Name="currencyCulture", EmitDefaultValue=false)]
        public string CurrencyCulture { get; set; }

        /// <summary>
        /// Gets or Sets CurrencySymbol
        /// </summary>
        [DataMember(Name="currencySymbol", EmitDefaultValue=false)]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Gets or Sets DecimalDigits
        /// </summary>
        [DataMember(Name="decimalDigits", EmitDefaultValue=false)]
        public int? DecimalDigits { get; set; }

        /// <summary>
        /// Gets or Sets DefaultSortOrderAscending
        /// </summary>
        [DataMember(Name="defaultSortOrderAscending", EmitDefaultValue=false)]
        public bool? DefaultSortOrderAscending { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets FieldName
        /// </summary>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// Gets or Sets FullFieldId
        /// </summary>
        [DataMember(Name="fullFieldId", EmitDefaultValue=false)]
        public string FullFieldId { get; set; }

        /// <summary>
        /// Gets or Sets HasDefaultSortField
        /// </summary>
        [DataMember(Name="hasDefaultSortField", EmitDefaultValue=false)]
        public bool? HasDefaultSortField { get; set; }

        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }

        /// <summary>
        /// Gets or Sets IsBinary
        /// </summary>
        [DataMember(Name="isBinary", EmitDefaultValue=false)]
        public bool? IsBinary { get; set; }

        /// <summary>
        /// Gets or Sets IsCurrency
        /// </summary>
        [DataMember(Name="isCurrency", EmitDefaultValue=false)]
        public bool? IsCurrency { get; set; }

        /// <summary>
        /// Gets or Sets IsDateTime
        /// </summary>
        [DataMember(Name="isDateTime", EmitDefaultValue=false)]
        public bool? IsDateTime { get; set; }

        /// <summary>
        /// Gets or Sets IsFilterAllowed
        /// </summary>
        [DataMember(Name="isFilterAllowed", EmitDefaultValue=false)]
        public bool? IsFilterAllowed { get; set; }

        /// <summary>
        /// Gets or Sets IsLogical
        /// </summary>
        [DataMember(Name="isLogical", EmitDefaultValue=false)]
        public bool? IsLogical { get; set; }

        /// <summary>
        /// Gets or Sets IsNumber
        /// </summary>
        [DataMember(Name="isNumber", EmitDefaultValue=false)]
        public bool? IsNumber { get; set; }

        /// <summary>
        /// Gets or Sets IsShortDate
        /// </summary>
        [DataMember(Name="isShortDate", EmitDefaultValue=false)]
        public bool? IsShortDate { get; set; }

        /// <summary>
        /// Gets or Sets IsShortTime
        /// </summary>
        [DataMember(Name="isShortTime", EmitDefaultValue=false)]
        public bool? IsShortTime { get; set; }

        /// <summary>
        /// Gets or Sets IsVisible
        /// </summary>
        [DataMember(Name="isVisible", EmitDefaultValue=false)]
        public bool? IsVisible { get; set; }

        /// <summary>
        /// Gets or Sets Sortable
        /// </summary>
        [DataMember(Name="sortable", EmitDefaultValue=false)]
        public bool? Sortable { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets StorageName
        /// </summary>
        [DataMember(Name="storageName", EmitDefaultValue=false)]
        public string StorageName { get; set; }

        /// <summary>
        /// Gets or Sets WholeDigits
        /// </summary>
        [DataMember(Name="wholeDigits", EmitDefaultValue=false)]
        public int? WholeDigits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsSearchesField {\n");
            sb.Append("  Caption: ").Append(this.Caption).Append("\n");
            sb.Append("  CurrencyCulture: ").Append(this.CurrencyCulture).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(this.CurrencySymbol).Append("\n");
            sb.Append("  DecimalDigits: ").Append(this.DecimalDigits).Append("\n");
            sb.Append("  DefaultSortOrderAscending: ").Append(this.DefaultSortOrderAscending).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  FieldName: ").Append(this.FieldName).Append("\n");
            sb.Append("  FullFieldId: ").Append(this.FullFieldId).Append("\n");
            sb.Append("  HasDefaultSortField: ").Append(this.HasDefaultSortField).Append("\n");
            sb.Append("  FieldId: ").Append(this.FieldId).Append("\n");
            sb.Append("  IsBinary: ").Append(this.IsBinary).Append("\n");
            sb.Append("  IsCurrency: ").Append(this.IsCurrency).Append("\n");
            sb.Append("  IsDateTime: ").Append(this.IsDateTime).Append("\n");
            sb.Append("  IsFilterAllowed: ").Append(this.IsFilterAllowed).Append("\n");
            sb.Append("  IsLogical: ").Append(this.IsLogical).Append("\n");
            sb.Append("  IsNumber: ").Append(this.IsNumber).Append("\n");
            sb.Append("  IsShortDate: ").Append(this.IsShortDate).Append("\n");
            sb.Append("  IsShortTime: ").Append(this.IsShortTime).Append("\n");
            sb.Append("  IsVisible: ").Append(this.IsVisible).Append("\n");
            sb.Append("  Sortable: ").Append(this.Sortable).Append("\n");
            sb.Append("  SortOrder: ").Append(this.SortOrder).Append("\n");
            sb.Append("  StorageName: ").Append(this.StorageName).Append("\n");
            sb.Append("  WholeDigits: ").Append(this.WholeDigits).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as TrebuchetWebApiDataContractsSearchesField);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsSearchesField instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsSearchesField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsSearchesField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Caption == input.Caption ||
                    (this.Caption != null &&
                    this.Caption.Equals(input.Caption))
                ) && 
                (
                    this.CurrencyCulture == input.CurrencyCulture ||
                    (this.CurrencyCulture != null &&
                    this.CurrencyCulture.Equals(input.CurrencyCulture))
                ) && 
                (
                    this.CurrencySymbol == input.CurrencySymbol ||
                    (this.CurrencySymbol != null &&
                    this.CurrencySymbol.Equals(input.CurrencySymbol))
                ) && 
                (
                    this.DecimalDigits == input.DecimalDigits ||
                    (this.DecimalDigits != null &&
                    this.DecimalDigits.Equals(input.DecimalDigits))
                ) && 
                (
                    this.DefaultSortOrderAscending == input.DefaultSortOrderAscending ||
                    (this.DefaultSortOrderAscending != null &&
                    this.DefaultSortOrderAscending.Equals(input.DefaultSortOrderAscending))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.FullFieldId == input.FullFieldId ||
                    (this.FullFieldId != null &&
                    this.FullFieldId.Equals(input.FullFieldId))
                ) && 
                (
                    this.HasDefaultSortField == input.HasDefaultSortField ||
                    (this.HasDefaultSortField != null &&
                    this.HasDefaultSortField.Equals(input.HasDefaultSortField))
                ) && 
                (
                    this.FieldId == input.FieldId ||
                    (this.FieldId != null &&
                    this.FieldId.Equals(input.FieldId))
                ) && 
                (
                    this.IsBinary == input.IsBinary ||
                    (this.IsBinary != null &&
                    this.IsBinary.Equals(input.IsBinary))
                ) && 
                (
                    this.IsCurrency == input.IsCurrency ||
                    (this.IsCurrency != null &&
                    this.IsCurrency.Equals(input.IsCurrency))
                ) && 
                (
                    this.IsDateTime == input.IsDateTime ||
                    (this.IsDateTime != null &&
                    this.IsDateTime.Equals(input.IsDateTime))
                ) && 
                (
                    this.IsFilterAllowed == input.IsFilterAllowed ||
                    (this.IsFilterAllowed != null &&
                    this.IsFilterAllowed.Equals(input.IsFilterAllowed))
                ) && 
                (
                    this.IsLogical == input.IsLogical ||
                    (this.IsLogical != null &&
                    this.IsLogical.Equals(input.IsLogical))
                ) && 
                (
                    this.IsNumber == input.IsNumber ||
                    (this.IsNumber != null &&
                    this.IsNumber.Equals(input.IsNumber))
                ) && 
                (
                    this.IsShortDate == input.IsShortDate ||
                    (this.IsShortDate != null &&
                    this.IsShortDate.Equals(input.IsShortDate))
                ) && 
                (
                    this.IsShortTime == input.IsShortTime ||
                    (this.IsShortTime != null &&
                    this.IsShortTime.Equals(input.IsShortTime))
                ) && 
                (
                    this.IsVisible == input.IsVisible ||
                    (this.IsVisible != null &&
                    this.IsVisible.Equals(input.IsVisible))
                ) && 
                (
                    this.Sortable == input.Sortable ||
                    (this.Sortable != null &&
                    this.Sortable.Equals(input.Sortable))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.StorageName == input.StorageName ||
                    (this.StorageName != null &&
                    this.StorageName.Equals(input.StorageName))
                ) && 
                (
                    this.WholeDigits == input.WholeDigits ||
                    (this.WholeDigits != null &&
                    this.WholeDigits.Equals(input.WholeDigits))
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
                int hashCode = 41;
                if (this.Caption != null)
                    hashCode = hashCode * 59 + this.Caption.GetHashCode();
                if (this.CurrencyCulture != null)
                    hashCode = hashCode * 59 + this.CurrencyCulture.GetHashCode();
                if (this.CurrencySymbol != null)
                    hashCode = hashCode * 59 + this.CurrencySymbol.GetHashCode();
                if (this.DecimalDigits != null)
                    hashCode = hashCode * 59 + this.DecimalDigits.GetHashCode();
                if (this.DefaultSortOrderAscending != null)
                    hashCode = hashCode * 59 + this.DefaultSortOrderAscending.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.FullFieldId != null)
                    hashCode = hashCode * 59 + this.FullFieldId.GetHashCode();
                if (this.HasDefaultSortField != null)
                    hashCode = hashCode * 59 + this.HasDefaultSortField.GetHashCode();
                if (this.FieldId != null)
                    hashCode = hashCode * 59 + this.FieldId.GetHashCode();
                if (this.IsBinary != null)
                    hashCode = hashCode * 59 + this.IsBinary.GetHashCode();
                if (this.IsCurrency != null)
                    hashCode = hashCode * 59 + this.IsCurrency.GetHashCode();
                if (this.IsDateTime != null)
                    hashCode = hashCode * 59 + this.IsDateTime.GetHashCode();
                if (this.IsFilterAllowed != null)
                    hashCode = hashCode * 59 + this.IsFilterAllowed.GetHashCode();
                if (this.IsLogical != null)
                    hashCode = hashCode * 59 + this.IsLogical.GetHashCode();
                if (this.IsNumber != null)
                    hashCode = hashCode * 59 + this.IsNumber.GetHashCode();
                if (this.IsShortDate != null)
                    hashCode = hashCode * 59 + this.IsShortDate.GetHashCode();
                if (this.IsShortTime != null)
                    hashCode = hashCode * 59 + this.IsShortTime.GetHashCode();
                if (this.IsVisible != null)
                    hashCode = hashCode * 59 + this.IsVisible.GetHashCode();
                if (this.Sortable != null)
                    hashCode = hashCode * 59 + this.Sortable.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.StorageName != null)
                    hashCode = hashCode * 59 + this.StorageName.GetHashCode();
                if (this.WholeDigits != null)
                    hashCode = hashCode * 59 + this.WholeDigits.GetHashCode();
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
            yield break;
        }
    }

}