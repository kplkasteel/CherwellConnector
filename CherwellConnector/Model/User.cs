using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CherwellConnector.Model
{
    /// <summary>
    ///     User
    /// </summary>
    [DataContract]
    public sealed class User : IEquatable<User>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="accountLocked">accountLocked.</param>
        /// <param name="createDateTime">createDateTime.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="error">error.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="fields">fields.</param>
        /// <param name="hasError">hasError.</param>
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
        public User(bool? accountLocked = default, DateTime? createDateTime = default, string displayName = default,
            string error = default, string errorCode = default, List<FieldTemplateItem> fields = default,
            bool? hasError = default, DateTime? lastPasswordResetDate = default, DateTime? lastResetDateTime = default,
            bool? ldapRequired = default, bool? passwordNeverExpires = default, string publicId = default,
            string recordId = default, string securityGroupId = default, string shortDisplayName = default,
            bool? userCannotChangePassword = default, bool? userMustResetPasswordAtNextLogin = default)
        {
            AccountLocked = accountLocked;
            CreateDateTime = createDateTime;
            DisplayName = displayName;
            Error = error;
            ErrorCode = errorCode;
            Fields = fields;
            HasError = hasError;
            LastPasswordResetDate = lastPasswordResetDate;
            LastResetDateTime = lastResetDateTime;
            LdapRequired = ldapRequired;
            PasswordNeverExpires = passwordNeverExpires;
            PublicId = publicId;
            RecordId = recordId;
            SecurityGroupId = securityGroupId;
            ShortDisplayName = shortDisplayName;
            UserCannotChangePassword = userCannotChangePassword;
            UserMustResetPasswordAtNextLogin = userMustResetPasswordAtNextLogin;
        }

        /// <summary>
        ///     Gets or Sets AccountLocked
        /// </summary>
        [DataMember(Name = "accountLocked", EmitDefaultValue = false)]
        public bool? AccountLocked { get; set; }

        /// <summary>
        ///     Gets or Sets CreateDateTime
        /// </summary>
        [DataMember(Name = "createDateTime", EmitDefaultValue = false)]
        public DateTime? CreateDateTime { get; set; }

        /// <summary>
        ///     Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        ///     Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        ///     Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        ///     Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public List<FieldTemplateItem> Fields { get; set; }

        /// <summary>
        ///     Gets or Sets HasError
        /// </summary>
        [DataMember(Name = "hasError", EmitDefaultValue = false)]
        public bool? HasError { get; set; }

        /// <summary>
        ///     Gets or Sets LastPasswordResetDate
        /// </summary>
        [DataMember(Name = "lastPasswordResetDate", EmitDefaultValue = false)]
        public DateTime? LastPasswordResetDate { get; set; }

        /// <summary>
        ///     Gets or Sets LastResetDateTime
        /// </summary>
        [DataMember(Name = "lastResetDateTime", EmitDefaultValue = false)]
        public DateTime? LastResetDateTime { get; set; }

        /// <summary>
        ///     Gets or Sets LdapRequired
        /// </summary>
        [DataMember(Name = "ldapRequired", EmitDefaultValue = false)]
        public bool? LdapRequired { get; set; }

        /// <summary>
        ///     Gets or Sets PasswordNeverExpires
        /// </summary>
        [DataMember(Name = "passwordNeverExpires", EmitDefaultValue = false)]
        public bool? PasswordNeverExpires { get; set; }

        /// <summary>
        ///     Gets or Sets PublicId
        /// </summary>
        [DataMember(Name = "publicId", EmitDefaultValue = false)]
        public string PublicId { get; set; }

        /// <summary>
        ///     Gets or Sets RecordId
        /// </summary>
        [DataMember(Name = "recordId", EmitDefaultValue = false)]
        public string RecordId { get; set; }

        /// <summary>
        ///     Gets or Sets SecurityGroupId
        /// </summary>
        [DataMember(Name = "securityGroupId", EmitDefaultValue = false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        ///     Gets or Sets ShortDisplayName
        /// </summary>
        [DataMember(Name = "shortDisplayName", EmitDefaultValue = false)]
        public string ShortDisplayName { get; set; }

        /// <summary>
        ///     Gets or Sets UserCannotChangePassword
        /// </summary>
        [DataMember(Name = "userCannotChangePassword", EmitDefaultValue = false)]
        public bool? UserCannotChangePassword { get; set; }

        /// <summary>
        ///     Gets or Sets UserMustResetPasswordAtNextLogin
        /// </summary>
        [DataMember(Name = "userMustResetPasswordAtNextLogin", EmitDefaultValue = false)]
        public bool? UserMustResetPasswordAtNextLogin { get; set; }

        /// <summary>
        ///     Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            if (input == null)
                return false;

            return
                (
                    AccountLocked == input.AccountLocked ||
                    AccountLocked != null &&
                    AccountLocked.Equals(input.AccountLocked)
                ) &&
                (
                    CreateDateTime == input.CreateDateTime ||
                    CreateDateTime != null &&
                    CreateDateTime.Equals(input.CreateDateTime)
                ) &&
                (
                    DisplayName == input.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(input.DisplayName)
                ) &&
                (
                    Error == input.Error ||
                    Error != null &&
                    Error.Equals(input.Error)
                ) &&
                (
                    ErrorCode == input.ErrorCode ||
                    ErrorCode != null &&
                    ErrorCode.Equals(input.ErrorCode)
                ) &&
                (
                    Fields == input.Fields ||
                    Fields != null &&
                    Fields.SequenceEqual(input.Fields)
                ) &&
                (
                    HasError == input.HasError ||
                    HasError != null &&
                    HasError.Equals(input.HasError)
                ) &&
                (
                    LastPasswordResetDate == input.LastPasswordResetDate ||
                    LastPasswordResetDate != null &&
                    LastPasswordResetDate.Equals(input.LastPasswordResetDate)
                ) &&
                (
                    LastResetDateTime == input.LastResetDateTime ||
                    LastResetDateTime != null &&
                    LastResetDateTime.Equals(input.LastResetDateTime)
                ) &&
                (
                    LdapRequired == input.LdapRequired ||
                    LdapRequired != null &&
                    LdapRequired.Equals(input.LdapRequired)
                ) &&
                (
                    PasswordNeverExpires == input.PasswordNeverExpires ||
                    PasswordNeverExpires != null &&
                    PasswordNeverExpires.Equals(input.PasswordNeverExpires)
                ) &&
                (
                    PublicId == input.PublicId ||
                    PublicId != null &&
                    PublicId.Equals(input.PublicId)
                ) &&
                (
                    RecordId == input.RecordId ||
                    RecordId != null &&
                    RecordId.Equals(input.RecordId)
                ) &&
                (
                    SecurityGroupId == input.SecurityGroupId ||
                    SecurityGroupId != null &&
                    SecurityGroupId.Equals(input.SecurityGroupId)
                ) &&
                (
                    ShortDisplayName == input.ShortDisplayName ||
                    ShortDisplayName != null &&
                    ShortDisplayName.Equals(input.ShortDisplayName)
                ) &&
                (
                    UserCannotChangePassword == input.UserCannotChangePassword ||
                    UserCannotChangePassword != null &&
                    UserCannotChangePassword.Equals(input.UserCannotChangePassword)
                ) &&
                (
                    UserMustResetPasswordAtNextLogin == input.UserMustResetPasswordAtNextLogin ||
                    UserMustResetPasswordAtNextLogin != null &&
                    UserMustResetPasswordAtNextLogin.Equals(input.UserMustResetPasswordAtNextLogin)
                );
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  AccountLocked: ").Append(AccountLocked).Append("\n");
            sb.Append("  CreateDateTime: ").Append(CreateDateTime).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  HasError: ").Append(HasError).Append("\n");
            sb.Append("  LastPasswordResetDate: ").Append(LastPasswordResetDate).Append("\n");
            sb.Append("  LastResetDateTime: ").Append(LastResetDateTime).Append("\n");
            sb.Append("  LdapRequired: ").Append(LdapRequired).Append("\n");
            sb.Append("  PasswordNeverExpires: ").Append(PasswordNeverExpires).Append("\n");
            sb.Append("  PublicId: ").Append(PublicId).Append("\n");
            sb.Append("  RecordId: ").Append(RecordId).Append("\n");
            sb.Append("  SecurityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  ShortDisplayName: ").Append(ShortDisplayName).Append("\n");
            sb.Append("  UserCannotChangePassword: ").Append(UserCannotChangePassword).Append("\n");
            sb.Append("  UserMustResetPasswordAtNextLogin: ").Append(UserMustResetPasswordAtNextLogin).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as User);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (AccountLocked != null)
                    hashCode = hashCode * 59 + AccountLocked.GetHashCode();
                if (CreateDateTime != null)
                    hashCode = hashCode * 59 + CreateDateTime.GetHashCode();
                if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                if (Error != null)
                    hashCode = hashCode * 59 + Error.GetHashCode();
                if (ErrorCode != null)
                    hashCode = hashCode * 59 + ErrorCode.GetHashCode();
                if (Fields != null)
                    hashCode = hashCode * 59 + Fields.GetHashCode();
                if (HasError != null)
                    hashCode = hashCode * 59 + HasError.GetHashCode();
                if (LastPasswordResetDate != null)
                    hashCode = hashCode * 59 + LastPasswordResetDate.GetHashCode();
                if (LastResetDateTime != null)
                    hashCode = hashCode * 59 + LastResetDateTime.GetHashCode();
                if (LdapRequired != null)
                    hashCode = hashCode * 59 + LdapRequired.GetHashCode();
                if (PasswordNeverExpires != null)
                    hashCode = hashCode * 59 + PasswordNeverExpires.GetHashCode();
                if (PublicId != null)
                    hashCode = hashCode * 59 + PublicId.GetHashCode();
                if (RecordId != null)
                    hashCode = hashCode * 59 + RecordId.GetHashCode();
                if (SecurityGroupId != null)
                    hashCode = hashCode * 59 + SecurityGroupId.GetHashCode();
                if (ShortDisplayName != null)
                    hashCode = hashCode * 59 + ShortDisplayName.GetHashCode();
                if (UserCannotChangePassword != null)
                    hashCode = hashCode * 59 + UserCannotChangePassword.GetHashCode();
                if (UserMustResetPasswordAtNextLogin != null)
                    hashCode = hashCode * 59 + UserMustResetPasswordAtNextLogin.GetHashCode();
                return hashCode;
            }
        }
    }
}