
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
    /// TrebuchetWebApiDataContractsSearchesColumnSchema
    /// </summary>
    [DataContract]
    public sealed class TrebuchetWebApiDataContractsSearchesColumnSchema :  IEquatable<TrebuchetWebApiDataContractsSearchesColumnSchema>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
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
            /// Enum Currency for value: Currency
            /// </summary>
            [EnumMember(Value = "Currency")]
            Currency = 3,
            
            /// <summary>
            /// Enum Integer for value: Integer
            /// </summary>
            [EnumMember(Value = "Integer")]
            Integer = 4,
            
            /// <summary>
            /// Enum Datetime for value: Datetime
            /// </summary>
            [EnumMember(Value = "Datetime")]
            Datetime = 5,
            
            /// <summary>
            /// Enum Date for value: Date
            /// </summary>
            [EnumMember(Value = "Date")]
            Date = 6,
            
            /// <summary>
            /// Enum Time for value: Time
            /// </summary>
            [EnumMember(Value = "Time")]
            Time = 7,
            
            /// <summary>
            /// Enum Logical for value: Logical
            /// </summary>
            [EnumMember(Value = "Logical")]
            Logical = 8
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsSearchesColumnSchema" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="fieldId">fieldId.</param>
        /// <param name="type">type.</param>
        public TrebuchetWebApiDataContractsSearchesColumnSchema(string name = default, string fieldId = default, TypeEnum? type = default)
        {
            Name = name;
            FieldId = fieldId;
            Type = type;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsSearchesColumnSchema {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  string ToJson()
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
            return Equals(input as TrebuchetWebApiDataContractsSearchesColumnSchema);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsSearchesColumnSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsSearchesColumnSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsSearchesColumnSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    FieldId == input.FieldId ||
                    (FieldId != null &&
                    FieldId.Equals(input.FieldId))
                ) && 
                (
                    Type == input.Type ||
                    (Type != null &&
                    Type.Equals(input.Type))
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
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (FieldId != null)
                    hashCode = hashCode * 59 + FieldId.GetHashCode();
                if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
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
