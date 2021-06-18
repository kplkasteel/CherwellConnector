using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using CherwellConnector.Enum;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     AttachmentsRequest
    /// </summary>
    [DataContract]
    public sealed class AttachmentsRequest : IEquatable<AttachmentsRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AttachmentsRequest" /> class.
        /// </summary>
        /// <param name="attachmentId">attachmentId.</param>
        /// <param name="attachmentTypes">attachmentTypes.</param>
        /// <param name="busObId">busObId.</param>
        /// <param name="busObName">busObName.</param>
        /// <param name="busObPublicId">busObPublicId.</param>
        /// <param name="busObRecId">busObRecId.</param>
        /// <param name="includeLinks">includeLinks.</param>
        /// <param name="types">types.</param>
        public AttachmentsRequest(string attachmentId = default, List<AttachmentTypeEnum> attachmentTypes = default,
            string busObId = default, string busObName = default, string busObPublicId = default,
            string busObRecId = default, bool? includeLinks = default, List<TypeEnum> types = default)
        {
            AttachmentId = attachmentId;
            AttachmentTypes = attachmentTypes;
            BusObId = busObId;
            BusObName = busObName;
            BusObPublicId = busObPublicId;
            BusObRecId = busObRecId;
            IncludeLinks = includeLinks;
            Types = types;
        }

        /// <summary>
        ///     Gets or Sets AttachmentTypes
        /// </summary>
        [DataMember(Name = "attachmentTypes", EmitDefaultValue = false)]
        public List<AttachmentTypeEnum> AttachmentTypes { get; set; }

        /// <summary>
        ///     Gets or Sets Types
        /// </summary>
        [DataMember(Name = "types", EmitDefaultValue = false)]
        public List<TypeEnum> Types { get; set; }

        /// <summary>
        ///     Gets or Sets AttachmentId
        /// </summary>
        [DataMember(Name = "attachmentId", EmitDefaultValue = false)]
        public string AttachmentId { get; set; }


        /// <summary>
        ///     Gets or Sets BusObId
        /// </summary>
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }

        /// <summary>
        ///     Gets or Sets BusObName
        /// </summary>
        [DataMember(Name = "busObName", EmitDefaultValue = false)]
        public string BusObName { get; set; }

        /// <summary>
        ///     Gets or Sets BusObPublicId
        /// </summary>
        [DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
        public string BusObPublicId { get; set; }

        /// <summary>
        ///     Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
        public string BusObRecId { get; set; }

        /// <summary>
        ///     Gets or Sets IncludeLinks
        /// </summary>
        [DataMember(Name = "includeLinks", EmitDefaultValue = false)]
        public bool? IncludeLinks { get; set; }

        /// <summary>
        ///     Returns true if AttachmentsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachmentsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentsRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    AttachmentId == input.AttachmentId ||
                    AttachmentId != null &&
                    AttachmentId.Equals(input.AttachmentId)
                ) &&
                (
                    AttachmentTypes == input.AttachmentTypes ||
                    AttachmentTypes != null &&
                    AttachmentTypes.SequenceEqual(input.AttachmentTypes)
                ) &&
                (
                    BusObId == input.BusObId ||
                    BusObId != null &&
                    BusObId.Equals(input.BusObId)
                ) &&
                (
                    BusObName == input.BusObName ||
                    BusObName != null &&
                    BusObName.Equals(input.BusObName)
                ) &&
                (
                    BusObPublicId == input.BusObPublicId ||
                    BusObPublicId != null &&
                    BusObPublicId.Equals(input.BusObPublicId)
                ) &&
                (
                    BusObRecId == input.BusObRecId ||
                    BusObRecId != null &&
                    BusObRecId.Equals(input.BusObRecId)
                ) &&
                (
                    IncludeLinks == input.IncludeLinks ||
                    IncludeLinks != null &&
                    IncludeLinks.Equals(input.IncludeLinks)
                ) &&
                (
                    Types == input.Types ||
                    Types != null &&
                    Types.SequenceEqual(input.Types)
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
            sb.Append("class AttachmentsRequest {\n");
            sb.Append("  AttachmentId: ").Append(AttachmentId).Append("\n");
            sb.Append("  AttachmentTypes: ").Append(AttachmentTypes).Append("\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObName: ").Append(BusObName).Append("\n");
            sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  IncludeLinks: ").Append(IncludeLinks).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
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
            return Equals(input as AttachmentsRequest);
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
                if (AttachmentId != null)
                    hashCode = hashCode * 59 + AttachmentId.GetHashCode();
                if (AttachmentTypes != null)
                    hashCode = hashCode * 59 + AttachmentTypes.GetHashCode();
                if (BusObId != null)
                    hashCode = hashCode * 59 + BusObId.GetHashCode();
                if (BusObName != null)
                    hashCode = hashCode * 59 + BusObName.GetHashCode();
                if (BusObPublicId != null)
                    hashCode = hashCode * 59 + BusObPublicId.GetHashCode();
                if (BusObRecId != null)
                    hashCode = hashCode * 59 + BusObRecId.GetHashCode();
                if (IncludeLinks != null)
                    hashCode = hashCode * 59 + IncludeLinks.GetHashCode();
                if (Types != null)
                    hashCode = hashCode * 59 + Types.GetHashCode();
                return hashCode;
            }
        }
    }
}