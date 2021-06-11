
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
    /// TrebuchetWebApiDataContractsSearchesQuickSearchConfigSavedRequest
    /// </summary>
    [DataContract]
    public sealed class TrebuchetWebApiDataContractsSearchesQuickSearchConfigSavedRequest :  IEquatable<TrebuchetWebApiDataContractsSearchesQuickSearchConfigSavedRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsSearchesQuickSearchConfigSavedRequest" /> class.
        /// </summary>
        /// <param name="standIn">standIn.</param>
        /// <param name="busObIds">busObIds.</param>
        /// <param name="isGeneral">isGeneral.</param>
        public TrebuchetWebApiDataContractsSearchesQuickSearchConfigSavedRequest(string standIn = default, List<string> busObIds = default, bool? isGeneral = default)
        {
            StandIn = standIn;
            BusObIds = busObIds;
            IsGeneral = isGeneral;
        }
        
        /// <summary>
        /// Gets or Sets StandIn
        /// </summary>
        [DataMember(Name="standIn", EmitDefaultValue=false)]
        public string StandIn { get; set; }

        /// <summary>
        /// Gets or Sets BusObIds
        /// </summary>
        [DataMember(Name="busObIds", EmitDefaultValue=false)]
        public List<string> BusObIds { get; set; }

        /// <summary>
        /// Gets or Sets IsGeneral
        /// </summary>
        [DataMember(Name="isGeneral", EmitDefaultValue=false)]
        public bool? IsGeneral { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsSearchesQuickSearchConfigSavedRequest {\n");
            sb.Append("  StandIn: ").Append(StandIn).Append("\n");
            sb.Append("  BusObIds: ").Append(BusObIds).Append("\n");
            sb.Append("  IsGeneral: ").Append(IsGeneral).Append("\n");
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
            return Equals(input as TrebuchetWebApiDataContractsSearchesQuickSearchConfigSavedRequest);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsSearchesQuickSearchConfigSavedRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsSearchesQuickSearchConfigSavedRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsSearchesQuickSearchConfigSavedRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    StandIn == input.StandIn ||
                    (StandIn != null &&
                    StandIn.Equals(input.StandIn))
                ) && 
                (
                    BusObIds == input.BusObIds ||
                    BusObIds != null &&
                    BusObIds.SequenceEqual(input.BusObIds)
                ) && 
                (
                    IsGeneral == input.IsGeneral ||
                    (IsGeneral != null &&
                    IsGeneral.Equals(input.IsGeneral))
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
                if (StandIn != null)
                    hashCode = hashCode * 59 + StandIn.GetHashCode();
                if (BusObIds != null)
                    hashCode = hashCode * 59 + BusObIds.GetHashCode();
                if (IsGeneral != null)
                    hashCode = hashCode * 59 + IsGeneral.GetHashCode();
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
