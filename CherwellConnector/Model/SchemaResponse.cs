
using System.Diagnostics.CodeAnalysis;
using CherwellConnector.Enum;

namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// SchemaResponse
    /// </summary>
    [DataContract]
    public sealed class SchemaResponse :  IEquatable<SchemaResponse>, IValidatableObject
    {
       

        /// <summary>
        /// Gets or Sets HttpStatusCode
        /// </summary>
        [DataMember(Name="httpStatusCode", EmitDefaultValue=false)]
        public HttpStatusCodeEnum? HttpStatusCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaResponse" /> class.
        /// </summary>
        /// <param name="busObId">busObId.</param>
        /// <param name="fieldDefinitions">fieldDefinitions.</param>
        /// <param name="firstRecIdField">firstRecIdField.</param>
        /// <param name="gridDefinitions">gridDefinitions.</param>
        /// <param name="name">name.</param>
        /// <param name="recIdFields">recIdFields.</param>
        /// <param name="relationships">relationships.</param>
        /// <param name="stateFieldId">stateFieldId.</param>
        /// <param name="states">states.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public SchemaResponse(string busObId = default, List<FieldDefinition> fieldDefinitions = default, string firstRecIdField = default, List<GridDefinition> gridDefinitions = default, string name = default, string recIdFields = default, List<Relationship> relationships = default, string stateFieldId = default, string states = default, string errorCode = default, string errorMessage = default, bool? hasError = default, HttpStatusCodeEnum? httpStatusCode = default)
        {
            BusObId = busObId;
            FieldDefinitions = fieldDefinitions;
            FirstRecIdField = firstRecIdField;
            GridDefinitions = gridDefinitions;
            Name = name;
            RecIdFields = recIdFields;
            Relationships = relationships;
            StateFieldId = stateFieldId;
            States = states;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            HasError = hasError;
            HttpStatusCode = httpStatusCode;
        }
        
        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }

        /// <summary>
        /// Gets or Sets FieldDefinitions
        /// </summary>
        [DataMember(Name="fieldDefinitions", EmitDefaultValue=false)]
        public List<FieldDefinition> FieldDefinitions { get; set; }

        /// <summary>
        /// Gets or Sets FirstRecIdField
        /// </summary>
        [DataMember(Name="firstRecIdField", EmitDefaultValue=false)]
        public string FirstRecIdField { get; set; }

        /// <summary>
        /// Gets or Sets GridDefinitions
        /// </summary>
        [DataMember(Name="gridDefinitions", EmitDefaultValue=false)]
        public List<GridDefinition> GridDefinitions { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RecIdFields
        /// </summary>
        [DataMember(Name="recIdFields", EmitDefaultValue=false)]
        public string RecIdFields { get; set; }

        /// <summary>
        /// Gets or Sets Relationships
        /// </summary>
        [DataMember(Name="relationships", EmitDefaultValue=false)]
        public List<Relationship> Relationships { get; set; }

        /// <summary>
        /// Gets or Sets StateFieldId
        /// </summary>
        [DataMember(Name="stateFieldId", EmitDefaultValue=false)]
        public string StateFieldId { get; set; }

        /// <summary>
        /// Gets or Sets States
        /// </summary>
        [DataMember(Name="states", EmitDefaultValue=false)]
        public string States { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets HasError
        /// </summary>
        [DataMember(Name="hasError", EmitDefaultValue=false)]
        public bool? HasError { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchemaResponse {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  FieldDefinitions: ").Append(FieldDefinitions).Append("\n");
            sb.Append("  FirstRecIdField: ").Append(FirstRecIdField).Append("\n");
            sb.Append("  GridDefinitions: ").Append(GridDefinitions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RecIdFields: ").Append(RecIdFields).Append("\n");
            sb.Append("  Relationships: ").Append(Relationships).Append("\n");
            sb.Append("  StateFieldId: ").Append(StateFieldId).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  HasError: ").Append(HasError).Append("\n");
            sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append("\n");
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
            return Equals(input as SchemaResponse);
        }

        /// <summary>
        /// Returns true if SchemaResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SchemaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchemaResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    BusObId == input.BusObId ||
                    (BusObId != null &&
                    BusObId.Equals(input.BusObId))
                ) && 
                (
                    FieldDefinitions == input.FieldDefinitions ||
                    FieldDefinitions != null &&
                    FieldDefinitions.SequenceEqual(input.FieldDefinitions)
                ) && 
                (
                    FirstRecIdField == input.FirstRecIdField ||
                    (FirstRecIdField != null &&
                    FirstRecIdField.Equals(input.FirstRecIdField))
                ) && 
                (
                    GridDefinitions == input.GridDefinitions ||
                    GridDefinitions != null &&
                    GridDefinitions.SequenceEqual(input.GridDefinitions)
                ) && 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    RecIdFields == input.RecIdFields ||
                    (RecIdFields != null &&
                    RecIdFields.Equals(input.RecIdFields))
                ) && 
                (
                    Relationships == input.Relationships ||
                    Relationships != null &&
                    Relationships.SequenceEqual(input.Relationships)
                ) && 
                (
                    StateFieldId == input.StateFieldId ||
                    (StateFieldId != null &&
                    StateFieldId.Equals(input.StateFieldId))
                ) && 
                (
                    States == input.States ||
                    (States != null &&
                    States.Equals(input.States))
                ) && 
                (
                    ErrorCode == input.ErrorCode ||
                    (ErrorCode != null &&
                    ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    ErrorMessage == input.ErrorMessage ||
                    (ErrorMessage != null &&
                    ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    HasError == input.HasError ||
                    (HasError != null &&
                    HasError.Equals(input.HasError))
                ) && 
                (
                    HttpStatusCode == input.HttpStatusCode ||
                    (HttpStatusCode != null &&
                    HttpStatusCode.Equals(input.HttpStatusCode))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (BusObId != null)
                    hashCode = hashCode * 59 + BusObId.GetHashCode();
                if (FieldDefinitions != null)
                    hashCode = hashCode * 59 + FieldDefinitions.GetHashCode();
                if (FirstRecIdField != null)
                    hashCode = hashCode * 59 + FirstRecIdField.GetHashCode();
                if (GridDefinitions != null)
                    hashCode = hashCode * 59 + GridDefinitions.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (RecIdFields != null)
                    hashCode = hashCode * 59 + RecIdFields.GetHashCode();
                if (Relationships != null)
                    hashCode = hashCode * 59 + Relationships.GetHashCode();
                if (StateFieldId != null)
                    hashCode = hashCode * 59 + StateFieldId.GetHashCode();
                if (States != null)
                    hashCode = hashCode * 59 + States.GetHashCode();
                if (ErrorCode != null)
                    hashCode = hashCode * 59 + ErrorCode.GetHashCode();
                if (ErrorMessage != null)
                    hashCode = hashCode * 59 + ErrorMessage.GetHashCode();
                if (HasError != null)
                    hashCode = hashCode * 59 + HasError.GetHashCode();
                if (HttpStatusCode != null)
                    hashCode = hashCode * 59 + HttpStatusCode.GetHashCode();
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
