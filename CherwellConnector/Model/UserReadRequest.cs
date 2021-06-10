namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// UserReadRequest
    /// </summary>
    [DataContract]
    public sealed class UserReadRequest :  IEquatable<UserReadRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserReadRequest" /> class.
        /// </summary>
        /// <param name="loginId">loginId.</param>
        /// <param name="publicId">publicId.</param>
        public UserReadRequest(string loginId = default, string publicId = default)
        {
            LoginId = loginId;
            PublicId = publicId;
        }
        
        /// <summary>
        /// Gets or Sets LoginId
        /// </summary>
        [DataMember(Name="loginId", EmitDefaultValue=false)]
        public string LoginId { get; set; }

        /// <summary>
        /// Gets or Sets PublicId
        /// </summary>
        [DataMember(Name="publicId", EmitDefaultValue=false)]
        public string PublicId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserReadRequest {\n");
            sb.Append("  LoginId: ").Append(LoginId).Append("\n");
            sb.Append("  PublicId: ").Append(PublicId).Append("\n");
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
            return Equals(input as UserReadRequest);
        }

        /// <summary>
        /// Returns true if UserReadRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UserReadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserReadRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    LoginId == input.LoginId ||
                    (LoginId != null &&
                    LoginId.Equals(input.LoginId))
                ) && 
                (
                    PublicId == input.PublicId ||
                    (PublicId != null &&
                    PublicId.Equals(input.PublicId))
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
                if (LoginId != null)
                    hashCode = hashCode * 59 + LoginId.GetHashCode();
                if (PublicId != null)
                    hashCode = hashCode * 59 + PublicId.GetHashCode();
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
