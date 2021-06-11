
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
    /// TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationRequest
    /// </summary>
    [DataContract]
    public sealed class TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationRequest :  IEquatable<TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationRequest" /> class.
        /// </summary>
        /// <param name="busObIds">busObIds.</param>
        public TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationRequest(List<string> busObIds = default)
        {
            BusObIds = busObIds;
        }
        
        /// <summary>
        /// Gets or Sets BusObIds
        /// </summary>
        [DataMember(Name="busObIds", EmitDefaultValue=false)]
        public List<string> BusObIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationRequest {\n");
            sb.Append("  BusObIds: ").Append(BusObIds).Append("\n");
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
            return Equals(input as TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationRequest);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    BusObIds == input.BusObIds ||
                    BusObIds != null &&
                    BusObIds.SequenceEqual(input.BusObIds)
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
                if (BusObIds != null)
                    hashCode = hashCode * 59 + BusObIds.GetHashCode();
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
