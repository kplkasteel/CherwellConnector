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
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// TrebuchetWebApiDataContractsCorePromptValue
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsCorePromptValue :  IEquatable<TrebuchetWebApiDataContractsCorePromptValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsCorePromptValue" /> class.
        /// </summary>
        /// <param name="busObId">busObId.</param>
        /// <param name="collectionStoreEntireRow">collectionStoreEntireRow.</param>
        /// <param name="collectionValueField">collectionValueField.</param>
        /// <param name="fieldId">fieldId.</param>
        /// <param name="listReturnFieldId">listReturnFieldId.</param>
        /// <param name="promptId">promptId.</param>
        /// <param name="value">value.</param>
        /// <param name="valueIsRecId">valueIsRecId.</param>
        public TrebuchetWebApiDataContractsCorePromptValue(string busObId = default(string), string collectionStoreEntireRow = default(string), string collectionValueField = default(string), string fieldId = default(string), string listReturnFieldId = default(string), string promptId = default(string), Object value = default(Object), bool? valueIsRecId = default(bool?))
        {
            this.BusObId = busObId;
            this.CollectionStoreEntireRow = collectionStoreEntireRow;
            this.CollectionValueField = collectionValueField;
            this.FieldId = fieldId;
            this.ListReturnFieldId = listReturnFieldId;
            this.PromptId = promptId;
            this.Value = value;
            this.ValueIsRecId = valueIsRecId;
        }
        
        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }

        /// <summary>
        /// Gets or Sets CollectionStoreEntireRow
        /// </summary>
        [DataMember(Name="collectionStoreEntireRow", EmitDefaultValue=false)]
        public string CollectionStoreEntireRow { get; set; }

        /// <summary>
        /// Gets or Sets CollectionValueField
        /// </summary>
        [DataMember(Name="collectionValueField", EmitDefaultValue=false)]
        public string CollectionValueField { get; set; }

        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }

        /// <summary>
        /// Gets or Sets ListReturnFieldId
        /// </summary>
        [DataMember(Name="listReturnFieldId", EmitDefaultValue=false)]
        public string ListReturnFieldId { get; set; }

        /// <summary>
        /// Gets or Sets PromptId
        /// </summary>
        [DataMember(Name="promptId", EmitDefaultValue=false)]
        public string PromptId { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }

        /// <summary>
        /// Gets or Sets ValueIsRecId
        /// </summary>
        [DataMember(Name="valueIsRecId", EmitDefaultValue=false)]
        public bool? ValueIsRecId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsCorePromptValue {\n");
            sb.Append("  BusObId: ").Append(this.BusObId).Append("\n");
            sb.Append("  CollectionStoreEntireRow: ").Append(this.CollectionStoreEntireRow).Append("\n");
            sb.Append("  CollectionValueField: ").Append(this.CollectionValueField).Append("\n");
            sb.Append("  FieldId: ").Append(this.FieldId).Append("\n");
            sb.Append("  ListReturnFieldId: ").Append(this.ListReturnFieldId).Append("\n");
            sb.Append("  PromptId: ").Append(this.PromptId).Append("\n");
            sb.Append("  Value: ").Append(this.Value).Append("\n");
            sb.Append("  ValueIsRecId: ").Append(this.ValueIsRecId).Append("\n");
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
            return this.Equals(input as TrebuchetWebApiDataContractsCorePromptValue);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsCorePromptValue instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsCorePromptValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsCorePromptValue input)
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
                    this.CollectionStoreEntireRow == input.CollectionStoreEntireRow ||
                    (this.CollectionStoreEntireRow != null &&
                    this.CollectionStoreEntireRow.Equals(input.CollectionStoreEntireRow))
                ) && 
                (
                    this.CollectionValueField == input.CollectionValueField ||
                    (this.CollectionValueField != null &&
                    this.CollectionValueField.Equals(input.CollectionValueField))
                ) && 
                (
                    this.FieldId == input.FieldId ||
                    (this.FieldId != null &&
                    this.FieldId.Equals(input.FieldId))
                ) && 
                (
                    this.ListReturnFieldId == input.ListReturnFieldId ||
                    (this.ListReturnFieldId != null &&
                    this.ListReturnFieldId.Equals(input.ListReturnFieldId))
                ) && 
                (
                    this.PromptId == input.PromptId ||
                    (this.PromptId != null &&
                    this.PromptId.Equals(input.PromptId))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.ValueIsRecId == input.ValueIsRecId ||
                    (this.ValueIsRecId != null &&
                    this.ValueIsRecId.Equals(input.ValueIsRecId))
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
                if (this.CollectionStoreEntireRow != null)
                    hashCode = hashCode * 59 + this.CollectionStoreEntireRow.GetHashCode();
                if (this.CollectionValueField != null)
                    hashCode = hashCode * 59 + this.CollectionValueField.GetHashCode();
                if (this.FieldId != null)
                    hashCode = hashCode * 59 + this.FieldId.GetHashCode();
                if (this.ListReturnFieldId != null)
                    hashCode = hashCode * 59 + this.ListReturnFieldId.GetHashCode();
                if (this.PromptId != null)
                    hashCode = hashCode * 59 + this.PromptId.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ValueIsRecId != null)
                    hashCode = hashCode * 59 + this.ValueIsRecId.GetHashCode();
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