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
    /// TrebuchetWebApiDataContractsUsersUserV2
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsUsersUserV2 :  IEquatable<TrebuchetWebApiDataContractsUsersUserV2>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsUsersUserV2" /> class.
        /// </summary>
        /// <param name="accountLocked">accountLocked.</param>
        /// <param name="createDateTime">createDateTime.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="fields">fields.</param>
        /// <param name="lastPasswordResetDate">lastPasswordResetDate.</param>
        /// <param name="lastResetDateTime">lastResetDateTime.</param>
        /// <param name="ldapRequired">ldapRequired.</param>
        /// <param name="passwordNeverExpires">passwordNeverExpires.</param>
        /// <param name="publicId">publicId.</param>
        /// <param name="recordId">recordId.</param>
        /// <param name="securityGroupId">securityGroupId.</param>
        /// <param name="shortDisplayName">shortDisplayName.</param>
        /// <param name="userCannotChangePassword">userCannotChangePassword.</param>
        /// <param name="userMustResetPasswordAtNextLogin">userMustResetPasswordAtNextLogin.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="hasError">hasError.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        public TrebuchetWebApiDataContractsUsersUserV2(bool? accountLocked = default(bool?), DateTime? createDateTime = default(DateTime?), string displayName = default(string), List<TrebuchetWebApiDataContractsBusinessObjectFieldTemplateItem> fields = default(List<TrebuchetWebApiDataContractsBusinessObjectFieldTemplateItem>), DateTime? lastPasswordResetDate = default(DateTime?), DateTime? lastResetDateTime = default(DateTime?), bool? ldapRequired = default(bool?), bool? passwordNeverExpires = default(bool?), string publicId = default(string), string recordId = default(string), string securityGroupId = default(string), string shortDisplayName = default(string), bool? userCannotChangePassword = default(bool?), bool? userMustResetPasswordAtNextLogin = default(bool?), string errorCode = default(string), string errorMessage = default(string), bool? hasError = default(bool?), HttpStatusCodeEnum? httpStatusCode = default(HttpStatusCodeEnum?))
        {
            this.AccountLocked = accountLocked;
            this.CreateDateTime = createDateTime;
            this.DisplayName = displayName;
            this.Fields = fields;
            this.LastPasswordResetDate = lastPasswordResetDate;
            this.LastResetDateTime = lastResetDateTime;
            this.LdapRequired = ldapRequired;
            this.PasswordNeverExpires = passwordNeverExpires;
            this.PublicId = publicId;
            this.RecordId = recordId;
            this.SecurityGroupId = securityGroupId;
            this.ShortDisplayName = shortDisplayName;
            this.UserCannotChangePassword = userCannotChangePassword;
            this.UserMustResetPasswordAtNextLogin = userMustResetPasswordAtNextLogin;
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.HasError = hasError;
            this.HttpStatusCode = httpStatusCode;
        }
        
        /// <summary>
        /// Gets or Sets AccountLocked
        /// </summary>
        [DataMember(Name="accountLocked", EmitDefaultValue=false)]
        public bool? AccountLocked { get; set; }

        /// <summary>
        /// Gets or Sets CreateDateTime
        /// </summary>
        [DataMember(Name="createDateTime", EmitDefaultValue=false)]
        public DateTime? CreateDateTime { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<TrebuchetWebApiDataContractsBusinessObjectFieldTemplateItem> Fields { get; set; }

        /// <summary>
        /// Gets or Sets LastPasswordResetDate
        /// </summary>
        [DataMember(Name="lastPasswordResetDate", EmitDefaultValue=false)]
        public DateTime? LastPasswordResetDate { get; set; }

        /// <summary>
        /// Gets or Sets LastResetDateTime
        /// </summary>
        [DataMember(Name="lastResetDateTime", EmitDefaultValue=false)]
        public DateTime? LastResetDateTime { get; set; }

        /// <summary>
        /// Gets or Sets LdapRequired
        /// </summary>
        [DataMember(Name="ldapRequired", EmitDefaultValue=false)]
        public bool? LdapRequired { get; set; }

        /// <summary>
        /// Gets or Sets PasswordNeverExpires
        /// </summary>
        [DataMember(Name="passwordNeverExpires", EmitDefaultValue=false)]
        public bool? PasswordNeverExpires { get; set; }

        /// <summary>
        /// Gets or Sets PublicId
        /// </summary>
        [DataMember(Name="publicId", EmitDefaultValue=false)]
        public string PublicId { get; set; }

        /// <summary>
        /// Gets or Sets RecordId
        /// </summary>
        [DataMember(Name="recordId", EmitDefaultValue=false)]
        public string RecordId { get; set; }

        /// <summary>
        /// Gets or Sets SecurityGroupId
        /// </summary>
        [DataMember(Name="securityGroupId", EmitDefaultValue=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// Gets or Sets ShortDisplayName
        /// </summary>
        [DataMember(Name="shortDisplayName", EmitDefaultValue=false)]
        public string ShortDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets UserCannotChangePassword
        /// </summary>
        [DataMember(Name="userCannotChangePassword", EmitDefaultValue=false)]
        public bool? UserCannotChangePassword { get; set; }

        /// <summary>
        /// Gets or Sets UserMustResetPasswordAtNextLogin
        /// </summary>
        [DataMember(Name="userMustResetPasswordAtNextLogin", EmitDefaultValue=false)]
        public bool? UserMustResetPasswordAtNextLogin { get; set; }

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
            sb.Append("class TrebuchetWebApiDataContractsUsersUserV2 {\n");
            sb.Append("  AccountLocked: ").Append(this.AccountLocked).Append("\n");
            sb.Append("  CreateDateTime: ").Append(this.CreateDateTime).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  Fields: ").Append(this.Fields).Append("\n");
            sb.Append("  LastPasswordResetDate: ").Append(this.LastPasswordResetDate).Append("\n");
            sb.Append("  LastResetDateTime: ").Append(this.LastResetDateTime).Append("\n");
            sb.Append("  LdapRequired: ").Append(this.LdapRequired).Append("\n");
            sb.Append("  PasswordNeverExpires: ").Append(this.PasswordNeverExpires).Append("\n");
            sb.Append("  PublicId: ").Append(this.PublicId).Append("\n");
            sb.Append("  RecordId: ").Append(this.RecordId).Append("\n");
            sb.Append("  SecurityGroupId: ").Append(this.SecurityGroupId).Append("\n");
            sb.Append("  ShortDisplayName: ").Append(this.ShortDisplayName).Append("\n");
            sb.Append("  UserCannotChangePassword: ").Append(this.UserCannotChangePassword).Append("\n");
            sb.Append("  UserMustResetPasswordAtNextLogin: ").Append(this.UserMustResetPasswordAtNextLogin).Append("\n");
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
            return this.Equals(input as TrebuchetWebApiDataContractsUsersUserV2);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsUsersUserV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsUsersUserV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsUsersUserV2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountLocked == input.AccountLocked ||
                    (this.AccountLocked != null &&
                    this.AccountLocked.Equals(input.AccountLocked))
                ) && 
                (
                    this.CreateDateTime == input.CreateDateTime ||
                    (this.CreateDateTime != null &&
                    this.CreateDateTime.Equals(input.CreateDateTime))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.LastPasswordResetDate == input.LastPasswordResetDate ||
                    (this.LastPasswordResetDate != null &&
                    this.LastPasswordResetDate.Equals(input.LastPasswordResetDate))
                ) && 
                (
                    this.LastResetDateTime == input.LastResetDateTime ||
                    (this.LastResetDateTime != null &&
                    this.LastResetDateTime.Equals(input.LastResetDateTime))
                ) && 
                (
                    this.LdapRequired == input.LdapRequired ||
                    (this.LdapRequired != null &&
                    this.LdapRequired.Equals(input.LdapRequired))
                ) && 
                (
                    this.PasswordNeverExpires == input.PasswordNeverExpires ||
                    (this.PasswordNeverExpires != null &&
                    this.PasswordNeverExpires.Equals(input.PasswordNeverExpires))
                ) && 
                (
                    this.PublicId == input.PublicId ||
                    (this.PublicId != null &&
                    this.PublicId.Equals(input.PublicId))
                ) && 
                (
                    this.RecordId == input.RecordId ||
                    (this.RecordId != null &&
                    this.RecordId.Equals(input.RecordId))
                ) && 
                (
                    this.SecurityGroupId == input.SecurityGroupId ||
                    (this.SecurityGroupId != null &&
                    this.SecurityGroupId.Equals(input.SecurityGroupId))
                ) && 
                (
                    this.ShortDisplayName == input.ShortDisplayName ||
                    (this.ShortDisplayName != null &&
                    this.ShortDisplayName.Equals(input.ShortDisplayName))
                ) && 
                (
                    this.UserCannotChangePassword == input.UserCannotChangePassword ||
                    (this.UserCannotChangePassword != null &&
                    this.UserCannotChangePassword.Equals(input.UserCannotChangePassword))
                ) && 
                (
                    this.UserMustResetPasswordAtNextLogin == input.UserMustResetPasswordAtNextLogin ||
                    (this.UserMustResetPasswordAtNextLogin != null &&
                    this.UserMustResetPasswordAtNextLogin.Equals(input.UserMustResetPasswordAtNextLogin))
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
                if (this.AccountLocked != null)
                    hashCode = hashCode * 59 + this.AccountLocked.GetHashCode();
                if (this.CreateDateTime != null)
                    hashCode = hashCode * 59 + this.CreateDateTime.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.LastPasswordResetDate != null)
                    hashCode = hashCode * 59 + this.LastPasswordResetDate.GetHashCode();
                if (this.LastResetDateTime != null)
                    hashCode = hashCode * 59 + this.LastResetDateTime.GetHashCode();
                if (this.LdapRequired != null)
                    hashCode = hashCode * 59 + this.LdapRequired.GetHashCode();
                if (this.PasswordNeverExpires != null)
                    hashCode = hashCode * 59 + this.PasswordNeverExpires.GetHashCode();
                if (this.PublicId != null)
                    hashCode = hashCode * 59 + this.PublicId.GetHashCode();
                if (this.RecordId != null)
                    hashCode = hashCode * 59 + this.RecordId.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.ShortDisplayName != null)
                    hashCode = hashCode * 59 + this.ShortDisplayName.GetHashCode();
                if (this.UserCannotChangePassword != null)
                    hashCode = hashCode * 59 + this.UserCannotChangePassword.GetHashCode();
                if (this.UserMustResetPasswordAtNextLogin != null)
                    hashCode = hashCode * 59 + this.UserMustResetPasswordAtNextLogin.GetHashCode();
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
