using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     SecurityGroup
    /// </summary>
    [DataContract]
    public sealed class SecurityGroup : IEquatable<SecurityGroup>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SecurityGroup" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="groupId">groupId.</param>
        /// <param name="groupName">groupName.</param>
        public SecurityGroup(string description = default, string groupId = default, string groupName = default)
        {
            Description = description;
            GroupId = groupId;
            GroupName = groupName;
        }

        /// <summary>
        ///     Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        ///     Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        public string GroupId { get; set; }

        /// <summary>
        ///     Gets or Sets GroupName
        /// </summary>
        [DataMember(Name = "groupName", EmitDefaultValue = false)]
        public string GroupName { get; set; }

        /// <summary>
        ///     Returns true if SecurityGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityGroup input)
        {
            if (input == null)
                return false;

            return
                (
                    Description == input.Description ||
                    Description != null &&
                    Description.Equals(input.Description)
                ) &&
                (
                    GroupId == input.GroupId ||
                    GroupId != null &&
                    GroupId.Equals(input.GroupId)
                ) &&
                (
                    GroupName == input.GroupName ||
                    GroupName != null &&
                    GroupName.Equals(input.GroupName)
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
            sb.Append("class SecurityGroup {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
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
            return Equals(input as SecurityGroup);
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
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (GroupId != null)
                    hashCode = hashCode * 59 + GroupId.GetHashCode();
                if (GroupName != null)
                    hashCode = hashCode * 59 + GroupName.GetHashCode();
                return hashCode;
            }
        }
    }
}