
namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// FilterInfo
    /// </summary>
    [DataContract]
    public sealed class FilterInfo :  IEquatable<FilterInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterInfo" /> class.
        /// </summary>
        /// <param name="fieldId">fieldId.</param>
        /// <param name="_operator">_operator.</param>
        /// <param name="value">value.</param>
        public FilterInfo(string fieldId = default, string _operator = default, string value = default)
        {
            FieldId = fieldId;
            Operator = _operator;
            Value = value;
        }
        
        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }

        /// <summary>
        /// Gets or Sets Operator
        /// </summary>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public string Operator { get; set; }

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
            sb.Append("class FilterInfo {\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return Equals(input as FilterInfo);
        }

        /// <summary>
        /// Returns true if FilterInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of FilterInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    FieldId == input.FieldId ||
                    (FieldId != null &&
                    FieldId.Equals(input.FieldId))
                ) && 
                (
                    Operator == input.Operator ||
                    (Operator != null &&
                    Operator.Equals(input.Operator))
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
                if (FieldId != null)
                    hashCode = hashCode * 59 + FieldId.GetHashCode();
                if (Operator != null)
                    hashCode = hashCode * 59 + Operator.GetHashCode();
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
