
namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// TrebuchetWebApiDataContractsSecurityGetApiClientSettingsResponseItem
    /// </summary>
    [DataContract]
    public sealed class TrebuchetWebApiDataContractsSecurityGetApiClientSettingsResponseItem :  IEquatable<TrebuchetWebApiDataContractsSecurityGetApiClientSettingsResponseItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsSecurityGetApiClientSettingsResponseItem" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="standInKey">standInKey.</param>
        public TrebuchetWebApiDataContractsSecurityGetApiClientSettingsResponseItem(string name = default, string standInKey = default)
        {
            Name = name;
            StandInKey = standInKey;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets StandInKey
        /// </summary>
        [DataMember(Name="standInKey", EmitDefaultValue=false)]
        public string StandInKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsSecurityGetApiClientSettingsResponseItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StandInKey: ").Append(StandInKey).Append("\n");
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
            return Equals(input as TrebuchetWebApiDataContractsSecurityGetApiClientSettingsResponseItem);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsSecurityGetApiClientSettingsResponseItem instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsSecurityGetApiClientSettingsResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsSecurityGetApiClientSettingsResponseItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    StandInKey == input.StandInKey ||
                    (StandInKey != null &&
                    StandInKey.Equals(input.StandInKey))
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
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (StandInKey != null)
                    hashCode = hashCode * 59 + StandInKey.GetHashCode();
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
