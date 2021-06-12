
namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// ClientSecuritySettingsResponse
    /// </summary>
    [DataContract]
    public sealed class ClientSecuritySettingsResponse :  IEquatable<ClientSecuritySettingsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSecuritySettingsResponse" /> class.
        /// </summary>
        /// <param name="internalLoginAllowed">internalLoginAllowed.</param>
        /// <param name="ldapLoginAllowed">ldapLoginAllowed.</param>
        /// <param name="samlLoginAllowed">samlLoginAllowed.</param>
        /// <param name="windowsLoginAllowed">windowsLoginAllowed.</param>
        public ClientSecuritySettingsResponse(bool? internalLoginAllowed = default, bool? ldapLoginAllowed = default, bool? samlLoginAllowed = default, bool? windowsLoginAllowed = default)
        {
            InternalLoginAllowed = internalLoginAllowed;
            LdapLoginAllowed = ldapLoginAllowed;
            SamlLoginAllowed = samlLoginAllowed;
            WindowsLoginAllowed = windowsLoginAllowed;
        }
        
        /// <summary>
        /// Gets or Sets InternalLoginAllowed
        /// </summary>
        [DataMember(Name="internalLoginAllowed", EmitDefaultValue=false)]
        public bool? InternalLoginAllowed { get; set; }

        /// <summary>
        /// Gets or Sets LdapLoginAllowed
        /// </summary>
        [DataMember(Name="ldapLoginAllowed", EmitDefaultValue=false)]
        public bool? LdapLoginAllowed { get; set; }

        /// <summary>
        /// Gets or Sets SamlLoginAllowed
        /// </summary>
        [DataMember(Name="samlLoginAllowed", EmitDefaultValue=false)]
        public bool? SamlLoginAllowed { get; set; }

        /// <summary>
        /// Gets or Sets WindowsLoginAllowed
        /// </summary>
        [DataMember(Name="windowsLoginAllowed", EmitDefaultValue=false)]
        public bool? WindowsLoginAllowed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientSecuritySettingsResponse {\n");
            sb.Append("  InternalLoginAllowed: ").Append(InternalLoginAllowed).Append("\n");
            sb.Append("  LdapLoginAllowed: ").Append(LdapLoginAllowed).Append("\n");
            sb.Append("  SamlLoginAllowed: ").Append(SamlLoginAllowed).Append("\n");
            sb.Append("  WindowsLoginAllowed: ").Append(WindowsLoginAllowed).Append("\n");
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
            return Equals(input as ClientSecuritySettingsResponse);
        }

        /// <summary>
        /// Returns true if ClientSecuritySettingsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientSecuritySettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientSecuritySettingsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    InternalLoginAllowed == input.InternalLoginAllowed ||
                    (InternalLoginAllowed != null &&
                    InternalLoginAllowed.Equals(input.InternalLoginAllowed))
                ) && 
                (
                    LdapLoginAllowed == input.LdapLoginAllowed ||
                    (LdapLoginAllowed != null &&
                    LdapLoginAllowed.Equals(input.LdapLoginAllowed))
                ) && 
                (
                    SamlLoginAllowed == input.SamlLoginAllowed ||
                    (SamlLoginAllowed != null &&
                    SamlLoginAllowed.Equals(input.SamlLoginAllowed))
                ) && 
                (
                    WindowsLoginAllowed == input.WindowsLoginAllowed ||
                    (WindowsLoginAllowed != null &&
                    WindowsLoginAllowed.Equals(input.WindowsLoginAllowed))
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
                if (InternalLoginAllowed != null)
                    hashCode = hashCode * 59 + InternalLoginAllowed.GetHashCode();
                if (LdapLoginAllowed != null)
                    hashCode = hashCode * 59 + LdapLoginAllowed.GetHashCode();
                if (SamlLoginAllowed != null)
                    hashCode = hashCode * 59 + SamlLoginAllowed.GetHashCode();
                if (WindowsLoginAllowed != null)
                    hashCode = hashCode * 59 + WindowsLoginAllowed.GetHashCode();
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
