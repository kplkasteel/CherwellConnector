using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     SearchesChangedLimit
    /// </summary>
    [DataContract]
    public sealed class SearchesChangedLimit : IEquatable<SearchesChangedLimit>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SearchesChangedLimit" /> class.
        /// </summary>
        /// <param name="displayName">displayName.</param>
        /// <param name="units">units.</param>
        /// <param name="value">value.</param>
        public SearchesChangedLimit(string displayName = default, string units = default, int? value = default)
        {
            DisplayName = displayName;
            Units = units;
            Value = value;
        }

        /// <summary>
        ///     Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        ///     Gets or Sets Units
        /// </summary>
        [DataMember(Name = "units", EmitDefaultValue = false)]
        public string Units { get; set; }

        /// <summary>
        ///     Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public int? Value { get; set; }

        /// <summary>
        ///     Returns true if SearchesChangedLimit instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchesChangedLimit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchesChangedLimit input)
        {
            if (input == null)
                return false;

            return
                (
                    DisplayName == input.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(input.DisplayName)
                ) &&
                (
                    Units == input.Units ||
                    Units != null &&
                    Units.Equals(input.Units)
                ) &&
                (
                    Value == input.Value ||
                    Value != null &&
                    Value.Equals(input.Value)
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
            sb.Append("class SearchesChangedLimit {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return Equals(input as SearchesChangedLimit);
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
                if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                if (Units != null)
                    hashCode = hashCode * 59 + Units.GetHashCode();
                if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                return hashCode;
            }
        }
    }
}