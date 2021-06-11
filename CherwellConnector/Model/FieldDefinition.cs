
namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// FieldDefinition
    /// </summary>
    [DataContract]
    public sealed class FieldDefinition :  IEquatable<FieldDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldDefinition" /> class.
        /// </summary>
        /// <param name="autoFill">autoFill.</param>
        /// <param name="calculated">calculated.</param>
        /// <param name="category">category.</param>
        /// <param name="decimalDigits">decimalDigits.</param>
        /// <param name="description">description.</param>
        /// <param name="details">details.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="fieldId">fieldId.</param>
        /// <param name="hasDate">hasDate.</param>
        /// <param name="hasTime">hasTime.</param>
        /// <param name="isFullTextSearchable">isFullTextSearchable.</param>
        /// <param name="maximumSize">maximumSize.</param>
        /// <param name="name">name.</param>
        /// <param name="readOnly">readOnly.</param>
        /// <param name="required">required.</param>
        /// <param name="type">type.</param>
        /// <param name="typeLocalized">typeLocalized.</param>
        /// <param name="validated">validated.</param>
        /// <param name="wholeDigits">wholeDigits.</param>
        public FieldDefinition(bool? autoFill = default, bool? calculated = default, string category = default, int? decimalDigits = default, string description = default, string details = default, string displayName = default, bool? enabled = default, string fieldId = default, bool? hasDate = default, bool? hasTime = default, bool? isFullTextSearchable = default, string maximumSize = default, string name = default, bool? readOnly = default, bool? required = default, string type = default, string typeLocalized = default, bool? validated = default, int? wholeDigits = default)
        {
            AutoFill = autoFill;
            Calculated = calculated;
            Category = category;
            DecimalDigits = decimalDigits;
            Description = description;
            Details = details;
            DisplayName = displayName;
            Enabled = enabled;
            FieldId = fieldId;
            HasDate = hasDate;
            HasTime = hasTime;
            IsFullTextSearchable = isFullTextSearchable;
            MaximumSize = maximumSize;
            Name = name;
            ReadOnly = readOnly;
            Required = required;
            Type = type;
            TypeLocalized = typeLocalized;
            Validated = validated;
            WholeDigits = wholeDigits;
        }
        
        /// <summary>
        /// Gets or Sets AutoFill
        /// </summary>
        [DataMember(Name="autoFill", EmitDefaultValue=false)]
        public bool? AutoFill { get; set; }

        /// <summary>
        /// Gets or Sets Calculated
        /// </summary>
        [DataMember(Name="calculated", EmitDefaultValue=false)]
        public bool? Calculated { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets DecimalDigits
        /// </summary>
        [DataMember(Name="decimalDigits", EmitDefaultValue=false)]
        public int? DecimalDigits { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }

        /// <summary>
        /// Gets or Sets HasDate
        /// </summary>
        [DataMember(Name="hasDate", EmitDefaultValue=false)]
        public bool? HasDate { get; set; }

        /// <summary>
        /// Gets or Sets HasTime
        /// </summary>
        [DataMember(Name="hasTime", EmitDefaultValue=false)]
        public bool? HasTime { get; set; }

        /// <summary>
        /// Gets or Sets IsFullTextSearchable
        /// </summary>
        [DataMember(Name="isFullTextSearchable", EmitDefaultValue=false)]
        public bool? IsFullTextSearchable { get; set; }

        /// <summary>
        /// Gets or Sets MaximumSize
        /// </summary>
        [DataMember(Name="maximumSize", EmitDefaultValue=false)]
        public string MaximumSize { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ReadOnly
        /// </summary>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets TypeLocalized
        /// </summary>
        [DataMember(Name="typeLocalized", EmitDefaultValue=false)]
        public string TypeLocalized { get; set; }

        /// <summary>
        /// Gets or Sets Validated
        /// </summary>
        [DataMember(Name="validated", EmitDefaultValue=false)]
        public bool? Validated { get; set; }

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
            sb.Append("class FieldDefinition {\n");
            sb.Append("  AutoFill: ").Append(AutoFill).Append("\n");
            sb.Append("  Calculated: ").Append(Calculated).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  DecimalDigits: ").Append(DecimalDigits).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  HasDate: ").Append(HasDate).Append("\n");
            sb.Append("  HasTime: ").Append(HasTime).Append("\n");
            sb.Append("  IsFullTextSearchable: ").Append(IsFullTextSearchable).Append("\n");
            sb.Append("  MaximumSize: ").Append(MaximumSize).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TypeLocalized: ").Append(TypeLocalized).Append("\n");
            sb.Append("  Validated: ").Append(Validated).Append("\n");
            sb.Append("  WholeDigits: ").Append(WholeDigits).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return Equals(input as FieldDefinition);
        }

        /// <summary>
        /// Returns true if FieldDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    AutoFill == input.AutoFill ||
                    (AutoFill != null &&
                    AutoFill.Equals(input.AutoFill))
                ) && 
                (
                    Calculated == input.Calculated ||
                    (Calculated != null &&
                    Calculated.Equals(input.Calculated))
                ) && 
                (
                    Category == input.Category ||
                    (Category != null &&
                    Category.Equals(input.Category))
                ) && 
                (
                    DecimalDigits == input.DecimalDigits ||
                    (DecimalDigits != null &&
                    DecimalDigits.Equals(input.DecimalDigits))
                ) && 
                (
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) && 
                (
                    Details == input.Details ||
                    (Details != null &&
                    Details.Equals(input.Details))
                ) && 
                (
                    DisplayName == input.DisplayName ||
                    (DisplayName != null &&
                    DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    Enabled == input.Enabled ||
                    (Enabled != null &&
                    Enabled.Equals(input.Enabled))
                ) && 
                (
                    FieldId == input.FieldId ||
                    (FieldId != null &&
                    FieldId.Equals(input.FieldId))
                ) && 
                (
                    HasDate == input.HasDate ||
                    (HasDate != null &&
                    HasDate.Equals(input.HasDate))
                ) && 
                (
                    HasTime == input.HasTime ||
                    (HasTime != null &&
                    HasTime.Equals(input.HasTime))
                ) && 
                (
                    IsFullTextSearchable == input.IsFullTextSearchable ||
                    (IsFullTextSearchable != null &&
                    IsFullTextSearchable.Equals(input.IsFullTextSearchable))
                ) && 
                (
                    MaximumSize == input.MaximumSize ||
                    (MaximumSize != null &&
                    MaximumSize.Equals(input.MaximumSize))
                ) && 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    ReadOnly == input.ReadOnly ||
                    (ReadOnly != null &&
                    ReadOnly.Equals(input.ReadOnly))
                ) && 
                (
                    Required == input.Required ||
                    (Required != null &&
                    Required.Equals(input.Required))
                ) && 
                (
                    Type == input.Type ||
                    (Type != null &&
                    Type.Equals(input.Type))
                ) && 
                (
                    TypeLocalized == input.TypeLocalized ||
                    (TypeLocalized != null &&
                    TypeLocalized.Equals(input.TypeLocalized))
                ) && 
                (
                    Validated == input.Validated ||
                    (Validated != null &&
                    Validated.Equals(input.Validated))
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
                if (AutoFill != null)
                    hashCode = hashCode * 59 + AutoFill.GetHashCode();
                if (Calculated != null)
                    hashCode = hashCode * 59 + Calculated.GetHashCode();
                if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                if (DecimalDigits != null)
                    hashCode = hashCode * 59 + DecimalDigits.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (Details != null)
                    hashCode = hashCode * 59 + Details.GetHashCode();
                if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                if (Enabled != null)
                    hashCode = hashCode * 59 + Enabled.GetHashCode();
                if (FieldId != null)
                    hashCode = hashCode * 59 + FieldId.GetHashCode();
                if (HasDate != null)
                    hashCode = hashCode * 59 + HasDate.GetHashCode();
                if (HasTime != null)
                    hashCode = hashCode * 59 + HasTime.GetHashCode();
                if (IsFullTextSearchable != null)
                    hashCode = hashCode * 59 + IsFullTextSearchable.GetHashCode();
                if (MaximumSize != null)
                    hashCode = hashCode * 59 + MaximumSize.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (ReadOnly != null)
                    hashCode = hashCode * 59 + ReadOnly.GetHashCode();
                if (Required != null)
                    hashCode = hashCode * 59 + Required.GetHashCode();
                if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                if (TypeLocalized != null)
                    hashCode = hashCode * 59 + TypeLocalized.GetHashCode();
                if (Validated != null)
                    hashCode = hashCode * 59 + Validated.GetHashCode();
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
