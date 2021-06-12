
namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// SaveWorkgroupMemberRequest
    /// </summary>
    [DataContract]
    public sealed class SaveWorkgroupMemberRequest :  IEquatable<SaveWorkgroupMemberRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveWorkgroupMemberRequest" /> class.
        /// </summary>
        /// <param name="customerRecordId">customerRecordId.</param>
        /// <param name="workgroupId">workgroupId.</param>
        /// <param name="customerIsWorkgroupManager">customerIsWorkgroupManager.</param>
        public SaveWorkgroupMemberRequest(string customerRecordId = default, string workgroupId = default, bool? customerIsWorkgroupManager = default)
        {
            CustomerRecordId = customerRecordId;
            WorkgroupId = workgroupId;
            CustomerIsWorkgroupManager = customerIsWorkgroupManager;
        }
        
        /// <summary>
        /// Gets or Sets CustomerRecordId
        /// </summary>
        [DataMember(Name="customerRecordId", EmitDefaultValue=false)]
        public string CustomerRecordId { get; set; }

        /// <summary>
        /// Gets or Sets WorkgroupId
        /// </summary>
        [DataMember(Name="workgroupId", EmitDefaultValue=false)]
        public string WorkgroupId { get; set; }

        /// <summary>
        /// Gets or Sets CustomerIsWorkgroupManager
        /// </summary>
        [DataMember(Name="customerIsWorkgroupManager", EmitDefaultValue=false)]
        public bool? CustomerIsWorkgroupManager { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveWorkgroupMemberRequest {\n");
            sb.Append("  CustomerRecordId: ").Append(CustomerRecordId).Append("\n");
            sb.Append("  WorkgroupId: ").Append(WorkgroupId).Append("\n");
            sb.Append("  CustomerIsWorkgroupManager: ").Append(CustomerIsWorkgroupManager).Append("\n");
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
            return Equals(input as SaveWorkgroupMemberRequest);
        }

        /// <summary>
        /// Returns true if SaveWorkgroupMemberRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveWorkgroupMemberRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveWorkgroupMemberRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    CustomerRecordId == input.CustomerRecordId ||
                    (CustomerRecordId != null &&
                    CustomerRecordId.Equals(input.CustomerRecordId))
                ) && 
                (
                    WorkgroupId == input.WorkgroupId ||
                    (WorkgroupId != null &&
                    WorkgroupId.Equals(input.WorkgroupId))
                ) && 
                (
                    CustomerIsWorkgroupManager == input.CustomerIsWorkgroupManager ||
                    (CustomerIsWorkgroupManager != null &&
                    CustomerIsWorkgroupManager.Equals(input.CustomerIsWorkgroupManager))
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
                if (CustomerRecordId != null)
                    hashCode = hashCode * 59 + CustomerRecordId.GetHashCode();
                if (WorkgroupId != null)
                    hashCode = hashCode * 59 + WorkgroupId.GetHashCode();
                if (CustomerIsWorkgroupManager != null)
                    hashCode = hashCode * 59 + CustomerIsWorkgroupManager.GetHashCode();
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
