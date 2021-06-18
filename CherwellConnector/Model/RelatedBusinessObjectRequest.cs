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
    ///     RelatedBusinessObjectRequest
    /// </summary>
    [DataContract]
    public sealed class RelatedBusinessObjectRequest : IEquatable<RelatedBusinessObjectRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RelatedBusinessObjectRequest" /> class.
        /// </summary>
        /// <param name="allFields">allFields.</param>
        /// <param name="customGridId">customGridId.</param>
        /// <param name="fieldsList">fieldsList.</param>
        /// <param name="filters">filters.</param>
        /// <param name="pageNumber">pageNumber.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="parentBusObId">parentBusObId.</param>
        /// <param name="parentBusObRecId">parentBusObRecId.</param>
        /// <param name="relationshipId">relationshipId.</param>
        /// <param name="sorting">sorting.</param>
        /// <param name="useDefaultGrid">useDefaultGrid.</param>
        public RelatedBusinessObjectRequest(bool? allFields = default, string customGridId = default,
            List<string> fieldsList = default, List<FilterInfo> filters = default, int? pageNumber = default,
            int? pageSize = default, string parentBusObId = default, string parentBusObRecId = default,
            string relationshipId = default, List<SortInfo> sorting = default, bool? useDefaultGrid = default)
        {
            AllFields = allFields;
            CustomGridId = customGridId;
            FieldsList = fieldsList;
            Filters = filters;
            PageNumber = pageNumber;
            PageSize = pageSize;
            ParentBusObId = parentBusObId;
            ParentBusObRecId = parentBusObRecId;
            RelationshipId = relationshipId;
            Sorting = sorting;
            UseDefaultGrid = useDefaultGrid;
        }

        /// <summary>
        ///     Gets or Sets AllFields
        /// </summary>
        [DataMember(Name = "allFields", EmitDefaultValue = false)]
        public bool? AllFields { get; set; }

        /// <summary>
        ///     Gets or Sets CustomGridId
        /// </summary>
        [DataMember(Name = "customGridId", EmitDefaultValue = false)]
        public string CustomGridId { get; set; }

        /// <summary>
        ///     Gets or Sets FieldsList
        /// </summary>
        [DataMember(Name = "fieldsList", EmitDefaultValue = false)]
        public List<string> FieldsList { get; set; }

        /// <summary>
        ///     Gets or Sets Filters
        /// </summary>
        [DataMember(Name = "filters", EmitDefaultValue = false)]
        public List<FilterInfo> Filters { get; set; }

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
        ///     Gets or Sets ParentBusObId
        /// </summary>
        [DataMember(Name = "parentBusObId", EmitDefaultValue = false)]
        public string ParentBusObId { get; set; }

        /// <summary>
        ///     Gets or Sets ParentBusObRecId
        /// </summary>
        [DataMember(Name = "parentBusObRecId", EmitDefaultValue = false)]
        public string ParentBusObRecId { get; set; }

        /// <summary>
        ///     Gets or Sets RelationshipId
        /// </summary>
        [DataMember(Name = "relationshipId", EmitDefaultValue = false)]
        public string RelationshipId { get; set; }

        /// <summary>
        ///     Gets or Sets Sorting
        /// </summary>
        [DataMember(Name = "sorting", EmitDefaultValue = false)]
        public List<SortInfo> Sorting { get; set; }

        /// <summary>
        ///     Gets or Sets UseDefaultGrid
        /// </summary>
        [DataMember(Name = "useDefaultGrid", EmitDefaultValue = false)]
        public bool? UseDefaultGrid { get; set; }

        /// <summary>
        ///     Returns true if RelatedBusinessObjectRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RelatedBusinessObjectRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelatedBusinessObjectRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    AllFields == input.AllFields ||
                    AllFields != null &&
                    AllFields.Equals(input.AllFields)
                ) &&
                (
                    CustomGridId == input.CustomGridId ||
                    CustomGridId != null &&
                    CustomGridId.Equals(input.CustomGridId)
                ) &&
                (
                    FieldsList == input.FieldsList ||
                    FieldsList != null &&
                    FieldsList.SequenceEqual(input.FieldsList)
                ) &&
                (
                    Filters == input.Filters ||
                    Filters != null &&
                    Filters.SequenceEqual(input.Filters)
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
                    ParentBusObId == input.ParentBusObId ||
                    ParentBusObId != null &&
                    ParentBusObId.Equals(input.ParentBusObId)
                ) &&
                (
                    ParentBusObRecId == input.ParentBusObRecId ||
                    ParentBusObRecId != null &&
                    ParentBusObRecId.Equals(input.ParentBusObRecId)
                ) &&
                (
                    RelationshipId == input.RelationshipId ||
                    RelationshipId != null &&
                    RelationshipId.Equals(input.RelationshipId)
                ) &&
                (
                    Sorting == input.Sorting ||
                    Sorting != null &&
                    Sorting.SequenceEqual(input.Sorting)
                ) &&
                (
                    UseDefaultGrid == input.UseDefaultGrid ||
                    UseDefaultGrid != null &&
                    UseDefaultGrid.Equals(input.UseDefaultGrid)
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
            sb.Append("class RelatedBusinessObjectRequest {\n");
            sb.Append("  AllFields: ").Append(AllFields).Append("\n");
            sb.Append("  CustomGridId: ").Append(CustomGridId).Append("\n");
            sb.Append("  FieldsList: ").Append(FieldsList).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  ParentBusObId: ").Append(ParentBusObId).Append("\n");
            sb.Append("  ParentBusObRecId: ").Append(ParentBusObRecId).Append("\n");
            sb.Append("  RelationshipId: ").Append(RelationshipId).Append("\n");
            sb.Append("  Sorting: ").Append(Sorting).Append("\n");
            sb.Append("  UseDefaultGrid: ").Append(UseDefaultGrid).Append("\n");
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
            return Equals(input as RelatedBusinessObjectRequest);
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
                if (AllFields != null)
                    hashCode = hashCode * 59 + AllFields.GetHashCode();
                if (CustomGridId != null)
                    hashCode = hashCode * 59 + CustomGridId.GetHashCode();
                if (FieldsList != null)
                    hashCode = hashCode * 59 + FieldsList.GetHashCode();
                if (Filters != null)
                    hashCode = hashCode * 59 + Filters.GetHashCode();
                if (PageNumber != null)
                    hashCode = hashCode * 59 + PageNumber.GetHashCode();
                if (PageSize != null)
                    hashCode = hashCode * 59 + PageSize.GetHashCode();
                if (ParentBusObId != null)
                    hashCode = hashCode * 59 + ParentBusObId.GetHashCode();
                if (ParentBusObRecId != null)
                    hashCode = hashCode * 59 + ParentBusObRecId.GetHashCode();
                if (RelationshipId != null)
                    hashCode = hashCode * 59 + RelationshipId.GetHashCode();
                if (Sorting != null)
                    hashCode = hashCode * 59 + Sorting.GetHashCode();
                if (UseDefaultGrid != null)
                    hashCode = hashCode * 59 + UseDefaultGrid.GetHashCode();
                return hashCode;
            }
        }
    }
}