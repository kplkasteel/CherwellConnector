
namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// TransitionRecordRequest
    /// </summary>
    [DataContract]
    public sealed class TransitionRecordRequest :  IEquatable<TransitionRecordRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransitionRecordRequest" /> class.
        /// </summary>
        /// <param name="transitionOptionId">transitionOptionId.</param>
        public TransitionRecordRequest(string transitionOptionId = default)
        {
            TransitionOptionId = transitionOptionId;
        }
        
        /// <summary>
        /// Gets or Sets TransitionOptionId
        /// </summary>
        [DataMember(Name="transitionOptionId", EmitDefaultValue=false)]
        public string TransitionOptionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransitionRecordRequest {\n");
            sb.Append("  TransitionOptionId: ").Append(TransitionOptionId).Append("\n");
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
            return Equals(input as TransitionRecordRequest);
        }

        /// <summary>
        /// Returns true if TransitionRecordRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitionRecordRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitionRecordRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    TransitionOptionId == input.TransitionOptionId ||
                    (TransitionOptionId != null &&
                    TransitionOptionId.Equals(input.TransitionOptionId))
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
                if (TransitionOptionId != null)
                    hashCode = hashCode * 59 + TransitionOptionId.GetHashCode();
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
