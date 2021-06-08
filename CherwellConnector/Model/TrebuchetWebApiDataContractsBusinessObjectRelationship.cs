/* 
 * 
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

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
    /// TrebuchetWebApiDataContractsBusinessObjectRelationship
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsBusinessObjectRelationship :  IEquatable<TrebuchetWebApiDataContractsBusinessObjectRelationship>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsBusinessObjectRelationship" /> class.
        /// </summary>
        /// <param name="cardinality">cardinality.</param>
        /// <param name="description">description.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="fieldDefinitions">fieldDefinitions.</param>
        /// <param name="relationshipId">relationshipId.</param>
        /// <param name="target">target.</param>
        public TrebuchetWebApiDataContractsBusinessObjectRelationship(string cardinality = default(string), string description = default(string), string displayName = default(string), List<TrebuchetWebApiDataContractsBusinessObjectFieldDefinition> fieldDefinitions = default(List<TrebuchetWebApiDataContractsBusinessObjectFieldDefinition>), string relationshipId = default(string), string target = default(string))
        {
            this.Cardinality = cardinality;
            this.Description = description;
            this.DisplayName = displayName;
            this.FieldDefinitions = fieldDefinitions;
            this.RelationshipId = relationshipId;
            this.Target = target;
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
        public List<TrebuchetWebApiDataContractsBusinessObjectFieldDefinition> FieldDefinitions { get; set; }

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
            sb.Append("class TrebuchetWebApiDataContractsBusinessObjectRelationship {\n");
            sb.Append("  Cardinality: ").Append(this.Cardinality).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  FieldDefinitions: ").Append(this.FieldDefinitions).Append("\n");
            sb.Append("  RelationshipId: ").Append(this.RelationshipId).Append("\n");
            sb.Append("  Target: ").Append(this.Target).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as TrebuchetWebApiDataContractsBusinessObjectRelationship);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsBusinessObjectRelationship instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsBusinessObjectRelationship to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsBusinessObjectRelationship input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cardinality == input.Cardinality ||
                    (this.Cardinality != null &&
                    this.Cardinality.Equals(input.Cardinality))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.FieldDefinitions == input.FieldDefinitions ||
                    this.FieldDefinitions != null &&
                    this.FieldDefinitions.SequenceEqual(input.FieldDefinitions)
                ) && 
                (
                    this.RelationshipId == input.RelationshipId ||
                    (this.RelationshipId != null &&
                    this.RelationshipId.Equals(input.RelationshipId))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
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
                int hashCode = 41;
                if (this.Cardinality != null)
                    hashCode = hashCode * 59 + this.Cardinality.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.FieldDefinitions != null)
                    hashCode = hashCode * 59 + this.FieldDefinitions.GetHashCode();
                if (this.RelationshipId != null)
                    hashCode = hashCode * 59 + this.RelationshipId.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}