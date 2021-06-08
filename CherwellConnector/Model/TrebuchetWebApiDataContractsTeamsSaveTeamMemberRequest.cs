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
    /// TrebuchetWebApiDataContractsTeamsSaveTeamMemberRequest
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsTeamsSaveTeamMemberRequest :  IEquatable<TrebuchetWebApiDataContractsTeamsSaveTeamMemberRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsTeamsSaveTeamMemberRequest" /> class.
        /// </summary>
        /// <param name="isTeamManager">isTeamManager.</param>
        /// <param name="setAsDefaultTeam">setAsDefaultTeam.</param>
        /// <param name="teamId">teamId.</param>
        /// <param name="userRecId">userRecId.</param>
        public TrebuchetWebApiDataContractsTeamsSaveTeamMemberRequest(bool? isTeamManager = default(bool?), bool? setAsDefaultTeam = default(bool?), string teamId = default(string), string userRecId = default(string))
        {
            this.IsTeamManager = isTeamManager;
            this.SetAsDefaultTeam = setAsDefaultTeam;
            this.TeamId = teamId;
            this.UserRecId = userRecId;
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
            sb.Append("class TrebuchetWebApiDataContractsTeamsSaveTeamMemberRequest {\n");
            sb.Append("  IsTeamManager: ").Append(this.IsTeamManager).Append("\n");
            sb.Append("  SetAsDefaultTeam: ").Append(this.SetAsDefaultTeam).Append("\n");
            sb.Append("  TeamId: ").Append(this.TeamId).Append("\n");
            sb.Append("  UserRecId: ").Append(this.UserRecId).Append("\n");
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
            return this.Equals(input as TrebuchetWebApiDataContractsTeamsSaveTeamMemberRequest);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsTeamsSaveTeamMemberRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsTeamsSaveTeamMemberRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsTeamsSaveTeamMemberRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsTeamManager == input.IsTeamManager ||
                    (this.IsTeamManager != null &&
                    this.IsTeamManager.Equals(input.IsTeamManager))
                ) && 
                (
                    this.SetAsDefaultTeam == input.SetAsDefaultTeam ||
                    (this.SetAsDefaultTeam != null &&
                    this.SetAsDefaultTeam.Equals(input.SetAsDefaultTeam))
                ) && 
                (
                    this.TeamId == input.TeamId ||
                    (this.TeamId != null &&
                    this.TeamId.Equals(input.TeamId))
                ) && 
                (
                    this.UserRecId == input.UserRecId ||
                    (this.UserRecId != null &&
                    this.UserRecId.Equals(input.UserRecId))
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
                if (this.IsTeamManager != null)
                    hashCode = hashCode * 59 + this.IsTeamManager.GetHashCode();
                if (this.SetAsDefaultTeam != null)
                    hashCode = hashCode * 59 + this.SetAsDefaultTeam.GetHashCode();
                if (this.TeamId != null)
                    hashCode = hashCode * 59 + this.TeamId.GetHashCode();
                if (this.UserRecId != null)
                    hashCode = hashCode * 59 + this.UserRecId.GetHashCode();
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
