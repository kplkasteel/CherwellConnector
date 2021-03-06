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
    ///     UserSaveV2Request
    /// </summary>
    [DataContract]
    public sealed class UserSaveV2Request : IEquatable<UserSaveV2Request>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UserSaveV2Request" /> class.
        /// </summary>
        /// <param name="accountLocked">accountLocked.</param>
        /// <param name="allCultures">allCultures.</param>
        /// <param name="busObId">busObId.</param>
        /// <param name="busObPublicId">busObPublicId.</param>
        /// <param name="busObRecId">busObRecId.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="ldapRequired">ldapRequired.</param>
        /// <param name="loginId">loginId.</param>
        /// <param name="nextPasswordResetDate">nextPasswordResetDate.</param>
        /// <param name="password">password.</param>
        /// <param name="passwordNeverExpires">passwordNeverExpires.</param>
        /// <param name="securityGroupId">securityGroupId.</param>
        /// <param name="specificCulture">specificCulture.</param>
        /// <param name="userCannotChangePassword">userCannotChangePassword.</param>
        /// <param name="userInfoFields">userInfoFields.</param>
        /// <param name="userMustChangePasswordAtNextLogin">userMustChangePasswordAtNextLogin.</param>
        /// <param name="windowsUserId">windowsUserId.</param>
        public UserSaveV2Request(bool? accountLocked = default, bool? allCultures = default, string busObId = default,
            string busObPublicId = default, string busObRecId = default, string displayName = default,
            bool? ldapRequired = default, string loginId = default, DateTime? nextPasswordResetDate = default,
            string password = default, bool? passwordNeverExpires = default, string securityGroupId = default,
            string specificCulture = default, bool? userCannotChangePassword = default,
            List<FieldTemplateItem> userInfoFields = default, bool? userMustChangePasswordAtNextLogin = default,
            string windowsUserId = default)
        {
            AccountLocked = accountLocked;
            AllCultures = allCultures;
            BusObId = busObId;
            BusObPublicId = busObPublicId;
            BusObRecId = busObRecId;
            DisplayName = displayName;
            LdapRequired = ldapRequired;
            LoginId = loginId;
            NextPasswordResetDate = nextPasswordResetDate;
            Password = password;
            PasswordNeverExpires = passwordNeverExpires;
            SecurityGroupId = securityGroupId;
            SpecificCulture = specificCulture;
            UserCannotChangePassword = userCannotChangePassword;
            UserInfoFields = userInfoFields;
            UserMustChangePasswordAtNextLogin = userMustChangePasswordAtNextLogin;
            WindowsUserId = windowsUserId;
        }

        /// <summary>
        ///     Gets or Sets AccountLocked
        /// </summary>
        [DataMember(Name = "accountLocked", EmitDefaultValue = false)]
        public bool? AccountLocked { get; set; }

        /// <summary>
        ///     Gets or Sets AllCultures
        /// </summary>
        [DataMember(Name = "allCultures", EmitDefaultValue = false)]
        public bool? AllCultures { get; set; }

        /// <summary>
        ///     Gets or Sets BusObId
        /// </summary>
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }

        /// <summary>
        ///     Gets or Sets BusObPublicId
        /// </summary>
        [DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
        public string BusObPublicId { get; set; }

        /// <summary>
        ///     Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
        public string BusObRecId { get; set; }

        /// <summary>
        ///     Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        ///     Gets or Sets LdapRequired
        /// </summary>
        [DataMember(Name = "ldapRequired", EmitDefaultValue = false)]
        public bool? LdapRequired { get; set; }

        /// <summary>
        ///     Gets or Sets LoginId
        /// </summary>
        [DataMember(Name = "loginId", EmitDefaultValue = false)]
        public string LoginId { get; set; }

        /// <summary>
        ///     Gets or Sets NextPasswordResetDate
        /// </summary>
        [DataMember(Name = "nextPasswordResetDate", EmitDefaultValue = false)]
        public DateTime? NextPasswordResetDate { get; set; }

        /// <summary>
        ///     Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        ///     Gets or Sets PasswordNeverExpires
        /// </summary>
        [DataMember(Name = "passwordNeverExpires", EmitDefaultValue = false)]
        public bool? PasswordNeverExpires { get; set; }

        /// <summary>
        ///     Gets or Sets SecurityGroupId
        /// </summary>
        [DataMember(Name = "securityGroupId", EmitDefaultValue = false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        ///     Gets or Sets SpecificCulture
        /// </summary>
        [DataMember(Name = "specificCulture", EmitDefaultValue = false)]
        public string SpecificCulture { get; set; }

        /// <summary>
        ///     Gets or Sets UserCannotChangePassword
        /// </summary>
        [DataMember(Name = "userCannotChangePassword", EmitDefaultValue = false)]
        public bool? UserCannotChangePassword { get; set; }

        /// <summary>
        ///     Gets or Sets UserInfoFields
        /// </summary>
        [DataMember(Name = "userInfoFields", EmitDefaultValue = false)]
        public List<FieldTemplateItem> UserInfoFields { get; set; }

        /// <summary>
        ///     Gets or Sets UserMustChangePasswordAtNextLogin
        /// </summary>
        [DataMember(Name = "userMustChangePasswordAtNextLogin", EmitDefaultValue = false)]
        public bool? UserMustChangePasswordAtNextLogin { get; set; }

        /// <summary>
        ///     Gets or Sets WindowsUserId
        /// </summary>
        [DataMember(Name = "windowsUserId", EmitDefaultValue = false)]
        public string WindowsUserId { get; set; }

        /// <summary>
        ///     Returns true if UserSaveV2Request instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSaveV2Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSaveV2Request input)
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
                    AllCultures == input.AllCultures ||
                    AllCultures != null &&
                    AllCultures.Equals(input.AllCultures)
                ) &&
                (
                    BusObId == input.BusObId ||
                    BusObId != null &&
                    BusObId.Equals(input.BusObId)
                ) &&
                (
                    BusObPublicId == input.BusObPublicId ||
                    BusObPublicId != null &&
                    BusObPublicId.Equals(input.BusObPublicId)
                ) &&
                (
                    BusObRecId == input.BusObRecId ||
                    BusObRecId != null &&
                    BusObRecId.Equals(input.BusObRecId)
                ) &&
                (
                    DisplayName == input.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(input.DisplayName)
                ) &&
                (
                    LdapRequired == input.LdapRequired ||
                    LdapRequired != null &&
                    LdapRequired.Equals(input.LdapRequired)
                ) &&
                (
                    LoginId == input.LoginId ||
                    LoginId != null &&
                    LoginId.Equals(input.LoginId)
                ) &&
                (
                    NextPasswordResetDate == input.NextPasswordResetDate ||
                    NextPasswordResetDate != null &&
                    NextPasswordResetDate.Equals(input.NextPasswordResetDate)
                ) &&
                (
                    Password == input.Password ||
                    Password != null &&
                    Password.Equals(input.Password)
                ) &&
                (
                    PasswordNeverExpires == input.PasswordNeverExpires ||
                    PasswordNeverExpires != null &&
                    PasswordNeverExpires.Equals(input.PasswordNeverExpires)
                ) &&
                (
                    SecurityGroupId == input.SecurityGroupId ||
                    SecurityGroupId != null &&
                    SecurityGroupId.Equals(input.SecurityGroupId)
                ) &&
                (
                    SpecificCulture == input.SpecificCulture ||
                    SpecificCulture != null &&
                    SpecificCulture.Equals(input.SpecificCulture)
                ) &&
                (
                    UserCannotChangePassword == input.UserCannotChangePassword ||
                    UserCannotChangePassword != null &&
                    UserCannotChangePassword.Equals(input.UserCannotChangePassword)
                ) &&
                (
                    UserInfoFields == input.UserInfoFields ||
                    UserInfoFields != null &&
                    UserInfoFields.SequenceEqual(input.UserInfoFields)
                ) &&
                (
                    UserMustChangePasswordAtNextLogin == input.UserMustChangePasswordAtNextLogin ||
                    UserMustChangePasswordAtNextLogin != null &&
                    UserMustChangePasswordAtNextLogin.Equals(input.UserMustChangePasswordAtNextLogin)
                ) &&
                (
                    WindowsUserId == input.WindowsUserId ||
                    WindowsUserId != null &&
                    WindowsUserId.Equals(input.WindowsUserId)
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
            sb.Append("class UserSaveV2Request {\n");
            sb.Append("  AccountLocked: ").Append(AccountLocked).Append("\n");
            sb.Append("  AllCultures: ").Append(AllCultures).Append("\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  LdapRequired: ").Append(LdapRequired).Append("\n");
            sb.Append("  LoginId: ").Append(LoginId).Append("\n");
            sb.Append("  NextPasswordResetDate: ").Append(NextPasswordResetDate).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PasswordNeverExpires: ").Append(PasswordNeverExpires).Append("\n");
            sb.Append("  SecurityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  SpecificCulture: ").Append(SpecificCulture).Append("\n");
            sb.Append("  UserCannotChangePassword: ").Append(UserCannotChangePassword).Append("\n");
            sb.Append("  UserInfoFields: ").Append(UserInfoFields).Append("\n");
            sb.Append("  UserMustChangePasswordAtNextLogin: ").Append(UserMustChangePasswordAtNextLogin).Append("\n");
            sb.Append("  WindowsUserId: ").Append(WindowsUserId).Append("\n");
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
            return Equals(input as UserSaveV2Request);
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
                if (AllCultures != null)
                    hashCode = hashCode * 59 + AllCultures.GetHashCode();
                if (BusObId != null)
                    hashCode = hashCode * 59 + BusObId.GetHashCode();
                if (BusObPublicId != null)
                    hashCode = hashCode * 59 + BusObPublicId.GetHashCode();
                if (BusObRecId != null)
                    hashCode = hashCode * 59 + BusObRecId.GetHashCode();
                if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                if (LdapRequired != null)
                    hashCode = hashCode * 59 + LdapRequired.GetHashCode();
                if (LoginId != null)
                    hashCode = hashCode * 59 + LoginId.GetHashCode();
                if (NextPasswordResetDate != null)
                    hashCode = hashCode * 59 + NextPasswordResetDate.GetHashCode();
                if (Password != null)
                    hashCode = hashCode * 59 + Password.GetHashCode();
                if (PasswordNeverExpires != null)
                    hashCode = hashCode * 59 + PasswordNeverExpires.GetHashCode();
                if (SecurityGroupId != null)
                    hashCode = hashCode * 59 + SecurityGroupId.GetHashCode();
                if (SpecificCulture != null)
                    hashCode = hashCode * 59 + SpecificCulture.GetHashCode();
                if (UserCannotChangePassword != null)
                    hashCode = hashCode * 59 + UserCannotChangePassword.GetHashCode();
                if (UserInfoFields != null)
                    hashCode = hashCode * 59 + UserInfoFields.GetHashCode();
                if (UserMustChangePasswordAtNextLogin != null)
                    hashCode = hashCode * 59 + UserMustChangePasswordAtNextLogin.GetHashCode();
                if (WindowsUserId != null)
                    hashCode = hashCode * 59 + WindowsUserId.GetHashCode();
                return hashCode;
            }
        }
    }
}