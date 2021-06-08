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
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// TrebuchetWebApiDataContractsCoreSaveStoredValueRequest
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsCoreSaveStoredValueRequest :  IEquatable<TrebuchetWebApiDataContractsCoreSaveStoredValueRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines StoredValueType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StoredValueTypeEnum
        {
            
            /// <summary>
            /// Enum Text for value: Text
            /// </summary>
            [EnumMember(Value = "Text")]
            Text = 1,
            
            /// <summary>
            /// Enum Number for value: Number
            /// </summary>
            [EnumMember(Value = "Number")]
            Number = 2,
            
            /// <summary>
            /// Enum DateTime for value: DateTime
            /// </summary>
            [EnumMember(Value = "DateTime")]
            DateTime = 3,
            
            /// <summary>
            /// Enum Logical for value: Logical
            /// </summary>
            [EnumMember(Value = "Logical")]
            Logical = 4,
            
            /// <summary>
            /// Enum Color for value: Color
            /// </summary>
            [EnumMember(Value = "Color")]
            Color = 5,
            
            /// <summary>
            /// Enum Json for value: Json
            /// </summary>
            [EnumMember(Value = "Json")]
            Json = 6,
            
            /// <summary>
            /// Enum JsonArray for value: JsonArray
            /// </summary>
            [EnumMember(Value = "JsonArray")]
            JsonArray = 7,
            
            /// <summary>
            /// Enum Xml for value: Xml
            /// </summary>
            [EnumMember(Value = "Xml")]
            Xml = 8,
            
            /// <summary>
            /// Enum XmlCollection for value: XmlCollection
            /// </summary>
            [EnumMember(Value = "XmlCollection")]
            XmlCollection = 9
        }

        /// <summary>
        /// Gets or Sets StoredValueType
        /// </summary>
        [DataMember(Name="storedValueType", EmitDefaultValue=false)]
        public StoredValueTypeEnum? StoredValueType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsCoreSaveStoredValueRequest" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="folder">folder.</param>
        /// <param name="name">name.</param>
        /// <param name="scope">scope.</param>
        /// <param name="scopeOwner">scopeOwner.</param>
        /// <param name="standInKey">standInKey.</param>
        /// <param name="storedValueType">storedValueType.</param>
        /// <param name="value">value.</param>
        public TrebuchetWebApiDataContractsCoreSaveStoredValueRequest(string description = default(string), string folder = default(string), string name = default(string), string scope = default(string), string scopeOwner = default(string), string standInKey = default(string), StoredValueTypeEnum? storedValueType = default(StoredValueTypeEnum?), string value = default(string))
        {
            this.Description = description;
            this.Folder = folder;
            this.Name = name;
            this.Scope = scope;
            this.ScopeOwner = scopeOwner;
            this.StandInKey = standInKey;
            this.StoredValueType = storedValueType;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Folder
        /// </summary>
        [DataMember(Name="folder", EmitDefaultValue=false)]
        public string Folder { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or Sets ScopeOwner
        /// </summary>
        [DataMember(Name="scopeOwner", EmitDefaultValue=false)]
        public string ScopeOwner { get; set; }

        /// <summary>
        /// Gets or Sets StandInKey
        /// </summary>
        [DataMember(Name="standInKey", EmitDefaultValue=false)]
        public string StandInKey { get; set; }


        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsCoreSaveStoredValueRequest {\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  Folder: ").Append(this.Folder).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Scope: ").Append(this.Scope).Append("\n");
            sb.Append("  ScopeOwner: ").Append(this.ScopeOwner).Append("\n");
            sb.Append("  StandInKey: ").Append(this.StandInKey).Append("\n");
            sb.Append("  StoredValueType: ").Append(this.StoredValueType).Append("\n");
            sb.Append("  Value: ").Append(this.Value).Append("\n");
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
            return this.Equals(input as TrebuchetWebApiDataContractsCoreSaveStoredValueRequest);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsCoreSaveStoredValueRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsCoreSaveStoredValueRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsCoreSaveStoredValueRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Folder == input.Folder ||
                    (this.Folder != null &&
                    this.Folder.Equals(input.Folder))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.ScopeOwner == input.ScopeOwner ||
                    (this.ScopeOwner != null &&
                    this.ScopeOwner.Equals(input.ScopeOwner))
                ) && 
                (
                    this.StandInKey == input.StandInKey ||
                    (this.StandInKey != null &&
                    this.StandInKey.Equals(input.StandInKey))
                ) && 
                (
                    this.StoredValueType == input.StoredValueType ||
                    (this.StoredValueType != null &&
                    this.StoredValueType.Equals(input.StoredValueType))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Folder != null)
                    hashCode = hashCode * 59 + this.Folder.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.ScopeOwner != null)
                    hashCode = hashCode * 59 + this.ScopeOwner.GetHashCode();
                if (this.StandInKey != null)
                    hashCode = hashCode * 59 + this.StandInKey.GetHashCode();
                if (this.StoredValueType != null)
                    hashCode = hashCode * 59 + this.StoredValueType.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
