
using CherwellConnector.Enum;

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
    /// TrebuchetWebApiDataContractsBusinessObjectAttachment
    /// </summary>
    [DataContract]
    public sealed class Attachment :  IEquatable<Attachment>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AttachmentType
        /// </summary>
        [DataMember(Name="attachmentType", EmitDefaultValue=false)]
        public AttachmentTypeEnum? AttachmentType { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public ScopeEnum? Scope { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment" /> class.
        /// </summary>
        /// <param name="attachedBusObId">attachedBusObId.</param>
        /// <param name="attachedBusObRecId">attachedBusObRecId.</param>
        /// <param name="attachmentFileId">attachmentFileId.</param>
        /// <param name="attachmentFileName">attachmentFileName.</param>
        /// <param name="attachmentFileType">attachmentFileType.</param>
        /// <param name="attachmentId">attachmentId.</param>
        /// <param name="attachmentType">attachmentType.</param>
        /// <param name="busObId">busObId.</param>
        /// <param name="busObRecId">busObRecId.</param>
        /// <param name="comment">comment.</param>
        /// <param name="created">created.</param>
        /// <param name="displayText">displayText.</param>
        /// <param name="links">links.</param>
        /// <param name="owner">owner.</param>
        /// <param name="scope">scope.</param>
        /// <param name="scopeOwner">scopeOwner.</param>
        /// <param name="type">type.</param>
        public Attachment(string attachedBusObId = default, string attachedBusObRecId = default, string attachmentFileId = default, string attachmentFileName = default, string attachmentFileType = default, string attachmentId = default, AttachmentTypeEnum? attachmentType = default, string busObId = default, string busObRecId = default, string comment = default, DateTime? created = default, string displayText = default, List<Link> links = default, string owner = default, ScopeEnum? scope = default, string scopeOwner = default, TypeEnum? type = default)
        {
            AttachedBusObId = attachedBusObId;
            AttachedBusObRecId = attachedBusObRecId;
            AttachmentFileId = attachmentFileId;
            AttachmentFileName = attachmentFileName;
            AttachmentFileType = attachmentFileType;
            AttachmentId = attachmentId;
            AttachmentType = attachmentType;
            BusObId = busObId;
            BusObRecId = busObRecId;
            Comment = comment;
            Created = created;
            DisplayText = displayText;
            Links = links;
            Owner = owner;
            Scope = scope;
            ScopeOwner = scopeOwner;
            Type = type;
        }
        
        /// <summary>
        /// Gets or Sets AttachedBusObId
        /// </summary>
        [DataMember(Name="attachedBusObId", EmitDefaultValue=false)]
        public string AttachedBusObId { get; set; }

        /// <summary>
        /// Gets or Sets AttachedBusObRecId
        /// </summary>
        [DataMember(Name="attachedBusObRecId", EmitDefaultValue=false)]
        public string AttachedBusObRecId { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentFileId
        /// </summary>
        [DataMember(Name="attachmentFileId", EmitDefaultValue=false)]
        public string AttachmentFileId { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentFileName
        /// </summary>
        [DataMember(Name="attachmentFileName", EmitDefaultValue=false)]
        public string AttachmentFileName { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentFileType
        /// </summary>
        [DataMember(Name="attachmentFileType", EmitDefaultValue=false)]
        public string AttachmentFileType { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentId
        /// </summary>
        [DataMember(Name="attachmentId", EmitDefaultValue=false)]
        public string AttachmentId { get; set; }


        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }

        /// <summary>
        /// Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name="busObRecId", EmitDefaultValue=false)]
        public string BusObRecId { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=false)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public string Owner { get; set; }


        /// <summary>
        /// Gets or Sets ScopeOwner
        /// </summary>
        [DataMember(Name="scopeOwner", EmitDefaultValue=false)]
        public string ScopeOwner { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attachment {\n");
            sb.Append("  AttachedBusObId: ").Append(AttachedBusObId).Append("\n");
            sb.Append("  AttachedBusObRecId: ").Append(AttachedBusObRecId).Append("\n");
            sb.Append("  AttachmentFileId: ").Append(AttachmentFileId).Append("\n");
            sb.Append("  AttachmentFileName: ").Append(AttachmentFileName).Append("\n");
            sb.Append("  AttachmentFileType: ").Append(AttachmentFileType).Append("\n");
            sb.Append("  AttachmentId: ").Append(AttachmentId).Append("\n");
            sb.Append("  AttachmentType: ").Append(AttachmentType).Append("\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return Equals(input as Attachment);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsBusinessObjectAttachment instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsBusinessObjectAttachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Attachment input)
        {
            if (input == null)
                return false;

            return 
                (
                    AttachedBusObId == input.AttachedBusObId ||
                    (AttachedBusObId != null &&
                    AttachedBusObId.Equals(input.AttachedBusObId))
                ) && 
                (
                    AttachedBusObRecId == input.AttachedBusObRecId ||
                    (AttachedBusObRecId != null &&
                    AttachedBusObRecId.Equals(input.AttachedBusObRecId))
                ) && 
                (
                    AttachmentFileId == input.AttachmentFileId ||
                    (AttachmentFileId != null &&
                    AttachmentFileId.Equals(input.AttachmentFileId))
                ) && 
                (
                    AttachmentFileName == input.AttachmentFileName ||
                    (AttachmentFileName != null &&
                    AttachmentFileName.Equals(input.AttachmentFileName))
                ) && 
                (
                    AttachmentFileType == input.AttachmentFileType ||
                    (AttachmentFileType != null &&
                    AttachmentFileType.Equals(input.AttachmentFileType))
                ) && 
                (
                    AttachmentId == input.AttachmentId ||
                    (AttachmentId != null &&
                    AttachmentId.Equals(input.AttachmentId))
                ) && 
                (
                    AttachmentType == input.AttachmentType ||
                    (AttachmentType != null &&
                    AttachmentType.Equals(input.AttachmentType))
                ) && 
                (
                    BusObId == input.BusObId ||
                    (BusObId != null &&
                    BusObId.Equals(input.BusObId))
                ) && 
                (
                    BusObRecId == input.BusObRecId ||
                    (BusObRecId != null &&
                    BusObRecId.Equals(input.BusObRecId))
                ) && 
                (
                    Comment == input.Comment ||
                    (Comment != null &&
                    Comment.Equals(input.Comment))
                ) && 
                (
                    Created == input.Created ||
                    (Created != null &&
                    Created.Equals(input.Created))
                ) && 
                (
                    DisplayText == input.DisplayText ||
                    (DisplayText != null &&
                    DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    Links == input.Links ||
                    Links != null &&
                    Links.SequenceEqual(input.Links)
                ) && 
                (
                    Owner == input.Owner ||
                    (Owner != null &&
                    Owner.Equals(input.Owner))
                ) && 
                (
                    Scope == input.Scope ||
                    (Scope != null &&
                    Scope.Equals(input.Scope))
                ) && 
                (
                    ScopeOwner == input.ScopeOwner ||
                    (ScopeOwner != null &&
                    ScopeOwner.Equals(input.ScopeOwner))
                ) && 
                (
                    Type == input.Type ||
                    (Type != null &&
                    Type.Equals(input.Type))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        
        public override int GetHashCode()
        {
            var hashCode = 41;
            unchecked // Overflow is fine, just wrap
            {
                if (AttachedBusObId != null)
                    hashCode = hashCode * 59 + AttachedBusObId.GetHashCode();
                if (AttachedBusObRecId != null)
                    hashCode = hashCode * 59 + AttachedBusObRecId.GetHashCode();
                if (AttachmentFileId != null)
                    hashCode = hashCode * 59 + AttachmentFileId.GetHashCode();
                if (AttachmentFileName != null)
                    hashCode = hashCode * 59 + AttachmentFileName.GetHashCode();
                if (AttachmentFileType != null)
                    hashCode = hashCode * 59 + AttachmentFileType.GetHashCode();
                if (AttachmentId != null)
                    hashCode = hashCode * 59 + AttachmentId.GetHashCode();
                if (AttachmentType != null)
                    hashCode = hashCode * 59 + AttachmentType.GetHashCode();
                if (BusObId != null)
                    hashCode = hashCode * 59 + BusObId.GetHashCode();
                if (BusObRecId != null)
                    hashCode = hashCode * 59 + BusObRecId.GetHashCode();
                if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                if (Created != null)
                    hashCode = hashCode * 59 + Created.GetHashCode();
                if (DisplayText != null)
                    hashCode = hashCode * 59 + DisplayText.GetHashCode();
                if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                if (Owner != null)
                    hashCode = hashCode * 59 + Owner.GetHashCode();
                if (Scope != null)
                    hashCode = hashCode * 59 + Scope.GetHashCode();
                if (ScopeOwner != null)
                    hashCode = hashCode * 59 + ScopeOwner.GetHashCode();
                if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
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
