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
    /// TrebuchetWebApiDataContractsLifecycleGetStagesResponseStages
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsLifecycleGetStagesResponseStages :  IEquatable<TrebuchetWebApiDataContractsLifecycleGetStagesResponseStages>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsLifecycleGetStagesResponseStages" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="isFinal">isFinal.</param>
        /// <param name="name">name.</param>
        public TrebuchetWebApiDataContractsLifecycleGetStagesResponseStages(string id = default(string), bool? isFinal = default(bool?), string name = default(string))
        {
            this.Id = id;
            this.IsFinal = isFinal;
            this.Name = name;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IsFinal
        /// </summary>
        [DataMember(Name="isFinal", EmitDefaultValue=false)]
        public bool? IsFinal { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsLifecycleGetStagesResponseStages {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  IsFinal: ").Append(this.IsFinal).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
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
            return this.Equals(input as TrebuchetWebApiDataContractsLifecycleGetStagesResponseStages);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsLifecycleGetStagesResponseStages instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsLifecycleGetStagesResponseStages to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsLifecycleGetStagesResponseStages input)
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
                    this.IsFinal == input.IsFinal ||
                    (this.IsFinal != null &&
                    this.IsFinal.Equals(input.IsFinal))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.IsFinal != null)
                    hashCode = hashCode * 59 + this.IsFinal.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
