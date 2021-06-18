using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     StagesResponseStages
    /// </summary>
    [DataContract]
    public class StagesResponseStages : IEquatable<StagesResponseStages>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="StagesResponseStages" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="isFinal">isFinal.</param>
        /// <param name="name">name.</param>
        public StagesResponseStages(string id = default, bool? isFinal = default, string name = default)
        {
            Id = id;
            IsFinal = isFinal;
            Name = name;
        }

        /// <summary>
        ///     Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        ///     Gets or Sets IsFinal
        /// </summary>
        [DataMember(Name = "isFinal", EmitDefaultValue = false)]
        public bool? IsFinal { get; set; }

        /// <summary>
        ///     Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        ///     Returns true if StagesResponseStages instances are equal
        /// </summary>
        /// <param name="input">Instance of StagesResponseStages to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StagesResponseStages input)
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
                    IsFinal == input.IsFinal ||
                    IsFinal != null &&
                    IsFinal.Equals(input.IsFinal)
                ) &&
                (
                    Name == input.Name ||
                    Name != null &&
                    Name.Equals(input.Name)
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
            sb.Append("class StagesResponseStages {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsFinal: ").Append(IsFinal).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return Equals(input as StagesResponseStages);
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
                if (IsFinal != null)
                    hashCode = hashCode * 59 + IsFinal.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                return hashCode;
            }
        }
    }
}