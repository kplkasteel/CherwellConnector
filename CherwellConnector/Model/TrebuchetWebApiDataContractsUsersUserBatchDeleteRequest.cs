
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
    /// TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest
    /// </summary>
    [DataContract]
    public sealed class TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest :  IEquatable<TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest" /> class.
        /// </summary>
        /// <param name="stopOnError">stopOnError.</param>
        /// <param name="userRecordIds">userRecordIds.</param>
        public TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest(bool? stopOnError = default, List<string> userRecordIds = default)
        {
            StopOnError = stopOnError;
            UserRecordIds = userRecordIds;
        }
        
        /// <summary>
        /// Gets or Sets StopOnError
        /// </summary>
        [DataMember(Name="stopOnError", EmitDefaultValue=false)]
        public bool? StopOnError { get; set; }

        /// <summary>
        /// Gets or Sets UserRecordIds
        /// </summary>
        [DataMember(Name="userRecordIds", EmitDefaultValue=false)]
        public List<string> UserRecordIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest {\n");
            sb.Append("  StopOnError: ").Append(StopOnError).Append("\n");
            sb.Append("  UserRecordIds: ").Append(UserRecordIds).Append("\n");
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
            return Equals(input as TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    StopOnError == input.StopOnError ||
                    (StopOnError != null &&
                    StopOnError.Equals(input.StopOnError))
                ) && 
                (
                    UserRecordIds == input.UserRecordIds ||
                    UserRecordIds != null &&
                    UserRecordIds.SequenceEqual(input.UserRecordIds)
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
                if (StopOnError != null)
                    hashCode = hashCode * 59 + StopOnError.GetHashCode();
                if (UserRecordIds != null)
                    hashCode = hashCode * 59 + UserRecordIds.GetHashCode();
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
