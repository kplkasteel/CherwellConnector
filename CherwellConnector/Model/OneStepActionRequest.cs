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
    ///     OneStepActionRequest
    /// </summary>
    [DataContract]
    public sealed class OneStepActionRequest : IEquatable<OneStepActionRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="OneStepActionRequest" /> class.
        /// </summary>
        /// <param name="acquireLicense">acquireLicense.</param>
        /// <param name="busObId">busObId.</param>
        /// <param name="busObRecId">busObRecId.</param>
        /// <param name="oneStepActionStandInKey">oneStepActionStandInKey.</param>
        /// <param name="promptValues">promptValues.</param>
        public OneStepActionRequest(bool? acquireLicense = default, string busObId = default,
            string busObRecId = default, string oneStepActionStandInKey = default,
            List<SimplePromptValue> promptValues = default)
        {
            AcquireLicense = acquireLicense;
            BusObId = busObId;
            BusObRecId = busObRecId;
            OneStepActionStandInKey = oneStepActionStandInKey;
            PromptValues = promptValues;
        }

        /// <summary>
        ///     Gets or Sets AcquireLicense
        /// </summary>
        [DataMember(Name = "acquireLicense", EmitDefaultValue = false)]
        public bool? AcquireLicense { get; set; }

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
        ///     Gets or Sets OneStepActionStandInKey
        /// </summary>
        [DataMember(Name = "oneStepActionStandInKey", EmitDefaultValue = false)]
        public string OneStepActionStandInKey { get; set; }

        /// <summary>
        ///     Gets or Sets PromptValues
        /// </summary>
        [DataMember(Name = "promptValues", EmitDefaultValue = false)]
        public List<SimplePromptValue> PromptValues { get; set; }

        /// <summary>
        ///     Returns true if OneStepActionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OneStepActionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OneStepActionRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    AcquireLicense == input.AcquireLicense ||
                    AcquireLicense != null &&
                    AcquireLicense.Equals(input.AcquireLicense)
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
                    OneStepActionStandInKey == input.OneStepActionStandInKey ||
                    OneStepActionStandInKey != null &&
                    OneStepActionStandInKey.Equals(input.OneStepActionStandInKey)
                ) &&
                (
                    PromptValues == input.PromptValues ||
                    PromptValues != null &&
                    PromptValues.SequenceEqual(input.PromptValues)
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
            sb.Append("class OneStepActionRequest {\n");
            sb.Append("  AcquireLicense: ").Append(AcquireLicense).Append("\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  OneStepActionStandInKey: ").Append(OneStepActionStandInKey).Append("\n");
            sb.Append("  PromptValues: ").Append(PromptValues).Append("\n");
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
            return Equals(input as OneStepActionRequest);
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
                if (AcquireLicense != null)
                    hashCode = hashCode * 59 + AcquireLicense.GetHashCode();
                if (BusObId != null)
                    hashCode = hashCode * 59 + BusObId.GetHashCode();
                if (BusObRecId != null)
                    hashCode = hashCode * 59 + BusObRecId.GetHashCode();
                if (OneStepActionStandInKey != null)
                    hashCode = hashCode * 59 + OneStepActionStandInKey.GetHashCode();
                if (PromptValues != null)
                    hashCode = hashCode * 59 + PromptValues.GetHashCode();
                return hashCode;
            }
        }
    }
}