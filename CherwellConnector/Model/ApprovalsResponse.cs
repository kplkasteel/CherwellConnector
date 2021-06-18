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
    ///     ApprovalsResponse
    /// </summary>
    [DataContract]
    public sealed class ApprovalsResponse : IEquatable<ApprovalsResponse>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ApprovalsResponse" /> class.
        /// </summary>
        /// <param name="totalRecords">totalRecords.</param>
        /// <param name="approvals">approvals.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public ApprovalsResponse(int? totalRecords = default, List<ApprovalReadResponse> approvals = default,
            string errorCode = default, string errorMessage = default, bool? hasError = default,
            HttpStatusCodeEnum? httpStatusCode = default)
        {
            TotalRecords = totalRecords;
            Approvals = approvals;
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
        ///     Gets or Sets TotalRecords
        /// </summary>
        [DataMember(Name = "totalRecords", EmitDefaultValue = false)]
        public int? TotalRecords { get; set; }

        /// <summary>
        ///     Gets or Sets Approvals
        /// </summary>
        [DataMember(Name = "approvals", EmitDefaultValue = false)]
        public List<ApprovalReadResponse> Approvals { get; set; }

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
        ///     Returns true if ApprovalsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ApprovalsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApprovalsResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    TotalRecords == input.TotalRecords ||
                    TotalRecords != null &&
                    TotalRecords.Equals(input.TotalRecords)
                ) &&
                (
                    Approvals == input.Approvals ||
                    Approvals != null &&
                    Approvals.SequenceEqual(input.Approvals)
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
            sb.Append("class ApprovalsResponse {\n");
            sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
            sb.Append("  Approvals: ").Append(Approvals).Append("\n");
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
            return Equals(input as ApprovalsResponse);
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
                if (TotalRecords != null)
                    hashCode = hashCode * 59 + TotalRecords.GetHashCode();
                if (Approvals != null)
                    hashCode = hashCode * 59 + Approvals.GetHashCode();
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