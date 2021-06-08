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
    /// TrebuchetWebApiDataContractsTeamsSaveWorkgroupMemberRequest
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsTeamsSaveWorkgroupMemberRequest :  IEquatable<TrebuchetWebApiDataContractsTeamsSaveWorkgroupMemberRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsTeamsSaveWorkgroupMemberRequest" /> class.
        /// </summary>
        /// <param name="customerRecordId">customerRecordId.</param>
        /// <param name="workgroupId">workgroupId.</param>
        /// <param name="customerIsWorkgroupManager">customerIsWorkgroupManager.</param>
        public TrebuchetWebApiDataContractsTeamsSaveWorkgroupMemberRequest(string customerRecordId = default(string), string workgroupId = default(string), bool? customerIsWorkgroupManager = default(bool?))
        {
            this.CustomerRecordId = customerRecordId;
            this.WorkgroupId = workgroupId;
            this.CustomerIsWorkgroupManager = customerIsWorkgroupManager;
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
            sb.Append("class TrebuchetWebApiDataContractsTeamsSaveWorkgroupMemberRequest {\n");
            sb.Append("  CustomerRecordId: ").Append(this.CustomerRecordId).Append("\n");
            sb.Append("  WorkgroupId: ").Append(this.WorkgroupId).Append("\n");
            sb.Append("  CustomerIsWorkgroupManager: ").Append(this.CustomerIsWorkgroupManager).Append("\n");
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
            return this.Equals(input as TrebuchetWebApiDataContractsTeamsSaveWorkgroupMemberRequest);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsTeamsSaveWorkgroupMemberRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsTeamsSaveWorkgroupMemberRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsTeamsSaveWorkgroupMemberRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomerRecordId == input.CustomerRecordId ||
                    (this.CustomerRecordId != null &&
                    this.CustomerRecordId.Equals(input.CustomerRecordId))
                ) && 
                (
                    this.WorkgroupId == input.WorkgroupId ||
                    (this.WorkgroupId != null &&
                    this.WorkgroupId.Equals(input.WorkgroupId))
                ) && 
                (
                    this.CustomerIsWorkgroupManager == input.CustomerIsWorkgroupManager ||
                    (this.CustomerIsWorkgroupManager != null &&
                    this.CustomerIsWorkgroupManager.Equals(input.CustomerIsWorkgroupManager))
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
                if (this.CustomerRecordId != null)
                    hashCode = hashCode * 59 + this.CustomerRecordId.GetHashCode();
                if (this.WorkgroupId != null)
                    hashCode = hashCode * 59 + this.WorkgroupId.GetHashCode();
                if (this.CustomerIsWorkgroupManager != null)
                    hashCode = hashCode * 59 + this.CustomerIsWorkgroupManager.GetHashCode();
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