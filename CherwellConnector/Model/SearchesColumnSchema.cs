using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using CherwellConnector.Enum;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     SearchesColumnSchema
    /// </summary>
    [DataContract]
    public sealed class SearchesColumnSchema : IEquatable<SearchesColumnSchema>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SearchesColumnSchema" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="fieldId">fieldId.</param>
        /// <param name="type">type.</param>
        public SearchesColumnSchema(string name = default, string fieldId = default, TypeEnum? type = default)
        {
            Name = name;
            FieldId = fieldId;
            Type = type;
        }

        /// <summary>
        ///     Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        ///     Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or Sets FieldId
        /// </summary>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }

        /// <summary>
        ///     Returns true if SearchesColumnSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchesColumnSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchesColumnSchema input)
        {
            if (input == null)
                return false;

            return
                (
                    Name == input.Name ||
                    Name != null &&
                    Name.Equals(input.Name)
                ) &&
                (
                    FieldId == input.FieldId ||
                    FieldId != null &&
                    FieldId.Equals(input.FieldId)
                ) &&
                (
                    Type == input.Type ||
                    Type != null &&
                    Type.Equals(input.Type)
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
            sb.Append("class SearchesColumnSchema {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return Equals(input as SearchesColumnSchema);
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
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (FieldId != null)
                    hashCode = hashCode * 59 + FieldId.GetHashCode();
                if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                return hashCode;
            }
        }
    }
}