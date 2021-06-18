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
    ///     BatchReadResponse
    /// </summary>
    [DataContract]
    public sealed class BatchReadResponse : IEquatable<BatchReadResponse>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BatchReadResponse" /> class.
        /// </summary>
        /// <param name="responses">responses.</param>
        public BatchReadResponse(List<ReadResponse> responses = default)
        {
            Responses = responses;
        }

        /// <summary>
        ///     Gets or Sets Responses
        /// </summary>
        [DataMember(Name = "responses", EmitDefaultValue = false)]
        public List<ReadResponse> Responses { get; set; }

        /// <summary>
        ///     Returns true if BatchReadResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchReadResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchReadResponse input)
        {
            if (input == null)
                return false;

            return
                Responses == input.Responses ||
                Responses != null &&
                Responses.SequenceEqual(input.Responses);
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
            sb.Append("class BatchReadResponse {\n");
            sb.Append("  Responses: ").Append(Responses).Append("\n");
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
            return Equals(input as BatchReadResponse);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            var hashCode = 41;
            unchecked // Overflow is fine, just wrap
            {
                if (Responses != null)
                    hashCode = hashCode * 59 + Responses.GetHashCode();
                return hashCode;
            }
        }
    }
}