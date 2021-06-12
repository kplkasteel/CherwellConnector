
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
    /// QuickSearchSpecificByIdRequest
    /// </summary>
    [DataContract]
    public sealed class QuickSearchSpecificByIdRequest :  IEquatable<QuickSearchSpecificByIdRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickSearchSpecificByIdRequest" /> class.
        /// </summary>
        /// <param name="busObIds">busObIds.</param>
        /// <param name="standIn">standIn.</param>
        /// <param name="ascending">ascending.</param>
        /// <param name="isBusObTarget">isBusObTarget.</param>
        /// <param name="nonFinalState">nonFinalState.</param>
        /// <param name="searchAnyWords">searchAnyWords.</param>
        /// <param name="searchAttachments">searchAttachments.</param>
        /// <param name="searchRelated">searchRelated.</param>
        /// <param name="searchText">searchText.</param>
        /// <param name="selectedChangedLimit">selectedChangedLimit.</param>
        /// <param name="selectedSortByFieldId">selectedSortByFieldId.</param>
        /// <param name="sortByRelevance">sortByRelevance.</param>
        /// <param name="specificSearchTargetId">specificSearchTargetId.</param>
        /// <param name="useSortBy">useSortBy.</param>
        public QuickSearchSpecificByIdRequest(List<string> busObIds = default, string standIn = default, bool? ascending = default, bool? isBusObTarget = default, bool? nonFinalState = default, bool? searchAnyWords = default, bool? searchAttachments = default, bool? searchRelated = default, string searchText = default, SearchesChangedLimit selectedChangedLimit = default, string selectedSortByFieldId = default, bool? sortByRelevance = default, string specificSearchTargetId = default, bool? useSortBy = default)
        {
            BusObIds = busObIds;
            StandIn = standIn;
            Ascending = ascending;
            IsBusObTarget = isBusObTarget;
            NonFinalState = nonFinalState;
            SearchAnyWords = searchAnyWords;
            SearchAttachments = searchAttachments;
            SearchRelated = searchRelated;
            SearchText = searchText;
            SelectedChangedLimit = selectedChangedLimit;
            SelectedSortByFieldId = selectedSortByFieldId;
            SortByRelevance = sortByRelevance;
            SpecificSearchTargetId = specificSearchTargetId;
            UseSortBy = useSortBy;
        }
        
        /// <summary>
        /// Gets or Sets BusObIds
        /// </summary>
        [DataMember(Name="busObIds", EmitDefaultValue=false)]
        public List<string> BusObIds { get; set; }

        /// <summary>
        /// Gets or Sets StandIn
        /// </summary>
        [DataMember(Name="standIn", EmitDefaultValue=false)]
        public string StandIn { get; set; }

        /// <summary>
        /// Gets or Sets Ascending
        /// </summary>
        [DataMember(Name="ascending", EmitDefaultValue=false)]
        public bool? Ascending { get; set; }

        /// <summary>
        /// Gets or Sets IsBusObTarget
        /// </summary>
        [DataMember(Name="isBusObTarget", EmitDefaultValue=false)]
        public bool? IsBusObTarget { get; set; }

        /// <summary>
        /// Gets or Sets NonFinalState
        /// </summary>
        [DataMember(Name="nonFinalState", EmitDefaultValue=false)]
        public bool? NonFinalState { get; set; }

        /// <summary>
        /// Gets or Sets SearchAnyWords
        /// </summary>
        [DataMember(Name="searchAnyWords", EmitDefaultValue=false)]
        public bool? SearchAnyWords { get; set; }

        /// <summary>
        /// Gets or Sets SearchAttachments
        /// </summary>
        [DataMember(Name="searchAttachments", EmitDefaultValue=false)]
        public bool? SearchAttachments { get; set; }

        /// <summary>
        /// Gets or Sets SearchRelated
        /// </summary>
        [DataMember(Name="searchRelated", EmitDefaultValue=false)]
        public bool? SearchRelated { get; set; }

        /// <summary>
        /// Gets or Sets SearchText
        /// </summary>
        [DataMember(Name="searchText", EmitDefaultValue=false)]
        public string SearchText { get; set; }

        /// <summary>
        /// Gets or Sets SelectedChangedLimit
        /// </summary>
        [DataMember(Name="selectedChangedLimit", EmitDefaultValue=false)]
        public SearchesChangedLimit SelectedChangedLimit { get; set; }

        /// <summary>
        /// Gets or Sets SelectedSortByFieldId
        /// </summary>
        [DataMember(Name="selectedSortByFieldId", EmitDefaultValue=false)]
        public string SelectedSortByFieldId { get; set; }

        /// <summary>
        /// Gets or Sets SortByRelevance
        /// </summary>
        [DataMember(Name="sortByRelevance", EmitDefaultValue=false)]
        public bool? SortByRelevance { get; set; }

        /// <summary>
        /// Gets or Sets SpecificSearchTargetId
        /// </summary>
        [DataMember(Name="specificSearchTargetId", EmitDefaultValue=false)]
        public string SpecificSearchTargetId { get; set; }

        /// <summary>
        /// Gets or Sets UseSortBy
        /// </summary>
        [DataMember(Name="useSortBy", EmitDefaultValue=false)]
        public bool? UseSortBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuickSearchSpecificByIdRequest {\n");
            sb.Append("  BusObIds: ").Append(BusObIds).Append("\n");
            sb.Append("  StandIn: ").Append(StandIn).Append("\n");
            sb.Append("  Ascending: ").Append(Ascending).Append("\n");
            sb.Append("  IsBusObTarget: ").Append(IsBusObTarget).Append("\n");
            sb.Append("  NonFinalState: ").Append(NonFinalState).Append("\n");
            sb.Append("  SearchAnyWords: ").Append(SearchAnyWords).Append("\n");
            sb.Append("  SearchAttachments: ").Append(SearchAttachments).Append("\n");
            sb.Append("  SearchRelated: ").Append(SearchRelated).Append("\n");
            sb.Append("  SearchText: ").Append(SearchText).Append("\n");
            sb.Append("  SelectedChangedLimit: ").Append(SelectedChangedLimit).Append("\n");
            sb.Append("  SelectedSortByFieldId: ").Append(SelectedSortByFieldId).Append("\n");
            sb.Append("  SortByRelevance: ").Append(SortByRelevance).Append("\n");
            sb.Append("  SpecificSearchTargetId: ").Append(SpecificSearchTargetId).Append("\n");
            sb.Append("  UseSortBy: ").Append(UseSortBy).Append("\n");
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
            return Equals(input as QuickSearchSpecificByIdRequest);
        }

        /// <summary>
        /// Returns true if QuickSearchSpecificByIdRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of QuickSearchSpecificByIdRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuickSearchSpecificByIdRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    BusObIds == input.BusObIds ||
                    BusObIds != null &&
                    BusObIds.SequenceEqual(input.BusObIds)
                ) && 
                (
                    StandIn == input.StandIn ||
                    (StandIn != null &&
                    StandIn.Equals(input.StandIn))
                ) && 
                (
                    Ascending == input.Ascending ||
                    (Ascending != null &&
                    Ascending.Equals(input.Ascending))
                ) && 
                (
                    IsBusObTarget == input.IsBusObTarget ||
                    (IsBusObTarget != null &&
                    IsBusObTarget.Equals(input.IsBusObTarget))
                ) && 
                (
                    NonFinalState == input.NonFinalState ||
                    (NonFinalState != null &&
                    NonFinalState.Equals(input.NonFinalState))
                ) && 
                (
                    SearchAnyWords == input.SearchAnyWords ||
                    (SearchAnyWords != null &&
                    SearchAnyWords.Equals(input.SearchAnyWords))
                ) && 
                (
                    SearchAttachments == input.SearchAttachments ||
                    (SearchAttachments != null &&
                    SearchAttachments.Equals(input.SearchAttachments))
                ) && 
                (
                    SearchRelated == input.SearchRelated ||
                    (SearchRelated != null &&
                    SearchRelated.Equals(input.SearchRelated))
                ) && 
                (
                    SearchText == input.SearchText ||
                    (SearchText != null &&
                    SearchText.Equals(input.SearchText))
                ) && 
                (
                    SelectedChangedLimit == input.SelectedChangedLimit ||
                    (SelectedChangedLimit != null &&
                    SelectedChangedLimit.Equals(input.SelectedChangedLimit))
                ) && 
                (
                    SelectedSortByFieldId == input.SelectedSortByFieldId ||
                    (SelectedSortByFieldId != null &&
                    SelectedSortByFieldId.Equals(input.SelectedSortByFieldId))
                ) && 
                (
                    SortByRelevance == input.SortByRelevance ||
                    (SortByRelevance != null &&
                    SortByRelevance.Equals(input.SortByRelevance))
                ) && 
                (
                    SpecificSearchTargetId == input.SpecificSearchTargetId ||
                    (SpecificSearchTargetId != null &&
                    SpecificSearchTargetId.Equals(input.SpecificSearchTargetId))
                ) && 
                (
                    UseSortBy == input.UseSortBy ||
                    (UseSortBy != null &&
                    UseSortBy.Equals(input.UseSortBy))
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
                if (BusObIds != null)
                    hashCode = hashCode * 59 + BusObIds.GetHashCode();
                if (StandIn != null)
                    hashCode = hashCode * 59 + StandIn.GetHashCode();
                if (Ascending != null)
                    hashCode = hashCode * 59 + Ascending.GetHashCode();
                if (IsBusObTarget != null)
                    hashCode = hashCode * 59 + IsBusObTarget.GetHashCode();
                if (NonFinalState != null)
                    hashCode = hashCode * 59 + NonFinalState.GetHashCode();
                if (SearchAnyWords != null)
                    hashCode = hashCode * 59 + SearchAnyWords.GetHashCode();
                if (SearchAttachments != null)
                    hashCode = hashCode * 59 + SearchAttachments.GetHashCode();
                if (SearchRelated != null)
                    hashCode = hashCode * 59 + SearchRelated.GetHashCode();
                if (SearchText != null)
                    hashCode = hashCode * 59 + SearchText.GetHashCode();
                if (SelectedChangedLimit != null)
                    hashCode = hashCode * 59 + SelectedChangedLimit.GetHashCode();
                if (SelectedSortByFieldId != null)
                    hashCode = hashCode * 59 + SelectedSortByFieldId.GetHashCode();
                if (SortByRelevance != null)
                    hashCode = hashCode * 59 + SortByRelevance.GetHashCode();
                if (SpecificSearchTargetId != null)
                    hashCode = hashCode * 59 + SpecificSearchTargetId.GetHashCode();
                if (UseSortBy != null)
                    hashCode = hashCode * 59 + UseSortBy.GetHashCode();
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
