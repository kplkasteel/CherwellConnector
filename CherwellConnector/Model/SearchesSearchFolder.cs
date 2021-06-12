
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
    /// SearchesSearchFolder
    /// </summary>
    [DataContract]
    public sealed class SearchesSearchFolder :  IEquatable<SearchesSearchFolder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesSearchFolder" /> class.
        /// </summary>
        /// <param name="association">association.</param>
        /// <param name="childFolders">childFolders.</param>
        /// <param name="childItems">childItems.</param>
        /// <param name="folderId">folderId.</param>
        /// <param name="folderName">folderName.</param>
        /// <param name="links">links.</param>
        /// <param name="localizedScopeName">localizedScopeName.</param>
        /// <param name="parentFolderId">parentFolderId.</param>
        /// <param name="scope">scope.</param>
        /// <param name="scopeOwner">scopeOwner.</param>
        public SearchesSearchFolder(string association = default, List<SearchesSearchFolder> childFolders = default, List<SearchesSearchItem> childItems = default, string folderId = default, string folderName = default, List<Link> links = default, string localizedScopeName = default, string parentFolderId = default, string scope = default, string scopeOwner = default)
        {
            Association = association;
            ChildFolders = childFolders;
            ChildItems = childItems;
            FolderId = folderId;
            FolderName = folderName;
            Links = links;
            LocalizedScopeName = localizedScopeName;
            ParentFolderId = parentFolderId;
            Scope = scope;
            ScopeOwner = scopeOwner;
        }
        
        /// <summary>
        /// Gets or Sets Association
        /// </summary>
        [DataMember(Name="association", EmitDefaultValue=false)]
        public string Association { get; set; }

        /// <summary>
        /// Gets or Sets ChildFolders
        /// </summary>
        [DataMember(Name="childFolders", EmitDefaultValue=false)]
        public List<SearchesSearchFolder> ChildFolders { get; set; }

        /// <summary>
        /// Gets or Sets ChildItems
        /// </summary>
        [DataMember(Name="childItems", EmitDefaultValue=false)]
        public List<SearchesSearchItem> ChildItems { get; set; }

        /// <summary>
        /// Gets or Sets FolderId
        /// </summary>
        [DataMember(Name="folderId", EmitDefaultValue=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// Gets or Sets FolderName
        /// </summary>
        [DataMember(Name="folderName", EmitDefaultValue=false)]
        public string FolderName { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets or Sets LocalizedScopeName
        /// </summary>
        [DataMember(Name="localizedScopeName", EmitDefaultValue=false)]
        public string LocalizedScopeName { get; set; }

        /// <summary>
        /// Gets or Sets ParentFolderId
        /// </summary>
        [DataMember(Name="parentFolderId", EmitDefaultValue=false)]
        public string ParentFolderId { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }

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
            sb.Append("class SearchesSearchFolder {\n");
            sb.Append("  Association: ").Append(Association).Append("\n");
            sb.Append("  ChildFolders: ").Append(ChildFolders).Append("\n");
            sb.Append("  ChildItems: ").Append(ChildItems).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  FolderName: ").Append(FolderName).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  LocalizedScopeName: ").Append(LocalizedScopeName).Append("\n");
            sb.Append("  ParentFolderId: ").Append(ParentFolderId).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  string ToJson()
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
            return Equals(input as SearchesSearchFolder);
        }

        /// <summary>
        /// Returns true if SearchesSearchFolder instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchesSearchFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchesSearchFolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    Association == input.Association ||
                    (Association != null &&
                    Association.Equals(input.Association))
                ) && 
                (
                    ChildFolders == input.ChildFolders ||
                    ChildFolders != null &&
                    ChildFolders.SequenceEqual(input.ChildFolders)
                ) && 
                (
                    ChildItems == input.ChildItems ||
                    ChildItems != null &&
                    ChildItems.SequenceEqual(input.ChildItems)
                ) && 
                (
                    FolderId == input.FolderId ||
                    (FolderId != null &&
                    FolderId.Equals(input.FolderId))
                ) && 
                (
                    FolderName == input.FolderName ||
                    (FolderName != null &&
                    FolderName.Equals(input.FolderName))
                ) && 
                (
                    Links == input.Links ||
                    Links != null &&
                    Links.SequenceEqual(input.Links)
                ) && 
                (
                    LocalizedScopeName == input.LocalizedScopeName ||
                    (LocalizedScopeName != null &&
                    LocalizedScopeName.Equals(input.LocalizedScopeName))
                ) && 
                (
                    ParentFolderId == input.ParentFolderId ||
                    (ParentFolderId != null &&
                    ParentFolderId.Equals(input.ParentFolderId))
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
                if (Association != null)
                    hashCode = hashCode * 59 + Association.GetHashCode();
                if (ChildFolders != null)
                    hashCode = hashCode * 59 + ChildFolders.GetHashCode();
                if (ChildItems != null)
                    hashCode = hashCode * 59 + ChildItems.GetHashCode();
                if (FolderId != null)
                    hashCode = hashCode * 59 + FolderId.GetHashCode();
                if (FolderName != null)
                    hashCode = hashCode * 59 + FolderName.GetHashCode();
                if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                if (LocalizedScopeName != null)
                    hashCode = hashCode * 59 + LocalizedScopeName.GetHashCode();
                if (ParentFolderId != null)
                    hashCode = hashCode * 59 + ParentFolderId.GetHashCode();
                if (Scope != null)
                    hashCode = hashCode * 59 + Scope.GetHashCode();
                if (ScopeOwner != null)
                    hashCode = hashCode * 59 + ScopeOwner.GetHashCode();
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
