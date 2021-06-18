using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     TeamsResponse
    /// </summary>
    [DataContract]
    public sealed class TeamsResponse : IEquatable<TeamsResponse>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TeamsResponse" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="teams">teams.</param>
        public TeamsResponse(string error = default, string errorCode = default, bool? hasError = default,
            List<Team> teams = default)
        {
            Error = error;
            ErrorCode = errorCode;
            HasError = hasError;
            Teams = teams;
        }

        /// <summary>
        ///     Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        ///     Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        ///     Gets or Sets HasError
        /// </summary>
        [DataMember(Name = "hasError", EmitDefaultValue = false)]
        public bool? HasError { get; set; }

        /// <summary>
        ///     Gets or Sets Teams
        /// </summary>
        [DataMember(Name = "teams", EmitDefaultValue = false)]
        public List<Team> Teams { get; set; }

        /// <summary>
        ///     Returns true if TeamsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamsResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    Error == input.Error ||
                    Error != null &&
                    Error.Equals(input.Error)
                ) &&
                (
                    ErrorCode == input.ErrorCode ||
                    ErrorCode != null &&
                    ErrorCode.Equals(input.ErrorCode)
                ) &&
                (
                    HasError == input.HasError ||
                    HasError != null &&
                    HasError.Equals(input.HasError)
                ) &&
                (
                    Teams == input.Teams ||
                    Teams != null &&
                    Teams.SequenceEqual(input.Teams)
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
            sb.Append("class TeamsResponse {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  HasError: ").Append(HasError).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
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
            return Equals(input as TeamsResponse);
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
                if (Error != null)
                    hashCode = hashCode * 59 + Error.GetHashCode();
                if (ErrorCode != null)
                    hashCode = hashCode * 59 + ErrorCode.GetHashCode();
                if (HasError != null)
                    hashCode = hashCode * 59 + HasError.GetHashCode();
                if (Teams != null)
                    hashCode = hashCode * 59 + Teams.GetHashCode();
                return hashCode;
            }
        }
    }
}