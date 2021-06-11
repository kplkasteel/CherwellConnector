
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
    public sealed class TrebuchetWebApiDataContractsSearchesField :  IEquatable<TrebuchetWebApiDataContractsSearchesField>, IValidatableObject
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
        public TrebuchetWebApiDataContractsSearchesField(string caption = default, string currencyCulture = default, string currencySymbol = default, int? decimalDigits = default, bool? defaultSortOrderAscending = default, string displayName = default, string fieldName = default, string fullFieldId = default, bool? hasDefaultSortField = default, string fieldId = default, bool? isBinary = default, bool? isCurrency = default, bool? isDateTime = default, bool? isFilterAllowed = default, bool? isLogical = default, bool? isNumber = default, bool? isShortDate = default, bool? isShortTime = default, bool? isVisible = default, bool? sortable = default, string sortOrder = default, string storageName = default, int? wholeDigits = default)
        {
            Caption = caption;
            CurrencyCulture = currencyCulture;
            CurrencySymbol = currencySymbol;
            DecimalDigits = decimalDigits;
            DefaultSortOrderAscending = defaultSortOrderAscending;
            DisplayName = displayName;
            FieldName = fieldName;
            FullFieldId = fullFieldId;
            HasDefaultSortField = hasDefaultSortField;
            FieldId = fieldId;
            IsBinary = isBinary;
            IsCurrency = isCurrency;
            IsDateTime = isDateTime;
            IsFilterAllowed = isFilterAllowed;
            IsLogical = isLogical;
            IsNumber = isNumber;
            IsShortDate = isShortDate;
            IsShortTime = isShortTime;
            IsVisible = isVisible;
            Sortable = sortable;
            SortOrder = sortOrder;
            StorageName = storageName;
            WholeDigits = wholeDigits;
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
            sb.Append("  Caption: ").Append(Caption).Append("\n");
            sb.Append("  CurrencyCulture: ").Append(CurrencyCulture).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  DecimalDigits: ").Append(DecimalDigits).Append("\n");
            sb.Append("  DefaultSortOrderAscending: ").Append(DefaultSortOrderAscending).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  FullFieldId: ").Append(FullFieldId).Append("\n");
            sb.Append("  HasDefaultSortField: ").Append(HasDefaultSortField).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  IsBinary: ").Append(IsBinary).Append("\n");
            sb.Append("  IsCurrency: ").Append(IsCurrency).Append("\n");
            sb.Append("  IsDateTime: ").Append(IsDateTime).Append("\n");
            sb.Append("  IsFilterAllowed: ").Append(IsFilterAllowed).Append("\n");
            sb.Append("  IsLogical: ").Append(IsLogical).Append("\n");
            sb.Append("  IsNumber: ").Append(IsNumber).Append("\n");
            sb.Append("  IsShortDate: ").Append(IsShortDate).Append("\n");
            sb.Append("  IsShortTime: ").Append(IsShortTime).Append("\n");
            sb.Append("  IsVisible: ").Append(IsVisible).Append("\n");
            sb.Append("  Sortable: ").Append(Sortable).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  StorageName: ").Append(StorageName).Append("\n");
            sb.Append("  WholeDigits: ").Append(WholeDigits).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  string ToJson()
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
            return Equals(input as TrebuchetWebApiDataContractsSearchesField);
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
                    Caption == input.Caption ||
                    (Caption != null &&
                    Caption.Equals(input.Caption))
                ) && 
                (
                    CurrencyCulture == input.CurrencyCulture ||
                    (CurrencyCulture != null &&
                    CurrencyCulture.Equals(input.CurrencyCulture))
                ) && 
                (
                    CurrencySymbol == input.CurrencySymbol ||
                    (CurrencySymbol != null &&
                    CurrencySymbol.Equals(input.CurrencySymbol))
                ) && 
                (
                    DecimalDigits == input.DecimalDigits ||
                    (DecimalDigits != null &&
                    DecimalDigits.Equals(input.DecimalDigits))
                ) && 
                (
                    DefaultSortOrderAscending == input.DefaultSortOrderAscending ||
                    (DefaultSortOrderAscending != null &&
                    DefaultSortOrderAscending.Equals(input.DefaultSortOrderAscending))
                ) && 
                (
                    DisplayName == input.DisplayName ||
                    (DisplayName != null &&
                    DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    FieldName == input.FieldName ||
                    (FieldName != null &&
                    FieldName.Equals(input.FieldName))
                ) && 
                (
                    FullFieldId == input.FullFieldId ||
                    (FullFieldId != null &&
                    FullFieldId.Equals(input.FullFieldId))
                ) && 
                (
                    HasDefaultSortField == input.HasDefaultSortField ||
                    (HasDefaultSortField != null &&
                    HasDefaultSortField.Equals(input.HasDefaultSortField))
                ) && 
                (
                    FieldId == input.FieldId ||
                    (FieldId != null &&
                    FieldId.Equals(input.FieldId))
                ) && 
                (
                    IsBinary == input.IsBinary ||
                    (IsBinary != null &&
                    IsBinary.Equals(input.IsBinary))
                ) && 
                (
                    IsCurrency == input.IsCurrency ||
                    (IsCurrency != null &&
                    IsCurrency.Equals(input.IsCurrency))
                ) && 
                (
                    IsDateTime == input.IsDateTime ||
                    (IsDateTime != null &&
                    IsDateTime.Equals(input.IsDateTime))
                ) && 
                (
                    IsFilterAllowed == input.IsFilterAllowed ||
                    (IsFilterAllowed != null &&
                    IsFilterAllowed.Equals(input.IsFilterAllowed))
                ) && 
                (
                    IsLogical == input.IsLogical ||
                    (IsLogical != null &&
                    IsLogical.Equals(input.IsLogical))
                ) && 
                (
                    IsNumber == input.IsNumber ||
                    (IsNumber != null &&
                    IsNumber.Equals(input.IsNumber))
                ) && 
                (
                    IsShortDate == input.IsShortDate ||
                    (IsShortDate != null &&
                    IsShortDate.Equals(input.IsShortDate))
                ) && 
                (
                    IsShortTime == input.IsShortTime ||
                    (IsShortTime != null &&
                    IsShortTime.Equals(input.IsShortTime))
                ) && 
                (
                    IsVisible == input.IsVisible ||
                    (IsVisible != null &&
                    IsVisible.Equals(input.IsVisible))
                ) && 
                (
                    Sortable == input.Sortable ||
                    (Sortable != null &&
                    Sortable.Equals(input.Sortable))
                ) && 
                (
                    SortOrder == input.SortOrder ||
                    (SortOrder != null &&
                    SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    StorageName == input.StorageName ||
                    (StorageName != null &&
                    StorageName.Equals(input.StorageName))
                ) && 
                (
                    WholeDigits == input.WholeDigits ||
                    (WholeDigits != null &&
                    WholeDigits.Equals(input.WholeDigits))
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
                var hashCode = 41;
                if (Caption != null)
                    hashCode = hashCode * 59 + Caption.GetHashCode();
                if (CurrencyCulture != null)
                    hashCode = hashCode * 59 + CurrencyCulture.GetHashCode();
                if (CurrencySymbol != null)
                    hashCode = hashCode * 59 + CurrencySymbol.GetHashCode();
                if (DecimalDigits != null)
                    hashCode = hashCode * 59 + DecimalDigits.GetHashCode();
                if (DefaultSortOrderAscending != null)
                    hashCode = hashCode * 59 + DefaultSortOrderAscending.GetHashCode();
                if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                if (FieldName != null)
                    hashCode = hashCode * 59 + FieldName.GetHashCode();
                if (FullFieldId != null)
                    hashCode = hashCode * 59 + FullFieldId.GetHashCode();
                if (HasDefaultSortField != null)
                    hashCode = hashCode * 59 + HasDefaultSortField.GetHashCode();
                if (FieldId != null)
                    hashCode = hashCode * 59 + FieldId.GetHashCode();
                if (IsBinary != null)
                    hashCode = hashCode * 59 + IsBinary.GetHashCode();
                if (IsCurrency != null)
                    hashCode = hashCode * 59 + IsCurrency.GetHashCode();
                if (IsDateTime != null)
                    hashCode = hashCode * 59 + IsDateTime.GetHashCode();
                if (IsFilterAllowed != null)
                    hashCode = hashCode * 59 + IsFilterAllowed.GetHashCode();
                if (IsLogical != null)
                    hashCode = hashCode * 59 + IsLogical.GetHashCode();
                if (IsNumber != null)
                    hashCode = hashCode * 59 + IsNumber.GetHashCode();
                if (IsShortDate != null)
                    hashCode = hashCode * 59 + IsShortDate.GetHashCode();
                if (IsShortTime != null)
                    hashCode = hashCode * 59 + IsShortTime.GetHashCode();
                if (IsVisible != null)
                    hashCode = hashCode * 59 + IsVisible.GetHashCode();
                if (Sortable != null)
                    hashCode = hashCode * 59 + Sortable.GetHashCode();
                if (SortOrder != null)
                    hashCode = hashCode * 59 + SortOrder.GetHashCode();
                if (StorageName != null)
                    hashCode = hashCode * 59 + StorageName.GetHashCode();
                if (WholeDigits != null)
                    hashCode = hashCode * 59 + WholeDigits.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
