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
    ///     LogRequest
    /// </summary>
    [DataContract]
    public sealed class LogRequest : IEquatable<LogRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="LogRequest" /> class.
        /// </summary>
        /// <param name="keyValueProperties">keyValueProperties.</param>
        /// <param name="level">level.</param>
        /// <param name="message">message.</param>
        public LogRequest(List<Object> keyValueProperties = default, LevelEnum? level = default,
            string message = default)
        {
            KeyValueProperties = keyValueProperties;
            Level = level;
            Message = message;
        }

        /// <summary>
        ///     Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public LevelEnum? Level { get; set; }

        /// <summary>
        ///     Gets or Sets KeyValueProperties
        /// </summary>
        [DataMember(Name = "keyValueProperties", EmitDefaultValue = false)]
        public List<Object> KeyValueProperties { get; set; }


        /// <summary>
        ///     Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        ///     Returns true if LogRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LogRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    KeyValueProperties == input.KeyValueProperties ||
                    KeyValueProperties != null &&
                    KeyValueProperties.SequenceEqual(input.KeyValueProperties)
                ) &&
                (
                    Level == input.Level ||
                    Level != null &&
                    Level.Equals(input.Level)
                ) &&
                (
                    Message == input.Message ||
                    Message != null &&
                    Message.Equals(input.Message)
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
            sb.Append("class LogRequest {\n");
            sb.Append("  KeyValueProperties: ").Append(KeyValueProperties).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return Equals(input as LogRequest);
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
                if (KeyValueProperties != null)
                    hashCode = hashCode * 59 + KeyValueProperties.GetHashCode();
                if (Level != null)
                    hashCode = hashCode * 59 + Level.GetHashCode();
                if (Message != null)
                    hashCode = hashCode * 59 + Message.GetHashCode();
                return hashCode;
            }
        }
    }
}