/* 
 * 
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse :  IEquatable<TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse" /> class.
        /// </summary>
        /// <param name="internalLoginAllowed">internalLoginAllowed.</param>
        /// <param name="ldapLoginAllowed">ldapLoginAllowed.</param>
        /// <param name="samlLoginAllowed">samlLoginAllowed.</param>
        /// <param name="windowsLoginAllowed">windowsLoginAllowed.</param>
        public TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse(bool? internalLoginAllowed = default(bool?), bool? ldapLoginAllowed = default(bool?), bool? samlLoginAllowed = default(bool?), bool? windowsLoginAllowed = default(bool?))
        {
            this.InternalLoginAllowed = internalLoginAllowed;
            this.LdapLoginAllowed = ldapLoginAllowed;
            this.SamlLoginAllowed = samlLoginAllowed;
            this.WindowsLoginAllowed = windowsLoginAllowed;
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
            sb.Append("class TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse {\n");
            sb.Append("  InternalLoginAllowed: ").Append(this.InternalLoginAllowed).Append("\n");
            sb.Append("  LdapLoginAllowed: ").Append(this.LdapLoginAllowed).Append("\n");
            sb.Append("  SamlLoginAllowed: ").Append(this.SamlLoginAllowed).Append("\n");
            sb.Append("  WindowsLoginAllowed: ").Append(this.WindowsLoginAllowed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InternalLoginAllowed == input.InternalLoginAllowed ||
                    (this.InternalLoginAllowed != null &&
                    this.InternalLoginAllowed.Equals(input.InternalLoginAllowed))
                ) && 
                (
                    this.LdapLoginAllowed == input.LdapLoginAllowed ||
                    (this.LdapLoginAllowed != null &&
                    this.LdapLoginAllowed.Equals(input.LdapLoginAllowed))
                ) && 
                (
                    this.SamlLoginAllowed == input.SamlLoginAllowed ||
                    (this.SamlLoginAllowed != null &&
                    this.SamlLoginAllowed.Equals(input.SamlLoginAllowed))
                ) && 
                (
                    this.WindowsLoginAllowed == input.WindowsLoginAllowed ||
                    (this.WindowsLoginAllowed != null &&
                    this.WindowsLoginAllowed.Equals(input.WindowsLoginAllowed))
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
                int hashCode = 41;
                if (this.InternalLoginAllowed != null)
                    hashCode = hashCode * 59 + this.InternalLoginAllowed.GetHashCode();
                if (this.LdapLoginAllowed != null)
                    hashCode = hashCode * 59 + this.LdapLoginAllowed.GetHashCode();
                if (this.SamlLoginAllowed != null)
                    hashCode = hashCode * 59 + this.SamlLoginAllowed.GetHashCode();
                if (this.WindowsLoginAllowed != null)
                    hashCode = hashCode * 59 + this.WindowsLoginAllowed.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
