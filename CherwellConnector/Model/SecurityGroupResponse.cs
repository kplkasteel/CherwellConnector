using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     SecurityGroupResponse
    /// </summary>
    [DataContract]
    public sealed class SecurityGroupResponse : IEquatable<SecurityGroupResponse>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SecurityGroupResponse" /> class.
        /// </summary>
        /// <param name="securityGroups">securityGroups.</param>
        public SecurityGroupResponse(List<SecurityGroup> securityGroups = default)
        {
            SecurityGroups = securityGroups;
        }

        /// <summary>
        ///     Gets or Sets SecurityGroups
        /// </summary>
        [DataMember(Name = "securityGroups", EmitDefaultValue = false)]
        public List<SecurityGroup> SecurityGroups { get; set; }

        /// <summary>
        ///     Returns true if SecurityGroupResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityGroupResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityGroupResponse input)
        {
            if (input == null)
                return false;

            return
                SecurityGroups == input.SecurityGroups ||
                SecurityGroups != null &&
                SecurityGroups.SequenceEqual(input.SecurityGroups);
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
            sb.Append("class SecurityGroupResponse {\n");
            sb.Append("  SecurityGroups: ").Append(SecurityGroups).Append("\n");
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
            return Equals(input as SecurityGroupResponse);
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
                if (SecurityGroups != null)
                    hashCode = hashCode * 59 + SecurityGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}