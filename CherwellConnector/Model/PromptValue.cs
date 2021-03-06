using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     PromptValue
    /// </summary>
    [DataContract]
    public sealed class PromptValue : IEquatable<PromptValue>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PromptValue" /> class.
        /// </summary>
        /// <param name="busObId">busObId.</param>
        /// <param name="collectionStoreEntireRow">collectionStoreEntireRow.</param>
        /// <param name="collectionValueField">collectionValueField.</param>
        /// <param name="fieldId">fieldId.</param>
        /// <param name="listReturnFieldId">listReturnFieldId.</param>
        /// <param name="promptId">promptId.</param>
        /// <param name="value">value.</param>
        /// <param name="valueIsRecId">valueIsRecId.</param>
        public PromptValue(string busObId = default, string collectionStoreEntireRow = default,
            string collectionValueField = default, string fieldId = default, string listReturnFieldId = default,
            string promptId = default, Object value = default, bool? valueIsRecId = default)
        {
            BusObId = busObId;
            CollectionStoreEntireRow = collectionStoreEntireRow;
            CollectionValueField = collectionValueField;
            FieldId = fieldId;
            ListReturnFieldId = listReturnFieldId;
            PromptId = promptId;
            Value = value;
            ValueIsRecId = valueIsRecId;
        }

        /// <summary>
        ///     Gets or Sets BusObId
        /// </summary>
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }

        /// <summary>
        ///     Gets or Sets CollectionStoreEntireRow
        /// </summary>
        [DataMember(Name = "collectionStoreEntireRow", EmitDefaultValue = false)]
        public string CollectionStoreEntireRow { get; set; }

        /// <summary>
        ///     Gets or Sets CollectionValueField
        /// </summary>
        [DataMember(Name = "collectionValueField", EmitDefaultValue = false)]
        public string CollectionValueField { get; set; }

        /// <summary>
        ///     Gets or Sets FieldId
        /// </summary>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }

        /// <summary>
        ///     Gets or Sets ListReturnFieldId
        /// </summary>
        [DataMember(Name = "listReturnFieldId", EmitDefaultValue = false)]
        public string ListReturnFieldId { get; set; }

        /// <summary>
        ///     Gets or Sets PromptId
        /// </summary>
        [DataMember(Name = "promptId", EmitDefaultValue = false)]
        public string PromptId { get; set; }

        /// <summary>
        ///     Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public Object Value { get; set; }

        /// <summary>
        ///     Gets or Sets ValueIsRecId
        /// </summary>
        [DataMember(Name = "valueIsRecId", EmitDefaultValue = false)]
        public bool? ValueIsRecId { get; set; }

        /// <summary>
        ///     Returns true if PromptValue instances are equal
        /// </summary>
        /// <param name="input">Instance of PromptValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PromptValue input)
        {
            if (input == null)
                return false;

            return
                (
                    BusObId == input.BusObId ||
                    BusObId != null &&
                    BusObId.Equals(input.BusObId)
                ) &&
                (
                    CollectionStoreEntireRow == input.CollectionStoreEntireRow ||
                    CollectionStoreEntireRow != null &&
                    CollectionStoreEntireRow.Equals(input.CollectionStoreEntireRow)
                ) &&
                (
                    CollectionValueField == input.CollectionValueField ||
                    CollectionValueField != null &&
                    CollectionValueField.Equals(input.CollectionValueField)
                ) &&
                (
                    FieldId == input.FieldId ||
                    FieldId != null &&
                    FieldId.Equals(input.FieldId)
                ) &&
                (
                    ListReturnFieldId == input.ListReturnFieldId ||
                    ListReturnFieldId != null &&
                    ListReturnFieldId.Equals(input.ListReturnFieldId)
                ) &&
                (
                    PromptId == input.PromptId ||
                    PromptId != null &&
                    PromptId.Equals(input.PromptId)
                ) &&
                (
                    Value == input.Value ||
                    Value != null &&
                    Value.Equals(input.Value)
                ) &&
                (
                    ValueIsRecId == input.ValueIsRecId ||
                    ValueIsRecId != null &&
                    ValueIsRecId.Equals(input.ValueIsRecId)
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
            sb.Append("class PromptValue {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  CollectionStoreEntireRow: ").Append(CollectionStoreEntireRow).Append("\n");
            sb.Append("  CollectionValueField: ").Append(CollectionValueField).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  ListReturnFieldId: ").Append(ListReturnFieldId).Append("\n");
            sb.Append("  PromptId: ").Append(PromptId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueIsRecId: ").Append(ValueIsRecId).Append("\n");
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
            return Equals(input as PromptValue);
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
                if (BusObId != null)
                    hashCode = hashCode * 59 + BusObId.GetHashCode();
                if (CollectionStoreEntireRow != null)
                    hashCode = hashCode * 59 + CollectionStoreEntireRow.GetHashCode();
                if (CollectionValueField != null)
                    hashCode = hashCode * 59 + CollectionValueField.GetHashCode();
                if (FieldId != null)
                    hashCode = hashCode * 59 + FieldId.GetHashCode();
                if (ListReturnFieldId != null)
                    hashCode = hashCode * 59 + ListReturnFieldId.GetHashCode();
                if (PromptId != null)
                    hashCode = hashCode * 59 + PromptId.GetHashCode();
                if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                if (ValueIsRecId != null)
                    hashCode = hashCode * 59 + ValueIsRecId.GetHashCode();
                return hashCode;
            }
        }
    }
}