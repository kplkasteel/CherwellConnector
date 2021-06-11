
namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// TrebuchetWebApiDataContractsSecurityRightCategory
    /// </summary>
    [DataContract]
    public sealed class TrebuchetWebApiDataContractsSecurityRightCategory :  IEquatable<TrebuchetWebApiDataContractsSecurityRightCategory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsSecurityRightCategory" /> class.
        /// </summary>
        /// <param name="categoryDescription">categoryDescription.</param>
        /// <param name="categoryId">categoryId.</param>
        /// <param name="categoryName">categoryName.</param>
        public TrebuchetWebApiDataContractsSecurityRightCategory(string categoryDescription = default, string categoryId = default, string categoryName = default)
        {
            CategoryDescription = categoryDescription;
            CategoryId = categoryId;
            CategoryName = categoryName;
        }
        
        /// <summary>
        /// Gets or Sets CategoryDescription
        /// </summary>
        [DataMember(Name="categoryDescription", EmitDefaultValue=false)]
        public string CategoryDescription { get; set; }

        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name="categoryId", EmitDefaultValue=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// Gets or Sets CategoryName
        /// </summary>
        [DataMember(Name="categoryName", EmitDefaultValue=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsSecurityRightCategory {\n");
            sb.Append("  CategoryDescription: ").Append(CategoryDescription).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
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
            return Equals(input as TrebuchetWebApiDataContractsSecurityRightCategory);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsSecurityRightCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsSecurityRightCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsSecurityRightCategory input)
        {
            if (input == null)
                return false;

            return 
                (
                    CategoryDescription == input.CategoryDescription ||
                    (CategoryDescription != null &&
                    CategoryDescription.Equals(input.CategoryDescription))
                ) && 
                (
                    CategoryId == input.CategoryId ||
                    (CategoryId != null &&
                    CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    CategoryName == input.CategoryName ||
                    (CategoryName != null &&
                    CategoryName.Equals(input.CategoryName))
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
                if (CategoryDescription != null)
                    hashCode = hashCode * 59 + CategoryDescription.GetHashCode();
                if (CategoryId != null)
                    hashCode = hashCode * 59 + CategoryId.GetHashCode();
                if (CategoryName != null)
                    hashCode = hashCode * 59 + CategoryName.GetHashCode();
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
