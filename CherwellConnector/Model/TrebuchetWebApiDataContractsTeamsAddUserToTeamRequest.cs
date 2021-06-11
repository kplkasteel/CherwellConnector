
namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// TrebuchetWebApiDataContractsTeamsAddUserToTeamRequest
    /// </summary>
    [DataContract]
    public sealed class TrebuchetWebApiDataContractsTeamsAddUserToTeamRequest :  IEquatable<TrebuchetWebApiDataContractsTeamsAddUserToTeamRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsTeamsAddUserToTeamRequest" /> class.
        /// </summary>
        /// <param name="teamId">teamId.</param>
        /// <param name="userIsTeamManager">userIsTeamManager.</param>
        /// <param name="userRecordId">userRecordId.</param>
        public TrebuchetWebApiDataContractsTeamsAddUserToTeamRequest(string teamId = default, bool? userIsTeamManager = default, string userRecordId = default)
        {
            TeamId = teamId;
            UserIsTeamManager = userIsTeamManager;
            UserRecordId = userRecordId;
        }
        
        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or Sets UserIsTeamManager
        /// </summary>
        [DataMember(Name="userIsTeamManager", EmitDefaultValue=false)]
        public bool? UserIsTeamManager { get; set; }

        /// <summary>
        /// Gets or Sets UserRecordId
        /// </summary>
        [DataMember(Name="userRecordId", EmitDefaultValue=false)]
        public string UserRecordId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsTeamsAddUserToTeamRequest {\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  UserIsTeamManager: ").Append(UserIsTeamManager).Append("\n");
            sb.Append("  UserRecordId: ").Append(UserRecordId).Append("\n");
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
            return Equals(input as TrebuchetWebApiDataContractsTeamsAddUserToTeamRequest);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsTeamsAddUserToTeamRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsTeamsAddUserToTeamRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsTeamsAddUserToTeamRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    TeamId == input.TeamId ||
                    (TeamId != null &&
                    TeamId.Equals(input.TeamId))
                ) && 
                (
                    UserIsTeamManager == input.UserIsTeamManager ||
                    (UserIsTeamManager != null &&
                    UserIsTeamManager.Equals(input.UserIsTeamManager))
                ) && 
                (
                    UserRecordId == input.UserRecordId ||
                    (UserRecordId != null &&
                    UserRecordId.Equals(input.UserRecordId))
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
                if (TeamId != null)
                    hashCode = hashCode * 59 + TeamId.GetHashCode();
                if (UserIsTeamManager != null)
                    hashCode = hashCode * 59 + UserIsTeamManager.GetHashCode();
                if (UserRecordId != null)
                    hashCode = hashCode * 59 + UserRecordId.GetHashCode();
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
