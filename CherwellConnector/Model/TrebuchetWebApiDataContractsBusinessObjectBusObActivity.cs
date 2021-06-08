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
    /// TrebuchetWebApiDataContractsBusinessObjectBusObActivity
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsBusinessObjectBusObActivity :  IEquatable<TrebuchetWebApiDataContractsBusinessObjectBusObActivity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsBusinessObjectBusObActivity" /> class.
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
        public TrebuchetWebApiDataContractsBusinessObjectBusObActivity(string id = default(string), string parentBusObDefId = default(string), string parentBusObRecId = default(string), string historyBusObDefId = default(string), string historyBusObRecId = default(string), string type = default(string), string title = default(string), string body = default(string), string createdBy = default(string), DateTime? created = default(DateTime?), DateTime? modified = default(DateTime?), string modifiedBy = default(string))
        {
            this.Id = id;
            this.ParentBusObDefId = parentBusObDefId;
            this.ParentBusObRecId = parentBusObRecId;
            this.HistoryBusObDefId = historyBusObDefId;
            this.HistoryBusObRecId = historyBusObRecId;
            this.Type = type;
            this.Title = title;
            this.Body = body;
            this.CreatedBy = createdBy;
            this.Created = created;
            this.Modified = modified;
            this.ModifiedBy = modifiedBy;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ParentBusObDefId
        /// </summary>
        [DataMember(Name="parentBusObDefId", EmitDefaultValue=false)]
        public string ParentBusObDefId { get; set; }

        /// <summary>
        /// Gets or Sets ParentBusObRecId
        /// </summary>
        [DataMember(Name="parentBusObRecId", EmitDefaultValue=false)]
        public string ParentBusObRecId { get; set; }

        /// <summary>
        /// Gets or Sets HistoryBusObDefId
        /// </summary>
        [DataMember(Name="historyBusObDefId", EmitDefaultValue=false)]
        public string HistoryBusObDefId { get; set; }

        /// <summary>
        /// Gets or Sets HistoryBusObRecId
        /// </summary>
        [DataMember(Name="historyBusObRecId", EmitDefaultValue=false)]
        public string HistoryBusObRecId { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsBusinessObjectBusObActivity {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  ParentBusObDefId: ").Append(this.ParentBusObDefId).Append("\n");
            sb.Append("  ParentBusObRecId: ").Append(this.ParentBusObRecId).Append("\n");
            sb.Append("  HistoryBusObDefId: ").Append(this.HistoryBusObDefId).Append("\n");
            sb.Append("  HistoryBusObRecId: ").Append(this.HistoryBusObRecId).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Title: ").Append(this.Title).Append("\n");
            sb.Append("  Body: ").Append(this.Body).Append("\n");
            sb.Append("  CreatedBy: ").Append(this.CreatedBy).Append("\n");
            sb.Append("  Created: ").Append(this.Created).Append("\n");
            sb.Append("  Modified: ").Append(this.Modified).Append("\n");
            sb.Append("  ModifiedBy: ").Append(this.ModifiedBy).Append("\n");
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
            return this.Equals(input as TrebuchetWebApiDataContractsBusinessObjectBusObActivity);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsBusinessObjectBusObActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsBusinessObjectBusObActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsBusinessObjectBusObActivity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ParentBusObDefId == input.ParentBusObDefId ||
                    (this.ParentBusObDefId != null &&
                    this.ParentBusObDefId.Equals(input.ParentBusObDefId))
                ) && 
                (
                    this.ParentBusObRecId == input.ParentBusObRecId ||
                    (this.ParentBusObRecId != null &&
                    this.ParentBusObRecId.Equals(input.ParentBusObRecId))
                ) && 
                (
                    this.HistoryBusObDefId == input.HistoryBusObDefId ||
                    (this.HistoryBusObDefId != null &&
                    this.HistoryBusObDefId.Equals(input.HistoryBusObDefId))
                ) && 
                (
                    this.HistoryBusObRecId == input.HistoryBusObRecId ||
                    (this.HistoryBusObRecId != null &&
                    this.HistoryBusObRecId.Equals(input.HistoryBusObRecId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.ModifiedBy == input.ModifiedBy ||
                    (this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(input.ModifiedBy))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ParentBusObDefId != null)
                    hashCode = hashCode * 59 + this.ParentBusObDefId.GetHashCode();
                if (this.ParentBusObRecId != null)
                    hashCode = hashCode * 59 + this.ParentBusObRecId.GetHashCode();
                if (this.HistoryBusObDefId != null)
                    hashCode = hashCode * 59 + this.HistoryBusObDefId.GetHashCode();
                if (this.HistoryBusObRecId != null)
                    hashCode = hashCode * 59 + this.HistoryBusObRecId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.ModifiedBy != null)
                    hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
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
