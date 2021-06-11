
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
    /// TrebuchetWebApiDataContractsSearchesStoredSearchResults
    /// </summary>
    [DataContract]
    public sealed class TrebuchetWebApiDataContractsSearchesStoredSearchResults :  IEquatable<TrebuchetWebApiDataContractsSearchesStoredSearchResults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsSearchesStoredSearchResults" /> class.
        /// </summary>
        /// <param name="columns">columns.</param>
        public TrebuchetWebApiDataContractsSearchesStoredSearchResults(List<TrebuchetWebApiDataContractsSearchesColumnSchema> columns = default)
        {
            Columns = columns;
        }
        
        /// <summary>
        /// Gets or Sets Columns
        /// </summary>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public List<TrebuchetWebApiDataContractsSearchesColumnSchema> Columns { get; set; }

        /// <summary>
        /// Gets or Sets Rows
        /// </summary>
        [DataMember(Name="rows", EmitDefaultValue=false)]
        public List<List<Object>> Rows { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsSearchesStoredSearchResults {\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
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
            return Equals(input as TrebuchetWebApiDataContractsSearchesStoredSearchResults);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsSearchesStoredSearchResults instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsSearchesStoredSearchResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsSearchesStoredSearchResults input)
        {
            if (input == null)
                return false;

            return 
                (
                    Columns == input.Columns ||
                    Columns != null &&
                    Columns.SequenceEqual(input.Columns)
                ) && 
                (
                    Rows == input.Rows ||
                    Rows != null &&
                    Rows.SequenceEqual(input.Rows)
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
                if (Columns != null)
                    hashCode = hashCode * 59 + Columns.GetHashCode();
                if (Rows != null)
                    hashCode = hashCode * 59 + Rows.GetHashCode();
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
