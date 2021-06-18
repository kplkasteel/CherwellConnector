using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     SaveLinkAttachmentRequest
    /// </summary>
    [DataContract]
    public sealed class SaveLinkAttachmentRequest : IEquatable<SaveLinkAttachmentRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SaveLinkAttachmentRequest" /> class.
        /// </summary>
        /// <param name="busObId">busObId.</param>
        /// <param name="busObName">busObName.</param>
        /// <param name="busObPublicId">busObPublicId.</param>
        /// <param name="busObRecId">busObRecId.</param>
        /// <param name="comment">comment.</param>
        /// <param name="displayText">displayText.</param>
        /// <param name="includeLinks">includeLinks.</param>
        /// <param name="uncFilePath">uncFilePath.</param>
        public SaveLinkAttachmentRequest(string busObId = default, string busObName = default,
            string busObPublicId = default, string busObRecId = default, string comment = default,
            string displayText = default, bool? includeLinks = default, string uncFilePath = default)
        {
            BusObId = busObId;
            BusObName = busObName;
            BusObPublicId = busObPublicId;
            BusObRecId = busObRecId;
            Comment = comment;
            DisplayText = displayText;
            IncludeLinks = includeLinks;
            UncFilePath = uncFilePath;
        }

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
        ///     Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        ///     Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name = "displayText", EmitDefaultValue = false)]
        public string DisplayText { get; set; }

        /// <summary>
        ///     Gets or Sets IncludeLinks
        /// </summary>
        [DataMember(Name = "includeLinks", EmitDefaultValue = false)]
        public bool? IncludeLinks { get; set; }

        /// <summary>
        ///     Gets or Sets UncFilePath
        /// </summary>
        [DataMember(Name = "uncFilePath", EmitDefaultValue = false)]
        public string UncFilePath { get; set; }

        /// <summary>
        ///     Returns true if SaveLinkAttachmentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveLinkAttachmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveLinkAttachmentRequest input)
        {
            if (input == null)
                return false;

            return
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
                    Comment == input.Comment ||
                    Comment != null &&
                    Comment.Equals(input.Comment)
                ) &&
                (
                    DisplayText == input.DisplayText ||
                    DisplayText != null &&
                    DisplayText.Equals(input.DisplayText)
                ) &&
                (
                    IncludeLinks == input.IncludeLinks ||
                    IncludeLinks != null &&
                    IncludeLinks.Equals(input.IncludeLinks)
                ) &&
                (
                    UncFilePath == input.UncFilePath ||
                    UncFilePath != null &&
                    UncFilePath.Equals(input.UncFilePath)
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
            sb.Append("class SaveLinkAttachmentRequest {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObName: ").Append(BusObName).Append("\n");
            sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  IncludeLinks: ").Append(IncludeLinks).Append("\n");
            sb.Append("  UncFilePath: ").Append(UncFilePath).Append("\n");
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
            return Equals(input as SaveLinkAttachmentRequest);
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
                if (DisplayText != null)
                    hashCode = hashCode * 59 + DisplayText.GetHashCode();
                if (IncludeLinks != null)
                    hashCode = hashCode * 59 + IncludeLinks.GetHashCode();
                if (UncFilePath != null)
                    hashCode = hashCode * 59 + UncFilePath.GetHashCode();
                return hashCode;
            }
        }
    }
}