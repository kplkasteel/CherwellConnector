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
    /// FormsSection
    /// </summary>
    [DataContract]
    public sealed class Section :  IEquatable<Section>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Section" /> class.
        /// </summary>
        /// <param name="sectionFields">sectionFields.</param>
        /// <param name="galleryImage">galleryImage.</param>
        /// <param name="title">title.</param>
        /// <param name="relationshipId">relationshipId.</param>
        /// <param name="targetBusObId">targetBusObId.</param>
        /// <param name="targetBusObRecId">targetBusObRecId.</param>
        public Section(List<SectionField> sectionFields = default, string galleryImage = default, string title = default, string relationshipId = default, string targetBusObId = default, string targetBusObRecId = default)
        {
            SectionFields = sectionFields;
            GalleryImage = galleryImage;
            Title = title;
            RelationshipId = relationshipId;
            TargetBusObId = targetBusObId;
            TargetBusObRecId = targetBusObRecId;
        }
        
        /// <summary>
        /// Gets or Sets SectionFields
        /// </summary>
        [DataMember(Name="sectionFields", EmitDefaultValue=false)]
        public List<SectionField> SectionFields { get; set; }

        /// <summary>
        /// Gets or Sets GalleryImage
        /// </summary>
        [DataMember(Name="galleryImage", EmitDefaultValue=false)]
        public string GalleryImage { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets RelationshipId
        /// </summary>
        [DataMember(Name="relationshipId", EmitDefaultValue=false)]
        public string RelationshipId { get; set; }

        /// <summary>
        /// Gets or Sets TargetBusObId
        /// </summary>
        [DataMember(Name="targetBusObId", EmitDefaultValue=false)]
        public string TargetBusObId { get; set; }

        /// <summary>
        /// Gets or Sets TargetBusObRecId
        /// </summary>
        [DataMember(Name="targetBusObRecId", EmitDefaultValue=false)]
        public string TargetBusObRecId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Section {\n");
            sb.Append("  SectionFields: ").Append(SectionFields).Append("\n");
            sb.Append("  GalleryImage: ").Append(GalleryImage).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  RelationshipId: ").Append(RelationshipId).Append("\n");
            sb.Append("  TargetBusObId: ").Append(TargetBusObId).Append("\n");
            sb.Append("  TargetBusObRecId: ").Append(TargetBusObRecId).Append("\n");
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
            return Equals(input as Section);
        }

        /// <summary>
        /// Returns true if Section instances are equal
        /// </summary>
        /// <param name="input">Instance of Section to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Section input)
        {
            if (input == null)
                return false;

            return 
                (
                    SectionFields == input.SectionFields ||
                    SectionFields != null &&
                    SectionFields.SequenceEqual(input.SectionFields)
                ) && 
                (
                    GalleryImage == input.GalleryImage ||
                    (GalleryImage != null &&
                    GalleryImage.Equals(input.GalleryImage))
                ) && 
                (
                    Title == input.Title ||
                    (Title != null &&
                    Title.Equals(input.Title))
                ) && 
                (
                    RelationshipId == input.RelationshipId ||
                    (RelationshipId != null &&
                    RelationshipId.Equals(input.RelationshipId))
                ) && 
                (
                    TargetBusObId == input.TargetBusObId ||
                    (TargetBusObId != null &&
                    TargetBusObId.Equals(input.TargetBusObId))
                ) && 
                (
                    TargetBusObRecId == input.TargetBusObRecId ||
                    (TargetBusObRecId != null &&
                    TargetBusObRecId.Equals(input.TargetBusObRecId))
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
                if (SectionFields != null)
                    hashCode = hashCode * 59 + SectionFields.GetHashCode();
                if (GalleryImage != null)
                    hashCode = hashCode * 59 + GalleryImage.GetHashCode();
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (RelationshipId != null)
                    hashCode = hashCode * 59 + RelationshipId.GetHashCode();
                if (TargetBusObId != null)
                    hashCode = hashCode * 59 + TargetBusObId.GetHashCode();
                if (TargetBusObRecId != null)
                    hashCode = hashCode * 59 + TargetBusObRecId.GetHashCode();
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
