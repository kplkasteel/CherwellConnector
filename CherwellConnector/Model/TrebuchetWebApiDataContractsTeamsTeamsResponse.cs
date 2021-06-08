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
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// TrebuchetWebApiDataContractsTeamsTeamsResponse
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsTeamsTeamsResponse :  IEquatable<TrebuchetWebApiDataContractsTeamsTeamsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsTeamsTeamsResponse" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="teams">teams.</param>
        public TrebuchetWebApiDataContractsTeamsTeamsResponse(string error = default(string), string errorCode = default(string), bool? hasError = default(bool?), List<TrebuchetWebApiDataContractsTeamsTeam> teams = default(List<TrebuchetWebApiDataContractsTeamsTeam>))
        {
            this.Error = error;
            this.ErrorCode = errorCode;
            this.HasError = hasError;
            this.Teams = teams;
        }
        
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets HasError
        /// </summary>
        [DataMember(Name="hasError", EmitDefaultValue=false)]
        public bool? HasError { get; set; }

        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name="teams", EmitDefaultValue=false)]
        public List<TrebuchetWebApiDataContractsTeamsTeam> Teams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsTeamsTeamsResponse {\n");
            sb.Append("  Error: ").Append(this.Error).Append("\n");
            sb.Append("  ErrorCode: ").Append(this.ErrorCode).Append("\n");
            sb.Append("  HasError: ").Append(this.HasError).Append("\n");
            sb.Append("  Teams: ").Append(this.Teams).Append("\n");
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
            return this.Equals(input as TrebuchetWebApiDataContractsTeamsTeamsResponse);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsTeamsTeamsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsTeamsTeamsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsTeamsTeamsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.HasError == input.HasError ||
                    (this.HasError != null &&
                    this.HasError.Equals(input.HasError))
                ) && 
                (
                    this.Teams == input.Teams ||
                    this.Teams != null &&
                    this.Teams.SequenceEqual(input.Teams)
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.HasError != null)
                    hashCode = hashCode * 59 + this.HasError.GetHashCode();
                if (this.Teams != null)
                    hashCode = hashCode * 59 + this.Teams.GetHashCode();
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
