
using CherwellConnector.Enum;

namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// SearchResultsResponse
    /// </summary>
    [DataContract]
    public sealed class SearchResultsResponse :  IEquatable<SearchResultsResponse>, IValidatableObject
    {
        

        /// <summary>
        /// Gets or Sets HttpStatusCode
        /// </summary>
        [DataMember(Name="httpStatusCode", EmitDefaultValue=false)]
        public HttpStatusCodeEnum? HttpStatusCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultsResponse" /> class.
        /// </summary>
        /// <param name="businessObjects">businessObjects.</param>
        /// <param name="hasPrompts">hasPrompts.</param>
        /// <param name="links">links.</param>
        /// <param name="prompts">prompts.</param>
        /// <param name="searchResultsFields">searchResultsFields.</param>
        /// <param name="simpleResults">simpleResults.</param>
        /// <param name="totalRows">totalRows.</param>
        /// <param name="hasMoreRecords">hasMoreRecords.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public SearchResultsResponse(List<ReadResponse> businessObjects = default, bool? hasPrompts = default, List<Link> links = default, List<Prompt> prompts = default, List<SearchesField> searchResultsFields = default, SimpleResultsList simpleResults = default, long? totalRows = default, bool? hasMoreRecords = default, string errorCode = default, string errorMessage = default, bool? hasError = default, HttpStatusCodeEnum? httpStatusCode = default)
        {
            BusinessObjects = businessObjects;
            HasPrompts = hasPrompts;
            Links = links;
            Prompts = prompts;
            SearchResultsFields = searchResultsFields;
            SimpleResults = simpleResults;
            TotalRows = totalRows;
            HasMoreRecords = hasMoreRecords;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            HasError = hasError;
            HttpStatusCode = httpStatusCode;
        }
        
        /// <summary>
        /// Gets or Sets BusinessObjects
        /// </summary>
        [DataMember(Name="businessObjects", EmitDefaultValue=false)]
        public List<ReadResponse> BusinessObjects { get; set; }

        /// <summary>
        /// Gets or Sets HasPrompts
        /// </summary>
        [DataMember(Name="hasPrompts", EmitDefaultValue=false)]
        public bool? HasPrompts { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets or Sets Prompts
        /// </summary>
        [DataMember(Name="prompts", EmitDefaultValue=false)]
        public List<Prompt> Prompts { get; set; }

        /// <summary>
        /// Gets or Sets SearchResultsFields
        /// </summary>
        [DataMember(Name="searchResultsFields", EmitDefaultValue=false)]
        public List<SearchesField> SearchResultsFields { get; set; }

        /// <summary>
        /// Gets or Sets SimpleResults
        /// </summary>
        [DataMember(Name="simpleResults", EmitDefaultValue=false)]
        public SimpleResultsList SimpleResults { get; set; }

        /// <summary>
        /// Gets or Sets TotalRows
        /// </summary>
        [DataMember(Name="totalRows", EmitDefaultValue=false)]
        public long? TotalRows { get; set; }

        /// <summary>
        /// Gets or Sets HasMoreRecords
        /// </summary>
        [DataMember(Name="hasMoreRecords", EmitDefaultValue=false)]
        public bool? HasMoreRecords { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets HasError
        /// </summary>
        [DataMember(Name="hasError", EmitDefaultValue=false)]
        public bool? HasError { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchResultsResponse {\n");
            sb.Append("  BusinessObjects: ").Append(BusinessObjects).Append("\n");
            sb.Append("  HasPrompts: ").Append(HasPrompts).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Prompts: ").Append(Prompts).Append("\n");
            sb.Append("  SearchResultsFields: ").Append(SearchResultsFields).Append("\n");
            sb.Append("  SimpleResults: ").Append(SimpleResults).Append("\n");
            sb.Append("  TotalRows: ").Append(TotalRows).Append("\n");
            sb.Append("  HasMoreRecords: ").Append(HasMoreRecords).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  HasError: ").Append(HasError).Append("\n");
            sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append("\n");
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
            return Equals(input as SearchResultsResponse);
        }

        /// <summary>
        /// Returns true if SearchResultsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchResultsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResultsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    BusinessObjects == input.BusinessObjects ||
                    BusinessObjects != null &&
                    BusinessObjects.SequenceEqual(input.BusinessObjects)
                ) && 
                (
                    HasPrompts == input.HasPrompts ||
                    (HasPrompts != null &&
                    HasPrompts.Equals(input.HasPrompts))
                ) && 
                (
                    Links == input.Links ||
                    Links != null &&
                    Links.SequenceEqual(input.Links)
                ) && 
                (
                    Prompts == input.Prompts ||
                    Prompts != null &&
                    Prompts.SequenceEqual(input.Prompts)
                ) && 
                (
                    SearchResultsFields == input.SearchResultsFields ||
                    SearchResultsFields != null &&
                    SearchResultsFields.SequenceEqual(input.SearchResultsFields)
                ) && 
                (
                    SimpleResults == input.SimpleResults ||
                    (SimpleResults != null &&
                    SimpleResults.Equals(input.SimpleResults))
                ) && 
                (
                    TotalRows == input.TotalRows ||
                    (TotalRows != null &&
                    TotalRows.Equals(input.TotalRows))
                ) && 
                (
                    HasMoreRecords == input.HasMoreRecords ||
                    (HasMoreRecords != null &&
                    HasMoreRecords.Equals(input.HasMoreRecords))
                ) && 
                (
                    ErrorCode == input.ErrorCode ||
                    (ErrorCode != null &&
                    ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    ErrorMessage == input.ErrorMessage ||
                    (ErrorMessage != null &&
                    ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    HasError == input.HasError ||
                    (HasError != null &&
                    HasError.Equals(input.HasError))
                ) && 
                (
                    HttpStatusCode == input.HttpStatusCode ||
                    (HttpStatusCode != null &&
                    HttpStatusCode.Equals(input.HttpStatusCode))
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
                if (BusinessObjects != null)
                    hashCode = hashCode * 59 + BusinessObjects.GetHashCode();
                if (HasPrompts != null)
                    hashCode = hashCode * 59 + HasPrompts.GetHashCode();
                if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                if (Prompts != null)
                    hashCode = hashCode * 59 + Prompts.GetHashCode();
                if (SearchResultsFields != null)
                    hashCode = hashCode * 59 + SearchResultsFields.GetHashCode();
                if (SimpleResults != null)
                    hashCode = hashCode * 59 + SimpleResults.GetHashCode();
                if (TotalRows != null)
                    hashCode = hashCode * 59 + TotalRows.GetHashCode();
                if (HasMoreRecords != null)
                    hashCode = hashCode * 59 + HasMoreRecords.GetHashCode();
                if (ErrorCode != null)
                    hashCode = hashCode * 59 + ErrorCode.GetHashCode();
                if (ErrorMessage != null)
                    hashCode = hashCode * 59 + ErrorMessage.GetHashCode();
                if (HasError != null)
                    hashCode = hashCode * 59 + HasError.GetHashCode();
                if (HttpStatusCode != null)
                    hashCode = hashCode * 59 + HttpStatusCode.GetHashCode();
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
