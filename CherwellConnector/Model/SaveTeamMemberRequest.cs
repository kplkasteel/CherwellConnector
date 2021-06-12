
namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// SaveTeamMemberRequest
    /// </summary>
    [DataContract]
    public sealed class SaveTeamMemberRequest :  IEquatable<SaveTeamMemberRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveTeamMemberRequest" /> class.
        /// </summary>
        /// <param name="isTeamManager">isTeamManager.</param>
        /// <param name="setAsDefaultTeam">setAsDefaultTeam.</param>
        /// <param name="teamId">teamId.</param>
        /// <param name="userRecId">userRecId.</param>
        public SaveTeamMemberRequest(bool? isTeamManager = default, bool? setAsDefaultTeam = default, string teamId = default, string userRecId = default)
        {
            IsTeamManager = isTeamManager;
            SetAsDefaultTeam = setAsDefaultTeam;
            TeamId = teamId;
            UserRecId = userRecId;
        }
        
        /// <summary>
        /// Gets or Sets IsTeamManager
        /// </summary>
        [DataMember(Name="isTeamManager", EmitDefaultValue=false)]
        public bool? IsTeamManager { get; set; }

        /// <summary>
        /// Gets or Sets SetAsDefaultTeam
        /// </summary>
        [DataMember(Name="setAsDefaultTeam", EmitDefaultValue=false)]
        public bool? SetAsDefaultTeam { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or Sets UserRecId
        /// </summary>
        [DataMember(Name="userRecId", EmitDefaultValue=false)]
        public string UserRecId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveTeamMemberRequest {\n");
            sb.Append("  IsTeamManager: ").Append(IsTeamManager).Append("\n");
            sb.Append("  SetAsDefaultTeam: ").Append(SetAsDefaultTeam).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  UserRecId: ").Append(UserRecId).Append("\n");
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
            return Equals(input as SaveTeamMemberRequest);
        }

        /// <summary>
        /// Returns true if SaveTeamMemberRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveTeamMemberRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveTeamMemberRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    IsTeamManager == input.IsTeamManager ||
                    (IsTeamManager != null &&
                    IsTeamManager.Equals(input.IsTeamManager))
                ) && 
                (
                    SetAsDefaultTeam == input.SetAsDefaultTeam ||
                    (SetAsDefaultTeam != null &&
                    SetAsDefaultTeam.Equals(input.SetAsDefaultTeam))
                ) && 
                (
                    TeamId == input.TeamId ||
                    (TeamId != null &&
                    TeamId.Equals(input.TeamId))
                ) && 
                (
                    UserRecId == input.UserRecId ||
                    (UserRecId != null &&
                    UserRecId.Equals(input.UserRecId))
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
                if (IsTeamManager != null)
                    hashCode = hashCode * 59 + IsTeamManager.GetHashCode();
                if (SetAsDefaultTeam != null)
                    hashCode = hashCode * 59 + SetAsDefaultTeam.GetHashCode();
                if (TeamId != null)
                    hashCode = hashCode * 59 + TeamId.GetHashCode();
                if (UserRecId != null)
                    hashCode = hashCode * 59 + UserRecId.GetHashCode();
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
