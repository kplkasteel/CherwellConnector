
using CherwellConnector.Enum;

namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// QuickSearchResponse
    /// </summary>
    [DataContract]
    public sealed class QuickSearchResponse :  IEquatable<QuickSearchResponse>, IValidatableObject
    {
       

        /// <summary>
        /// Gets or Sets HttpStatusCode
        /// </summary>
        [DataMember(Name="httpStatusCode", EmitDefaultValue=false)]
        public HttpStatusCodeEnum? HttpStatusCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickSearchResponse" /> class.
        /// </summary>
        /// <param name="searchResultsTable">searchResultsTable.</param>
        /// <param name="simpleResultsList">simpleResultsList.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public QuickSearchResponse(SearchResultsTableResponse searchResultsTable = default, SimpleResultsList simpleResultsList = default, string errorCode = default, string errorMessage = default, bool? hasError = default, HttpStatusCodeEnum? httpStatusCode = default)
        {
            SearchResultsTable = searchResultsTable;
            SimpleResultsList = simpleResultsList;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            HasError = hasError;
            HttpStatusCode = httpStatusCode;
        }
        
        /// <summary>
        /// Gets or Sets SearchResultsTable
        /// </summary>
        [DataMember(Name="searchResultsTable", EmitDefaultValue=false)]
        public SearchResultsTableResponse SearchResultsTable { get; set; }

        /// <summary>
        /// Gets or Sets SimpleResultsList
        /// </summary>
        [DataMember(Name="simpleResultsList", EmitDefaultValue=false)]
        public SimpleResultsList SimpleResultsList { get; set; }

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
            sb.Append("class QuickSearchResponse {\n");
            sb.Append("  SearchResultsTable: ").Append(SearchResultsTable).Append("\n");
            sb.Append("  SimpleResultsList: ").Append(SimpleResultsList).Append("\n");
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
            return Equals(input as QuickSearchResponse);
        }

        /// <summary>
        /// Returns true if QuickSearchResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of QuickSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuickSearchResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    SearchResultsTable == input.SearchResultsTable ||
                    (SearchResultsTable != null &&
                    SearchResultsTable.Equals(input.SearchResultsTable))
                ) && 
                (
                    SimpleResultsList == input.SimpleResultsList ||
                    (SimpleResultsList != null &&
                    SimpleResultsList.Equals(input.SimpleResultsList))
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
                if (SearchResultsTable != null)
                    hashCode = hashCode * 59 + SearchResultsTable.GetHashCode();
                if (SimpleResultsList != null)
                    hashCode = hashCode * 59 + SimpleResultsList.GetHashCode();
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
