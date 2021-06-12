
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
    /// SearchesRelatedBusinessObjectResponse
    /// </summary>
    [DataContract]
    public sealed class SearchesRelatedBusinessObjectResponse :  IEquatable<SearchesRelatedBusinessObjectResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesRelatedBusinessObjectResponse" /> class.
        /// </summary>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="links">links.</param>
        /// <param name="pageNumber">pageNumber.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="parentBusObId">parentBusObId.</param>
        /// <param name="parentBusObPublicId">parentBusObPublicId.</param>
        /// <param name="parentBusObRecId">parentBusObRecId.</param>
        /// <param name="relatedBusinessObjects">relatedBusinessObjects.</param>
        /// <param name="relationshipId">relationshipId.</param>
        /// <param name="totalRecords">totalRecords.</param>
        public SearchesRelatedBusinessObjectResponse(string errorCode = default, string errorMessage = default, bool? hasError = default, List<Link> links = default, int? pageNumber = default, int? pageSize = default, string parentBusObId = default, string parentBusObPublicId = default, string parentBusObRecId = default, List<ReadResponse> relatedBusinessObjects = default, string relationshipId = default, int? totalRecords = default)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            HasError = hasError;
            Links = links;
            PageNumber = pageNumber;
            PageSize = pageSize;
            ParentBusObId = parentBusObId;
            ParentBusObPublicId = parentBusObPublicId;
            ParentBusObRecId = parentBusObRecId;
            RelatedBusinessObjects = relatedBusinessObjects;
            RelationshipId = relationshipId;
            TotalRecords = totalRecords;
        }
        
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
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or Sets ParentBusObId
        /// </summary>
        [DataMember(Name="parentBusObId", EmitDefaultValue=false)]
        public string ParentBusObId { get; set; }

        /// <summary>
        /// Gets or Sets ParentBusObPublicId
        /// </summary>
        [DataMember(Name="parentBusObPublicId", EmitDefaultValue=false)]
        public string ParentBusObPublicId { get; set; }

        /// <summary>
        /// Gets or Sets ParentBusObRecId
        /// </summary>
        [DataMember(Name="parentBusObRecId", EmitDefaultValue=false)]
        public string ParentBusObRecId { get; set; }

        /// <summary>
        /// Gets or Sets RelatedBusinessObjects
        /// </summary>
        [DataMember(Name="relatedBusinessObjects", EmitDefaultValue=false)]
        public List<ReadResponse> RelatedBusinessObjects { get; set; }

        /// <summary>
        /// Gets or Sets RelationshipId
        /// </summary>
        [DataMember(Name="relationshipId", EmitDefaultValue=false)]
        public string RelationshipId { get; set; }

        /// <summary>
        /// Gets or Sets TotalRecords
        /// </summary>
        [DataMember(Name="totalRecords", EmitDefaultValue=false)]
        public int? TotalRecords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchesRelatedBusinessObjectResponse {\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  HasError: ").Append(HasError).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  ParentBusObId: ").Append(ParentBusObId).Append("\n");
            sb.Append("  ParentBusObPublicId: ").Append(ParentBusObPublicId).Append("\n");
            sb.Append("  ParentBusObRecId: ").Append(ParentBusObRecId).Append("\n");
            sb.Append("  RelatedBusinessObjects: ").Append(RelatedBusinessObjects).Append("\n");
            sb.Append("  RelationshipId: ").Append(RelationshipId).Append("\n");
            sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
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
            return Equals(input as SearchesRelatedBusinessObjectResponse);
        }

        /// <summary>
        /// Returns true if SearchesRelatedBusinessObjectResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchesRelatedBusinessObjectResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchesRelatedBusinessObjectResponse input)
        {
            if (input == null)
                return false;

            return 
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
                    Links == input.Links ||
                    Links != null &&
                    Links.SequenceEqual(input.Links)
                ) && 
                (
                    PageNumber == input.PageNumber ||
                    (PageNumber != null &&
                    PageNumber.Equals(input.PageNumber))
                ) && 
                (
                    PageSize == input.PageSize ||
                    (PageSize != null &&
                    PageSize.Equals(input.PageSize))
                ) && 
                (
                    ParentBusObId == input.ParentBusObId ||
                    (ParentBusObId != null &&
                    ParentBusObId.Equals(input.ParentBusObId))
                ) && 
                (
                    ParentBusObPublicId == input.ParentBusObPublicId ||
                    (ParentBusObPublicId != null &&
                    ParentBusObPublicId.Equals(input.ParentBusObPublicId))
                ) && 
                (
                    ParentBusObRecId == input.ParentBusObRecId ||
                    (ParentBusObRecId != null &&
                    ParentBusObRecId.Equals(input.ParentBusObRecId))
                ) && 
                (
                    RelatedBusinessObjects == input.RelatedBusinessObjects ||
                    RelatedBusinessObjects != null &&
                    RelatedBusinessObjects.SequenceEqual(input.RelatedBusinessObjects)
                ) && 
                (
                    RelationshipId == input.RelationshipId ||
                    (RelationshipId != null &&
                    RelationshipId.Equals(input.RelationshipId))
                ) && 
                (
                    TotalRecords == input.TotalRecords ||
                    (TotalRecords != null &&
                    TotalRecords.Equals(input.TotalRecords))
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
                if (ErrorCode != null)
                    hashCode = hashCode * 59 + ErrorCode.GetHashCode();
                if (ErrorMessage != null)
                    hashCode = hashCode * 59 + ErrorMessage.GetHashCode();
                if (HasError != null)
                    hashCode = hashCode * 59 + HasError.GetHashCode();
                if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                if (PageNumber != null)
                    hashCode = hashCode * 59 + PageNumber.GetHashCode();
                if (PageSize != null)
                    hashCode = hashCode * 59 + PageSize.GetHashCode();
                if (ParentBusObId != null)
                    hashCode = hashCode * 59 + ParentBusObId.GetHashCode();
                if (ParentBusObPublicId != null)
                    hashCode = hashCode * 59 + ParentBusObPublicId.GetHashCode();
                if (ParentBusObRecId != null)
                    hashCode = hashCode * 59 + ParentBusObRecId.GetHashCode();
                if (RelatedBusinessObjects != null)
                    hashCode = hashCode * 59 + RelatedBusinessObjects.GetHashCode();
                if (RelationshipId != null)
                    hashCode = hashCode * 59 + RelationshipId.GetHashCode();
                if (TotalRecords != null)
                    hashCode = hashCode * 59 + TotalRecords.GetHashCode();
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
