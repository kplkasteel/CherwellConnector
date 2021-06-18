using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     AddUserToTeamRequest
    /// </summary>
    [DataContract]
    public sealed class AddUserToTeamRequest : IEquatable<AddUserToTeamRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AddUserToTeamRequest" /> class.
        /// </summary>
        /// <param name="teamId">teamId.</param>
        /// <param name="userIsTeamManager">userIsTeamManager.</param>
        /// <param name="userRecordId">userRecordId.</param>
        public AddUserToTeamRequest(string teamId = default, bool? userIsTeamManager = default,
            string userRecordId = default)
        {
            TeamId = teamId;
            UserIsTeamManager = userIsTeamManager;
            UserRecordId = userRecordId;
        }

        /// <summary>
        ///     Gets or Sets TeamId
        /// </summary>
        [DataMember(Name = "teamId", EmitDefaultValue = false)]
        public string TeamId { get; set; }

        /// <summary>
        ///     Gets or Sets UserIsTeamManager
        /// </summary>
        [DataMember(Name = "userIsTeamManager", EmitDefaultValue = false)]
        public bool? UserIsTeamManager { get; set; }

        /// <summary>
        ///     Gets or Sets UserRecordId
        /// </summary>
        [DataMember(Name = "userRecordId", EmitDefaultValue = false)]
        public string UserRecordId { get; set; }

        /// <summary>
        ///     Returns true if AddUserToTeamRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddUserToTeamRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddUserToTeamRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    TeamId == input.TeamId ||
                    TeamId != null &&
                    TeamId.Equals(input.TeamId)
                ) &&
                (
                    UserIsTeamManager == input.UserIsTeamManager ||
                    UserIsTeamManager != null &&
                    UserIsTeamManager.Equals(input.UserIsTeamManager)
                ) &&
                (
                    UserRecordId == input.UserRecordId ||
                    UserRecordId != null &&
                    UserRecordId.Equals(input.UserRecordId)
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
            sb.Append("class AddUserToTeamRequest {\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  UserIsTeamManager: ").Append(UserIsTeamManager).Append("\n");
            sb.Append("  UserRecordId: ").Append(UserRecordId).Append("\n");
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
            return Equals(input as AddUserToTeamRequest);
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
                if (TeamId != null)
                    hashCode = hashCode * 59 + TeamId.GetHashCode();
                if (UserIsTeamManager != null)
                    hashCode = hashCode * 59 + UserIsTeamManager.GetHashCode();
                if (UserRecordId != null)
                    hashCode = hashCode * 59 + UserRecordId.GetHashCode();
                return hashCode;
            }
        }
    }
}