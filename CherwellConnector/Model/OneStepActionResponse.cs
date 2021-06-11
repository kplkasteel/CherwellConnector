
using CherwellConnector.Enum;

namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// OneStepActionResponse
    /// </summary>
    [DataContract]
    public sealed class OneStepActionResponse :  IEquatable<OneStepActionResponse>, IValidatableObject
    {
        

        /// <summary>
        /// Gets or Sets HttpStatusCode
        /// </summary>
        [DataMember(Name="httpStatusCode", EmitDefaultValue=false)]
        public HttpStatusCodeEnum? HttpStatusCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OneStepActionResponse" /> class.
        /// </summary>
        /// <param name="completed">completed.</param>
        /// <param name="currentPrimaryBusObId">currentPrimaryBusObId.</param>
        /// <param name="currentPrimaryBusObRecId">currentPrimaryBusObRecId.</param>
        /// <param name="hasNewAccessToken">hasNewAccessToken.</param>
        /// <param name="newAccessToken">newAccessToken.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public OneStepActionResponse(bool? completed = default, string currentPrimaryBusObId = default, string currentPrimaryBusObRecId = default, bool? hasNewAccessToken = default, string newAccessToken = default, string errorCode = default, string errorMessage = default, bool? hasError = default, HttpStatusCodeEnum? httpStatusCode = default)
        {
            Completed = completed;
            CurrentPrimaryBusObId = currentPrimaryBusObId;
            CurrentPrimaryBusObRecId = currentPrimaryBusObRecId;
            HasNewAccessToken = hasNewAccessToken;
            NewAccessToken = newAccessToken;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            HasError = hasError;
            HttpStatusCode = httpStatusCode;
        }
        
        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name="completed", EmitDefaultValue=false)]
        public bool? Completed { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPrimaryBusObId
        /// </summary>
        [DataMember(Name="currentPrimaryBusObId", EmitDefaultValue=false)]
        public string CurrentPrimaryBusObId { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPrimaryBusObRecId
        /// </summary>
        [DataMember(Name="currentPrimaryBusObRecId", EmitDefaultValue=false)]
        public string CurrentPrimaryBusObRecId { get; set; }

        /// <summary>
        /// Gets or Sets HasNewAccessToken
        /// </summary>
        [DataMember(Name="hasNewAccessToken", EmitDefaultValue=false)]
        public bool? HasNewAccessToken { get; set; }

        /// <summary>
        /// Gets or Sets NewAccessToken
        /// </summary>
        [DataMember(Name="newAccessToken", EmitDefaultValue=false)]
        public string NewAccessToken { get; set; }

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
            sb.Append("class OneStepActionResponse {\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  CurrentPrimaryBusObId: ").Append(CurrentPrimaryBusObId).Append("\n");
            sb.Append("  CurrentPrimaryBusObRecId: ").Append(CurrentPrimaryBusObRecId).Append("\n");
            sb.Append("  HasNewAccessToken: ").Append(HasNewAccessToken).Append("\n");
            sb.Append("  NewAccessToken: ").Append(NewAccessToken).Append("\n");
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
        public  string ToJson()
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
            return Equals(input as OneStepActionResponse);
        }

        /// <summary>
        /// Returns true if OneStepActionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OneStepActionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OneStepActionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    Completed == input.Completed ||
                    (Completed != null &&
                    Completed.Equals(input.Completed))
                ) && 
                (
                    CurrentPrimaryBusObId == input.CurrentPrimaryBusObId ||
                    (CurrentPrimaryBusObId != null &&
                    CurrentPrimaryBusObId.Equals(input.CurrentPrimaryBusObId))
                ) && 
                (
                    CurrentPrimaryBusObRecId == input.CurrentPrimaryBusObRecId ||
                    (CurrentPrimaryBusObRecId != null &&
                    CurrentPrimaryBusObRecId.Equals(input.CurrentPrimaryBusObRecId))
                ) && 
                (
                    HasNewAccessToken == input.HasNewAccessToken ||
                    (HasNewAccessToken != null &&
                    HasNewAccessToken.Equals(input.HasNewAccessToken))
                ) && 
                (
                    NewAccessToken == input.NewAccessToken ||
                    (NewAccessToken != null &&
                    NewAccessToken.Equals(input.NewAccessToken))
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
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Completed != null)
                    hashCode = hashCode * 59 + Completed.GetHashCode();
                if (CurrentPrimaryBusObId != null)
                    hashCode = hashCode * 59 + CurrentPrimaryBusObId.GetHashCode();
                if (CurrentPrimaryBusObRecId != null)
                    hashCode = hashCode * 59 + CurrentPrimaryBusObRecId.GetHashCode();
                if (HasNewAccessToken != null)
                    hashCode = hashCode * 59 + HasNewAccessToken.GetHashCode();
                if (NewAccessToken != null)
                    hashCode = hashCode * 59 + NewAccessToken.GetHashCode();
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
