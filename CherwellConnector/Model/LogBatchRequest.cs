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
    ///     LogBatchRequest
    /// </summary>
    [DataContract]
    public sealed class LogBatchRequest : IEquatable<LogBatchRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="LogBatchRequest" /> class.
        /// </summary>
        /// <param name="logRequests">logRequests.</param>
        public LogBatchRequest(List<LogRequest> logRequests = default)
        {
            LogRequests = logRequests;
        }

        /// <summary>
        ///     Gets or Sets LogRequests
        /// </summary>
        [DataMember(Name = "logRequests", EmitDefaultValue = false)]
        public List<LogRequest> LogRequests { get; set; }

        /// <summary>
        ///     Returns true if LogBatchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LogBatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogBatchRequest input)
        {
            if (input == null)
                return false;

            return
                LogRequests == input.LogRequests ||
                LogRequests != null &&
                LogRequests.SequenceEqual(input.LogRequests);
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
            sb.Append("class LogBatchRequest {\n");
            sb.Append("  LogRequests: ").Append(LogRequests).Append("\n");
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
            return Equals(input as LogBatchRequest);
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
                if (LogRequests != null)
                    hashCode = hashCode * 59 + LogRequests.GetHashCode();
                return hashCode;
            }
        }
    }
}