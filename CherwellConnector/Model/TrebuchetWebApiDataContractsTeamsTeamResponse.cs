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
    /// TrebuchetWebApiDataContractsTeamsTeamResponse
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsTeamsTeamResponse :  IEquatable<TrebuchetWebApiDataContractsTeamsTeamResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines TeamType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TeamTypeEnum
        {
            
            /// <summary>
            /// Enum User for value: User
            /// </summary>
            [EnumMember(Value = "User")]
            User = 1,
            
            /// <summary>
            /// Enum CustomerWorkgroup for value: CustomerWorkgroup
            /// </summary>
            [EnumMember(Value = "CustomerWorkgroup")]
            CustomerWorkgroup = 2
        }

        /// <summary>
        /// Gets or Sets TeamType
        /// </summary>
        [DataMember(Name="teamType", EmitDefaultValue=false)]
        public TeamTypeEnum? TeamType { get; set; }
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
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsTeamsTeamResponse" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="emailAlias">emailAlias.</param>
        /// <param name="fields">fields.</param>
        /// <param name="image">image.</param>
        /// <param name="name">name.</param>
        /// <param name="teamId">teamId.</param>
        /// <param name="teamType">teamType.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public TrebuchetWebApiDataContractsTeamsTeamResponse(string description = default(string), string emailAlias = default(string), List<TrebuchetWebApiDataContractsBusinessObjectFieldTemplateItem> fields = default(List<TrebuchetWebApiDataContractsBusinessObjectFieldTemplateItem>), string image = default(string), string name = default(string), string teamId = default(string), TeamTypeEnum? teamType = default(TeamTypeEnum?), string errorCode = default(string), string errorMessage = default(string), bool? hasError = default(bool?), HttpStatusCodeEnum? httpStatusCode = default(HttpStatusCodeEnum?))
        {
            this.Description = description;
            this.EmailAlias = emailAlias;
            this.Fields = fields;
            this.Image = image;
            this.Name = name;
            this.TeamId = teamId;
            this.TeamType = teamType;
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.HasError = hasError;
            this.HttpStatusCode = httpStatusCode;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets EmailAlias
        /// </summary>
        [DataMember(Name="emailAlias", EmitDefaultValue=false)]
        public string EmailAlias { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<TrebuchetWebApiDataContractsBusinessObjectFieldTemplateItem> Fields { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }


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
            sb.Append("class TrebuchetWebApiDataContractsTeamsTeamResponse {\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  EmailAlias: ").Append(this.EmailAlias).Append("\n");
            sb.Append("  Fields: ").Append(this.Fields).Append("\n");
            sb.Append("  Image: ").Append(this.Image).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  TeamId: ").Append(this.TeamId).Append("\n");
            sb.Append("  TeamType: ").Append(this.TeamType).Append("\n");
            sb.Append("  ErrorCode: ").Append(this.ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(this.ErrorMessage).Append("\n");
            sb.Append("  HasError: ").Append(this.HasError).Append("\n");
            sb.Append("  HttpStatusCode: ").Append(this.HttpStatusCode).Append("\n");
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
            return this.Equals(input as TrebuchetWebApiDataContractsTeamsTeamResponse);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsTeamsTeamResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsTeamsTeamResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsTeamsTeamResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EmailAlias == input.EmailAlias ||
                    (this.EmailAlias != null &&
                    this.EmailAlias.Equals(input.EmailAlias))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TeamId == input.TeamId ||
                    (this.TeamId != null &&
                    this.TeamId.Equals(input.TeamId))
                ) && 
                (
                    this.TeamType == input.TeamType ||
                    (this.TeamType != null &&
                    this.TeamType.Equals(input.TeamType))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.HasError == input.HasError ||
                    (this.HasError != null &&
                    this.HasError.Equals(input.HasError))
                ) && 
                (
                    this.HttpStatusCode == input.HttpStatusCode ||
                    (this.HttpStatusCode != null &&
                    this.HttpStatusCode.Equals(input.HttpStatusCode))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EmailAlias != null)
                    hashCode = hashCode * 59 + this.EmailAlias.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TeamId != null)
                    hashCode = hashCode * 59 + this.TeamId.GetHashCode();
                if (this.TeamType != null)
                    hashCode = hashCode * 59 + this.TeamType.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.HasError != null)
                    hashCode = hashCode * 59 + this.HasError.GetHashCode();
                if (this.HttpStatusCode != null)
                    hashCode = hashCode * 59 + this.HttpStatusCode.GetHashCode();
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