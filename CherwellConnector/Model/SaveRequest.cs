
using System.Diagnostics.CodeAnalysis;
using CherwellConnector.Enum;

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
    /// SaveRequest
    /// </summary>
    [DataContract]
    public sealed class SaveRequest :  IEquatable<SaveRequest>, IValidatableObject
    {
       

        /// <summary>
        /// Gets or Sets CacheScope
        /// </summary>
        [DataMember(Name="cacheScope", EmitDefaultValue=false)]
        public CacheScopeEnum? CacheScope { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveRequest" /> class.
        /// </summary>
        /// <param name="busObId">busObId.</param>
        /// <param name="busObPublicId">busObPublicId.</param>
        /// <param name="busObRecId">busObRecId.</param>
        /// <param name="cacheKey">cacheKey.</param>
        /// <param name="cacheScope">cacheScope.</param>
        /// <param name="fields">fields.</param>
        /// <param name="persist">persist.</param>
        public SaveRequest(string busObId = default, string busObPublicId = default, string busObRecId = default, string cacheKey = default, CacheScopeEnum? cacheScope = default, List<FieldTemplateItem> fields = default, bool? persist = default)
        {
            BusObId = busObId;
            BusObPublicId = busObPublicId;
            BusObRecId = busObRecId;
            CacheKey = cacheKey;
            CacheScope = cacheScope;
            Fields = fields;
            Persist = persist;
        }
        
        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }

        /// <summary>
        /// Gets or Sets BusObPublicId
        /// </summary>
        [DataMember(Name="busObPublicId", EmitDefaultValue=false)]
        public string BusObPublicId { get; set; }

        /// <summary>
        /// Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name="busObRecId", EmitDefaultValue=false)]
        public string BusObRecId { get; set; }

        /// <summary>
        /// Gets or Sets CacheKey
        /// </summary>
        [DataMember(Name="cacheKey", EmitDefaultValue=false)]
        public string CacheKey { get; set; }


        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<FieldTemplateItem> Fields { get; set; }

        /// <summary>
        /// Gets or Sets Persist
        /// </summary>
        [DataMember(Name="persist", EmitDefaultValue=false)]
        public bool? Persist { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveRequest {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  CacheKey: ").Append(CacheKey).Append("\n");
            sb.Append("  CacheScope: ").Append(CacheScope).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Persist: ").Append(Persist).Append("\n");
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
            return Equals(input as SaveRequest);
        }

        /// <summary>
        /// Returns true if SaveRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    BusObId == input.BusObId ||
                    (BusObId != null &&
                    BusObId.Equals(input.BusObId))
                ) && 
                (
                    BusObPublicId == input.BusObPublicId ||
                    (BusObPublicId != null &&
                    BusObPublicId.Equals(input.BusObPublicId))
                ) && 
                (
                    BusObRecId == input.BusObRecId ||
                    (BusObRecId != null &&
                    BusObRecId.Equals(input.BusObRecId))
                ) && 
                (
                    CacheKey == input.CacheKey ||
                    (CacheKey != null &&
                    CacheKey.Equals(input.CacheKey))
                ) && 
                (
                    CacheScope == input.CacheScope ||
                    (CacheScope != null &&
                    CacheScope.Equals(input.CacheScope))
                ) && 
                (
                    Fields == input.Fields ||
                    Fields != null &&
                    Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    Persist == input.Persist ||
                    (Persist != null &&
                    Persist.Equals(input.Persist))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (BusObId != null)
                    hashCode = hashCode * 59 + BusObId.GetHashCode();
                if (BusObPublicId != null)
                    hashCode = hashCode * 59 + BusObPublicId.GetHashCode();
                if (BusObRecId != null)
                    hashCode = hashCode * 59 + BusObRecId.GetHashCode();
                if (CacheKey != null)
                    hashCode = hashCode * 59 + CacheKey.GetHashCode();
                if (CacheScope != null)
                    hashCode = hashCode * 59 + CacheScope.GetHashCode();
                if (Fields != null)
                    hashCode = hashCode * 59 + Fields.GetHashCode();
                if (Persist != null)
                    hashCode = hashCode * 59 + Persist.GetHashCode();
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
