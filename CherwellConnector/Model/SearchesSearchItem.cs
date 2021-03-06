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
    ///     SearchesSearchItem
    /// </summary>
    [DataContract]
    public sealed class SearchesSearchItem : IEquatable<SearchesSearchItem>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SearchesSearchItem" /> class.
        /// </summary>
        /// <param name="association">association.</param>
        /// <param name="links">links.</param>
        /// <param name="localizedScopeName">localizedScopeName.</param>
        /// <param name="parentFolderId">parentFolderId.</param>
        /// <param name="scope">scope.</param>
        /// <param name="scopeOwner">scopeOwner.</param>
        /// <param name="searchId">searchId.</param>
        /// <param name="searchName">searchName.</param>
        public SearchesSearchItem(string association = default, List<Link> links = default,
            string localizedScopeName = default, string parentFolderId = default, string scope = default,
            string scopeOwner = default, string searchId = default, string searchName = default)
        {
            Association = association;
            Links = links;
            LocalizedScopeName = localizedScopeName;
            ParentFolderId = parentFolderId;
            Scope = scope;
            ScopeOwner = scopeOwner;
            SearchId = searchId;
            SearchName = searchName;
        }

        /// <summary>
        ///     Gets or Sets Association
        /// </summary>
        [DataMember(Name = "association", EmitDefaultValue = false)]
        public string Association { get; set; }

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
        ///     Gets or Sets ParentFolderId
        /// </summary>
        [DataMember(Name = "parentFolderId", EmitDefaultValue = false)]
        public string ParentFolderId { get; set; }

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
        ///     Gets or Sets SearchId
        /// </summary>
        [DataMember(Name = "searchId", EmitDefaultValue = false)]
        public string SearchId { get; set; }

        /// <summary>
        ///     Gets or Sets SearchName
        /// </summary>
        [DataMember(Name = "searchName", EmitDefaultValue = false)]
        public string SearchName { get; set; }

        /// <summary>
        ///     Returns true if SearchesSearchItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchesSearchItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchesSearchItem input)
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
                    ParentFolderId == input.ParentFolderId ||
                    ParentFolderId != null &&
                    ParentFolderId.Equals(input.ParentFolderId)
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
                    SearchId == input.SearchId ||
                    SearchId != null &&
                    SearchId.Equals(input.SearchId)
                ) &&
                (
                    SearchName == input.SearchName ||
                    SearchName != null &&
                    SearchName.Equals(input.SearchName)
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
            sb.Append("class SearchesSearchItem {\n");
            sb.Append("  Association: ").Append(Association).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  LocalizedScopeName: ").Append(LocalizedScopeName).Append("\n");
            sb.Append("  ParentFolderId: ").Append(ParentFolderId).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append("\n");
            sb.Append("  SearchId: ").Append(SearchId).Append("\n");
            sb.Append("  SearchName: ").Append(SearchName).Append("\n");
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
            return Equals(input as SearchesSearchItem);
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
                if (SearchId != null)
                    hashCode = hashCode * 59 + SearchId.GetHashCode();
                if (SearchName != null)
                    hashCode = hashCode * 59 + SearchName.GetHashCode();
                return hashCode;
            }
        }
    }
}