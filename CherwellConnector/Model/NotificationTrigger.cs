using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     NotificationTrigger
    /// </summary>
    [DataContract]
    public sealed class NotificationTrigger : IEquatable<NotificationTrigger>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="NotificationTrigger" /> class.
        /// </summary>
        /// <param name="sourceType">sourceType.</param>
        /// <param name="sourceId">sourceId.</param>
        /// <param name="sourceChange">sourceChange.</param>
        /// <param name="key">key.</param>
        public NotificationTrigger(string sourceType = default, string sourceId = default,
            string sourceChange = default, string key = default)
        {
            SourceType = sourceType;
            SourceId = sourceId;
            SourceChange = sourceChange;
            Key = key;
        }

        /// <summary>
        ///     Gets or Sets SourceType
        /// </summary>
        [DataMember(Name = "sourceType", EmitDefaultValue = false)]
        public string SourceType { get; set; }

        /// <summary>
        ///     Gets or Sets SourceId
        /// </summary>
        [DataMember(Name = "sourceId", EmitDefaultValue = false)]
        public string SourceId { get; set; }

        /// <summary>
        ///     Gets or Sets SourceChange
        /// </summary>
        [DataMember(Name = "sourceChange", EmitDefaultValue = false)]
        public string SourceChange { get; set; }

        /// <summary>
        ///     Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        ///     Returns true if NotificationTrigger instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationTrigger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationTrigger input)
        {
            if (input == null)
                return false;

            return
                (
                    SourceType == input.SourceType ||
                    SourceType != null &&
                    SourceType.Equals(input.SourceType)
                ) &&
                (
                    SourceId == input.SourceId ||
                    SourceId != null &&
                    SourceId.Equals(input.SourceId)
                ) &&
                (
                    SourceChange == input.SourceChange ||
                    SourceChange != null &&
                    SourceChange.Equals(input.SourceChange)
                ) &&
                (
                    Key == input.Key ||
                    Key != null &&
                    Key.Equals(input.Key)
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
            sb.Append("class NotificationTrigger {\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  SourceChange: ").Append(SourceChange).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return Equals(input as NotificationTrigger);
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
                if (SourceType != null)
                    hashCode = hashCode * 59 + SourceType.GetHashCode();
                if (SourceId != null)
                    hashCode = hashCode * 59 + SourceId.GetHashCode();
                if (SourceChange != null)
                    hashCode = hashCode * 59 + SourceChange.GetHashCode();
                if (Key != null)
                    hashCode = hashCode * 59 + Key.GetHashCode();
                return hashCode;
            }
        }
    }
}