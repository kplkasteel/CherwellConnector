
namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// UserBatchSaveResponse
    /// </summary>
    [DataContract]
    public sealed class UserBatchSaveResponse :  IEquatable<UserBatchSaveResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserBatchSaveResponse" /> class.
        /// </summary>
        /// <param name="responses">responses.</param>
        public UserBatchSaveResponse(List<UserSaveResponse> responses = default)
        {
            Responses = responses;
        }
        
        /// <summary>
        /// Gets or Sets Responses
        /// </summary>
        [DataMember(Name="responses", EmitDefaultValue=false)]
        public List<UserSaveResponse> Responses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserBatchSaveResponse {\n");
            sb.Append("  Responses: ").Append(Responses).Append("\n");
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
            return Equals(input as UserBatchSaveResponse);
        }

        /// <summary>
        /// Returns true if UserBatchSaveResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UserBatchSaveResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserBatchSaveResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    Responses == input.Responses ||
                    Responses != null &&
                    Responses.SequenceEqual(input.Responses)
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
                if (Responses != null)
                    hashCode = hashCode * 59 + Responses.GetHashCode();
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
