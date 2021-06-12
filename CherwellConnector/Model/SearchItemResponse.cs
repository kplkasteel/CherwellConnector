
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
    /// SearchItemResponse
    /// </summary>
    [DataContract]
    public sealed class SearchItemResponse :  IEquatable<SearchItemResponse>, IValidatableObject
    {
        

        /// <summary>
        /// Gets or Sets HttpStatusCode
        /// </summary>
        [DataMember(Name="httpStatusCode", EmitDefaultValue=false)]
        public HttpStatusCodeEnum? HttpStatusCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchItemResponse" /> class.
        /// </summary>
        /// <param name="root">root.</param>
        /// <param name="supportedAssociations">supportedAssociations.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public SearchItemResponse(SearchesSearchFolder root = default, List<SearchesAssociation> supportedAssociations = default, string errorCode = default, string errorMessage = default, bool? hasError = default, HttpStatusCodeEnum? httpStatusCode = default)
        {
            Root = root;
            SupportedAssociations = supportedAssociations;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            HasError = hasError;
            HttpStatusCode = httpStatusCode;
        }
        
        /// <summary>
        /// Gets or Sets Root
        /// </summary>
        [DataMember(Name="root", EmitDefaultValue=false)]
        public SearchesSearchFolder Root { get; set; }

        /// <summary>
        /// Gets or Sets SupportedAssociations
        /// </summary>
        [DataMember(Name="supportedAssociations", EmitDefaultValue=false)]
        public List<SearchesAssociation> SupportedAssociations { get; set; }

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
            sb.Append("class SearchItemResponse {\n");
            sb.Append("  Root: ").Append(Root).Append("\n");
            sb.Append("  SupportedAssociations: ").Append(SupportedAssociations).Append("\n");
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
            return Equals(input as SearchItemResponse);
        }

        /// <summary>
        /// Returns true if SearchItemResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchItemResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchItemResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    Root == input.Root ||
                    (Root != null &&
                    Root.Equals(input.Root))
                ) && 
                (
                    SupportedAssociations == input.SupportedAssociations ||
                    SupportedAssociations != null &&
                    SupportedAssociations.SequenceEqual(input.SupportedAssociations)
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
                if (Root != null)
                    hashCode = hashCode * 59 + Root.GetHashCode();
                if (SupportedAssociations != null)
                    hashCode = hashCode * 59 + SupportedAssociations.GetHashCode();
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
