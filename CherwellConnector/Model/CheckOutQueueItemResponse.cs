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
    ///     CheckOutQueueItemResponse
    /// </summary>
    [DataContract]
    public sealed class CheckOutQueueItemResponse : IEquatable<CheckOutQueueItemResponse>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CheckOutQueueItemResponse" /> class.
        /// </summary>
        /// <param name="historyRecId">historyRecId.</param>
        /// <param name="historyText">historyText.</param>
        /// <param name="historyTypeId">historyTypeId.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public CheckOutQueueItemResponse(string historyRecId = default, string historyText = default,
            string historyTypeId = default, string errorCode = default, string errorMessage = default,
            bool? hasError = default, HttpStatusCodeEnum? httpStatusCode = default)
        {
            HistoryRecId = historyRecId;
            HistoryText = historyText;
            HistoryTypeId = historyTypeId;
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
        ///     Gets or Sets HistoryRecId
        /// </summary>
        [DataMember(Name = "historyRecId", EmitDefaultValue = false)]
        public string HistoryRecId { get; set; }

        /// <summary>
        ///     Gets or Sets HistoryText
        /// </summary>
        [DataMember(Name = "historyText", EmitDefaultValue = false)]
        public string HistoryText { get; set; }

        /// <summary>
        ///     Gets or Sets HistoryTypeId
        /// </summary>
        [DataMember(Name = "historyTypeId", EmitDefaultValue = false)]
        public string HistoryTypeId { get; set; }

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
        ///     Returns true if CheckOutQueueItemResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckOutQueueItemResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckOutQueueItemResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    HistoryRecId == input.HistoryRecId ||
                    HistoryRecId != null &&
                    HistoryRecId.Equals(input.HistoryRecId)
                ) &&
                (
                    HistoryText == input.HistoryText ||
                    HistoryText != null &&
                    HistoryText.Equals(input.HistoryText)
                ) &&
                (
                    HistoryTypeId == input.HistoryTypeId ||
                    HistoryTypeId != null &&
                    HistoryTypeId.Equals(input.HistoryTypeId)
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
            sb.Append("class CheckOutQueueItemResponse {\n");
            sb.Append("  HistoryRecId: ").Append(HistoryRecId).Append("\n");
            sb.Append("  HistoryText: ").Append(HistoryText).Append("\n");
            sb.Append("  HistoryTypeId: ").Append(HistoryTypeId).Append("\n");
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
            return Equals(input as CheckOutQueueItemResponse);
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
                if (HistoryRecId != null)
                    hashCode = hashCode * 59 + HistoryRecId.GetHashCode();
                if (HistoryText != null)
                    hashCode = hashCode * 59 + HistoryText.GetHashCode();
                if (HistoryTypeId != null)
                    hashCode = hashCode * 59 + HistoryTypeId.GetHashCode();
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