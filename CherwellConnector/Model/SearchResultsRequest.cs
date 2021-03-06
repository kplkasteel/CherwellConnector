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
    ///     SearchResultsRequest
    /// </summary>
    [DataContract]
    public sealed class SearchResultsRequest : IEquatable<SearchResultsRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SearchResultsRequest" /> class.
        /// </summary>
        /// <param name="association">association.</param>
        /// <param name="associationName">associationName.</param>
        /// <param name="busObId">busObId.</param>
        /// <param name="customGridDefId">customGridDefId.</param>
        /// <param name="dateTimeFormatting">dateTimeFormatting.</param>
        /// <param name="fieldId">fieldId.</param>
        /// <param name="fields">fields.</param>
        /// <param name="filters">filters.</param>
        /// <param name="includeAllFields">includeAllFields.</param>
        /// <param name="includeSchema">includeSchema.</param>
        /// <param name="pageNumber">pageNumber.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="scope">scope.</param>
        /// <param name="scopeOwner">scopeOwner.</param>
        /// <param name="searchId">searchId.</param>
        /// <param name="searchName">searchName.</param>
        /// <param name="searchText">searchText.</param>
        /// <param name="sorting">sorting.</param>
        /// <param name="promptValues">promptValues.</param>
        public SearchResultsRequest(string association = default, string associationName = default,
            string busObId = default, string customGridDefId = default, string dateTimeFormatting = default,
            string fieldId = default, List<string> fields = default, List<FilterInfo> filters = default,
            bool? includeAllFields = default, bool? includeSchema = default, int? pageNumber = default,
            int? pageSize = default, string scope = default, string scopeOwner = default, string searchId = default,
            string searchName = default, string searchText = default, List<SortInfo> sorting = default,
            List<PromptValue> promptValues = default)
        {
            Association = association;
            AssociationName = associationName;
            BusObId = busObId;
            CustomGridDefId = customGridDefId;
            DateTimeFormatting = dateTimeFormatting;
            FieldId = fieldId;
            Fields = fields;
            Filters = filters;
            IncludeAllFields = includeAllFields;
            IncludeSchema = includeSchema;
            PageNumber = pageNumber;
            PageSize = pageSize;
            Scope = scope;
            ScopeOwner = scopeOwner;
            SearchId = searchId;
            SearchName = searchName;
            SearchText = searchText;
            Sorting = sorting;
            PromptValues = promptValues;
        }

        /// <summary>
        ///     Gets or Sets Association
        /// </summary>
        [DataMember(Name = "association", EmitDefaultValue = false)]
        public string Association { get; set; }

        /// <summary>
        ///     Gets or Sets AssociationName
        /// </summary>
        [DataMember(Name = "associationName", EmitDefaultValue = false)]
        public string AssociationName { get; set; }

        /// <summary>
        ///     Gets or Sets BusObId
        /// </summary>
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }

        /// <summary>
        ///     Gets or Sets CustomGridDefId
        /// </summary>
        [DataMember(Name = "customGridDefId", EmitDefaultValue = false)]
        public string CustomGridDefId { get; set; }

        /// <summary>
        ///     Gets or Sets DateTimeFormatting
        /// </summary>
        [DataMember(Name = "dateTimeFormatting", EmitDefaultValue = false)]
        public string DateTimeFormatting { get; set; }

        /// <summary>
        ///     Gets or Sets FieldId
        /// </summary>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }

        /// <summary>
        ///     Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public List<string> Fields { get; set; }

        /// <summary>
        ///     Gets or Sets Filters
        /// </summary>
        [DataMember(Name = "filters", EmitDefaultValue = false)]
        public List<FilterInfo> Filters { get; set; }

        /// <summary>
        ///     Gets or Sets IncludeAllFields
        /// </summary>
        [DataMember(Name = "includeAllFields", EmitDefaultValue = false)]
        public bool? IncludeAllFields { get; set; }

        /// <summary>
        ///     Gets or Sets IncludeSchema
        /// </summary>
        [DataMember(Name = "includeSchema", EmitDefaultValue = false)]
        public bool? IncludeSchema { get; set; }

        /// <summary>
        ///     Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
        public int? PageNumber { get; set; }

        /// <summary>
        ///     Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public int? PageSize { get; set; }

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
        ///     Gets or Sets SearchText
        /// </summary>
        [DataMember(Name = "searchText", EmitDefaultValue = false)]
        public string SearchText { get; set; }

        /// <summary>
        ///     Gets or Sets Sorting
        /// </summary>
        [DataMember(Name = "sorting", EmitDefaultValue = false)]
        public List<SortInfo> Sorting { get; set; }

        /// <summary>
        ///     Gets or Sets PromptValues
        /// </summary>
        [DataMember(Name = "promptValues", EmitDefaultValue = false)]
        public List<PromptValue> PromptValues { get; set; }

        /// <summary>
        ///     Returns true if SearchResultsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchResultsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResultsRequest input)
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
                    AssociationName == input.AssociationName ||
                    AssociationName != null &&
                    AssociationName.Equals(input.AssociationName)
                ) &&
                (
                    BusObId == input.BusObId ||
                    BusObId != null &&
                    BusObId.Equals(input.BusObId)
                ) &&
                (
                    CustomGridDefId == input.CustomGridDefId ||
                    CustomGridDefId != null &&
                    CustomGridDefId.Equals(input.CustomGridDefId)
                ) &&
                (
                    DateTimeFormatting == input.DateTimeFormatting ||
                    DateTimeFormatting != null &&
                    DateTimeFormatting.Equals(input.DateTimeFormatting)
                ) &&
                (
                    FieldId == input.FieldId ||
                    FieldId != null &&
                    FieldId.Equals(input.FieldId)
                ) &&
                (
                    Fields == input.Fields ||
                    Fields != null &&
                    Fields.SequenceEqual(input.Fields)
                ) &&
                (
                    Filters == input.Filters ||
                    Filters != null &&
                    Filters.SequenceEqual(input.Filters)
                ) &&
                (
                    IncludeAllFields == input.IncludeAllFields ||
                    IncludeAllFields != null &&
                    IncludeAllFields.Equals(input.IncludeAllFields)
                ) &&
                (
                    IncludeSchema == input.IncludeSchema ||
                    IncludeSchema != null &&
                    IncludeSchema.Equals(input.IncludeSchema)
                ) &&
                (
                    PageNumber == input.PageNumber ||
                    PageNumber != null &&
                    PageNumber.Equals(input.PageNumber)
                ) &&
                (
                    PageSize == input.PageSize ||
                    PageSize != null &&
                    PageSize.Equals(input.PageSize)
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
                ) &&
                (
                    SearchText == input.SearchText ||
                    SearchText != null &&
                    SearchText.Equals(input.SearchText)
                ) &&
                (
                    Sorting == input.Sorting ||
                    Sorting != null &&
                    Sorting.SequenceEqual(input.Sorting)
                ) &&
                (
                    PromptValues == input.PromptValues ||
                    PromptValues != null &&
                    PromptValues.SequenceEqual(input.PromptValues)
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
            sb.Append("class SearchResultsRequest {\n");
            sb.Append("  Association: ").Append(Association).Append("\n");
            sb.Append("  AssociationName: ").Append(AssociationName).Append("\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  CustomGridDefId: ").Append(CustomGridDefId).Append("\n");
            sb.Append("  DateTimeFormatting: ").Append(DateTimeFormatting).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  IncludeAllFields: ").Append(IncludeAllFields).Append("\n");
            sb.Append("  IncludeSchema: ").Append(IncludeSchema).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append("\n");
            sb.Append("  SearchId: ").Append(SearchId).Append("\n");
            sb.Append("  SearchName: ").Append(SearchName).Append("\n");
            sb.Append("  SearchText: ").Append(SearchText).Append("\n");
            sb.Append("  Sorting: ").Append(Sorting).Append("\n");
            sb.Append("  PromptValues: ").Append(PromptValues).Append("\n");
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
            return Equals(input as SearchResultsRequest);
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
                if (AssociationName != null)
                    hashCode = hashCode * 59 + AssociationName.GetHashCode();
                if (BusObId != null)
                    hashCode = hashCode * 59 + BusObId.GetHashCode();
                if (CustomGridDefId != null)
                    hashCode = hashCode * 59 + CustomGridDefId.GetHashCode();
                if (DateTimeFormatting != null)
                    hashCode = hashCode * 59 + DateTimeFormatting.GetHashCode();
                if (FieldId != null)
                    hashCode = hashCode * 59 + FieldId.GetHashCode();
                if (Fields != null)
                    hashCode = hashCode * 59 + Fields.GetHashCode();
                if (Filters != null)
                    hashCode = hashCode * 59 + Filters.GetHashCode();
                if (IncludeAllFields != null)
                    hashCode = hashCode * 59 + IncludeAllFields.GetHashCode();
                if (IncludeSchema != null)
                    hashCode = hashCode * 59 + IncludeSchema.GetHashCode();
                if (PageNumber != null)
                    hashCode = hashCode * 59 + PageNumber.GetHashCode();
                if (PageSize != null)
                    hashCode = hashCode * 59 + PageSize.GetHashCode();
                if (Scope != null)
                    hashCode = hashCode * 59 + Scope.GetHashCode();
                if (ScopeOwner != null)
                    hashCode = hashCode * 59 + ScopeOwner.GetHashCode();
                if (SearchId != null)
                    hashCode = hashCode * 59 + SearchId.GetHashCode();
                if (SearchName != null)
                    hashCode = hashCode * 59 + SearchName.GetHashCode();
                if (SearchText != null)
                    hashCode = hashCode * 59 + SearchText.GetHashCode();
                if (Sorting != null)
                    hashCode = hashCode * 59 + Sorting.GetHashCode();
                if (PromptValues != null)
                    hashCode = hashCode * 59 + PromptValues.GetHashCode();
                return hashCode;
            }
        }
    }
}