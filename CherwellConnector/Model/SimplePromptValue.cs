namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// SimplePromptValue
    /// </summary>
    [DataContract]
    public sealed class SimplePromptValue :  IEquatable<SimplePromptValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimplePromptValue" /> class.
        /// </summary>
        /// <param name="promptDefId">promptDefId.</param>
        /// <param name="promptName">promptName.</param>
        /// <param name="value">value.</param>
        public SimplePromptValue(string promptDefId = default, string promptName = default, string value = default)
        {
            PromptDefId = promptDefId;
            PromptName = promptName;
            Value = value;
        }
        
        /// <summary>
        /// Gets or Sets PromptDefId
        /// </summary>
        [DataMember(Name="promptDefId", EmitDefaultValue=false)]
        public string PromptDefId { get; set; }

        /// <summary>
        /// Gets or Sets PromptName
        /// </summary>
        [DataMember(Name="promptName", EmitDefaultValue=false)]
        public string PromptName { get; set; }

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
            sb.Append("class SimplePromptValue {\n");
            sb.Append("  PromptDefId: ").Append(PromptDefId).Append("\n");
            sb.Append("  PromptName: ").Append(PromptName).Append("\n");
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
            return Equals(input as SimplePromptValue);
        }

        /// <summary>
        /// Returns true if SimplePromptValue instances are equal
        /// </summary>
        /// <param name="input">Instance of SimplePromptValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimplePromptValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    PromptDefId == input.PromptDefId ||
                    (PromptDefId != null &&
                    PromptDefId.Equals(input.PromptDefId))
                ) && 
                (
                    PromptName == input.PromptName ||
                    (PromptName != null &&
                    PromptName.Equals(input.PromptName))
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
                if (PromptDefId != null)
                    hashCode = hashCode * 59 + PromptDefId.GetHashCode();
                if (PromptName != null)
                    hashCode = hashCode * 59 + PromptName.GetHashCode();
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
