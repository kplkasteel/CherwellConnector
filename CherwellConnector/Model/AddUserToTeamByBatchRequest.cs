
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
    /// AddUserToTeamByBatchRequest
    /// </summary>
    [DataContract]
    public sealed class AddUserToTeamByBatchRequest :  IEquatable<AddUserToTeamByBatchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddUserToTeamByBatchRequest" /> class.
        /// </summary>
        /// <param name="addUserToTeamRequests">addUserToTeamRequests.</param>
        /// <param name="stopOnError">stopOnError.</param>
        public AddUserToTeamByBatchRequest(List<AddUserToTeamRequest> addUserToTeamRequests = default, bool? stopOnError = default)
        {
            AddUserToTeamRequests = addUserToTeamRequests;
            StopOnError = stopOnError;
        }
        
        /// <summary>
        /// Gets or Sets AddUserToTeamRequests
        /// </summary>
        [DataMember(Name="addUserToTeamRequests", EmitDefaultValue=false)]
        public List<AddUserToTeamRequest> AddUserToTeamRequests { get; set; }

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
            sb.Append("class AddUserToTeamByBatchRequest {\n");
            sb.Append("  AddUserToTeamRequests: ").Append(AddUserToTeamRequests).Append("\n");
            sb.Append("  StopOnError: ").Append(StopOnError).Append("\n");
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
            return Equals(input as AddUserToTeamByBatchRequest);
        }

        /// <summary>
        /// Returns true if AddUserToTeamByBatchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddUserToTeamByBatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddUserToTeamByBatchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    AddUserToTeamRequests == input.AddUserToTeamRequests ||
                    AddUserToTeamRequests != null &&
                    AddUserToTeamRequests.SequenceEqual(input.AddUserToTeamRequests)
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
                if (AddUserToTeamRequests != null)
                    hashCode = hashCode * 59 + AddUserToTeamRequests.GetHashCode();
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
