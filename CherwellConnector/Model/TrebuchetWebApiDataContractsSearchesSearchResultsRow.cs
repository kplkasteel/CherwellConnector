/* 
 * 
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

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
    /// TrebuchetWebApiDataContractsSearchesSearchResultsRow
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsSearchesSearchResultsRow :  IEquatable<TrebuchetWebApiDataContractsSearchesSearchResultsRow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsSearchesSearchResultsRow" /> class.
        /// </summary>
        /// <param name="busObId">busObId.</param>
        /// <param name="busObRecId">busObRecId.</param>
        /// <param name="links">links.</param>
        /// <param name="publicId">publicId.</param>
        /// <param name="rowColor">rowColor.</param>
        /// <param name="searchResultsFieldValues">searchResultsFieldValues.</param>
        public TrebuchetWebApiDataContractsSearchesSearchResultsRow(string busObId = default(string), string busObRecId = default(string), List<TrebuchetWebApiDataContractsCoreLink> links = default(List<TrebuchetWebApiDataContractsCoreLink>), string publicId = default(string), string rowColor = default(string), List<TrebuchetWebApiDataContractsBusinessObjectFieldTemplateItem> searchResultsFieldValues = default(List<TrebuchetWebApiDataContractsBusinessObjectFieldTemplateItem>))
        {
            this.BusObId = busObId;
            this.BusObRecId = busObRecId;
            this.Links = links;
            this.PublicId = publicId;
            this.RowColor = rowColor;
            this.SearchResultsFieldValues = searchResultsFieldValues;
        }
        
        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }

        /// <summary>
        /// Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name="busObRecId", EmitDefaultValue=false)]
        public string BusObRecId { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<TrebuchetWebApiDataContractsCoreLink> Links { get; set; }

        /// <summary>
        /// Gets or Sets PublicId
        /// </summary>
        [DataMember(Name="publicId", EmitDefaultValue=false)]
        public string PublicId { get; set; }

        /// <summary>
        /// Gets or Sets RowColor
        /// </summary>
        [DataMember(Name="rowColor", EmitDefaultValue=false)]
        public string RowColor { get; set; }

        /// <summary>
        /// Gets or Sets SearchResultsFieldValues
        /// </summary>
        [DataMember(Name="searchResultsFieldValues", EmitDefaultValue=false)]
        public List<TrebuchetWebApiDataContractsBusinessObjectFieldTemplateItem> SearchResultsFieldValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsSearchesSearchResultsRow {\n");
            sb.Append("  BusObId: ").Append(this.BusObId).Append("\n");
            sb.Append("  BusObRecId: ").Append(this.BusObRecId).Append("\n");
            sb.Append("  Links: ").Append(this.Links).Append("\n");
            sb.Append("  PublicId: ").Append(this.PublicId).Append("\n");
            sb.Append("  RowColor: ").Append(this.RowColor).Append("\n");
            sb.Append("  SearchResultsFieldValues: ").Append(this.SearchResultsFieldValues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as TrebuchetWebApiDataContractsSearchesSearchResultsRow);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsSearchesSearchResultsRow instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsSearchesSearchResultsRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsSearchesSearchResultsRow input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BusObId == input.BusObId ||
                    (this.BusObId != null &&
                    this.BusObId.Equals(input.BusObId))
                ) && 
                (
                    this.BusObRecId == input.BusObRecId ||
                    (this.BusObRecId != null &&
                    this.BusObRecId.Equals(input.BusObRecId))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.PublicId == input.PublicId ||
                    (this.PublicId != null &&
                    this.PublicId.Equals(input.PublicId))
                ) && 
                (
                    this.RowColor == input.RowColor ||
                    (this.RowColor != null &&
                    this.RowColor.Equals(input.RowColor))
                ) && 
                (
                    this.SearchResultsFieldValues == input.SearchResultsFieldValues ||
                    this.SearchResultsFieldValues != null &&
                    this.SearchResultsFieldValues.SequenceEqual(input.SearchResultsFieldValues)
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
                int hashCode = 41;
                if (this.BusObId != null)
                    hashCode = hashCode * 59 + this.BusObId.GetHashCode();
                if (this.BusObRecId != null)
                    hashCode = hashCode * 59 + this.BusObRecId.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.PublicId != null)
                    hashCode = hashCode * 59 + this.PublicId.GetHashCode();
                if (this.RowColor != null)
                    hashCode = hashCode * 59 + this.RowColor.GetHashCode();
                if (this.SearchResultsFieldValues != null)
                    hashCode = hashCode * 59 + this.SearchResultsFieldValues.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
