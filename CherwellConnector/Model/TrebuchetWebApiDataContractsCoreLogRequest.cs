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
    /// TrebuchetWebApiDataContractsCoreLogRequest
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsCoreLogRequest :  IEquatable<TrebuchetWebApiDataContractsCoreLogRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines Level
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LevelEnum
        {
            
            /// <summary>
            /// Enum Fatal for value: Fatal
            /// </summary>
            [EnumMember(Value = "Fatal")]
            Fatal = 1,
            
            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            [EnumMember(Value = "Error")]
            Error = 2,
            
            /// <summary>
            /// Enum Warning for value: Warning
            /// </summary>
            [EnumMember(Value = "Warning")]
            Warning = 3,
            
            /// <summary>
            /// Enum Info for value: Info
            /// </summary>
            [EnumMember(Value = "Info")]
            Info = 4,
            
            /// <summary>
            /// Enum Stats for value: Stats
            /// </summary>
            [EnumMember(Value = "Stats")]
            Stats = 5,
            
            /// <summary>
            /// Enum Debug for value: Debug
            /// </summary>
            [EnumMember(Value = "Debug")]
            Debug = 6
        }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public LevelEnum? Level { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsCoreLogRequest" /> class.
        /// </summary>
        /// <param name="keyValueProperties">keyValueProperties.</param>
        /// <param name="level">level.</param>
        /// <param name="message">message.</param>
        public TrebuchetWebApiDataContractsCoreLogRequest(List<Object> keyValueProperties = default(List<Object>), LevelEnum? level = default(LevelEnum?), string message = default(string))
        {
            this.KeyValueProperties = keyValueProperties;
            this.Level = level;
            this.Message = message;
        }
        
        /// <summary>
        /// Gets or Sets KeyValueProperties
        /// </summary>
        [DataMember(Name="keyValueProperties", EmitDefaultValue=false)]
        public List<Object> KeyValueProperties { get; set; }


        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsCoreLogRequest {\n");
            sb.Append("  KeyValueProperties: ").Append(this.KeyValueProperties).Append("\n");
            sb.Append("  Level: ").Append(this.Level).Append("\n");
            sb.Append("  Message: ").Append(this.Message).Append("\n");
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
            return this.Equals(input as TrebuchetWebApiDataContractsCoreLogRequest);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsCoreLogRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsCoreLogRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsCoreLogRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeyValueProperties == input.KeyValueProperties ||
                    this.KeyValueProperties != null &&
                    this.KeyValueProperties.SequenceEqual(input.KeyValueProperties)
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.KeyValueProperties != null)
                    hashCode = hashCode * 59 + this.KeyValueProperties.GetHashCode();
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
