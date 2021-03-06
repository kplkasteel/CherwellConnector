using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     SearchesAssociation
    /// </summary>
    [DataContract]
    public sealed class SearchesAssociation : IEquatable<SearchesAssociation>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SearchesAssociation" /> class.
        /// </summary>
        /// <param name="busObId">busObId.</param>
        /// <param name="busObName">busObName.</param>
        public SearchesAssociation(string busObId = default, string busObName = default)
        {
            BusObId = busObId;
            BusObName = busObName;
        }

        /// <summary>
        ///     Gets or Sets BusObId
        /// </summary>
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }

        /// <summary>
        ///     Gets or Sets BusObName
        /// </summary>
        [DataMember(Name = "busObName", EmitDefaultValue = false)]
        public string BusObName { get; set; }

        /// <summary>
        ///     Returns true if SearchesAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchesAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchesAssociation input)
        {
            if (input == null)
                return false;

            return
                (
                    BusObId == input.BusObId ||
                    BusObId != null &&
                    BusObId.Equals(input.BusObId)
                ) &&
                (
                    BusObName == input.BusObName ||
                    BusObName != null &&
                    BusObName.Equals(input.BusObName)
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
            sb.Append("class SearchesAssociation {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObName: ").Append(BusObName).Append("\n");
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
            return Equals(input as SearchesAssociation);
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
                if (BusObId != null)
                    hashCode = hashCode * 59 + BusObId.GetHashCode();
                if (BusObName != null)
                    hashCode = hashCode * 59 + BusObName.GetHashCode();
                return hashCode;
            }
        }
    }
}