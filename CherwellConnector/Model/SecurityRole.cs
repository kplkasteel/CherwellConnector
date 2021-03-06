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
    ///     SecurityRole
    /// </summary>
    [DataContract]
    public sealed class SecurityRole : IEquatable<SecurityRole>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SecurityRole" /> class.
        /// </summary>
        /// <param name="browserClientCustomViewId">browserClientCustomViewId.</param>
        /// <param name="businessObjectExcludeList">businessObjectExcludeList.</param>
        /// <param name="culture">culture.</param>
        /// <param name="description">description.</param>
        /// <param name="mobileClientCustomViewId">mobileClientCustomViewId.</param>
        /// <param name="primaryBusObId">primaryBusObId.</param>
        /// <param name="roleId">roleId.</param>
        /// <param name="roleName">roleName.</param>
        /// <param name="smartClientCustomViewId">smartClientCustomViewId.</param>
        public SecurityRole(string browserClientCustomViewId = default,
            List<string> businessObjectExcludeList = default, string culture = default, string description = default,
            string mobileClientCustomViewId = default, string primaryBusObId = default, string roleId = default,
            string roleName = default, string smartClientCustomViewId = default)
        {
            BrowserClientCustomViewId = browserClientCustomViewId;
            BusinessObjectExcludeList = businessObjectExcludeList;
            Culture = culture;
            Description = description;
            MobileClientCustomViewId = mobileClientCustomViewId;
            PrimaryBusObId = primaryBusObId;
            RoleId = roleId;
            RoleName = roleName;
            SmartClientCustomViewId = smartClientCustomViewId;
        }

        /// <summary>
        ///     Gets or Sets BrowserClientCustomViewId
        /// </summary>
        [DataMember(Name = "browserClientCustomViewId", EmitDefaultValue = false)]
        public string BrowserClientCustomViewId { get; set; }

        /// <summary>
        ///     Gets or Sets BusinessObjectExcludeList
        /// </summary>
        [DataMember(Name = "businessObjectExcludeList", EmitDefaultValue = false)]
        public List<string> BusinessObjectExcludeList { get; set; }

        /// <summary>
        ///     Gets or Sets Culture
        /// </summary>
        [DataMember(Name = "culture", EmitDefaultValue = false)]
        public string Culture { get; set; }

        /// <summary>
        ///     Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        ///     Gets or Sets MobileClientCustomViewId
        /// </summary>
        [DataMember(Name = "mobileClientCustomViewId", EmitDefaultValue = false)]
        public string MobileClientCustomViewId { get; set; }

        /// <summary>
        ///     Gets or Sets PrimaryBusObId
        /// </summary>
        [DataMember(Name = "primaryBusObId", EmitDefaultValue = false)]
        public string PrimaryBusObId { get; set; }

        /// <summary>
        ///     Gets or Sets RoleId
        /// </summary>
        [DataMember(Name = "roleId", EmitDefaultValue = false)]
        public string RoleId { get; set; }

        /// <summary>
        ///     Gets or Sets RoleName
        /// </summary>
        [DataMember(Name = "roleName", EmitDefaultValue = false)]
        public string RoleName { get; set; }

        /// <summary>
        ///     Gets or Sets SmartClientCustomViewId
        /// </summary>
        [DataMember(Name = "smartClientCustomViewId", EmitDefaultValue = false)]
        public string SmartClientCustomViewId { get; set; }

        /// <summary>
        ///     Returns true if SecurityRole instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityRole input)
        {
            if (input == null)
                return false;

            return
                (
                    BrowserClientCustomViewId == input.BrowserClientCustomViewId ||
                    BrowserClientCustomViewId != null &&
                    BrowserClientCustomViewId.Equals(input.BrowserClientCustomViewId)
                ) &&
                (
                    BusinessObjectExcludeList == input.BusinessObjectExcludeList ||
                    BusinessObjectExcludeList != null &&
                    BusinessObjectExcludeList.SequenceEqual(input.BusinessObjectExcludeList)
                ) &&
                (
                    Culture == input.Culture ||
                    Culture != null &&
                    Culture.Equals(input.Culture)
                ) &&
                (
                    Description == input.Description ||
                    Description != null &&
                    Description.Equals(input.Description)
                ) &&
                (
                    MobileClientCustomViewId == input.MobileClientCustomViewId ||
                    MobileClientCustomViewId != null &&
                    MobileClientCustomViewId.Equals(input.MobileClientCustomViewId)
                ) &&
                (
                    PrimaryBusObId == input.PrimaryBusObId ||
                    PrimaryBusObId != null &&
                    PrimaryBusObId.Equals(input.PrimaryBusObId)
                ) &&
                (
                    RoleId == input.RoleId ||
                    RoleId != null &&
                    RoleId.Equals(input.RoleId)
                ) &&
                (
                    RoleName == input.RoleName ||
                    RoleName != null &&
                    RoleName.Equals(input.RoleName)
                ) &&
                (
                    SmartClientCustomViewId == input.SmartClientCustomViewId ||
                    SmartClientCustomViewId != null &&
                    SmartClientCustomViewId.Equals(input.SmartClientCustomViewId)
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
            sb.Append("class SecurityRole {\n");
            sb.Append("  BrowserClientCustomViewId: ").Append(BrowserClientCustomViewId).Append("\n");
            sb.Append("  BusinessObjectExcludeList: ").Append(BusinessObjectExcludeList).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MobileClientCustomViewId: ").Append(MobileClientCustomViewId).Append("\n");
            sb.Append("  PrimaryBusObId: ").Append(PrimaryBusObId).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  SmartClientCustomViewId: ").Append(SmartClientCustomViewId).Append("\n");
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
            return Equals(input as SecurityRole);
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
                if (BrowserClientCustomViewId != null)
                    hashCode = hashCode * 59 + BrowserClientCustomViewId.GetHashCode();
                if (BusinessObjectExcludeList != null)
                    hashCode = hashCode * 59 + BusinessObjectExcludeList.GetHashCode();
                if (Culture != null)
                    hashCode = hashCode * 59 + Culture.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (MobileClientCustomViewId != null)
                    hashCode = hashCode * 59 + MobileClientCustomViewId.GetHashCode();
                if (PrimaryBusObId != null)
                    hashCode = hashCode * 59 + PrimaryBusObId.GetHashCode();
                if (RoleId != null)
                    hashCode = hashCode * 59 + RoleId.GetHashCode();
                if (RoleName != null)
                    hashCode = hashCode * 59 + RoleName.GetHashCode();
                if (SmartClientCustomViewId != null)
                    hashCode = hashCode * 59 + SmartClientCustomViewId.GetHashCode();
                return hashCode;
            }
        }
    }
}