namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// TrebuchetNameValuePair
    /// </summary>
    [DataContract]
    public sealed class NameValuePair :  IEquatable<NameValuePair>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameValuePair" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="valueObject">valueObject.</param>
        /// <param name="valueString">valueString.</param>
        /// <param name="category">category.</param>
        /// <param name="description">description.</param>
        /// <param name="displayShowsValue">displayShowsValue.</param>
        /// <param name="specialUseFlag">specialUseFlag.</param>
        /// <param name="displayString">displayString.</param>
        public NameValuePair(string name = default, Object valueObject = default, string valueString = default, string category = default, string description = default, bool? displayShowsValue = default, bool? specialUseFlag = default, string displayString = default)
        {
            Name = name;
            ValueObject = valueObject;
            ValueString = valueString;
            Category = category;
            Description = description;
            DisplayShowsValue = displayShowsValue;
            SpecialUseFlag = specialUseFlag;
            DisplayString = displayString;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ValueObject
        /// </summary>
        [DataMember(Name="valueObject", EmitDefaultValue=false)]
        public Object ValueObject { get; set; }

        /// <summary>
        /// Gets or Sets ValueString
        /// </summary>
        [DataMember(Name="valueString", EmitDefaultValue=false)]
        public string ValueString { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DisplayShowsValue
        /// </summary>
        [DataMember(Name="displayShowsValue", EmitDefaultValue=false)]
        public bool? DisplayShowsValue { get; set; }

        /// <summary>
        /// Gets or Sets SpecialUseFlag
        /// </summary>
        [DataMember(Name="specialUseFlag", EmitDefaultValue=false)]
        public bool? SpecialUseFlag { get; set; }

        /// <summary>
        /// Gets or Sets DisplayString
        /// </summary>
        [DataMember(Name="displayString", EmitDefaultValue=false)]
        public string DisplayString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetNameValuePair {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ValueObject: ").Append(ValueObject).Append("\n");
            sb.Append("  ValueString: ").Append(ValueString).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayShowsValue: ").Append(DisplayShowsValue).Append("\n");
            sb.Append("  SpecialUseFlag: ").Append(SpecialUseFlag).Append("\n");
            sb.Append("  DisplayString: ").Append(DisplayString).Append("\n");
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
            return Equals(input as NameValuePair);
        }

        /// <summary>
        /// Returns true if TrebuchetNameValuePair instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetNameValuePair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NameValuePair input)
        {
            if (input == null)
                return false;

            return 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    ValueObject.Equals(input.ValueObject) ||
                    (ValueObject != null &&
                    ValueObject.Equals(input.ValueObject))
                ) && 
                (
                    ValueString == input.ValueString ||
                    (ValueString != null &&
                    ValueString.Equals(input.ValueString))
                ) && 
                (
                    Category == input.Category ||
                    (Category != null &&
                    Category.Equals(input.Category))
                ) && 
                (
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) && 
                (
                    DisplayShowsValue == input.DisplayShowsValue ||
                    (DisplayShowsValue != null &&
                    DisplayShowsValue.Equals(input.DisplayShowsValue))
                ) && 
                (
                    SpecialUseFlag == input.SpecialUseFlag ||
                    (SpecialUseFlag != null &&
                    SpecialUseFlag.Equals(input.SpecialUseFlag))
                ) && 
                (
                    DisplayString == input.DisplayString ||
                    (DisplayString != null &&
                    DisplayString.Equals(input.DisplayString))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        
        public override int GetHashCode()
        {
            var hashCode = 41;
            unchecked // Overflow is fine, just wrap
            {
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (ValueObject != null)
                    hashCode = hashCode * 59 + ValueObject.GetHashCode();
                if (ValueString != null)
                    hashCode = hashCode * 59 + ValueString.GetHashCode();
                if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (DisplayShowsValue != null)
                    hashCode = hashCode * 59 + DisplayShowsValue.GetHashCode();
                if (SpecialUseFlag != null)
                    hashCode = hashCode * 59 + SpecialUseFlag.GetHashCode();
                if (DisplayString != null)
                    hashCode = hashCode * 59 + DisplayString.GetHashCode();
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
