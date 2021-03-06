using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     TeamSaveRequest
    /// </summary>
    [DataContract]
    public sealed class TeamSaveRequest : IEquatable<TeamSaveRequest>, IValidatableObject
    {
        /// <summary>
        ///     Defines TeamType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TeamTypeEnum
        {
            /// <summary>
            ///     Enum User for value: User
            /// </summary>
            [EnumMember(Value = "User")] User = 1,

            /// <summary>
            ///     Enum CustomerWorkgroup for value: CustomerWorkgroup
            /// </summary>
            [EnumMember(Value = "CustomerWorkgroup")]
            CustomerWorkgroup = 2
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="TeamSaveRequest" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="emailAlias">emailAlias.</param>
        /// <param name="image">image.</param>
        /// <param name="teamId">teamId.</param>
        /// <param name="teamName">teamName.</param>
        /// <param name="teamType">teamType.</param>
        public TeamSaveRequest(string description = default, string emailAlias = default, string image = default,
            string teamId = default, string teamName = default, TeamTypeEnum? teamType = default)
        {
            Description = description;
            EmailAlias = emailAlias;
            Image = image;
            TeamId = teamId;
            TeamName = teamName;
            TeamType = teamType;
        }

        /// <summary>
        ///     Gets or Sets TeamType
        /// </summary>
        [DataMember(Name = "teamType", EmitDefaultValue = false)]
        public TeamTypeEnum? TeamType { get; set; }

        /// <summary>
        ///     Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        ///     Gets or Sets EmailAlias
        /// </summary>
        [DataMember(Name = "emailAlias", EmitDefaultValue = false)]
        public string EmailAlias { get; set; }

        /// <summary>
        ///     Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public string Image { get; set; }

        /// <summary>
        ///     Gets or Sets TeamId
        /// </summary>
        [DataMember(Name = "teamId", EmitDefaultValue = false)]
        public string TeamId { get; set; }

        /// <summary>
        ///     Gets or Sets TeamName
        /// </summary>
        [DataMember(Name = "teamName", EmitDefaultValue = false)]
        public string TeamName { get; set; }

        /// <summary>
        ///     Returns true if TeamSaveRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamSaveRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamSaveRequest input)
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
                    EmailAlias == input.EmailAlias ||
                    EmailAlias != null &&
                    EmailAlias.Equals(input.EmailAlias)
                ) &&
                (
                    Image == input.Image ||
                    Image != null &&
                    Image.Equals(input.Image)
                ) &&
                (
                    TeamId == input.TeamId ||
                    TeamId != null &&
                    TeamId.Equals(input.TeamId)
                ) &&
                (
                    TeamName == input.TeamName ||
                    TeamName != null &&
                    TeamName.Equals(input.TeamName)
                ) &&
                (
                    TeamType == input.TeamType ||
                    TeamType != null &&
                    TeamType.Equals(input.TeamType)
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
            sb.Append("class TeamSaveRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EmailAlias: ").Append(EmailAlias).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  TeamName: ").Append(TeamName).Append("\n");
            sb.Append("  TeamType: ").Append(TeamType).Append("\n");
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
            return Equals(input as TeamSaveRequest);
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
                if (EmailAlias != null)
                    hashCode = hashCode * 59 + EmailAlias.GetHashCode();
                if (Image != null)
                    hashCode = hashCode * 59 + Image.GetHashCode();
                if (TeamId != null)
                    hashCode = hashCode * 59 + TeamId.GetHashCode();
                if (TeamName != null)
                    hashCode = hashCode * 59 + TeamName.GetHashCode();
                if (TeamType != null)
                    hashCode = hashCode * 59 + TeamType.GetHashCode();
                return hashCode;
            }
        }
    }
}