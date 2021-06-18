using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using CherwellConnector.Enum;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     FieldValuesLookupResponse
    /// </summary>
    [DataContract]
    public sealed class FieldValuesLookupResponse : IEquatable<FieldValuesLookupResponse>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="FieldValuesLookupResponse" /> class.
        /// </summary>
        /// <param name="values">values.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public FieldValuesLookupResponse(List<string> values = default, string errorCode = default,
            string errorMessage = default, bool? hasError = default, HttpStatusCodeEnum? httpStatusCode = default)
        {
            Values = values;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            HasError = hasError;
            HttpStatusCode = httpStatusCode;
        }


        /// <summary>
        ///     Gets or Sets HttpStatusCode
        /// </summary>
        [DataMember(Name = "httpStatusCode", EmitDefaultValue = false)]
        public HttpStatusCodeEnum? HttpStatusCode { get; set; }

        /// <summary>
        ///     Gets or Sets Values
        /// </summary>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public List<string> Values { get; set; }

        /// <summary>
        ///     Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        ///     Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        ///     Gets or Sets HasError
        /// </summary>
        [DataMember(Name = "hasError", EmitDefaultValue = false)]
        public bool? HasError { get; set; }

        /// <summary>
        ///     Returns true if FieldValuesLookupResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldValuesLookupResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldValuesLookupResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    Values == input.Values ||
                    Values != null &&
                    Values.SequenceEqual(input.Values)
                ) &&
                (
                    ErrorCode == input.ErrorCode ||
                    ErrorCode != null &&
                    ErrorCode.Equals(input.ErrorCode)
                ) &&
                (
                    ErrorMessage == input.ErrorMessage ||
                    ErrorMessage != null &&
                    ErrorMessage.Equals(input.ErrorMessage)
                ) &&
                (
                    HasError == input.HasError ||
                    HasError != null &&
                    HasError.Equals(input.HasError)
                ) &&
                (
                    HttpStatusCode == input.HttpStatusCode ||
                    HttpStatusCode != null &&
                    HttpStatusCode.Equals(input.HttpStatusCode)
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
            sb.Append("class FieldValuesLookupResponse {\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  HasError: ").Append(HasError).Append("\n");
            sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append("\n");
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
            return Equals(input as FieldValuesLookupResponse);
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
                if (Values != null)
                    hashCode = hashCode * 59 + Values.GetHashCode();
                if (ErrorCode != null)
                    hashCode = hashCode * 59 + ErrorCode.GetHashCode();
                if (ErrorMessage != null)
                    hashCode = hashCode * 59 + ErrorMessage.GetHashCode();
                if (HasError != null)
                    hashCode = hashCode * 59 + HasError.GetHashCode();
                if (HttpStatusCode != null)
                    hashCode = hashCode * 59 + HttpStatusCode.GetHashCode();
                return hashCode;
            }
        }
    }
}