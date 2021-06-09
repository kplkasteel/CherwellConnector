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
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// TrebuchetWebApiDataContractsBusinessObjectSchemaResponse
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsBusinessObjectSchemaResponse :  IEquatable<TrebuchetWebApiDataContractsBusinessObjectSchemaResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines HttpStatusCode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HttpStatusCodeEnum
        {
            
            /// <summary>
            /// Enum Continue for value: Continue
            /// </summary>
            [EnumMember(Value = "Continue")]
            Continue = 1,
            
            /// <summary>
            /// Enum SwitchingProtocols for value: SwitchingProtocols
            /// </summary>
            [EnumMember(Value = "SwitchingProtocols")]
            SwitchingProtocols = 2,
            
            /// <summary>
            /// Enum OK for value: OK
            /// </summary>
            [EnumMember(Value = "OK")]
            OK = 3,
            
            /// <summary>
            /// Enum Created for value: Created
            /// </summary>
            [EnumMember(Value = "Created")]
            Created = 4,
            
            /// <summary>
            /// Enum Accepted for value: Accepted
            /// </summary>
            [EnumMember(Value = "Accepted")]
            Accepted = 5,
            
            /// <summary>
            /// Enum NonAuthoritativeInformation for value: NonAuthoritativeInformation
            /// </summary>
            [EnumMember(Value = "NonAuthoritativeInformation")]
            NonAuthoritativeInformation = 6,
            
            /// <summary>
            /// Enum NoContent for value: NoContent
            /// </summary>
            [EnumMember(Value = "NoContent")]
            NoContent = 7,
            
            /// <summary>
            /// Enum ResetContent for value: ResetContent
            /// </summary>
            [EnumMember(Value = "ResetContent")]
            ResetContent = 8,
            
            /// <summary>
            /// Enum PartialContent for value: PartialContent
            /// </summary>
            [EnumMember(Value = "PartialContent")]
            PartialContent = 9,
            
            /// <summary>
            /// Enum MultipleChoices for value: MultipleChoices
            /// </summary>
            [EnumMember(Value = "MultipleChoices")]
            MultipleChoices = 10,
            
            /// <summary>
            /// Enum Ambiguous for value: Ambiguous
            /// </summary>
            [EnumMember(Value = "Ambiguous")]
            Ambiguous = 11,
            
            /// <summary>
            /// Enum MovedPermanently for value: MovedPermanently
            /// </summary>
            [EnumMember(Value = "MovedPermanently")]
            MovedPermanently = 12,
            
            /// <summary>
            /// Enum Moved for value: Moved
            /// </summary>
            [EnumMember(Value = "Moved")]
            Moved = 13,
            
            /// <summary>
            /// Enum Found for value: Found
            /// </summary>
            [EnumMember(Value = "Found")]
            Found = 14,
            
            /// <summary>
            /// Enum Redirect for value: Redirect
            /// </summary>
            [EnumMember(Value = "Redirect")]
            Redirect = 15,
            
            /// <summary>
            /// Enum SeeOther for value: SeeOther
            /// </summary>
            [EnumMember(Value = "SeeOther")]
            SeeOther = 16,
            
            /// <summary>
            /// Enum RedirectMethod for value: RedirectMethod
            /// </summary>
            [EnumMember(Value = "RedirectMethod")]
            RedirectMethod = 17,
            
            /// <summary>
            /// Enum NotModified for value: NotModified
            /// </summary>
            [EnumMember(Value = "NotModified")]
            NotModified = 18,
            
            /// <summary>
            /// Enum UseProxy for value: UseProxy
            /// </summary>
            [EnumMember(Value = "UseProxy")]
            UseProxy = 19,
            
            /// <summary>
            /// Enum Unused for value: Unused
            /// </summary>
            [EnumMember(Value = "Unused")]
            Unused = 20,
            
            /// <summary>
            /// Enum TemporaryRedirect for value: TemporaryRedirect
            /// </summary>
            [EnumMember(Value = "TemporaryRedirect")]
            TemporaryRedirect = 21,
            
            /// <summary>
            /// Enum RedirectKeepVerb for value: RedirectKeepVerb
            /// </summary>
            [EnumMember(Value = "RedirectKeepVerb")]
            RedirectKeepVerb = 22,
            
            /// <summary>
            /// Enum BadRequest for value: BadRequest
            /// </summary>
            [EnumMember(Value = "BadRequest")]
            BadRequest = 23,
            
            /// <summary>
            /// Enum Unauthorized for value: Unauthorized
            /// </summary>
            [EnumMember(Value = "Unauthorized")]
            Unauthorized = 24,
            
            /// <summary>
            /// Enum PaymentRequired for value: PaymentRequired
            /// </summary>
            [EnumMember(Value = "PaymentRequired")]
            PaymentRequired = 25,
            
            /// <summary>
            /// Enum Forbidden for value: Forbidden
            /// </summary>
            [EnumMember(Value = "Forbidden")]
            Forbidden = 26,
            
            /// <summary>
            /// Enum NotFound for value: NotFound
            /// </summary>
            [EnumMember(Value = "NotFound")]
            NotFound = 27,
            
            /// <summary>
            /// Enum MethodNotAllowed for value: MethodNotAllowed
            /// </summary>
            [EnumMember(Value = "MethodNotAllowed")]
            MethodNotAllowed = 28,
            
            /// <summary>
            /// Enum NotAcceptable for value: NotAcceptable
            /// </summary>
            [EnumMember(Value = "NotAcceptable")]
            NotAcceptable = 29,
            
            /// <summary>
            /// Enum ProxyAuthenticationRequired for value: ProxyAuthenticationRequired
            /// </summary>
            [EnumMember(Value = "ProxyAuthenticationRequired")]
            ProxyAuthenticationRequired = 30,
            
            /// <summary>
            /// Enum RequestTimeout for value: RequestTimeout
            /// </summary>
            [EnumMember(Value = "RequestTimeout")]
            RequestTimeout = 31,
            
            /// <summary>
            /// Enum Conflict for value: Conflict
            /// </summary>
            [EnumMember(Value = "Conflict")]
            Conflict = 32,
            
            /// <summary>
            /// Enum Gone for value: Gone
            /// </summary>
            [EnumMember(Value = "Gone")]
            Gone = 33,
            
            /// <summary>
            /// Enum LengthRequired for value: LengthRequired
            /// </summary>
            [EnumMember(Value = "LengthRequired")]
            LengthRequired = 34,
            
            /// <summary>
            /// Enum PreconditionFailed for value: PreconditionFailed
            /// </summary>
            [EnumMember(Value = "PreconditionFailed")]
            PreconditionFailed = 35,
            
            /// <summary>
            /// Enum RequestEntityTooLarge for value: RequestEntityTooLarge
            /// </summary>
            [EnumMember(Value = "RequestEntityTooLarge")]
            RequestEntityTooLarge = 36,
            
            /// <summary>
            /// Enum RequestUriTooLong for value: RequestUriTooLong
            /// </summary>
            [EnumMember(Value = "RequestUriTooLong")]
            RequestUriTooLong = 37,
            
            /// <summary>
            /// Enum UnsupportedMediaType for value: UnsupportedMediaType
            /// </summary>
            [EnumMember(Value = "UnsupportedMediaType")]
            UnsupportedMediaType = 38,
            
            /// <summary>
            /// Enum RequestedRangeNotSatisfiable for value: RequestedRangeNotSatisfiable
            /// </summary>
            [EnumMember(Value = "RequestedRangeNotSatisfiable")]
            RequestedRangeNotSatisfiable = 39,
            
            /// <summary>
            /// Enum ExpectationFailed for value: ExpectationFailed
            /// </summary>
            [EnumMember(Value = "ExpectationFailed")]
            ExpectationFailed = 40,
            
            /// <summary>
            /// Enum UpgradeRequired for value: UpgradeRequired
            /// </summary>
            [EnumMember(Value = "UpgradeRequired")]
            UpgradeRequired = 41,
            
            /// <summary>
            /// Enum InternalServerError for value: InternalServerError
            /// </summary>
            [EnumMember(Value = "InternalServerError")]
            InternalServerError = 42,
            
            /// <summary>
            /// Enum NotImplemented for value: NotImplemented
            /// </summary>
            [EnumMember(Value = "NotImplemented")]
            NotImplemented = 43,
            
            /// <summary>
            /// Enum BadGateway for value: BadGateway
            /// </summary>
            [EnumMember(Value = "BadGateway")]
            BadGateway = 44,
            
            /// <summary>
            /// Enum ServiceUnavailable for value: ServiceUnavailable
            /// </summary>
            [EnumMember(Value = "ServiceUnavailable")]
            ServiceUnavailable = 45,
            
            /// <summary>
            /// Enum GatewayTimeout for value: GatewayTimeout
            /// </summary>
            [EnumMember(Value = "GatewayTimeout")]
            GatewayTimeout = 46,
            
            /// <summary>
            /// Enum HttpVersionNotSupported for value: HttpVersionNotSupported
            /// </summary>
            [EnumMember(Value = "HttpVersionNotSupported")]
            HttpVersionNotSupported = 47
        }

        /// <summary>
        /// Gets or Sets HttpStatusCode
        /// </summary>
        [DataMember(Name="httpStatusCode", EmitDefaultValue=false)]
        public HttpStatusCodeEnum? HttpStatusCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsBusinessObjectSchemaResponse" /> class.
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
        public TrebuchetWebApiDataContractsBusinessObjectSchemaResponse(string busObId = default, List<FieldDefinition> fieldDefinitions = default, string firstRecIdField = default, List<TrebuchetWebApiDataContractsBusinessObjectGridDefinition> gridDefinitions = default, string name = default, string recIdFields = default, List<TrebuchetWebApiDataContractsBusinessObjectRelationship> relationships = default, string stateFieldId = default, string states = default, string errorCode = default, string errorMessage = default, bool? hasError = default, HttpStatusCodeEnum? httpStatusCode = default)
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
        public List<TrebuchetWebApiDataContractsBusinessObjectGridDefinition> GridDefinitions { get; set; }

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
        public List<TrebuchetWebApiDataContractsBusinessObjectRelationship> Relationships { get; set; }

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
            sb.Append("class TrebuchetWebApiDataContractsBusinessObjectSchemaResponse {\n");
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
            return Equals(input as TrebuchetWebApiDataContractsBusinessObjectSchemaResponse);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsBusinessObjectSchemaResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsBusinessObjectSchemaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsBusinessObjectSchemaResponse input)
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
