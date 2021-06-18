using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using CherwellConnector.Enum;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     RemoveCustomerFromWorkgroupResponse
    /// </summary>
    [DataContract]
    public sealed class RemoveCustomerFromWorkgroupResponse : IEquatable<RemoveCustomerFromWorkgroupResponse>,
        IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RemoveCustomerFromWorkgroupResponse" /> class.
        /// </summary>
        /// <param name="workgroupId">workgroupId.</param>
        /// <param name="customerRecordId">customerRecordId.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public RemoveCustomerFromWorkgroupResponse(string workgroupId = default, string customerRecordId = default,
            string errorCode = default, string errorMessage = default, bool? hasError = default,
            HttpStatusCodeEnum? httpStatusCode = default)
        {
            WorkgroupId = workgroupId;
            CustomerRecordId = customerRecordId;
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
        ///     Gets or Sets WorkgroupId
        /// </summary>
        [DataMember(Name = "workgroupId", EmitDefaultValue = false)]
        public string WorkgroupId { get; set; }

        /// <summary>
        ///     Gets or Sets CustomerRecordId
        /// </summary>
        [DataMember(Name = "customerRecordId", EmitDefaultValue = false)]
        public string CustomerRecordId { get; set; }

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
        ///     Returns true if RemoveCustomerFromWorkgroupResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoveCustomerFromWorkgroupResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoveCustomerFromWorkgroupResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    WorkgroupId == input.WorkgroupId ||
                    WorkgroupId != null &&
                    WorkgroupId.Equals(input.WorkgroupId)
                ) &&
                (
                    CustomerRecordId == input.CustomerRecordId ||
                    CustomerRecordId != null &&
                    CustomerRecordId.Equals(input.CustomerRecordId)
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
            sb.Append("class RemoveCustomerFromWorkgroupResponse {\n");
            sb.Append("  WorkgroupId: ").Append(WorkgroupId).Append("\n");
            sb.Append("  CustomerRecordId: ").Append(CustomerRecordId).Append("\n");
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
            return Equals(input as RemoveCustomerFromWorkgroupResponse);
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
                if (WorkgroupId != null)
                    hashCode = hashCode * 59 + WorkgroupId.GetHashCode();
                if (CustomerRecordId != null)
                    hashCode = hashCode * 59 + CustomerRecordId.GetHashCode();
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