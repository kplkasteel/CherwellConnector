using System.Diagnostics.CodeAnalysis;

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
    /// TemplateRequest
    /// </summary>
    [DataContract]  
    public sealed class TemplateRequest :  IEquatable<TemplateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRequest" /> class.
        /// </summary>
        /// <param name="busObId">busObId.</param>
        /// <param name="fieldNames">fieldNames.</param>
        /// <param name="fieldIds">fieldIds.</param>
        /// <param name="includeAll">includeAll.</param>
        /// <param name="includeRequired">includeRequired.</param>
        public TemplateRequest(string busObId = default, List<string> fieldNames = default, List<string> fieldIds = default, bool? includeAll = default, bool? includeRequired = default)
        {
            BusObId = busObId;
            FieldNames = fieldNames;
            FieldIds = fieldIds;
            IncludeAll = includeAll;
            IncludeRequired = includeRequired;
        }
        
        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }

        /// <summary>
        /// Gets or Sets FieldNames
        /// </summary>
        [DataMember(Name="fieldNames", EmitDefaultValue=false)]
        public List<string> FieldNames { get; set; }

        /// <summary>
        /// Gets or Sets FieldIds
        /// </summary>
        [DataMember(Name="fieldIds", EmitDefaultValue=false)]
        public List<string> FieldIds { get; set; }

        /// <summary>
        /// Gets or Sets IncludeAll
        /// </summary>
        [DataMember(Name="includeAll", EmitDefaultValue=false)]
        public bool? IncludeAll { get; set; }

        /// <summary>
        /// Gets or Sets IncludeRequired
        /// </summary>
        [DataMember(Name="includeRequired", EmitDefaultValue=false)]
        public bool? IncludeRequired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateRequest {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  FieldNames: ").Append(FieldNames).Append("\n");
            sb.Append("  FieldIds: ").Append(FieldIds).Append("\n");
            sb.Append("  IncludeAll: ").Append(IncludeAll).Append("\n");
            sb.Append("  IncludeRequired: ").Append(IncludeRequired).Append("\n");
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
            return Equals(input as TemplateRequest);
        }

        /// <summary>
        /// Returns true if TemplateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateRequest input)
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
                    FieldNames == input.FieldNames ||
                    FieldNames != null &&
                    FieldNames.SequenceEqual(input.FieldNames)
                ) && 
                (
                    FieldIds == input.FieldIds ||
                    FieldIds != null &&
                    FieldIds.SequenceEqual(input.FieldIds)
                ) && 
                (
                    IncludeAll == input.IncludeAll ||
                    (IncludeAll != null &&
                    IncludeAll.Equals(input.IncludeAll))
                ) && 
                (
                    IncludeRequired == input.IncludeRequired ||
                    (IncludeRequired != null &&
                    IncludeRequired.Equals(input.IncludeRequired))
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
                if (FieldNames != null)
                    hashCode = hashCode * 59 + FieldNames.GetHashCode();
                if (FieldIds != null)
                    hashCode = hashCode * 59 + FieldIds.GetHashCode();
                if (IncludeAll != null)
                    hashCode = hashCode * 59 + IncludeAll.GetHashCode();
                if (IncludeRequired != null)
                    hashCode = hashCode * 59 + IncludeRequired.GetHashCode();
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
