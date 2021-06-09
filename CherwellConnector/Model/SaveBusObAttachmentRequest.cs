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
    /// SaveBusObAttachmentRequest
    /// </summary>
    [DataContract]
    public sealed class SaveBusObAttachmentRequest :  IEquatable<SaveBusObAttachmentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveBusObAttachmentRequest" /> class.
        /// </summary>
        /// <param name="attachBusObId">attachBusObId.</param>
        /// <param name="attachBusObName">attachBusObName.</param>
        /// <param name="attachBusObPublicId">attachBusObPublicId.</param>
        /// <param name="attachBusObRecId">attachBusObRecId.</param>
        /// <param name="busObId">busObId.</param>
        /// <param name="busObName">busObName.</param>
        /// <param name="busObPublicId">busObPublicId.</param>
        /// <param name="busObRecId">busObRecId.</param>
        /// <param name="comment">comment.</param>
        /// <param name="includeLinks">includeLinks.</param>
        public SaveBusObAttachmentRequest(string attachBusObId = default, string attachBusObName = default, string attachBusObPublicId = default, string attachBusObRecId = default, string busObId = default, string busObName = default, string busObPublicId = default, string busObRecId = default, string comment = default, bool? includeLinks = default)
        {
            AttachBusObId = attachBusObId;
            AttachBusObName = attachBusObName;
            AttachBusObPublicId = attachBusObPublicId;
            AttachBusObRecId = attachBusObRecId;
            BusObId = busObId;
            BusObName = busObName;
            BusObPublicId = busObPublicId;
            BusObRecId = busObRecId;
            Comment = comment;
            IncludeLinks = includeLinks;
        }
        
        /// <summary>
        /// Gets or Sets AttachBusObId
        /// </summary>
        [DataMember(Name="attachBusObId", EmitDefaultValue=false)]
        public string AttachBusObId { get; set; }

        /// <summary>
        /// Gets or Sets AttachBusObName
        /// </summary>
        [DataMember(Name="attachBusObName", EmitDefaultValue=false)]
        public string AttachBusObName { get; set; }

        /// <summary>
        /// Gets or Sets AttachBusObPublicId
        /// </summary>
        [DataMember(Name="attachBusObPublicId", EmitDefaultValue=false)]
        public string AttachBusObPublicId { get; set; }

        /// <summary>
        /// Gets or Sets AttachBusObRecId
        /// </summary>
        [DataMember(Name="attachBusObRecId", EmitDefaultValue=false)]
        public string AttachBusObRecId { get; set; }

        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }

        /// <summary>
        /// Gets or Sets BusObName
        /// </summary>
        [DataMember(Name="busObName", EmitDefaultValue=false)]
        public string BusObName { get; set; }

        /// <summary>
        /// Gets or Sets BusObPublicId
        /// </summary>
        [DataMember(Name="busObPublicId", EmitDefaultValue=false)]
        public string BusObPublicId { get; set; }

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
        /// Gets or Sets IncludeLinks
        /// </summary>
        [DataMember(Name="includeLinks", EmitDefaultValue=false)]
        public bool? IncludeLinks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveBusObAttachmentRequest {\n");
            sb.Append("  AttachBusObId: ").Append(AttachBusObId).Append("\n");
            sb.Append("  AttachBusObName: ").Append(AttachBusObName).Append("\n");
            sb.Append("  AttachBusObPublicId: ").Append(AttachBusObPublicId).Append("\n");
            sb.Append("  AttachBusObRecId: ").Append(AttachBusObRecId).Append("\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObName: ").Append(BusObName).Append("\n");
            sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  IncludeLinks: ").Append(IncludeLinks).Append("\n");
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
            return Equals(input as SaveBusObAttachmentRequest);
        }

        /// <summary>
        /// Returns true if SaveBusObAttachmentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveBusObAttachmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveBusObAttachmentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    AttachBusObId == input.AttachBusObId ||
                    (AttachBusObId != null &&
                    AttachBusObId.Equals(input.AttachBusObId))
                ) && 
                (
                    AttachBusObName == input.AttachBusObName ||
                    (AttachBusObName != null &&
                    AttachBusObName.Equals(input.AttachBusObName))
                ) && 
                (
                    AttachBusObPublicId == input.AttachBusObPublicId ||
                    (AttachBusObPublicId != null &&
                    AttachBusObPublicId.Equals(input.AttachBusObPublicId))
                ) && 
                (
                    AttachBusObRecId == input.AttachBusObRecId ||
                    (AttachBusObRecId != null &&
                    AttachBusObRecId.Equals(input.AttachBusObRecId))
                ) && 
                (
                    BusObId == input.BusObId ||
                    (BusObId != null &&
                    BusObId.Equals(input.BusObId))
                ) && 
                (
                    BusObName == input.BusObName ||
                    (BusObName != null &&
                    BusObName.Equals(input.BusObName))
                ) && 
                (
                    BusObPublicId == input.BusObPublicId ||
                    (BusObPublicId != null &&
                    BusObPublicId.Equals(input.BusObPublicId))
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
                    IncludeLinks == input.IncludeLinks ||
                    (IncludeLinks != null &&
                    IncludeLinks.Equals(input.IncludeLinks))
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
                if (AttachBusObId != null)
                    hashCode = hashCode * 59 + AttachBusObId.GetHashCode();
                if (AttachBusObName != null)
                    hashCode = hashCode * 59 + AttachBusObName.GetHashCode();
                if (AttachBusObPublicId != null)
                    hashCode = hashCode * 59 + AttachBusObPublicId.GetHashCode();
                if (AttachBusObRecId != null)
                    hashCode = hashCode * 59 + AttachBusObRecId.GetHashCode();
                if (BusObId != null)
                    hashCode = hashCode * 59 + BusObId.GetHashCode();
                if (BusObName != null)
                    hashCode = hashCode * 59 + BusObName.GetHashCode();
                if (BusObPublicId != null)
                    hashCode = hashCode * 59 + BusObPublicId.GetHashCode();
                if (BusObRecId != null)
                    hashCode = hashCode * 59 + BusObRecId.GetHashCode();
                if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                if (IncludeLinks != null)
                    hashCode = hashCode * 59 + IncludeLinks.GetHashCode();
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
