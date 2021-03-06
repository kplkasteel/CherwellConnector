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
    ///     FieldValuesLookupRequest
    /// </summary>
    [DataContract]
    public sealed class FieldValuesLookupRequest : IEquatable<FieldValuesLookupRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="FieldValuesLookupRequest" /> class.
        /// </summary>
        /// <param name="busbPublicId">busbPublicId.</param>
        /// <param name="busObId">busObId.</param>
        /// <param name="busObRecId">busObRecId.</param>
        /// <param name="fieldId">fieldId.</param>
        /// <param name="fieldName">fieldName.</param>
        /// <param name="fields">fields.</param>
        public FieldValuesLookupRequest(string busbPublicId = default, string busObId = default,
            string busObRecId = default, string fieldId = default, string fieldName = default,
            List<FieldTemplateItem> fields = default)
        {
            BusbPublicId = busbPublicId;
            BusObId = busObId;
            BusObRecId = busObRecId;
            FieldId = fieldId;
            FieldName = fieldName;
            Fields = fields;
        }

        /// <summary>
        ///     Gets or Sets BusbPublicId
        /// </summary>
        [DataMember(Name = "busbPublicId", EmitDefaultValue = false)]
        public string BusbPublicId { get; set; }

        /// <summary>
        ///     Gets or Sets BusObId
        /// </summary>
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }

        /// <summary>
        ///     Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
        public string BusObRecId { get; set; }

        /// <summary>
        ///     Gets or Sets FieldId
        /// </summary>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }

        /// <summary>
        ///     Gets or Sets FieldName
        /// </summary>
        [DataMember(Name = "fieldName", EmitDefaultValue = false)]
        public string FieldName { get; set; }

        /// <summary>
        ///     Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public List<FieldTemplateItem> Fields { get; set; }

        /// <summary>
        ///     Returns true if FieldValuesLookupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldValuesLookupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldValuesLookupRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    BusbPublicId == input.BusbPublicId ||
                    BusbPublicId != null &&
                    BusbPublicId.Equals(input.BusbPublicId)
                ) &&
                (
                    BusObId == input.BusObId ||
                    BusObId != null &&
                    BusObId.Equals(input.BusObId)
                ) &&
                (
                    BusObRecId == input.BusObRecId ||
                    BusObRecId != null &&
                    BusObRecId.Equals(input.BusObRecId)
                ) &&
                (
                    FieldId == input.FieldId ||
                    FieldId != null &&
                    FieldId.Equals(input.FieldId)
                ) &&
                (
                    FieldName == input.FieldName ||
                    FieldName != null &&
                    FieldName.Equals(input.FieldName)
                ) &&
                (
                    Fields == input.Fields ||
                    Fields != null &&
                    Fields.SequenceEqual(input.Fields)
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
            sb.Append("class FieldValuesLookupRequest {\n");
            sb.Append("  BusPublicId: ").Append(BusbPublicId).Append("\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return Equals(input as FieldValuesLookupRequest);
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
                if (BusbPublicId != null)
                    hashCode = hashCode * 59 + BusbPublicId.GetHashCode();
                if (BusObId != null)
                    hashCode = hashCode * 59 + BusObId.GetHashCode();
                if (BusObRecId != null)
                    hashCode = hashCode * 59 + BusObRecId.GetHashCode();
                if (FieldId != null)
                    hashCode = hashCode * 59 + FieldId.GetHashCode();
                if (FieldName != null)
                    hashCode = hashCode * 59 + FieldName.GetHashCode();
                if (Fields != null)
                    hashCode = hashCode * 59 + Fields.GetHashCode();
                return hashCode;
            }
        }
    }
}