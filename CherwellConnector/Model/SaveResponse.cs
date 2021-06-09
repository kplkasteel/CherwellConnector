using System.Diagnostics.CodeAnalysis;
using CherwellConnector.Enum;

namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// SaveResponse
    /// </summary>
    [DataContract]
    public sealed class SaveResponse :  IEquatable<SaveResponse>, IValidatableObject
    {
       

        /// <summary>
        /// Gets or Sets HttpStatusCode
        /// </summary>
        [DataMember(Name="httpStatusCode", EmitDefaultValue=false)]
        public HttpStatusCodeEnum? HttpStatusCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveResponse" /> class.
        /// </summary>
        /// <param name="busObPublicId">busObPublicId.</param>
        /// <param name="busObRecId">busObRecId.</param>
        /// <param name="cacheKey">cacheKey.</param>
        /// <param name="fieldValidationErrors">fieldValidationErrors.</param>
        /// <param name="notificationTriggers">notificationTriggers.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public SaveResponse(string busObPublicId = default, string busObRecId = default, string cacheKey = default, List<FieldValidationError> fieldValidationErrors = default, List<NotificationTrigger> notificationTriggers = default, string errorCode = default, string errorMessage = default, bool? hasError = default, HttpStatusCodeEnum? httpStatusCode = default)
        {
            BusObPublicId = busObPublicId;
            BusObRecId = busObRecId;
            CacheKey = cacheKey;
            FieldValidationErrors = fieldValidationErrors;
            NotificationTriggers = notificationTriggers;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            HasError = hasError;
            HttpStatusCode = httpStatusCode;
        }
        
        /// <summary>
        /// Gets or Sets BusObPublicId
        /// </summary>
        [DataMember(Name="busObPublicId", EmitDefaultValue=false)]
        public string BusObPublicId { get; set; }

        /// <summary>
        /// Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name="busObRecId", EmitDefaultValue=false)]
        public string BusObRecId { get; set; }

        /// <summary>
        /// Gets or Sets CacheKey
        /// </summary>
        [DataMember(Name="cacheKey", EmitDefaultValue=false)]
        public string CacheKey { get; set; }

        /// <summary>
        /// Gets or Sets FieldValidationErrors
        /// </summary>
        [DataMember(Name="fieldValidationErrors", EmitDefaultValue=false)]
        public List<FieldValidationError> FieldValidationErrors { get; set; }

        /// <summary>
        /// Gets or Sets NotificationTriggers
        /// </summary>
        [DataMember(Name="notificationTriggers", EmitDefaultValue=false)]
        public List<NotificationTrigger> NotificationTriggers { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets HasError
        /// </summary>
        [DataMember(Name="hasError", EmitDefaultValue=false)]
        public bool? HasError { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveResponse {\n");
            sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  CacheKey: ").Append(CacheKey).Append("\n");
            sb.Append("  FieldValidationErrors: ").Append(FieldValidationErrors).Append("\n");
            sb.Append("  NotificationTriggers: ").Append(NotificationTriggers).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  HasError: ").Append(HasError).Append("\n");
            sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append("\n");
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
            return Equals(input as SaveResponse);
        }

        /// <summary>
        /// Returns true if SaveResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    BusObPublicId == input.BusObPublicId ||
                    (BusObPublicId != null &&
                    BusObPublicId.Equals(input.BusObPublicId))
                ) && 
                (
                    BusObRecId == input.BusObRecId ||
                    (BusObRecId != null &&
                    BusObRecId.Equals(input.BusObRecId))
                ) && 
                (
                    CacheKey == input.CacheKey ||
                    (CacheKey != null &&
                    CacheKey.Equals(input.CacheKey))
                ) && 
                (
                    FieldValidationErrors == input.FieldValidationErrors ||
                    FieldValidationErrors != null &&
                    FieldValidationErrors.SequenceEqual(input.FieldValidationErrors)
                ) && 
                (
                    NotificationTriggers == input.NotificationTriggers ||
                    NotificationTriggers != null &&
                    NotificationTriggers.SequenceEqual(input.NotificationTriggers)
                ) && 
                (
                    ErrorCode == input.ErrorCode ||
                    (ErrorCode != null &&
                    ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    ErrorMessage == input.ErrorMessage ||
                    (ErrorMessage != null &&
                    ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    HasError == input.HasError ||
                    (HasError != null &&
                    HasError.Equals(input.HasError))
                ) && 
                (
                    HttpStatusCode == input.HttpStatusCode ||
                    (HttpStatusCode != null &&
                    HttpStatusCode.Equals(input.HttpStatusCode))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (BusObPublicId != null)
                    hashCode = hashCode * 59 + BusObPublicId.GetHashCode();
                if (BusObRecId != null)
                    hashCode = hashCode * 59 + BusObRecId.GetHashCode();
                if (CacheKey != null)
                    hashCode = hashCode * 59 + CacheKey.GetHashCode();
                if (FieldValidationErrors != null)
                    hashCode = hashCode * 59 + FieldValidationErrors.GetHashCode();
                if (NotificationTriggers != null)
                    hashCode = hashCode * 59 + NotificationTriggers.GetHashCode();
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
