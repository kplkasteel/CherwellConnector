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
    ///     QuickSearchByIdRequest
    /// </summary>
    [DataContract]
    public sealed class QuickSearchByIdRequest : IEquatable<QuickSearchByIdRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="QuickSearchByIdRequest" /> class.
        /// </summary>
        /// <param name="busObIds">busObIds.</param>
        /// <param name="isGeneral">isGeneral.</param>
        /// <param name="searchText">searchText.</param>
        /// <param name="standIn">standIn.</param>
        public QuickSearchByIdRequest(List<string> busObIds = default, bool? isGeneral = default,
            string searchText = default, string standIn = default)
        {
            BusObIds = busObIds;
            IsGeneral = isGeneral;
            SearchText = searchText;
            StandIn = standIn;
        }

        /// <summary>
        ///     Gets or Sets BusObIds
        /// </summary>
        [DataMember(Name = "busObIds", EmitDefaultValue = false)]
        public List<string> BusObIds { get; set; }

        /// <summary>
        ///     Gets or Sets IsGeneral
        /// </summary>
        [DataMember(Name = "isGeneral", EmitDefaultValue = false)]
        public bool? IsGeneral { get; set; }

        /// <summary>
        ///     Gets or Sets SearchText
        /// </summary>
        [DataMember(Name = "searchText", EmitDefaultValue = false)]
        public string SearchText { get; set; }

        /// <summary>
        ///     Gets or Sets StandIn
        /// </summary>
        [DataMember(Name = "standIn", EmitDefaultValue = false)]
        public string StandIn { get; set; }

        /// <summary>
        ///     Returns true if QuickSearchByIdRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of QuickSearchByIdRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuickSearchByIdRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    BusObIds == input.BusObIds ||
                    BusObIds != null &&
                    BusObIds.SequenceEqual(input.BusObIds)
                ) &&
                (
                    IsGeneral == input.IsGeneral ||
                    IsGeneral != null &&
                    IsGeneral.Equals(input.IsGeneral)
                ) &&
                (
                    SearchText == input.SearchText ||
                    SearchText != null &&
                    SearchText.Equals(input.SearchText)
                ) &&
                (
                    StandIn == input.StandIn ||
                    StandIn != null &&
                    StandIn.Equals(input.StandIn)
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
            sb.Append("class QuickSearchByIdRequest {\n");
            sb.Append("  BusObIds: ").Append(BusObIds).Append("\n");
            sb.Append("  IsGeneral: ").Append(IsGeneral).Append("\n");
            sb.Append("  SearchText: ").Append(SearchText).Append("\n");
            sb.Append("  StandIn: ").Append(StandIn).Append("\n");
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
            return Equals(input as QuickSearchByIdRequest);
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
                if (BusObIds != null)
                    hashCode = hashCode * 59 + BusObIds.GetHashCode();
                if (IsGeneral != null)
                    hashCode = hashCode * 59 + IsGeneral.GetHashCode();
                if (SearchText != null)
                    hashCode = hashCode * 59 + SearchText.GetHashCode();
                if (StandIn != null)
                    hashCode = hashCode * 59 + StandIn.GetHashCode();
                return hashCode;
            }
        }
    }
}