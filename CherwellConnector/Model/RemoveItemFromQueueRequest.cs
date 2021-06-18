using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     RemoveItemFromQueueRequest
    /// </summary>
    [DataContract]
    public sealed class RemoveItemFromQueueRequest : IEquatable<RemoveItemFromQueueRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RemoveItemFromQueueRequest" /> class.
        /// </summary>
        /// <param name="busObId">busObId.</param>
        /// <param name="busObRecId">busObRecId.</param>
        /// <param name="historyNotes">historyNotes.</param>
        /// <param name="queueStandInKey">queueStandInKey.</param>
        public RemoveItemFromQueueRequest(string busObId = default, string busObRecId = default,
            string historyNotes = default, string queueStandInKey = default)
        {
            BusObId = busObId;
            BusObRecId = busObRecId;
            HistoryNotes = historyNotes;
            QueueStandInKey = queueStandInKey;
        }

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
        ///     Gets or Sets HistoryNotes
        /// </summary>
        [DataMember(Name = "historyNotes", EmitDefaultValue = false)]
        public string HistoryNotes { get; set; }

        /// <summary>
        ///     Gets or Sets QueueStandInKey
        /// </summary>
        [DataMember(Name = "queueStandInKey", EmitDefaultValue = false)]
        public string QueueStandInKey { get; set; }

        /// <summary>
        ///     Returns true if RemoveItemFromQueueRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoveItemFromQueueRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoveItemFromQueueRequest input)
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
                    BusObRecId == input.BusObRecId ||
                    BusObRecId != null &&
                    BusObRecId.Equals(input.BusObRecId)
                ) &&
                (
                    HistoryNotes == input.HistoryNotes ||
                    HistoryNotes != null &&
                    HistoryNotes.Equals(input.HistoryNotes)
                ) &&
                (
                    QueueStandInKey == input.QueueStandInKey ||
                    QueueStandInKey != null &&
                    QueueStandInKey.Equals(input.QueueStandInKey)
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
            sb.Append("class RemoveItemFromQueueRequest {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  HistoryNotes: ").Append(HistoryNotes).Append("\n");
            sb.Append("  QueueStandInKey: ").Append(QueueStandInKey).Append("\n");
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
            return Equals(input as RemoveItemFromQueueRequest);
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
                if (BusObRecId != null)
                    hashCode = hashCode * 59 + BusObRecId.GetHashCode();
                if (HistoryNotes != null)
                    hashCode = hashCode * 59 + HistoryNotes.GetHashCode();
                if (QueueStandInKey != null)
                    hashCode = hashCode * 59 + QueueStandInKey.GetHashCode();
                return hashCode;
            }
        }
    }
}