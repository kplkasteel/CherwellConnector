using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     TransitionsResponseTransition
    /// </summary>
    [DataContract]
    public sealed class TransitionsResponseTransition : IEquatable<TransitionsResponseTransition>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TransitionsResponseTransition" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="fromStatusId">fromStatusId.</param>
        /// <param name="toStatusId">toStatusId.</param>
        public TransitionsResponseTransition(string id = default, string name = default, string fromStatusId = default,
            string toStatusId = default)
        {
            Id = id;
            Name = name;
            FromStatusId = fromStatusId;
            ToStatusId = toStatusId;
        }

        /// <summary>
        ///     Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        ///     Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or Sets FromStatusId
        /// </summary>
        [DataMember(Name = "fromStatusId", EmitDefaultValue = false)]
        public string FromStatusId { get; set; }

        /// <summary>
        ///     Gets or Sets ToStatusId
        /// </summary>
        [DataMember(Name = "toStatusId", EmitDefaultValue = false)]
        public string ToStatusId { get; set; }

        /// <summary>
        ///     Returns true if TransitionsResponseTransition instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitionsResponseTransition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitionsResponseTransition input)
        {
            if (input == null)
                return false;

            return
                (
                    Id == input.Id ||
                    Id != null &&
                    Id.Equals(input.Id)
                ) &&
                (
                    Name == input.Name ||
                    Name != null &&
                    Name.Equals(input.Name)
                ) &&
                (
                    FromStatusId == input.FromStatusId ||
                    FromStatusId != null &&
                    FromStatusId.Equals(input.FromStatusId)
                ) &&
                (
                    ToStatusId == input.ToStatusId ||
                    ToStatusId != null &&
                    ToStatusId.Equals(input.ToStatusId)
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
            sb.Append("class TransitionsResponseTransition {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FromStatusId: ").Append(FromStatusId).Append("\n");
            sb.Append("  ToStatusId: ").Append(ToStatusId).Append("\n");
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
            return Equals(input as TransitionsResponseTransition);
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
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (FromStatusId != null)
                    hashCode = hashCode * 59 + FromStatusId.GetHashCode();
                if (ToStatusId != null)
                    hashCode = hashCode * 59 + ToStatusId.GetHashCode();
                return hashCode;
            }
        }
    }
}