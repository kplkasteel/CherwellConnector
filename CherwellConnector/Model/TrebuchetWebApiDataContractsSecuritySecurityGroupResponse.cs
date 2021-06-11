
namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// TrebuchetWebApiDataContractsSecuritySecurityGroupResponse
    /// </summary>
    [DataContract]
    public sealed class TrebuchetWebApiDataContractsSecuritySecurityGroupResponse :  IEquatable<TrebuchetWebApiDataContractsSecuritySecurityGroupResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsSecuritySecurityGroupResponse" /> class.
        /// </summary>
        /// <param name="securityGroups">securityGroups.</param>
        public TrebuchetWebApiDataContractsSecuritySecurityGroupResponse(List<TrebuchetWebApiDataContractsSecuritySecurityGroup> securityGroups = default)
        {
            SecurityGroups = securityGroups;
        }
        
        /// <summary>
        /// Gets or Sets SecurityGroups
        /// </summary>
        [DataMember(Name="securityGroups", EmitDefaultValue=false)]
        public List<TrebuchetWebApiDataContractsSecuritySecurityGroup> SecurityGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsSecuritySecurityGroupResponse {\n");
            sb.Append("  SecurityGroups: ").Append(SecurityGroups).Append("\n");
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
            return Equals(input as TrebuchetWebApiDataContractsSecuritySecurityGroupResponse);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsSecuritySecurityGroupResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsSecuritySecurityGroupResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsSecuritySecurityGroupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    SecurityGroups == input.SecurityGroups ||
                    SecurityGroups != null &&
                    SecurityGroups.SequenceEqual(input.SecurityGroups)
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
                if (SecurityGroups != null)
                    hashCode = hashCode * 59 + SecurityGroups.GetHashCode();
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
