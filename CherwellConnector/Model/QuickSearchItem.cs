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
    ///     QuickSearchItem
    /// </summary>
    [DataContract]
    public sealed class QuickSearchItem : IEquatable<QuickSearchItem>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="QuickSearchItem" /> class.
        /// </summary>
        /// <param name="ascending">ascending.</param>
        /// <param name="changedLimits">changedLimits.</param>
        /// <param name="changedOption">changedOption.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="galleryImage">galleryImage.</param>
        /// <param name="hasAnyOptions">hasAnyOptions.</param>
        /// <param name="nonFinalStateOption">nonFinalStateOption.</param>
        /// <param name="searchAnyWordsOption">searchAnyWordsOption.</param>
        /// <param name="searchAttachmentsOption">searchAttachmentsOption.</param>
        /// <param name="searchRelatedOption">searchRelatedOption.</param>
        /// <param name="searchTargetId">searchTargetId.</param>
        /// <param name="searchTargetType">searchTargetType.</param>
        /// <param name="selectedChangedLimit">selectedChangedLimit.</param>
        /// <param name="selectedSortByFieldId">selectedSortByFieldId.</param>
        /// <param name="sortByFields">sortByFields.</param>
        /// <param name="sortByOption">sortByOption.</param>
        /// <param name="watermarkText">watermarkText.</param>
        public QuickSearchItem(bool? ascending = default, List<SearchesChangedLimit> changedLimits = default,
            ChangedOptionEnum? changedOption = default, string displayName = default, string galleryImage = default,
            bool? hasAnyOptions = default, NonFinalStateOptionEnum? nonFinalStateOption = default,
            SearchAnyWordsOptionEnum? searchAnyWordsOption = default,
            SearchAttachmentsOptionEnum? searchAttachmentsOption = default,
            SearchRelatedOptionEnum? searchRelatedOption = default, string searchTargetId = default,
            SearchTargetTypeEnum? searchTargetType = default, SearchesChangedLimit selectedChangedLimit = default,
            string selectedSortByFieldId = default, Dictionary<string, string> sortByFields = default,
            SortByOptionEnum? sortByOption = default, string watermarkText = default)
        {
            Ascending = ascending;
            ChangedLimits = changedLimits;
            ChangedOption = changedOption;
            DisplayName = displayName;
            GalleryImage = galleryImage;
            HasAnyOptions = hasAnyOptions;
            NonFinalStateOption = nonFinalStateOption;
            SearchAnyWordsOption = searchAnyWordsOption;
            SearchAttachmentsOption = searchAttachmentsOption;
            SearchRelatedOption = searchRelatedOption;
            SearchTargetId = searchTargetId;
            SearchTargetType = searchTargetType;
            SelectedChangedLimit = selectedChangedLimit;
            SelectedSortByFieldId = selectedSortByFieldId;
            SortByFields = sortByFields;
            SortByOption = sortByOption;
            WatermarkText = watermarkText;
        }

        /// <summary>
        ///     Gets or Sets ChangedOption
        /// </summary>
        [DataMember(Name = "changedOption", EmitDefaultValue = false)]
        public ChangedOptionEnum? ChangedOption { get; set; }

        /// <summary>
        ///     Gets or Sets NonFinalStateOption
        /// </summary>
        [DataMember(Name = "nonFinalStateOption", EmitDefaultValue = false)]
        public NonFinalStateOptionEnum? NonFinalStateOption { get; set; }

        /// <summary>
        ///     Gets or Sets SearchAnyWordsOption
        /// </summary>
        [DataMember(Name = "searchAnyWordsOption", EmitDefaultValue = false)]
        public SearchAnyWordsOptionEnum? SearchAnyWordsOption { get; set; }

        /// <summary>
        ///     Gets or Sets SearchAttachmentsOption
        /// </summary>
        [DataMember(Name = "searchAttachmentsOption", EmitDefaultValue = false)]
        public SearchAttachmentsOptionEnum? SearchAttachmentsOption { get; set; }

        /// <summary>
        ///     Gets or Sets SearchRelatedOption
        /// </summary>
        [DataMember(Name = "searchRelatedOption", EmitDefaultValue = false)]
        public SearchRelatedOptionEnum? SearchRelatedOption { get; set; }

        /// <summary>
        ///     Gets or Sets SearchTargetType
        /// </summary>
        [DataMember(Name = "searchTargetType", EmitDefaultValue = false)]
        public SearchTargetTypeEnum? SearchTargetType { get; set; }

        /// <summary>
        ///     Gets or Sets SortByOption
        /// </summary>
        [DataMember(Name = "sortByOption", EmitDefaultValue = false)]
        public SortByOptionEnum? SortByOption { get; set; }

        /// <summary>
        ///     Gets or Sets Ascending
        /// </summary>
        [DataMember(Name = "ascending", EmitDefaultValue = false)]
        public bool? Ascending { get; set; }

        /// <summary>
        ///     Gets or Sets ChangedLimits
        /// </summary>
        [DataMember(Name = "changedLimits", EmitDefaultValue = false)]
        public List<SearchesChangedLimit> ChangedLimits { get; set; }


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
        ///     Gets or Sets HasAnyOptions
        /// </summary>
        [DataMember(Name = "hasAnyOptions", EmitDefaultValue = false)]
        public bool? HasAnyOptions { get; set; }

        /// <summary>
        ///     Gets or Sets SearchTargetId
        /// </summary>
        [DataMember(Name = "searchTargetId", EmitDefaultValue = false)]
        public string SearchTargetId { get; set; }


        /// <summary>
        ///     Gets or Sets SelectedChangedLimit
        /// </summary>
        [DataMember(Name = "selectedChangedLimit", EmitDefaultValue = false)]
        public SearchesChangedLimit SelectedChangedLimit { get; set; }

        /// <summary>
        ///     Gets or Sets SelectedSortByFieldId
        /// </summary>
        [DataMember(Name = "selectedSortByFieldId", EmitDefaultValue = false)]
        public string SelectedSortByFieldId { get; set; }

        /// <summary>
        ///     Gets or Sets SortByFields
        /// </summary>
        [DataMember(Name = "sortByFields", EmitDefaultValue = false)]
        public Dictionary<string, string> SortByFields { get; set; }


        /// <summary>
        ///     Gets or Sets WatermarkText
        /// </summary>
        [DataMember(Name = "watermarkText", EmitDefaultValue = false)]
        public string WatermarkText { get; set; }

        /// <summary>
        ///     Returns true if QuickSearchItem instances are equal
        /// </summary>
        /// <param name="input">Instance of QuickSearchItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuickSearchItem input)
        {
            if (input == null)
                return false;

            return
                (
                    Ascending == input.Ascending ||
                    Ascending != null &&
                    Ascending.Equals(input.Ascending)
                ) &&
                (
                    ChangedLimits == input.ChangedLimits ||
                    ChangedLimits != null &&
                    ChangedLimits.SequenceEqual(input.ChangedLimits)
                ) &&
                (
                    ChangedOption == input.ChangedOption ||
                    ChangedOption != null &&
                    ChangedOption.Equals(input.ChangedOption)
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
                    HasAnyOptions == input.HasAnyOptions ||
                    HasAnyOptions != null &&
                    HasAnyOptions.Equals(input.HasAnyOptions)
                ) &&
                (
                    NonFinalStateOption == input.NonFinalStateOption ||
                    NonFinalStateOption != null &&
                    NonFinalStateOption.Equals(input.NonFinalStateOption)
                ) &&
                (
                    SearchAnyWordsOption == input.SearchAnyWordsOption ||
                    SearchAnyWordsOption != null &&
                    SearchAnyWordsOption.Equals(input.SearchAnyWordsOption)
                ) &&
                (
                    SearchAttachmentsOption == input.SearchAttachmentsOption ||
                    SearchAttachmentsOption != null &&
                    SearchAttachmentsOption.Equals(input.SearchAttachmentsOption)
                ) &&
                (
                    SearchRelatedOption == input.SearchRelatedOption ||
                    SearchRelatedOption != null &&
                    SearchRelatedOption.Equals(input.SearchRelatedOption)
                ) &&
                (
                    SearchTargetId == input.SearchTargetId ||
                    SearchTargetId != null &&
                    SearchTargetId.Equals(input.SearchTargetId)
                ) &&
                (
                    SearchTargetType == input.SearchTargetType ||
                    SearchTargetType != null &&
                    SearchTargetType.Equals(input.SearchTargetType)
                ) &&
                (
                    SelectedChangedLimit == input.SelectedChangedLimit ||
                    SelectedChangedLimit != null &&
                    SelectedChangedLimit.Equals(input.SelectedChangedLimit)
                ) &&
                (
                    SelectedSortByFieldId == input.SelectedSortByFieldId ||
                    SelectedSortByFieldId != null &&
                    SelectedSortByFieldId.Equals(input.SelectedSortByFieldId)
                ) &&
                (
                    SortByFields == input.SortByFields ||
                    SortByFields != null &&
                    SortByFields.SequenceEqual(input.SortByFields)
                ) &&
                (
                    SortByOption == input.SortByOption ||
                    SortByOption != null &&
                    SortByOption.Equals(input.SortByOption)
                ) &&
                (
                    WatermarkText == input.WatermarkText ||
                    WatermarkText != null &&
                    WatermarkText.Equals(input.WatermarkText)
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
            sb.Append("class QuickSearchItem {\n");
            sb.Append("  Ascending: ").Append(Ascending).Append("\n");
            sb.Append("  ChangedLimits: ").Append(ChangedLimits).Append("\n");
            sb.Append("  ChangedOption: ").Append(ChangedOption).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  GalleryImage: ").Append(GalleryImage).Append("\n");
            sb.Append("  HasAnyOptions: ").Append(HasAnyOptions).Append("\n");
            sb.Append("  NonFinalStateOption: ").Append(NonFinalStateOption).Append("\n");
            sb.Append("  SearchAnyWordsOption: ").Append(SearchAnyWordsOption).Append("\n");
            sb.Append("  SearchAttachmentsOption: ").Append(SearchAttachmentsOption).Append("\n");
            sb.Append("  SearchRelatedOption: ").Append(SearchRelatedOption).Append("\n");
            sb.Append("  SearchTargetId: ").Append(SearchTargetId).Append("\n");
            sb.Append("  SearchTargetType: ").Append(SearchTargetType).Append("\n");
            sb.Append("  SelectedChangedLimit: ").Append(SelectedChangedLimit).Append("\n");
            sb.Append("  SelectedSortByFieldId: ").Append(SelectedSortByFieldId).Append("\n");
            sb.Append("  SortByFields: ").Append(SortByFields).Append("\n");
            sb.Append("  SortByOption: ").Append(SortByOption).Append("\n");
            sb.Append("  WatermarkText: ").Append(WatermarkText).Append("\n");
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
            return Equals(input as QuickSearchItem);
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
                if (Ascending != null)
                    hashCode = hashCode * 59 + Ascending.GetHashCode();
                if (ChangedLimits != null)
                    hashCode = hashCode * 59 + ChangedLimits.GetHashCode();
                if (ChangedOption != null)
                    hashCode = hashCode * 59 + ChangedOption.GetHashCode();
                if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                if (GalleryImage != null)
                    hashCode = hashCode * 59 + GalleryImage.GetHashCode();
                if (HasAnyOptions != null)
                    hashCode = hashCode * 59 + HasAnyOptions.GetHashCode();
                if (NonFinalStateOption != null)
                    hashCode = hashCode * 59 + NonFinalStateOption.GetHashCode();
                if (SearchAnyWordsOption != null)
                    hashCode = hashCode * 59 + SearchAnyWordsOption.GetHashCode();
                if (SearchAttachmentsOption != null)
                    hashCode = hashCode * 59 + SearchAttachmentsOption.GetHashCode();
                if (SearchRelatedOption != null)
                    hashCode = hashCode * 59 + SearchRelatedOption.GetHashCode();
                if (SearchTargetId != null)
                    hashCode = hashCode * 59 + SearchTargetId.GetHashCode();
                if (SearchTargetType != null)
                    hashCode = hashCode * 59 + SearchTargetType.GetHashCode();
                if (SelectedChangedLimit != null)
                    hashCode = hashCode * 59 + SelectedChangedLimit.GetHashCode();
                if (SelectedSortByFieldId != null)
                    hashCode = hashCode * 59 + SelectedSortByFieldId.GetHashCode();
                if (SortByFields != null)
                    hashCode = hashCode * 59 + SortByFields.GetHashCode();
                if (SortByOption != null)
                    hashCode = hashCode * 59 + SortByOption.GetHashCode();
                if (WatermarkText != null)
                    hashCode = hashCode * 59 + WatermarkText.GetHashCode();
                return hashCode;
            }
        }
    }
}