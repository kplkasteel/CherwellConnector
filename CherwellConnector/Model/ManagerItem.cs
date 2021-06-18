using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     ManagerItem
    /// </summary>
    [DataContract]
    public sealed class ManagerItem : IEquatable<ManagerItem>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ManagerItem" /> class.
        /// </summary>
        /// <param name="association">association.</param>
        /// <param name="description">description.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="galleryImage">galleryImage.</param>
        /// <param name="id">id.</param>
        /// <param name="links">links.</param>
        /// <param name="localizedScopeName">localizedScopeName.</param>
        /// <param name="name">name.</param>
        /// <param name="parentFolder">parentFolder.</param>
        /// <param name="parentIsScopeFolder">parentIsScopeFolder.</param>
        /// <param name="scope">scope.</param>
        /// <param name="scopeOwner">scopeOwner.</param>
        /// <param name="standInKey">standInKey.</param>
        public ManagerItem(string association = default, string description = default, string displayName = default,
            string galleryImage = default, string id = default, List<Link> links = default,
            string localizedScopeName = default, string name = default, string parentFolder = default,
            bool? parentIsScopeFolder = default, string scope = default, string scopeOwner = default,
            string standInKey = default)
        {
            Association = association;
            Description = description;
            DisplayName = displayName;
            GalleryImage = galleryImage;
            Id = id;
            Links = links;
            LocalizedScopeName = localizedScopeName;
            Name = name;
            ParentFolder = parentFolder;
            ParentIsScopeFolder = parentIsScopeFolder;
            Scope = scope;
            ScopeOwner = scopeOwner;
            StandInKey = standInKey;
        }

        /// <summary>
        ///     Gets or Sets Association
        /// </summary>
        [DataMember(Name = "association", EmitDefaultValue = false)]
        public string Association { get; set; }

        /// <summary>
        ///     Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        ///     Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        ///     Gets or Sets GalleryImage
        /// </summary>
        [DataMember(Name = "galleryImage", EmitDefaultValue = false)]
        public string GalleryImage { get; set; }

        /// <summary>
        ///     Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        ///     Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<Link> Links { get; set; }

        /// <summary>
        ///     Gets or Sets LocalizedScopeName
        /// </summary>
        [DataMember(Name = "localizedScopeName", EmitDefaultValue = false)]
        public string LocalizedScopeName { get; set; }

        /// <summary>
        ///     Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or Sets ParentFolder
        /// </summary>
        [DataMember(Name = "parentFolder", EmitDefaultValue = false)]
        public string ParentFolder { get; set; }

        /// <summary>
        ///     Gets or Sets ParentIsScopeFolder
        /// </summary>
        [DataMember(Name = "parentIsScopeFolder", EmitDefaultValue = false)]
        public bool? ParentIsScopeFolder { get; set; }

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
        ///     Returns true if ManagerItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ManagerItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagerItem input)
        {
            if (input == null)
                return false;

            return
                (
                    Association == input.Association ||
                    Association != null &&
                    Association.Equals(input.Association)
                ) &&
                (
                    Description == input.Description ||
                    Description != null &&
                    Description.Equals(input.Description)
                ) &&
                (
                    DisplayName == input.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(input.DisplayName)
                ) &&
                (
                    GalleryImage == input.GalleryImage ||
                    GalleryImage != null &&
                    GalleryImage.Equals(input.GalleryImage)
                ) &&
                (
                    Id == input.Id ||
                    Id != null &&
                    Id.Equals(input.Id)
                ) &&
                (
                    Links == input.Links ||
                    Links != null &&
                    Links.SequenceEqual(input.Links)
                ) &&
                (
                    LocalizedScopeName == input.LocalizedScopeName ||
                    LocalizedScopeName != null &&
                    LocalizedScopeName.Equals(input.LocalizedScopeName)
                ) &&
                (
                    Name == input.Name ||
                    Name != null &&
                    Name.Equals(input.Name)
                ) &&
                (
                    ParentFolder == input.ParentFolder ||
                    ParentFolder != null &&
                    ParentFolder.Equals(input.ParentFolder)
                ) &&
                (
                    ParentIsScopeFolder == input.ParentIsScopeFolder ||
                    ParentIsScopeFolder != null &&
                    ParentIsScopeFolder.Equals(input.ParentIsScopeFolder)
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
            sb.Append("class ManagerItem {\n");
            sb.Append("  Association: ").Append(Association).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  GalleryImage: ").Append(GalleryImage).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  LocalizedScopeName: ").Append(LocalizedScopeName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParentFolder: ").Append(ParentFolder).Append("\n");
            sb.Append("  ParentIsScopeFolder: ").Append(ParentIsScopeFolder).Append("\n");
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
            return Equals(input as ManagerItem);
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
                if (Association != null)
                    hashCode = hashCode * 59 + Association.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                if (GalleryImage != null)
                    hashCode = hashCode * 59 + GalleryImage.GetHashCode();
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                if (LocalizedScopeName != null)
                    hashCode = hashCode * 59 + LocalizedScopeName.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (ParentFolder != null)
                    hashCode = hashCode * 59 + ParentFolder.GetHashCode();
                if (ParentIsScopeFolder != null)
                    hashCode = hashCode * 59 + ParentIsScopeFolder.GetHashCode();
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