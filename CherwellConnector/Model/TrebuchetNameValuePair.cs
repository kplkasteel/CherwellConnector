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
    /// TrebuchetNameValuePair
    /// </summary>
    [DataContract]
    public partial class TrebuchetNameValuePair :  IEquatable<TrebuchetNameValuePair>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetNameValuePair" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="valueObject">valueObject.</param>
        /// <param name="valueString">valueString.</param>
        /// <param name="category">category.</param>
        /// <param name="description">description.</param>
        /// <param name="displayShowsValue">displayShowsValue.</param>
        /// <param name="specialUseFlag">specialUseFlag.</param>
        /// <param name="displayString">displayString.</param>
        public TrebuchetNameValuePair(string name = default(string), Object valueObject = default(Object), string valueString = default(string), string category = default(string), string description = default(string), bool? displayShowsValue = default(bool?), bool? specialUseFlag = default(bool?), string displayString = default(string))
        {
            this.Name = name;
            this.ValueObject = valueObject;
            this.ValueString = valueString;
            this.Category = category;
            this.Description = description;
            this.DisplayShowsValue = displayShowsValue;
            this.SpecialUseFlag = specialUseFlag;
            this.DisplayString = displayString;
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
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  ValueObject: ").Append(this.ValueObject).Append("\n");
            sb.Append("  ValueString: ").Append(this.ValueString).Append("\n");
            sb.Append("  Category: ").Append(this.Category).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  DisplayShowsValue: ").Append(this.DisplayShowsValue).Append("\n");
            sb.Append("  SpecialUseFlag: ").Append(this.SpecialUseFlag).Append("\n");
            sb.Append("  DisplayString: ").Append(this.DisplayString).Append("\n");
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
            return this.Equals(input as TrebuchetNameValuePair);
        }

        /// <summary>
        /// Returns true if TrebuchetNameValuePair instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetNameValuePair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetNameValuePair input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ValueObject == input.ValueObject ||
                    (this.ValueObject != null &&
                    this.ValueObject.Equals(input.ValueObject))
                ) && 
                (
                    this.ValueString == input.ValueString ||
                    (this.ValueString != null &&
                    this.ValueString.Equals(input.ValueString))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayShowsValue == input.DisplayShowsValue ||
                    (this.DisplayShowsValue != null &&
                    this.DisplayShowsValue.Equals(input.DisplayShowsValue))
                ) && 
                (
                    this.SpecialUseFlag == input.SpecialUseFlag ||
                    (this.SpecialUseFlag != null &&
                    this.SpecialUseFlag.Equals(input.SpecialUseFlag))
                ) && 
                (
                    this.DisplayString == input.DisplayString ||
                    (this.DisplayString != null &&
                    this.DisplayString.Equals(input.DisplayString))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ValueObject != null)
                    hashCode = hashCode * 59 + this.ValueObject.GetHashCode();
                if (this.ValueString != null)
                    hashCode = hashCode * 59 + this.ValueString.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayShowsValue != null)
                    hashCode = hashCode * 59 + this.DisplayShowsValue.GetHashCode();
                if (this.SpecialUseFlag != null)
                    hashCode = hashCode * 59 + this.SpecialUseFlag.GetHashCode();
                if (this.DisplayString != null)
                    hashCode = hashCode * 59 + this.DisplayString.GetHashCode();
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