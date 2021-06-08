/* 
 * 
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// TrebuchetWebApiDataContractsBusinessObjectSaveRequest
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsBusinessObjectSaveRequest :  IEquatable<TrebuchetWebApiDataContractsBusinessObjectSaveRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines CacheScope
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CacheScopeEnum
        {
            
            /// <summary>
            /// Enum Tenant for value: Tenant
            /// </summary>
            [EnumMember(Value = "Tenant")]
            Tenant = 1,
            
            /// <summary>
            /// Enum User for value: User
            /// </summary>
            [EnumMember(Value = "User")]
            User = 2,
            
            /// <summary>
            /// Enum Session for value: Session
            /// </summary>
            [EnumMember(Value = "Session")]
            Session = 3
        }

        /// <summary>
        /// Gets or Sets CacheScope
        /// </summary>
        [DataMember(Name="cacheScope", EmitDefaultValue=false)]
        public CacheScopeEnum? CacheScope { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsBusinessObjectSaveRequest" /> class.
        /// </summary>
        /// <param name="busObId">busObId.</param>
        /// <param name="busObPublicId">busObPublicId.</param>
        /// <param name="busObRecId">busObRecId.</param>
        /// <param name="cacheKey">cacheKey.</param>
        /// <param name="cacheScope">cacheScope.</param>
        /// <param name="fields">fields.</param>
        /// <param name="persist">persist.</param>
        public TrebuchetWebApiDataContractsBusinessObjectSaveRequest(string busObId = default(string), string busObPublicId = default(string), string busObRecId = default(string), string cacheKey = default(string), CacheScopeEnum? cacheScope = default(CacheScopeEnum?), List<TrebuchetWebApiDataContractsBusinessObjectFieldTemplateItem> fields = default(List<TrebuchetWebApiDataContractsBusinessObjectFieldTemplateItem>), bool? persist = default(bool?))
        {
            this.BusObId = busObId;
            this.BusObPublicId = busObPublicId;
            this.BusObRecId = busObRecId;
            this.CacheKey = cacheKey;
            this.CacheScope = cacheScope;
            this.Fields = fields;
            this.Persist = persist;
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
        public List<TrebuchetWebApiDataContractsBusinessObjectFieldTemplateItem> Fields { get; set; }

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
            sb.Append("class TrebuchetWebApiDataContractsBusinessObjectSaveRequest {\n");
            sb.Append("  BusObId: ").Append(this.BusObId).Append("\n");
            sb.Append("  BusObPublicId: ").Append(this.BusObPublicId).Append("\n");
            sb.Append("  BusObRecId: ").Append(this.BusObRecId).Append("\n");
            sb.Append("  CacheKey: ").Append(this.CacheKey).Append("\n");
            sb.Append("  CacheScope: ").Append(this.CacheScope).Append("\n");
            sb.Append("  Fields: ").Append(this.Fields).Append("\n");
            sb.Append("  Persist: ").Append(this.Persist).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as TrebuchetWebApiDataContractsBusinessObjectSaveRequest);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsBusinessObjectSaveRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsBusinessObjectSaveRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsBusinessObjectSaveRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BusObId == input.BusObId ||
                    (this.BusObId != null &&
                    this.BusObId.Equals(input.BusObId))
                ) && 
                (
                    this.BusObPublicId == input.BusObPublicId ||
                    (this.BusObPublicId != null &&
                    this.BusObPublicId.Equals(input.BusObPublicId))
                ) && 
                (
                    this.BusObRecId == input.BusObRecId ||
                    (this.BusObRecId != null &&
                    this.BusObRecId.Equals(input.BusObRecId))
                ) && 
                (
                    this.CacheKey == input.CacheKey ||
                    (this.CacheKey != null &&
                    this.CacheKey.Equals(input.CacheKey))
                ) && 
                (
                    this.CacheScope == input.CacheScope ||
                    (this.CacheScope != null &&
                    this.CacheScope.Equals(input.CacheScope))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.Persist == input.Persist ||
                    (this.Persist != null &&
                    this.Persist.Equals(input.Persist))
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
                int hashCode = 41;
                if (this.BusObId != null)
                    hashCode = hashCode * 59 + this.BusObId.GetHashCode();
                if (this.BusObPublicId != null)
                    hashCode = hashCode * 59 + this.BusObPublicId.GetHashCode();
                if (this.BusObRecId != null)
                    hashCode = hashCode * 59 + this.BusObRecId.GetHashCode();
                if (this.CacheKey != null)
                    hashCode = hashCode * 59 + this.CacheKey.GetHashCode();
                if (this.CacheScope != null)
                    hashCode = hashCode * 59 + this.CacheScope.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.Persist != null)
                    hashCode = hashCode * 59 + this.Persist.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}