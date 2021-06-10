namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// ServiceInfoResponse
    /// </summary>
    [DataContract]
    public sealed class ServiceInfoResponse :  IEquatable<ServiceInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceInfoResponse" /> class.
        /// </summary>
        /// <param name="apiVersion">apiVersion.</param>
        /// <param name="csmCulture">csmCulture.</param>
        /// <param name="csmVersion">csmVersion.</param>
        /// <param name="systemDateTime">systemDateTime.</param>
        /// <param name="timeZone">timeZone.</param>
        /// <param name="systemUtcOffset">systemUtcOffset.</param>
        public ServiceInfoResponse(string apiVersion = default, string csmCulture = default, string csmVersion = default, DateTime? systemDateTime = default, Object timeZone = default, string systemUtcOffset = default)
        {
            ApiVersion = apiVersion;
            CsmCulture = csmCulture;
            CsmVersion = csmVersion;
            SystemDateTime = systemDateTime;
            TimeZone = timeZone;
            SystemUtcOffset = systemUtcOffset;
        }
        
        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name="apiVersion", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or Sets CsmCulture
        /// </summary>
        [DataMember(Name="csmCulture", EmitDefaultValue=false)]
        public string CsmCulture { get; set; }

        /// <summary>
        /// Gets or Sets CsmVersion
        /// </summary>
        [DataMember(Name="csmVersion", EmitDefaultValue=false)]
        public string CsmVersion { get; set; }

        /// <summary>
        /// Gets or Sets SystemDateTime
        /// </summary>
        [DataMember(Name="systemDateTime", EmitDefaultValue=false)]
        public DateTime? SystemDateTime { get; set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public Object TimeZone { get; set; }

        /// <summary>
        /// Gets or Sets SystemUtcOffset
        /// </summary>
        [DataMember(Name="systemUtcOffset", EmitDefaultValue=false)]
        public string SystemUtcOffset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceInfoResponse {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  CsmCulture: ").Append(CsmCulture).Append("\n");
            sb.Append("  CsmVersion: ").Append(CsmVersion).Append("\n");
            sb.Append("  SystemDateTime: ").Append(SystemDateTime).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  SystemUtcOffset: ").Append(SystemUtcOffset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return Equals(input as ServiceInfoResponse);
        }

        /// <summary>
        /// Returns true if ServiceInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceInfoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    ApiVersion == input.ApiVersion ||
                    (ApiVersion != null &&
                    ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    CsmCulture == input.CsmCulture ||
                    (CsmCulture != null &&
                    CsmCulture.Equals(input.CsmCulture))
                ) && 
                (
                    CsmVersion == input.CsmVersion ||
                    (CsmVersion != null &&
                    CsmVersion.Equals(input.CsmVersion))
                ) && 
                (
                    SystemDateTime == input.SystemDateTime ||
                    (SystemDateTime != null &&
                    SystemDateTime.Equals(input.SystemDateTime))
                ) && 
                (
                    TimeZone == input.TimeZone ||
                    (TimeZone != null &&
                    TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    SystemUtcOffset == input.SystemUtcOffset ||
                    (SystemUtcOffset != null &&
                    SystemUtcOffset.Equals(input.SystemUtcOffset))
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
                if (ApiVersion != null)
                    hashCode = hashCode * 59 + ApiVersion.GetHashCode();
                if (CsmCulture != null)
                    hashCode = hashCode * 59 + CsmCulture.GetHashCode();
                if (CsmVersion != null)
                    hashCode = hashCode * 59 + CsmVersion.GetHashCode();
                if (SystemDateTime != null)
                    hashCode = hashCode * 59 + SystemDateTime.GetHashCode();
                if (TimeZone != null)
                    hashCode = hashCode * 59 + TimeZone.GetHashCode();
                if (SystemUtcOffset != null)
                    hashCode = hashCode * 59 + SystemUtcOffset.GetHashCode();
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
