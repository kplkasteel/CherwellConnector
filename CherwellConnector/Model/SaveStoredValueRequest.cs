using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using CherwellConnector.Enum;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     SaveStoredValueRequest
    /// </summary>
    [DataContract]
    public sealed class SaveStoredValueRequest : IEquatable<SaveStoredValueRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SaveStoredValueRequest" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="folder">folder.</param>
        /// <param name="name">name.</param>
        /// <param name="scope">scope.</param>
        /// <param name="scopeOwner">scopeOwner.</param>
        /// <param name="standInKey">standInKey.</param>
        /// <param name="storedValueType">storedValueType.</param>
        /// <param name="value">value.</param>
        public SaveStoredValueRequest(string description = default, string folder = default, string name = default,
            string scope = default, string scopeOwner = default, string standInKey = default,
            StoredValueTypeEnum? storedValueType = default, string value = default)
        {
            Description = description;
            Folder = folder;
            Name = name;
            Scope = scope;
            ScopeOwner = scopeOwner;
            StandInKey = standInKey;
            StoredValueType = storedValueType;
            Value = value;
        }

        /// <summary>
        ///     Gets or Sets StoredValueType
        /// </summary>
        [DataMember(Name = "storedValueType", EmitDefaultValue = false)]
        public StoredValueTypeEnum? StoredValueType { get; set; }

        /// <summary>
        ///     Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        ///     Gets or Sets Folder
        /// </summary>
        [DataMember(Name = "folder", EmitDefaultValue = false)]
        public string Folder { get; set; }

        /// <summary>
        ///     Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public string Scope { get; set; }

        /// <summary>
        ///     Gets or Sets ScopeOwner
        /// </summary>
        [DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
        public string ScopeOwner { get; set; }

        /// <summary>
        ///     Gets or Sets StandInKey
        /// </summary>
        [DataMember(Name = "standInKey", EmitDefaultValue = false)]
        public string StandInKey { get; set; }


        /// <summary>
        ///     Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        ///     Returns true if SaveStoredValueRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveStoredValueRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveStoredValueRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    Description == input.Description ||
                    Description != null &&
                    Description.Equals(input.Description)
                ) &&
                (
                    Folder == input.Folder ||
                    Folder != null &&
                    Folder.Equals(input.Folder)
                ) &&
                (
                    Name == input.Name ||
                    Name != null &&
                    Name.Equals(input.Name)
                ) &&
                (
                    Scope == input.Scope ||
                    Scope != null &&
                    Scope.Equals(input.Scope)
                ) &&
                (
                    ScopeOwner == input.ScopeOwner ||
                    ScopeOwner != null &&
                    ScopeOwner.Equals(input.ScopeOwner)
                ) &&
                (
                    StandInKey == input.StandInKey ||
                    StandInKey != null &&
                    StandInKey.Equals(input.StandInKey)
                ) &&
                (
                    StoredValueType == input.StoredValueType ||
                    StoredValueType != null &&
                    StoredValueType.Equals(input.StoredValueType)
                ) &&
                (
                    Value == input.Value ||
                    Value != null &&
                    Value.Equals(input.Value)
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
            sb.Append("class SaveStoredValueRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append("\n");
            sb.Append("  StandInKey: ").Append(StandInKey).Append("\n");
            sb.Append("  StoredValueType: ").Append(StoredValueType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return Equals(input as SaveStoredValueRequest);
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
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (Folder != null)
                    hashCode = hashCode * 59 + Folder.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Scope != null)
                    hashCode = hashCode * 59 + Scope.GetHashCode();
                if (ScopeOwner != null)
                    hashCode = hashCode * 59 + ScopeOwner.GetHashCode();
                if (StandInKey != null)
                    hashCode = hashCode * 59 + StandInKey.GetHashCode();
                if (StoredValueType != null)
                    hashCode = hashCode * 59 + StoredValueType.GetHashCode();
                if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                return hashCode;
            }
        }
    }
}