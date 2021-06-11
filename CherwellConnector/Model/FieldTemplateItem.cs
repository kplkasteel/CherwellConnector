
namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// FieldTemplateItem
    /// </summary>
    [DataContract]
    public sealed class FieldTemplateItem :  IEquatable<FieldTemplateItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldTemplateItem" /> class.
        /// </summary>
        /// <param name="dirty">dirty.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="fieldId">fieldId.</param>
        /// <param name="fullFieldId">fullFieldId.</param>
        /// <param name="html">html.</param>
        /// <param name="name">name.</param>
        /// <param name="value">value.</param>
        public FieldTemplateItem(bool? dirty = default, string displayName = default, string fieldId = default, string fullFieldId = default, string html = default, string name = default, string value = default)
        {
            Dirty = dirty;
            DisplayName = displayName;
            FieldId = fieldId;
            FullFieldId = fullFieldId;
            Html = html;
            Name = name;
            Value = value;
        }
        
        /// <summary>
        /// Gets or Sets Dirty
        /// </summary>
        [DataMember(Name="dirty", EmitDefaultValue=false)]
        public bool? Dirty { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }

        /// <summary>
        /// Gets or Sets FullFieldId
        /// </summary>
        [DataMember(Name="fullFieldId", EmitDefaultValue=false)]
        public string FullFieldId { get; set; }

        /// <summary>
        /// Gets or Sets Html
        /// </summary>
        [DataMember(Name="html", EmitDefaultValue=false)]
        public string Html { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldTemplateItem {\n");
            sb.Append("  Dirty: ").Append(Dirty).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  FullFieldId: ").Append(FullFieldId).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return Equals(input as FieldTemplateItem);
        }

        /// <summary>
        /// Returns true if FieldTemplateItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldTemplateItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldTemplateItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    Dirty == input.Dirty ||
                    (Dirty != null &&
                    Dirty.Equals(input.Dirty))
                ) && 
                (
                    DisplayName == input.DisplayName ||
                    (DisplayName != null &&
                    DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    FieldId == input.FieldId ||
                    (FieldId != null &&
                    FieldId.Equals(input.FieldId))
                ) && 
                (
                    FullFieldId == input.FullFieldId ||
                    (FullFieldId != null &&
                    FullFieldId.Equals(input.FullFieldId))
                ) && 
                (
                    Html == input.Html ||
                    (Html != null &&
                    Html.Equals(input.Html))
                ) && 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    Value == input.Value ||
                    (Value != null &&
                    Value.Equals(input.Value))
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
                if (Dirty != null)
                    hashCode = hashCode * 59 + Dirty.GetHashCode();
                if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                if (FieldId != null)
                    hashCode = hashCode * 59 + FieldId.GetHashCode();
                if (FullFieldId != null)
                    hashCode = hashCode * 59 + FullFieldId.GetHashCode();
                if (Html != null)
                    hashCode = hashCode * 59 + Html.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
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
