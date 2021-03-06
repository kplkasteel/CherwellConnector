using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     BusObActivity
    /// </summary>
    [DataContract]
    public sealed class BusObActivity : IEquatable<BusObActivity>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BusObActivity" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="parentBusObDefId">parentBusObDefId.</param>
        /// <param name="parentBusObRecId">parentBusObRecId.</param>
        /// <param name="historyBusObDefId">historyBusObDefId.</param>
        /// <param name="historyBusObRecId">historyBusObRecId.</param>
        /// <param name="type">type.</param>
        /// <param name="title">title.</param>
        /// <param name="body">body.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="created">created.</param>
        /// <param name="modified">modified.</param>
        /// <param name="modifiedBy">modifiedBy.</param>
        public BusObActivity(string id = default, string parentBusObDefId = default, string parentBusObRecId = default,
            string historyBusObDefId = default, string historyBusObRecId = default, string type = default,
            string title = default, string body = default, string createdBy = default, DateTime? created = default,
            DateTime? modified = default, string modifiedBy = default)
        {
            Id = id;
            ParentBusObDefId = parentBusObDefId;
            ParentBusObRecId = parentBusObRecId;
            HistoryBusObDefId = historyBusObDefId;
            HistoryBusObRecId = historyBusObRecId;
            Type = type;
            Title = title;
            Body = body;
            CreatedBy = createdBy;
            Created = created;
            Modified = modified;
            ModifiedBy = modifiedBy;
        }

        /// <summary>
        ///     Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        ///     Gets or Sets ParentBusObDefId
        /// </summary>
        [DataMember(Name = "parentBusObDefId", EmitDefaultValue = false)]
        public string ParentBusObDefId { get; set; }

        /// <summary>
        ///     Gets or Sets ParentBusObRecId
        /// </summary>
        [DataMember(Name = "parentBusObRecId", EmitDefaultValue = false)]
        public string ParentBusObRecId { get; set; }

        /// <summary>
        ///     Gets or Sets HistoryBusObDefId
        /// </summary>
        [DataMember(Name = "historyBusObDefId", EmitDefaultValue = false)]
        public string HistoryBusObDefId { get; set; }

        /// <summary>
        ///     Gets or Sets HistoryBusObRecId
        /// </summary>
        [DataMember(Name = "historyBusObRecId", EmitDefaultValue = false)]
        public string HistoryBusObRecId { get; set; }

        /// <summary>
        ///     Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        ///     Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        ///     Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        ///     Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        ///     Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime? Created { get; set; }

        /// <summary>
        ///     Gets or Sets Modified
        /// </summary>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///     Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
        public string ModifiedBy { get; set; }

        /// <summary>
        ///     Returns true if BusObActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of BusObActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusObActivity input)
        {
            if (input == null)
                return false;

            return
                (
                    Id == input.Id ||
                    Id != null &&
                    Id.Equals(input.Id)
                ) &&
                (
                    ParentBusObDefId == input.ParentBusObDefId ||
                    ParentBusObDefId != null &&
                    ParentBusObDefId.Equals(input.ParentBusObDefId)
                ) &&
                (
                    ParentBusObRecId == input.ParentBusObRecId ||
                    ParentBusObRecId != null &&
                    ParentBusObRecId.Equals(input.ParentBusObRecId)
                ) &&
                (
                    HistoryBusObDefId == input.HistoryBusObDefId ||
                    HistoryBusObDefId != null &&
                    HistoryBusObDefId.Equals(input.HistoryBusObDefId)
                ) &&
                (
                    HistoryBusObRecId == input.HistoryBusObRecId ||
                    HistoryBusObRecId != null &&
                    HistoryBusObRecId.Equals(input.HistoryBusObRecId)
                ) &&
                (
                    Type == input.Type ||
                    Type != null &&
                    Type.Equals(input.Type)
                ) &&
                (
                    Title == input.Title ||
                    Title != null &&
                    Title.Equals(input.Title)
                ) &&
                (
                    Body == input.Body ||
                    Body != null &&
                    Body.Equals(input.Body)
                ) &&
                (
                    CreatedBy == input.CreatedBy ||
                    CreatedBy != null &&
                    CreatedBy.Equals(input.CreatedBy)
                ) &&
                (
                    Created == input.Created ||
                    Created != null &&
                    Created.Equals(input.Created)
                ) &&
                (
                    Modified == input.Modified ||
                    Modified != null &&
                    Modified.Equals(input.Modified)
                ) &&
                (
                    ModifiedBy == input.ModifiedBy ||
                    ModifiedBy != null &&
                    ModifiedBy.Equals(input.ModifiedBy)
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
            sb.Append("class BusObActivity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ParentBusObDefId: ").Append(ParentBusObDefId).Append("\n");
            sb.Append("  ParentBusObRecId: ").Append(ParentBusObRecId).Append("\n");
            sb.Append("  HistoryBusObDefId: ").Append(HistoryBusObDefId).Append("\n");
            sb.Append("  HistoryBusObRecId: ").Append(HistoryBusObRecId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
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
            return Equals(input as BusObActivity);
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
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (ParentBusObDefId != null)
                    hashCode = hashCode * 59 + ParentBusObDefId.GetHashCode();
                if (ParentBusObRecId != null)
                    hashCode = hashCode * 59 + ParentBusObRecId.GetHashCode();
                if (HistoryBusObDefId != null)
                    hashCode = hashCode * 59 + HistoryBusObDefId.GetHashCode();
                if (HistoryBusObRecId != null)
                    hashCode = hashCode * 59 + HistoryBusObRecId.GetHashCode();
                if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (Body != null)
                    hashCode = hashCode * 59 + Body.GetHashCode();
                if (CreatedBy != null)
                    hashCode = hashCode * 59 + CreatedBy.GetHashCode();
                if (Created != null)
                    hashCode = hashCode * 59 + Created.GetHashCode();
                if (Modified != null)
                    hashCode = hashCode * 59 + Modified.GetHashCode();
                if (ModifiedBy != null)
                    hashCode = hashCode * 59 + ModifiedBy.GetHashCode();
                return hashCode;
            }
        }
    }
}