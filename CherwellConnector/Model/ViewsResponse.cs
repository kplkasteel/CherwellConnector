namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// ViewsResponse
    /// </summary>
    [DataContract]
    public sealed class ViewsResponse :  IEquatable<ViewsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewsResponse" /> class.
        /// </summary>
        /// <param name="views">views.</param>
        public ViewsResponse(List<View> views = default)
        {
            Views = views;
        }
        
        /// <summary>
        /// Gets or Sets Views
        /// </summary>
        [DataMember(Name="views", EmitDefaultValue=false)]
        public List<View> Views { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViewsResponse {\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return Equals(input as ViewsResponse);
        }

        /// <summary>
        /// Returns true if ViewsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    Views == input.Views ||
                    Views != null &&
                    Views.SequenceEqual(input.Views)
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
                if (Views != null)
                    hashCode = hashCode * 59 + Views.GetHashCode();
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
