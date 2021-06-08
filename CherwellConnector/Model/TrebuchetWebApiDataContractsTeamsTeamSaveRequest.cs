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
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// TrebuchetWebApiDataContractsTeamsTeamSaveRequest
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsTeamsTeamSaveRequest :  IEquatable<TrebuchetWebApiDataContractsTeamsTeamSaveRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines TeamType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TeamTypeEnum
        {
            
            /// <summary>
            /// Enum User for value: User
            /// </summary>
            [EnumMember(Value = "User")]
            User = 1,
            
            /// <summary>
            /// Enum CustomerWorkgroup for value: CustomerWorkgroup
            /// </summary>
            [EnumMember(Value = "CustomerWorkgroup")]
            CustomerWorkgroup = 2
        }

        /// <summary>
        /// Gets or Sets TeamType
        /// </summary>
        [DataMember(Name="teamType", EmitDefaultValue=false)]
        public TeamTypeEnum? TeamType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsTeamsTeamSaveRequest" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="emailAlias">emailAlias.</param>
        /// <param name="image">image.</param>
        /// <param name="teamId">teamId.</param>
        /// <param name="teamName">teamName.</param>
        /// <param name="teamType">teamType.</param>
        public TrebuchetWebApiDataContractsTeamsTeamSaveRequest(string description = default(string), string emailAlias = default(string), string image = default(string), string teamId = default(string), string teamName = default(string), TeamTypeEnum? teamType = default(TeamTypeEnum?))
        {
            this.Description = description;
            this.EmailAlias = emailAlias;
            this.Image = image;
            this.TeamId = teamId;
            this.TeamName = teamName;
            this.TeamType = teamType;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets EmailAlias
        /// </summary>
        [DataMember(Name="emailAlias", EmitDefaultValue=false)]
        public string EmailAlias { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }

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
            sb.Append("class TrebuchetWebApiDataContractsTeamsTeamSaveRequest {\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  EmailAlias: ").Append(this.EmailAlias).Append("\n");
            sb.Append("  Image: ").Append(this.Image).Append("\n");
            sb.Append("  TeamId: ").Append(this.TeamId).Append("\n");
            sb.Append("  TeamName: ").Append(this.TeamName).Append("\n");
            sb.Append("  TeamType: ").Append(this.TeamType).Append("\n");
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
            return this.Equals(input as TrebuchetWebApiDataContractsTeamsTeamSaveRequest);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsTeamsTeamSaveRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsTeamsTeamSaveRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsTeamsTeamSaveRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EmailAlias == input.EmailAlias ||
                    (this.EmailAlias != null &&
                    this.EmailAlias.Equals(input.EmailAlias))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.TeamId == input.TeamId ||
                    (this.TeamId != null &&
                    this.TeamId.Equals(input.TeamId))
                ) && 
                (
                    this.TeamName == input.TeamName ||
                    (this.TeamName != null &&
                    this.TeamName.Equals(input.TeamName))
                ) && 
                (
                    this.TeamType == input.TeamType ||
                    (this.TeamType != null &&
                    this.TeamType.Equals(input.TeamType))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EmailAlias != null)
                    hashCode = hashCode * 59 + this.EmailAlias.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.TeamId != null)
                    hashCode = hashCode * 59 + this.TeamId.GetHashCode();
                if (this.TeamName != null)
                    hashCode = hashCode * 59 + this.TeamName.GetHashCode();
                if (this.TeamType != null)
                    hashCode = hashCode * 59 + this.TeamType.GetHashCode();
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
