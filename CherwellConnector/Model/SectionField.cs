using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     SectionField
    /// </summary>
    [DataContract]
    public sealed class SectionField : IEquatable<SectionField>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SectionField" /> class.
        /// </summary>
        /// <param name="attributes">attributes.</param>
        /// <param name="fieldId">fieldId.</param>
        /// <param name="fieldType">fieldType.</param>
        /// <param name="label">label.</param>
        /// <param name="multiline">multiline.</param>
        /// <param name="value">value.</param>
        public SectionField(List<Object> attributes = default, string fieldId = default, string fieldType = default,
            string label = default, bool? multiline = default, string value = default)
        {
            Attributes = attributes;
            FieldId = fieldId;
            FieldType = fieldType;
            Label = label;
            Multiline = multiline;
            Value = value;
        }

        /// <summary>
        ///     Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public List<Object> Attributes { get; set; }

        /// <summary>
        ///     Gets or Sets FieldId
        /// </summary>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }

        /// <summary>
        ///     Gets or Sets FieldType
        /// </summary>
        [DataMember(Name = "fieldType", EmitDefaultValue = false)]
        public string FieldType { get; set; }

        /// <summary>
        ///     Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        ///     Gets or Sets Multiline
        /// </summary>
        [DataMember(Name = "multiline", EmitDefaultValue = false)]
        public bool? Multiline { get; set; }

        /// <summary>
        ///     Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        ///     Returns true if SectionField instances are equal
        /// </summary>
        /// <param name="input">Instance of SectionField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SectionField input)
        {
            if (input == null)
                return false;

            return
                (
                    Attributes == input.Attributes ||
                    Attributes != null &&
                    Attributes.SequenceEqual(input.Attributes)
                ) &&
                (
                    FieldId == input.FieldId ||
                    FieldId != null &&
                    FieldId.Equals(input.FieldId)
                ) &&
                (
                    FieldType == input.FieldType ||
                    FieldType != null &&
                    FieldType.Equals(input.FieldType)
                ) &&
                (
                    Label == input.Label ||
                    Label != null &&
                    Label.Equals(input.Label)
                ) &&
                (
                    Multiline == input.Multiline ||
                    Multiline != null &&
                    Multiline.Equals(input.Multiline)
                ) &&
                (
                    Value == input.Value ||
                    Value != null &&
                    Value.Equals(input.Value)
                );
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SectionField {\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Multiline: ").Append(Multiline).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as SectionField);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Attributes != null)
                    hashCode = hashCode * 59 + Attributes.GetHashCode();
                if (FieldId != null)
                    hashCode = hashCode * 59 + FieldId.GetHashCode();
                if (FieldType != null)
                    hashCode = hashCode * 59 + FieldType.GetHashCode();
                if (Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();
                if (Multiline != null)
                    hashCode = hashCode * 59 + Multiline.GetHashCode();
                if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                return hashCode;
            }
        }
    }
}