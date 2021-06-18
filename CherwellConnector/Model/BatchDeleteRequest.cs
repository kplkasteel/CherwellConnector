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
    ///     BatchDeleteRequest
    /// </summary>
    [DataContract]
    public sealed class BatchDeleteRequest : IEquatable<BatchDeleteRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BatchDeleteRequest" /> class.
        /// </summary>
        /// <param name="deleteRequests">deleteRequests.</param>
        /// <param name="stopOnError">stopOnError.</param>
        public BatchDeleteRequest(List<DeleteRequest> deleteRequests = default, bool? stopOnError = default)
        {
            DeleteRequests = deleteRequests;
            StopOnError = stopOnError;
        }

        /// <summary>
        ///     Gets or Sets DeleteRequests
        /// </summary>
        [DataMember(Name = "deleteRequests", EmitDefaultValue = false)]
        public List<DeleteRequest> DeleteRequests { get; set; }

        /// <summary>
        ///     Gets or Sets StopOnError
        /// </summary>
        [DataMember(Name = "stopOnError", EmitDefaultValue = false)]
        public bool? StopOnError { get; set; }

        /// <summary>
        ///     Returns true if BatchDeleteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchDeleteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchDeleteRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    DeleteRequests == input.DeleteRequests ||
                    DeleteRequests != null &&
                    DeleteRequests.SequenceEqual(input.DeleteRequests)
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
            sb.Append("class BatchDeleteRequest {\n");
            sb.Append("  DeleteRequests: ").Append(DeleteRequests).Append("\n");
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
            return Equals(input as BatchDeleteRequest);
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
                if (DeleteRequests != null)
                    hashCode = hashCode * 59 + DeleteRequests.GetHashCode();
                if (StopOnError != null)
                    hashCode = hashCode * 59 + StopOnError.GetHashCode();
                return hashCode;
            }
        }
    }
}