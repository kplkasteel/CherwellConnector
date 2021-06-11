
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
    /// UserBatchSaveV2Request
    /// </summary>
    [DataContract]
    public sealed class UserBatchSaveV2Request :  IEquatable<UserBatchSaveV2Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserBatchSaveV2Request" /> class.
        /// </summary>
        /// <param name="saveRequests">saveRequests.</param>
        /// <param name="stopOnError">stopOnError.</param>
        public UserBatchSaveV2Request(List<UserSaveV2Request> saveRequests = default, bool? stopOnError = default)
        {
            SaveRequests = saveRequests;
            StopOnError = stopOnError;
        }
        
        /// <summary>
        /// Gets or Sets SaveRequests
        /// </summary>
        [DataMember(Name="saveRequests", EmitDefaultValue=false)]
        public List<UserSaveV2Request> SaveRequests { get; set; }

        /// <summary>
        /// Gets or Sets StopOnError
        /// </summary>
        [DataMember(Name="stopOnError", EmitDefaultValue=false)]
        public bool? StopOnError { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserBatchSaveV2Request {\n");
            sb.Append("  SaveRequests: ").Append(SaveRequests).Append("\n");
            sb.Append("  StopOnError: ").Append(StopOnError).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return Equals(input as UserBatchSaveV2Request);
        }

        /// <summary>
        /// Returns true if UserBatchSaveV2Request instances are equal
        /// </summary>
        /// <param name="input">Instance of UserBatchSaveV2Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserBatchSaveV2Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    SaveRequests == input.SaveRequests ||
                    SaveRequests != null &&
                    SaveRequests.SequenceEqual(input.SaveRequests)
                ) && 
                (
                    StopOnError == input.StopOnError ||
                    (StopOnError != null &&
                    StopOnError.Equals(input.StopOnError))
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
                if (SaveRequests != null)
                    hashCode = hashCode * 59 + SaveRequests.GetHashCode();
                if (StopOnError != null)
                    hashCode = hashCode * 59 + StopOnError.GetHashCode();
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
