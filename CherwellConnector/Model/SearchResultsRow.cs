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
    ///     SearchResultsRow
    /// </summary>
    [DataContract]
    public sealed class SearchResultsRow : IEquatable<SearchResultsRow>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SearchResultsRow" /> class.
        /// </summary>
        /// <param name="busObId">busObId.</param>
        /// <param name="busObRecId">busObRecId.</param>
        /// <param name="links">links.</param>
        /// <param name="publicId">publicId.</param>
        /// <param name="rowColor">rowColor.</param>
        /// <param name="searchResultsFieldValues">searchResultsFieldValues.</param>
        public SearchResultsRow(string busObId = default, string busObRecId = default, List<Link> links = default,
            string publicId = default, string rowColor = default,
            List<FieldTemplateItem> searchResultsFieldValues = default)
        {
            BusObId = busObId;
            BusObRecId = busObRecId;
            Links = links;
            PublicId = publicId;
            RowColor = rowColor;
            SearchResultsFieldValues = searchResultsFieldValues;
        }

        /// <summary>
        ///     Gets or Sets BusObId
        /// </summary>
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }

        /// <summary>
        ///     Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
        public string BusObRecId { get; set; }

        /// <summary>
        ///     Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<Link> Links { get; set; }

        /// <summary>
        ///     Gets or Sets PublicId
        /// </summary>
        [DataMember(Name = "publicId", EmitDefaultValue = false)]
        public string PublicId { get; set; }

        /// <summary>
        ///     Gets or Sets RowColor
        /// </summary>
        [DataMember(Name = "rowColor", EmitDefaultValue = false)]
        public string RowColor { get; set; }

        /// <summary>
        ///     Gets or Sets SearchResultsFieldValues
        /// </summary>
        [DataMember(Name = "searchResultsFieldValues", EmitDefaultValue = false)]
        public List<FieldTemplateItem> SearchResultsFieldValues { get; set; }

        /// <summary>
        ///     Returns true if SearchResultsRow instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchResultsRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResultsRow input)
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
                    BusObRecId == input.BusObRecId ||
                    BusObRecId != null &&
                    BusObRecId.Equals(input.BusObRecId)
                ) &&
                (
                    Links == input.Links ||
                    Links != null &&
                    Links.SequenceEqual(input.Links)
                ) &&
                (
                    PublicId == input.PublicId ||
                    PublicId != null &&
                    PublicId.Equals(input.PublicId)
                ) &&
                (
                    RowColor == input.RowColor ||
                    RowColor != null &&
                    RowColor.Equals(input.RowColor)
                ) &&
                (
                    SearchResultsFieldValues == input.SearchResultsFieldValues ||
                    SearchResultsFieldValues != null &&
                    SearchResultsFieldValues.SequenceEqual(input.SearchResultsFieldValues)
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
            sb.Append("class SearchResultsRow {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  PublicId: ").Append(PublicId).Append("\n");
            sb.Append("  RowColor: ").Append(RowColor).Append("\n");
            sb.Append("  SearchResultsFieldValues: ").Append(SearchResultsFieldValues).Append("\n");
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
            return Equals(input as SearchResultsRow);
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
                if (BusObRecId != null)
                    hashCode = hashCode * 59 + BusObRecId.GetHashCode();
                if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                if (PublicId != null)
                    hashCode = hashCode * 59 + PublicId.GetHashCode();
                if (RowColor != null)
                    hashCode = hashCode * 59 + RowColor.GetHashCode();
                if (SearchResultsFieldValues != null)
                    hashCode = hashCode * 59 + SearchResultsFieldValues.GetHashCode();
                return hashCode;
            }
        }
    }
}