
namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// UserSaveResponse
    /// </summary>
    [DataContract]
    public sealed class UserSaveResponse :  IEquatable<UserSaveResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSaveResponse" /> class.
        /// </summary>
        /// <param name="busObPublicId">busObPublicId.</param>
        /// <param name="busObRecId">busObRecId.</param>
        /// <param name="error">error.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="hasError">hasError.</param>
        public UserSaveResponse(string busObPublicId = default, string busObRecId = default, string error = default, string errorCode = default, bool? hasError = default)
        {
            BusObPublicId = busObPublicId;
            BusObRecId = busObRecId;
            Error = error;
            ErrorCode = errorCode;
            HasError = hasError;
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
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

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
            sb.Append("class UserSaveResponse {\n");
            sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  HasError: ").Append(HasError).Append("\n");
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
            return Equals(input as UserSaveResponse);
        }

        /// <summary>
        /// Returns true if UserSaveResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSaveResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSaveResponse input)
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
                    Error == input.Error ||
                    (Error != null &&
                    Error.Equals(input.Error))
                ) && 
                (
                    ErrorCode == input.ErrorCode ||
                    (ErrorCode != null &&
                    ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    HasError == input.HasError ||
                    (HasError != null &&
                    HasError.Equals(input.HasError))
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
                if (BusObPublicId != null)
                    hashCode = hashCode * 59 + BusObPublicId.GetHashCode();
                if (BusObRecId != null)
                    hashCode = hashCode * 59 + BusObRecId.GetHashCode();
                if (Error != null)
                    hashCode = hashCode * 59 + Error.GetHashCode();
                if (ErrorCode != null)
                    hashCode = hashCode * 59 + ErrorCode.GetHashCode();
                if (HasError != null)
                    hashCode = hashCode * 59 + HasError.GetHashCode();
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
