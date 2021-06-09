using System.Diagnostics.CodeAnalysis;

namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// GridDefinition
    /// </summary>
    [DataContract]
    public sealed class GridDefinition :  IEquatable<GridDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GridDefinition" /> class.
        /// </summary>
        /// <param name="gridId">gridId.</param>
        /// <param name="name">name.</param>
        /// <param name="displayName">displayName.</param>
        public GridDefinition(string gridId = default, string name = default, string displayName = default)
        {
            GridId = gridId;
            Name = name;
            DisplayName = displayName;
        }
        
        /// <summary>
        /// Gets or Sets GridId
        /// </summary>
        [DataMember(Name="gridId", EmitDefaultValue=false)]
        public string GridId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GridDefinition {\n");
            sb.Append("  GridId: ").Append(GridId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
            return Equals(input as GridDefinition);
        }

        /// <summary>
        /// Returns true if GridDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of GridDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GridDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    GridId == input.GridId ||
                    (GridId != null &&
                    GridId.Equals(input.GridId))
                ) && 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    DisplayName == input.DisplayName ||
                    (DisplayName != null &&
                    DisplayName.Equals(input.DisplayName))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (GridId != null)
                    hashCode = hashCode * 59 + GridId.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
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
