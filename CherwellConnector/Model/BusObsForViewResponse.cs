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
    ///     BusObsForViewResponse
    /// </summary>
    [DataContract]
    public sealed class BusObsForViewResponse : IEquatable<BusObsForViewResponse>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BusObsForViewResponse" /> class.
        /// </summary>
        /// <param name="summaries">summaries.</param>
        public BusObsForViewResponse(List<ViewSummary> summaries = default)
        {
            Summaries = summaries;
        }

        /// <summary>
        ///     Gets or Sets Summaries
        /// </summary>
        [DataMember(Name = "summaries", EmitDefaultValue = false)]
        public List<ViewSummary> Summaries { get; set; }

        /// <summary>
        ///     Returns true if BusObsForViewResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BusObsForViewResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusObsForViewResponse input)
        {
            if (input == null)
                return false;

            return
                Summaries == input.Summaries ||
                Summaries != null &&
                Summaries.SequenceEqual(input.Summaries);
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
            sb.Append("class BusObsForViewResponse {\n");
            sb.Append("  Summaries: ").Append(Summaries).Append("\n");
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
            return Equals(input as BusObsForViewResponse);
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
                if (Summaries != null)
                    hashCode = hashCode * 59 + Summaries.GetHashCode();
                return hashCode;
            }
        }
    }
}