using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     StoredSearchRequest
    /// </summary>
    [DataContract]
    public sealed class StoredSearchRequest : IEquatable<StoredSearchRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="StoredSearchRequest" /> class.
        /// </summary>
        /// <param name="associationId">associationId.</param>
        /// <param name="associationName">associationName.</param>
        /// <param name="gridId">gridId.</param>
        /// <param name="includeSchema">includeSchema.</param>
        /// <param name="scope">scope.</param>
        /// <param name="scopeOwnerId">scopeOwnerId.</param>
        /// <param name="searchId">searchId.</param>
        /// <param name="searchName">searchName.</param>
        public StoredSearchRequest(string associationId = default, string associationName = default,
            string gridId = default, bool? includeSchema = default, string scope = default,
            string scopeOwnerId = default, string searchId = default, string searchName = default)
        {
            AssociationId = associationId;
            AssociationName = associationName;
            GridId = gridId;
            IncludeSchema = includeSchema;
            Scope = scope;
            ScopeOwnerId = scopeOwnerId;
            SearchId = searchId;
            SearchName = searchName;
        }

        /// <summary>
        ///     Gets or Sets AssociationId
        /// </summary>
        [DataMember(Name = "associationId", EmitDefaultValue = false)]
        public string AssociationId { get; set; }

        /// <summary>
        ///     Gets or Sets AssociationName
        /// </summary>
        [DataMember(Name = "associationName", EmitDefaultValue = false)]
        public string AssociationName { get; set; }

        /// <summary>
        ///     Gets or Sets GridId
        /// </summary>
        [DataMember(Name = "gridId", EmitDefaultValue = false)]
        public string GridId { get; set; }

        /// <summary>
        ///     Gets or Sets IncludeSchema
        /// </summary>
        [DataMember(Name = "includeSchema", EmitDefaultValue = false)]
        public bool? IncludeSchema { get; set; }

        /// <summary>
        ///     Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public string Scope { get; set; }

        /// <summary>
        ///     Gets or Sets ScopeOwnerId
        /// </summary>
        [DataMember(Name = "scopeOwnerId", EmitDefaultValue = false)]
        public string ScopeOwnerId { get; set; }

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
        ///     Returns true if StoredSearchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of StoredSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoredSearchRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    AssociationId == input.AssociationId ||
                    AssociationId != null &&
                    AssociationId.Equals(input.AssociationId)
                ) &&
                (
                    AssociationName == input.AssociationName ||
                    AssociationName != null &&
                    AssociationName.Equals(input.AssociationName)
                ) &&
                (
                    GridId == input.GridId ||
                    GridId != null &&
                    GridId.Equals(input.GridId)
                ) &&
                (
                    IncludeSchema == input.IncludeSchema ||
                    IncludeSchema != null &&
                    IncludeSchema.Equals(input.IncludeSchema)
                ) &&
                (
                    Scope == input.Scope ||
                    Scope != null &&
                    Scope.Equals(input.Scope)
                ) &&
                (
                    ScopeOwnerId == input.ScopeOwnerId ||
                    ScopeOwnerId != null &&
                    ScopeOwnerId.Equals(input.ScopeOwnerId)
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
            sb.Append("class StoredSearchRequest {\n");
            sb.Append("  AssociationId: ").Append(AssociationId).Append("\n");
            sb.Append("  AssociationName: ").Append(AssociationName).Append("\n");
            sb.Append("  GridId: ").Append(GridId).Append("\n");
            sb.Append("  IncludeSchema: ").Append(IncludeSchema).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ScopeOwnerId: ").Append(ScopeOwnerId).Append("\n");
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
            return Equals(input as StoredSearchRequest);
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
                if (AssociationId != null)
                    hashCode = hashCode * 59 + AssociationId.GetHashCode();
                if (AssociationName != null)
                    hashCode = hashCode * 59 + AssociationName.GetHashCode();
                if (GridId != null)
                    hashCode = hashCode * 59 + GridId.GetHashCode();
                if (IncludeSchema != null)
                    hashCode = hashCode * 59 + IncludeSchema.GetHashCode();
                if (Scope != null)
                    hashCode = hashCode * 59 + Scope.GetHashCode();
                if (ScopeOwnerId != null)
                    hashCode = hashCode * 59 + ScopeOwnerId.GetHashCode();
                if (SearchId != null)
                    hashCode = hashCode * 59 + SearchId.GetHashCode();
                if (SearchName != null)
                    hashCode = hashCode * 59 + SearchName.GetHashCode();
                return hashCode;
            }
        }
    }
}