
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
    /// Relationship
    /// </summary>
    [DataContract]
    public sealed class Relationship :  IEquatable<Relationship>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationship" /> class.
        /// </summary>
        /// <param name="cardinality">cardinality.</param>
        /// <param name="description">description.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="fieldDefinitions">fieldDefinitions.</param>
        /// <param name="relationshipId">relationshipId.</param>
        /// <param name="target">target.</param>
        public Relationship(string cardinality = default, string description = default, string displayName = default, List<FieldDefinition> fieldDefinitions = default, string relationshipId = default, string target = default)
        {
            Cardinality = cardinality;
            Description = description;
            DisplayName = displayName;
            FieldDefinitions = fieldDefinitions;
            RelationshipId = relationshipId;
            Target = target;
        }
        
        /// <summary>
        /// Gets or Sets Cardinality
        /// </summary>
        [DataMember(Name="cardinality", EmitDefaultValue=false)]
        public string Cardinality { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets FieldDefinitions
        /// </summary>
        [DataMember(Name="fieldDefinitions", EmitDefaultValue=false)]
        public List<FieldDefinition> FieldDefinitions { get; set; }

        /// <summary>
        /// Gets or Sets RelationshipId
        /// </summary>
        [DataMember(Name="relationshipId", EmitDefaultValue=false)]
        public string RelationshipId { get; set; }

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public string Target { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Relationship {\n");
            sb.Append("  Cardinality: ").Append(Cardinality).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FieldDefinitions: ").Append(FieldDefinitions).Append("\n");
            sb.Append("  RelationshipId: ").Append(RelationshipId).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
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
            return Equals(input as Relationship);
        }

        /// <summary>
        /// Returns true if Relationship instances are equal
        /// </summary>
        /// <param name="input">Instance of Relationship to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Relationship input)
        {
            if (input == null)
                return false;

            return 
                (
                    Cardinality == input.Cardinality ||
                    (Cardinality != null &&
                    Cardinality.Equals(input.Cardinality))
                ) && 
                (
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) && 
                (
                    DisplayName == input.DisplayName ||
                    (DisplayName != null &&
                    DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    FieldDefinitions == input.FieldDefinitions ||
                    FieldDefinitions != null &&
                    FieldDefinitions.SequenceEqual(input.FieldDefinitions)
                ) && 
                (
                    RelationshipId == input.RelationshipId ||
                    (RelationshipId != null &&
                    RelationshipId.Equals(input.RelationshipId))
                ) && 
                (
                    Target == input.Target ||
                    (Target != null &&
                    Target.Equals(input.Target))
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
                if (Cardinality != null)
                    hashCode = hashCode * 59 + Cardinality.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                if (FieldDefinitions != null)
                    hashCode = hashCode * 59 + FieldDefinitions.GetHashCode();
                if (RelationshipId != null)
                    hashCode = hashCode * 59 + RelationshipId.GetHashCode();
                if (Target != null)
                    hashCode = hashCode * 59 + Target.GetHashCode();
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
