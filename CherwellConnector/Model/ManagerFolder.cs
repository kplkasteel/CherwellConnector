
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
    /// ManagerFolder
    /// </summary>
    [DataContract]
    public sealed class ManagerFolder :  IEquatable<ManagerFolder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagerFolder" /> class.
        /// </summary>
        /// <param name="association">association.</param>
        /// <param name="childFolders">childFolders.</param>
        /// <param name="childItems">childItems.</param>
        /// <param name="id">id.</param>
        /// <param name="links">links.</param>
        /// <param name="localizedScopeName">localizedScopeName.</param>
        /// <param name="name">name.</param>
        /// <param name="parentId">parentId.</param>
        /// <param name="scope">scope.</param>
        /// <param name="scopeOwner">scopeOwner.</param>
        public ManagerFolder(string association = default, List<ManagerFolder> childFolders = default, List<ManagerItem> childItems = default, string id = default, List<Link> links = default, string localizedScopeName = default, string name = default, string parentId = default, string scope = default, string scopeOwner = default)
        {
            Association = association;
            ChildFolders = childFolders;
            ChildItems = childItems;
            Id = id;
            Links = links;
            LocalizedScopeName = localizedScopeName;
            Name = name;
            ParentId = parentId;
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
        public List<ManagerFolder> ChildFolders { get; set; }

        /// <summary>
        /// Gets or Sets ChildItems
        /// </summary>
        [DataMember(Name="childItems", EmitDefaultValue=false)]
        public List<ManagerItem> ChildItems { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public string ParentId { get; set; }

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
            sb.Append("class ManagerFolder {\n");
            sb.Append("  Association: ").Append(Association).Append("\n");
            sb.Append("  ChildFolders: ").Append(ChildFolders).Append("\n");
            sb.Append("  ChildItems: ").Append(ChildItems).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  LocalizedScopeName: ").Append(LocalizedScopeName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append("\n");
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
            return Equals(input as ManagerFolder);
        }

        /// <summary>
        /// Returns true if ManagerFolder instances are equal
        /// </summary>
        /// <param name="input">Instance of ManagerFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagerFolder input)
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
                    Id == input.Id ||
                    (Id != null &&
                    Id.Equals(input.Id))
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
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    ParentId == input.ParentId ||
                    (ParentId != null &&
                    ParentId.Equals(input.ParentId))
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
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                if (LocalizedScopeName != null)
                    hashCode = hashCode * 59 + LocalizedScopeName.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (ParentId != null)
                    hashCode = hashCode * 59 + ParentId.GetHashCode();
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
