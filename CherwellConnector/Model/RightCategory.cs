using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     RightCategory
    /// </summary>
    [DataContract]
    public sealed class RightCategory : IEquatable<RightCategory>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RightCategory" /> class.
        /// </summary>
        /// <param name="categoryDescription">categoryDescription.</param>
        /// <param name="categoryId">categoryId.</param>
        /// <param name="categoryName">categoryName.</param>
        public RightCategory(string categoryDescription = default, string categoryId = default,
            string categoryName = default)
        {
            CategoryDescription = categoryDescription;
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        /// <summary>
        ///     Gets or Sets CategoryDescription
        /// </summary>
        [DataMember(Name = "categoryDescription", EmitDefaultValue = false)]
        public string CategoryDescription { get; set; }

        /// <summary>
        ///     Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name = "categoryId", EmitDefaultValue = false)]
        public string CategoryId { get; set; }

        /// <summary>
        ///     Gets or Sets CategoryName
        /// </summary>
        [DataMember(Name = "categoryName", EmitDefaultValue = false)]
        public string CategoryName { get; set; }

        /// <summary>
        ///     Returns true if RightCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of RightCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RightCategory input)
        {
            if (input == null)
                return false;

            return
                (
                    CategoryDescription == input.CategoryDescription ||
                    CategoryDescription != null &&
                    CategoryDescription.Equals(input.CategoryDescription)
                ) &&
                (
                    CategoryId == input.CategoryId ||
                    CategoryId != null &&
                    CategoryId.Equals(input.CategoryId)
                ) &&
                (
                    CategoryName == input.CategoryName ||
                    CategoryName != null &&
                    CategoryName.Equals(input.CategoryName)
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
            sb.Append("class RightCategory {\n");
            sb.Append("  CategoryDescription: ").Append(CategoryDescription).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
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
            return Equals(input as RightCategory);
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
                if (CategoryDescription != null)
                    hashCode = hashCode * 59 + CategoryDescription.GetHashCode();
                if (CategoryId != null)
                    hashCode = hashCode * 59 + CategoryId.GetHashCode();
                if (CategoryName != null)
                    hashCode = hashCode * 59 + CategoryName.GetHashCode();
                return hashCode;
            }
        }
    }
}