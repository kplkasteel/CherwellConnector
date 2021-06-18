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
    ///     SearchResultsTableResponse
    /// </summary>
    [DataContract]
    public sealed class SearchResultsTableResponse : IEquatable<SearchResultsTableResponse>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SearchResultsTableResponse" /> class.
        /// </summary>
        /// <param name="columns">columns.</param>
        /// <param name="rows">rows.</param>
        /// <param name="sorting">sorting.</param>
        /// <param name="totalRows">totalRows.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public SearchResultsTableResponse(List<SearchesField> columns = default, List<SearchResultsRow> rows = default,
            List<SortInfo> sorting = default, long? totalRows = default, string errorCode = default,
            string errorMessage = default, bool? hasError = default, HttpStatusCodeEnum? httpStatusCode = default)
        {
            Columns = columns;
            Rows = rows;
            Sorting = sorting;
            TotalRows = totalRows;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            HasError = hasError;
            HttpStatusCode = httpStatusCode;
        }


        /// <summary>
        ///     Gets or Sets HttpStatusCode
        /// </summary>
        [DataMember(Name = "httpStatusCode", EmitDefaultValue = false)]
        public HttpStatusCodeEnum? HttpStatusCode { get; set; }

        /// <summary>
        ///     Gets or Sets Columns
        /// </summary>
        [DataMember(Name = "columns", EmitDefaultValue = false)]
        public List<SearchesField> Columns { get; set; }

        /// <summary>
        ///     Gets or Sets Rows
        /// </summary>
        [DataMember(Name = "rows", EmitDefaultValue = false)]
        public List<SearchResultsRow> Rows { get; set; }

        /// <summary>
        ///     Gets or Sets Sorting
        /// </summary>
        [DataMember(Name = "sorting", EmitDefaultValue = false)]
        public List<SortInfo> Sorting { get; set; }

        /// <summary>
        ///     Gets or Sets TotalRows
        /// </summary>
        [DataMember(Name = "totalRows", EmitDefaultValue = false)]
        public long? TotalRows { get; set; }

        /// <summary>
        ///     Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        ///     Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        ///     Gets or Sets HasError
        /// </summary>
        [DataMember(Name = "hasError", EmitDefaultValue = false)]
        public bool? HasError { get; set; }

        /// <summary>
        ///     Returns true if SearchResultsTableResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchResultsTableResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResultsTableResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    Columns == input.Columns ||
                    Columns != null &&
                    Columns.SequenceEqual(input.Columns)
                ) &&
                (
                    Rows == input.Rows ||
                    Rows != null &&
                    Rows.SequenceEqual(input.Rows)
                ) &&
                (
                    Sorting == input.Sorting ||
                    Sorting != null &&
                    Sorting.SequenceEqual(input.Sorting)
                ) &&
                (
                    TotalRows == input.TotalRows ||
                    TotalRows != null &&
                    TotalRows.Equals(input.TotalRows)
                ) &&
                (
                    ErrorCode == input.ErrorCode ||
                    ErrorCode != null &&
                    ErrorCode.Equals(input.ErrorCode)
                ) &&
                (
                    ErrorMessage == input.ErrorMessage ||
                    ErrorMessage != null &&
                    ErrorMessage.Equals(input.ErrorMessage)
                ) &&
                (
                    HasError == input.HasError ||
                    HasError != null &&
                    HasError.Equals(input.HasError)
                ) &&
                (
                    HttpStatusCode == input.HttpStatusCode ||
                    HttpStatusCode != null &&
                    HttpStatusCode.Equals(input.HttpStatusCode)
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
            sb.Append("class SearchResultsTableResponse {\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
            sb.Append("  Sorting: ").Append(Sorting).Append("\n");
            sb.Append("  TotalRows: ").Append(TotalRows).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  HasError: ").Append(HasError).Append("\n");
            sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append("\n");
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
            return Equals(input as SearchResultsTableResponse);
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
                if (Columns != null)
                    hashCode = hashCode * 59 + Columns.GetHashCode();
                if (Rows != null)
                    hashCode = hashCode * 59 + Rows.GetHashCode();
                if (Sorting != null)
                    hashCode = hashCode * 59 + Sorting.GetHashCode();
                if (TotalRows != null)
                    hashCode = hashCode * 59 + TotalRows.GetHashCode();
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
    }
}