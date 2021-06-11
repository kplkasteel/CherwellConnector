
namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// TrebuchetWebApiDataContractsSearchesSortInfo
    /// </summary>
    [DataContract]
    public sealed class TrebuchetWebApiDataContractsSearchesSortInfo :  IEquatable<TrebuchetWebApiDataContractsSearchesSortInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsSearchesSortInfo" /> class.
        /// </summary>
        /// <param name="fieldId">fieldId.</param>
        /// <param name="sortDirection">sortDirection.</param>
        public TrebuchetWebApiDataContractsSearchesSortInfo(string fieldId = default, int? sortDirection = default)
        {
            FieldId = fieldId;
            SortDirection = sortDirection;
        }
        
        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }

        /// <summary>
        /// Gets or Sets SortDirection
        /// </summary>
        [DataMember(Name="sortDirection", EmitDefaultValue=false)]
        public int? SortDirection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsSearchesSortInfo {\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  SortDirection: ").Append(SortDirection).Append("\n");
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
            return Equals(input as TrebuchetWebApiDataContractsSearchesSortInfo);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsSearchesSortInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsSearchesSortInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsSearchesSortInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    FieldId == input.FieldId ||
                    (FieldId != null &&
                    FieldId.Equals(input.FieldId))
                ) && 
                (
                    SortDirection == input.SortDirection ||
                    (SortDirection != null &&
                    SortDirection.Equals(input.SortDirection))
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
                if (FieldId != null)
                    hashCode = hashCode * 59 + FieldId.GetHashCode();
                if (SortDirection != null)
                    hashCode = hashCode * 59 + SortDirection.GetHashCode();
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
