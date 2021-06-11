
namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// StatusesResponseStatuses
    /// </summary>
    [DataContract]
    public sealed class StatusesResponseStatuses :  IEquatable<StatusesResponseStatuses>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusesResponseStatuses" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="isInitial">isInitial.</param>
        /// <param name="name">name.</param>
        /// <param name="stageId">stageId.</param>
        public StatusesResponseStatuses(string id = default, bool? isInitial = default, string name = default, string stageId = default)
        {
            Id = id;
            IsInitial = isInitial;
            Name = name;
            StageId = stageId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IsInitial
        /// </summary>
        [DataMember(Name="isInitial", EmitDefaultValue=false)]
        public bool? IsInitial { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets StageId
        /// </summary>
        [DataMember(Name="stageId", EmitDefaultValue=false)]
        public string StageId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusesResponseStatuses {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsInitial: ").Append(IsInitial).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StageId: ").Append(StageId).Append("\n");
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
            return Equals(input as StatusesResponseStatuses);
        }

        /// <summary>
        /// Returns true if StatusesResponseStatuses instances are equal
        /// </summary>
        /// <param name="input">Instance of StatusesResponseStatuses to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusesResponseStatuses input)
        {
            if (input == null)
                return false;

            return 
                (
                    Id == input.Id ||
                    (Id != null &&
                    Id.Equals(input.Id))
                ) && 
                (
                    IsInitial == input.IsInitial ||
                    (IsInitial != null &&
                    IsInitial.Equals(input.IsInitial))
                ) && 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    StageId == input.StageId ||
                    (StageId != null &&
                    StageId.Equals(input.StageId))
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
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (IsInitial != null)
                    hashCode = hashCode * 59 + IsInitial.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (StageId != null)
                    hashCode = hashCode * 59 + StageId.GetHashCode();
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
