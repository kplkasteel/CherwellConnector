
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
    /// TransitionOptionsResponseTransition
    /// </summary>
    [DataContract]
    public sealed class TransitionOptionsResponseTransition :  IEquatable<TransitionOptionsResponseTransition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransitionOptionsResponseTransition" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="id">id.</param>
        /// <param name="isAvailable">isAvailable.</param>
        /// <param name="criteria">criteria.</param>
        public TransitionOptionsResponseTransition(string name = default(string), string id = default(string), bool? isAvailable = default(bool?), List<string> criteria = default(List<string>))
        {
            Name = name;
            Id = id;
            IsAvailable = isAvailable;
            Criteria = criteria;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IsAvailable
        /// </summary>
        [DataMember(Name="isAvailable", EmitDefaultValue=false)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// Gets or Sets Criteria
        /// </summary>
        [DataMember(Name="criteria", EmitDefaultValue=false)]
        public List<string> Criteria { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransitionOptionsResponseTransition {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsAvailable: ").Append(IsAvailable).Append("\n");
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
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
            return Equals(input as TransitionOptionsResponseTransition);
        }

        /// <summary>
        /// Returns true if TransitionOptionsResponseTransition instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitionOptionsResponseTransition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitionOptionsResponseTransition input)
        {
            if (input == null)
                return false;

            return 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    Id == input.Id ||
                    (Id != null &&
                    Id.Equals(input.Id))
                ) && 
                (
                    IsAvailable == input.IsAvailable ||
                    (IsAvailable != null &&
                    IsAvailable.Equals(input.IsAvailable))
                ) && 
                (
                    Criteria == input.Criteria ||
                    Criteria != null &&
                    Criteria.SequenceEqual(input.Criteria)
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
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (IsAvailable != null)
                    hashCode = hashCode * 59 + IsAvailable.GetHashCode();
                if (Criteria != null)
                    hashCode = hashCode * 59 + Criteria.GetHashCode();
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
