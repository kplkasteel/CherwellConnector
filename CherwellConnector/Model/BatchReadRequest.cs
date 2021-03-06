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
    ///     BatchReadRequest
    /// </summary>
    [DataContract]
    public sealed class BatchReadRequest : IEquatable<BatchReadRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BatchReadRequest" /> class.
        /// </summary>
        /// <param name="readRequests">readRequests.</param>
        /// <param name="stopOnError">stopOnError.</param>
        public BatchReadRequest(List<ReadRequest> readRequests = default, bool? stopOnError = default)
        {
            ReadRequests = readRequests;
            StopOnError = stopOnError;
        }

        /// <summary>
        ///     Gets or Sets ReadRequests
        /// </summary>
        [DataMember(Name = "readRequests", EmitDefaultValue = false)]
        public List<ReadRequest> ReadRequests { get; set; }

        /// <summary>
        ///     Gets or Sets StopOnError
        /// </summary>
        [DataMember(Name = "stopOnError", EmitDefaultValue = false)]
        public bool? StopOnError { get; set; }

        /// <summary>
        ///     Returns true if BatchReadRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchReadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchReadRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    ReadRequests == input.ReadRequests ||
                    ReadRequests != null &&
                    ReadRequests.SequenceEqual(input.ReadRequests)
                ) &&
                (
                    StopOnError == input.StopOnError ||
                    StopOnError != null &&
                    StopOnError.Equals(input.StopOnError)
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
            sb.Append("class BatchReadRequest {\n");
            sb.Append("  ReadRequests: ").Append(ReadRequests).Append("\n");
            sb.Append("  StopOnError: ").Append(StopOnError).Append("\n");
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
            return Equals(input as BatchReadRequest);
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
                if (ReadRequests != null)
                    hashCode = hashCode * 59 + ReadRequests.GetHashCode();
                if (StopOnError != null)
                    hashCode = hashCode * 59 + StopOnError.GetHashCode();
                return hashCode;
            }
        }
    }
}