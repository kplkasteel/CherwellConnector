using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     FieldValidationError
    /// </summary>
    [DataContract]
    public sealed class FieldValidationError : IEquatable<FieldValidationError>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="FieldValidationError" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="fieldId">fieldId.</param>
        public FieldValidationError(string error = default, string errorCode = default, string fieldId = default)
        {
            Error = error;
            ErrorCode = errorCode;
            FieldId = fieldId;
        }

        /// <summary>
        ///     Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        ///     Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        ///     Gets or Sets FieldId
        /// </summary>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }

        /// <summary>
        ///     Returns true if FieldValidationError instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldValidationError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldValidationError input)
        {
            if (input == null)
                return false;

            return
                (
                    Error == input.Error ||
                    Error != null &&
                    Error.Equals(input.Error)
                ) &&
                (
                    ErrorCode == input.ErrorCode ||
                    ErrorCode != null &&
                    ErrorCode.Equals(input.ErrorCode)
                ) &&
                (
                    FieldId == input.FieldId ||
                    FieldId != null &&
                    FieldId.Equals(input.FieldId)
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
            sb.Append("class FieldValidationError {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
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
            return Equals(input as FieldValidationError);
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
                if (Error != null)
                    hashCode = hashCode * 59 + Error.GetHashCode();
                if (ErrorCode != null)
                    hashCode = hashCode * 59 + ErrorCode.GetHashCode();
                if (FieldId != null)
                    hashCode = hashCode * 59 + FieldId.GetHashCode();
                return hashCode;
            }
        }
    }
}