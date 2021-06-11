
namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// TrebuchetWebApiDataContractsTeamsTeam
    /// </summary>
    [DataContract]
    public sealed class TrebuchetWebApiDataContractsTeamsTeam :  IEquatable<TrebuchetWebApiDataContractsTeamsTeam>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsTeamsTeam" /> class.
        /// </summary>
        /// <param name="teamId">teamId.</param>
        /// <param name="teamName">teamName.</param>
        public TrebuchetWebApiDataContractsTeamsTeam(string teamId = default, string teamName = default)
        {
            TeamId = teamId;
            TeamName = teamName;
        }
        
        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or Sets TeamName
        /// </summary>
        [DataMember(Name="teamName", EmitDefaultValue=false)]
        public string TeamName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsTeamsTeam {\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  TeamName: ").Append(TeamName).Append("\n");
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
            return Equals(input as TrebuchetWebApiDataContractsTeamsTeam);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsTeamsTeam instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsTeamsTeam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsTeamsTeam input)
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
                    TeamName == input.TeamName ||
                    (TeamName != null &&
                    TeamName.Equals(input.TeamName))
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
                if (TeamName != null)
                    hashCode = hashCode * 59 + TeamName.GetHashCode();
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
