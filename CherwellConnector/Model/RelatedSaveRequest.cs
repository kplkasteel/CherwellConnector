using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using CherwellConnector.Enum;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     RelatedSaveRequest
    /// </summary>
    [DataContract]
    public sealed class RelatedSaveRequest : IEquatable<RelatedSaveRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RelatedSaveRequest" /> class.
        /// </summary>
        /// <param name="parentBusObId">parentBusObId.</param>
        /// <param name="parentBusObPublicId">parentBusObPublicId.</param>
        /// <param name="parentBusObRecId">parentBusObRecId.</param>
        /// <param name="relationshipId">relationshipId.</param>
        /// <param name="busObId">busObId.</param>
        /// <param name="busObPublicId">busObPublicId.</param>
        /// <param name="busObRecId">busObRecId.</param>
        /// <param name="cacheKey">cacheKey.</param>
        /// <param name="cacheScope">cacheScope.</param>
        /// <param name="fields">fields.</param>
        /// <param name="persist">persist.</param>
        public RelatedSaveRequest(string parentBusObId = default, string parentBusObPublicId = default,
            string parentBusObRecId = default, string relationshipId = default, string busObId = default,
            string busObPublicId = default, string busObRecId = default, string cacheKey = default,
            CacheScopeEnum? cacheScope = default, List<FieldTemplateItem> fields = default, bool? persist = default)
        {
            ParentBusObId = parentBusObId;
            ParentBusObPublicId = parentBusObPublicId;
            ParentBusObRecId = parentBusObRecId;
            RelationshipId = relationshipId;
            BusObId = busObId;
            BusObPublicId = busObPublicId;
            BusObRecId = busObRecId;
            CacheKey = cacheKey;
            CacheScope = cacheScope;
            Fields = fields;
            Persist = persist;
        }

        /// <summary>
        ///     Gets or Sets CacheScope
        /// </summary>
        [DataMember(Name = "cacheScope", EmitDefaultValue = false)]
        public CacheScopeEnum? CacheScope { get; set; }

        /// <summary>
        ///     Gets or Sets ParentBusObId
        /// </summary>
        [DataMember(Name = "parentBusObId", EmitDefaultValue = false)]
        public string ParentBusObId { get; set; }

        /// <summary>
        ///     Gets or Sets ParentBusObPublicId
        /// </summary>
        [DataMember(Name = "parentBusObPublicId", EmitDefaultValue = false)]
        public string ParentBusObPublicId { get; set; }

        /// <summary>
        ///     Gets or Sets ParentBusObRecId
        /// </summary>
        [DataMember(Name = "parentBusObRecId", EmitDefaultValue = false)]
        public string ParentBusObRecId { get; set; }

        /// <summary>
        ///     Gets or Sets RelationshipId
        /// </summary>
        [DataMember(Name = "relationshipId", EmitDefaultValue = false)]
        public string RelationshipId { get; set; }

        /// <summary>
        ///     Gets or Sets BusObId
        /// </summary>
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }

        /// <summary>
        ///     Gets or Sets BusObPublicId
        /// </summary>
        [DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
        public string BusObPublicId { get; set; }

        /// <summary>
        ///     Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
        public string BusObRecId { get; set; }

        /// <summary>
        ///     Gets or Sets CacheKey
        /// </summary>
        [DataMember(Name = "cacheKey", EmitDefaultValue = false)]
        public string CacheKey { get; set; }


        /// <summary>
        ///     Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public List<FieldTemplateItem> Fields { get; set; }

        /// <summary>
        ///     Gets or Sets Persist
        /// </summary>
        [DataMember(Name = "persist", EmitDefaultValue = false)]
        public bool? Persist { get; set; }

        /// <summary>
        ///     Returns true if RelatedSaveRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RelatedSaveRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelatedSaveRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    ParentBusObId == input.ParentBusObId ||
                    ParentBusObId != null &&
                    ParentBusObId.Equals(input.ParentBusObId)
                ) &&
                (
                    ParentBusObPublicId == input.ParentBusObPublicId ||
                    ParentBusObPublicId != null &&
                    ParentBusObPublicId.Equals(input.ParentBusObPublicId)
                ) &&
                (
                    ParentBusObRecId == input.ParentBusObRecId ||
                    ParentBusObRecId != null &&
                    ParentBusObRecId.Equals(input.ParentBusObRecId)
                ) &&
                (
                    RelationshipId == input.RelationshipId ||
                    RelationshipId != null &&
                    RelationshipId.Equals(input.RelationshipId)
                ) &&
                (
                    BusObId == input.BusObId ||
                    BusObId != null &&
                    BusObId.Equals(input.BusObId)
                ) &&
                (
                    BusObPublicId == input.BusObPublicId ||
                    BusObPublicId != null &&
                    BusObPublicId.Equals(input.BusObPublicId)
                ) &&
                (
                    BusObRecId == input.BusObRecId ||
                    BusObRecId != null &&
                    BusObRecId.Equals(input.BusObRecId)
                ) &&
                (
                    CacheKey == input.CacheKey ||
                    CacheKey != null &&
                    CacheKey.Equals(input.CacheKey)
                ) &&
                (
                    CacheScope == input.CacheScope ||
                    CacheScope != null &&
                    CacheScope.Equals(input.CacheScope)
                ) &&
                (
                    Fields == input.Fields ||
                    Fields != null &&
                    Fields.SequenceEqual(input.Fields)
                ) &&
                (
                    Persist == input.Persist ||
                    Persist != null &&
                    Persist.Equals(input.Persist)
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
            sb.Append("class RelatedSaveRequest {\n");
            sb.Append("  ParentBusObId: ").Append(ParentBusObId).Append("\n");
            sb.Append("  ParentBusObPublicId: ").Append(ParentBusObPublicId).Append("\n");
            sb.Append("  ParentBusObRecId: ").Append(ParentBusObRecId).Append("\n");
            sb.Append("  RelationshipId: ").Append(RelationshipId).Append("\n");
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
            return Equals(input as RelatedSaveRequest);
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
                if (ParentBusObId != null)
                    hashCode = hashCode * 59 + ParentBusObId.GetHashCode();
                if (ParentBusObPublicId != null)
                    hashCode = hashCode * 59 + ParentBusObPublicId.GetHashCode();
                if (ParentBusObRecId != null)
                    hashCode = hashCode * 59 + ParentBusObRecId.GetHashCode();
                if (RelationshipId != null)
                    hashCode = hashCode * 59 + RelationshipId.GetHashCode();
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
    }
}