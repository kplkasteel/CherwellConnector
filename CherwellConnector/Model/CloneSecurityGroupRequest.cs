using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     CloneSecurityGroupRequest
    /// </summary>
    [DataContract]
    public sealed class CloneSecurityGroupRequest : IEquatable<CloneSecurityGroupRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CloneSecurityGroupRequest" /> class.
        /// </summary>
        /// <param name="securityGroupName">securityGroupName.</param>
        /// <param name="sourceSecurityGroupNameOrId">sourceSecurityGroupNameOrId.</param>
        public CloneSecurityGroupRequest(string securityGroupName = default,
            string sourceSecurityGroupNameOrId = default)
        {
            SecurityGroupName = securityGroupName;
            SourceSecurityGroupNameOrId = sourceSecurityGroupNameOrId;
        }

        /// <summary>
        ///     Gets or Sets SecurityGroupName
        /// </summary>
        [DataMember(Name = "securityGroupName", EmitDefaultValue = false)]
        public string SecurityGroupName { get; set; }

        /// <summary>
        ///     Gets or Sets SourceSecurityGroupNameOrId
        /// </summary>
        [DataMember(Name = "sourceSecurityGroupNameOrId", EmitDefaultValue = false)]
        public string SourceSecurityGroupNameOrId { get; set; }

        /// <summary>
        ///     Returns true if CloneSecurityGroupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CloneSecurityGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloneSecurityGroupRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    SecurityGroupName == input.SecurityGroupName ||
                    SecurityGroupName != null &&
                    SecurityGroupName.Equals(input.SecurityGroupName)
                ) &&
                (
                    SourceSecurityGroupNameOrId == input.SourceSecurityGroupNameOrId ||
                    SourceSecurityGroupNameOrId != null &&
                    SourceSecurityGroupNameOrId.Equals(input.SourceSecurityGroupNameOrId)
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
            sb.Append("class CloneSecurityGroupRequest {\n");
            sb.Append("  SecurityGroupName: ").Append(SecurityGroupName).Append("\n");
            sb.Append("  SourceSecurityGroupNameOrId: ").Append(SourceSecurityGroupNameOrId).Append("\n");
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
            return Equals(input as CloneSecurityGroupRequest);
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
                if (SecurityGroupName != null)
                    hashCode = hashCode * 59 + SecurityGroupName.GetHashCode();
                if (SourceSecurityGroupNameOrId != null)
                    hashCode = hashCode * 59 + SourceSecurityGroupNameOrId.GetHashCode();
                return hashCode;
            }
        }
    }
}