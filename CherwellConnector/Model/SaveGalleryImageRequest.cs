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
    ///     SaveGalleryImageRequest
    /// </summary>
    [DataContract]
    public sealed class SaveGalleryImageRequest : IEquatable<SaveGalleryImageRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SaveGalleryImageRequest" /> class.
        /// </summary>
        /// <param name="base64EncodedImageData">base64EncodedImageData.</param>
        /// <param name="description">description.</param>
        /// <param name="folder">folder.</param>
        /// <param name="imageType">imageType.</param>
        /// <param name="name">name.</param>
        /// <param name="scope">scope.</param>
        /// <param name="scopeOwner">scopeOwner.</param>
        /// <param name="standInKey">standInKey.</param>
        public SaveGalleryImageRequest(string base64EncodedImageData = default, string description = default,
            string folder = default, ImageTypeEnum? imageType = default, string name = default, string scope = default,
            string scopeOwner = default, string standInKey = default)
        {
            Base64EncodedImageData = base64EncodedImageData;
            Description = description;
            Folder = folder;
            ImageType = imageType;
            Name = name;
            Scope = scope;
            ScopeOwner = scopeOwner;
            StandInKey = standInKey;
        }

        /// <summary>
        ///     Gets or Sets ImageType
        /// </summary>
        [DataMember(Name = "imageType", EmitDefaultValue = false)]
        public ImageTypeEnum? ImageType { get; set; }

        /// <summary>
        ///     Gets or Sets Base64EncodedImageData
        /// </summary>
        [DataMember(Name = "base64EncodedImageData", EmitDefaultValue = false)]
        public string Base64EncodedImageData { get; set; }

        /// <summary>
        ///     Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        ///     Gets or Sets Folder
        /// </summary>
        [DataMember(Name = "folder", EmitDefaultValue = false)]
        public string Folder { get; set; }


        /// <summary>
        ///     Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public string Scope { get; set; }

        /// <summary>
        ///     Gets or Sets ScopeOwner
        /// </summary>
        [DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
        public string ScopeOwner { get; set; }

        /// <summary>
        ///     Gets or Sets StandInKey
        /// </summary>
        [DataMember(Name = "standInKey", EmitDefaultValue = false)]
        public string StandInKey { get; set; }

        /// <summary>
        ///     Returns true if SaveGalleryImageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveGalleryImageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveGalleryImageRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    Base64EncodedImageData == input.Base64EncodedImageData ||
                    Base64EncodedImageData != null &&
                    Base64EncodedImageData.Equals(input.Base64EncodedImageData)
                ) &&
                (
                    Description == input.Description ||
                    Description != null &&
                    Description.Equals(input.Description)
                ) &&
                (
                    Folder == input.Folder ||
                    Folder != null &&
                    Folder.Equals(input.Folder)
                ) &&
                (
                    ImageType == input.ImageType ||
                    ImageType != null &&
                    ImageType.Equals(input.ImageType)
                ) &&
                (
                    Name == input.Name ||
                    Name != null &&
                    Name.Equals(input.Name)
                ) &&
                (
                    Scope == input.Scope ||
                    Scope != null &&
                    Scope.Equals(input.Scope)
                ) &&
                (
                    ScopeOwner == input.ScopeOwner ||
                    ScopeOwner != null &&
                    ScopeOwner.Equals(input.ScopeOwner)
                ) &&
                (
                    StandInKey == input.StandInKey ||
                    StandInKey != null &&
                    StandInKey.Equals(input.StandInKey)
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
            sb.Append("class SaveGalleryImageRequest {\n");
            sb.Append("  Base64EncodedImageData: ").Append(Base64EncodedImageData).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
            sb.Append("  ImageType: ").Append(ImageType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append("\n");
            sb.Append("  StandInKey: ").Append(StandInKey).Append("\n");
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
            return Equals(input as SaveGalleryImageRequest);
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
                if (Base64EncodedImageData != null)
                    hashCode = hashCode * 59 + Base64EncodedImageData.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (Folder != null)
                    hashCode = hashCode * 59 + Folder.GetHashCode();
                if (ImageType != null)
                    hashCode = hashCode * 59 + ImageType.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Scope != null)
                    hashCode = hashCode * 59 + Scope.GetHashCode();
                if (ScopeOwner != null)
                    hashCode = hashCode * 59 + ScopeOwner.GetHashCode();
                if (StandInKey != null)
                    hashCode = hashCode * 59 + StandInKey.GetHashCode();
                return hashCode;
            }
        }
    }
}