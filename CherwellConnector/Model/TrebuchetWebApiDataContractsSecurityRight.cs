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
    /// TrebuchetWebApiDataContractsSecurityRight
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsSecurityRight :  IEquatable<TrebuchetWebApiDataContractsSecurityRight>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsSecurityRight" /> class.
        /// </summary>
        /// <param name="add">add.</param>
        /// <param name="allow">allow.</param>
        /// <param name="categoryDescription">categoryDescription.</param>
        /// <param name="categoryId">categoryId.</param>
        /// <param name="categoryName">categoryName.</param>
        /// <param name="delete">delete.</param>
        /// <param name="edit">edit.</param>
        /// <param name="isYesNoRight">isYesNoRight.</param>
        /// <param name="nonScopeOwnerAdd">nonScopeOwnerAdd.</param>
        /// <param name="nonScopeOwnerDelete">nonScopeOwnerDelete.</param>
        /// <param name="nonScopeOwnerEdit">nonScopeOwnerEdit.</param>
        /// <param name="nonScopeOwnerView">nonScopeOwnerView.</param>
        /// <param name="rightId">rightId.</param>
        /// <param name="rightName">rightName.</param>
        /// <param name="standardRightName">standardRightName.</param>
        /// <param name="viewRunOpen">viewRunOpen.</param>
        public TrebuchetWebApiDataContractsSecurityRight(bool? add = default(bool?), bool? allow = default(bool?), string categoryDescription = default(string), string categoryId = default(string), string categoryName = default(string), bool? delete = default(bool?), bool? edit = default(bool?), bool? isYesNoRight = default(bool?), bool? nonScopeOwnerAdd = default(bool?), bool? nonScopeOwnerDelete = default(bool?), bool? nonScopeOwnerEdit = default(bool?), bool? nonScopeOwnerView = default(bool?), string rightId = default(string), string rightName = default(string), string standardRightName = default(string), bool? viewRunOpen = default(bool?))
        {
            this.Add = add;
            this.Allow = allow;
            this.CategoryDescription = categoryDescription;
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
            this.Delete = delete;
            this.Edit = edit;
            this.IsYesNoRight = isYesNoRight;
            this.NonScopeOwnerAdd = nonScopeOwnerAdd;
            this.NonScopeOwnerDelete = nonScopeOwnerDelete;
            this.NonScopeOwnerEdit = nonScopeOwnerEdit;
            this.NonScopeOwnerView = nonScopeOwnerView;
            this.RightId = rightId;
            this.RightName = rightName;
            this.StandardRightName = standardRightName;
            this.ViewRunOpen = viewRunOpen;
        }
        
        /// <summary>
        /// Gets or Sets Add
        /// </summary>
        [DataMember(Name="add", EmitDefaultValue=false)]
        public bool? Add { get; set; }

        /// <summary>
        /// Gets or Sets Allow
        /// </summary>
        [DataMember(Name="allow", EmitDefaultValue=false)]
        public bool? Allow { get; set; }

        /// <summary>
        /// Gets or Sets CategoryDescription
        /// </summary>
        [DataMember(Name="categoryDescription", EmitDefaultValue=false)]
        public string CategoryDescription { get; set; }

        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name="categoryId", EmitDefaultValue=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// Gets or Sets CategoryName
        /// </summary>
        [DataMember(Name="categoryName", EmitDefaultValue=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or Sets Delete
        /// </summary>
        [DataMember(Name="delete", EmitDefaultValue=false)]
        public bool? Delete { get; set; }

        /// <summary>
        /// Gets or Sets Edit
        /// </summary>
        [DataMember(Name="edit", EmitDefaultValue=false)]
        public bool? Edit { get; set; }

        /// <summary>
        /// Gets or Sets IsYesNoRight
        /// </summary>
        [DataMember(Name="isYesNoRight", EmitDefaultValue=false)]
        public bool? IsYesNoRight { get; set; }

        /// <summary>
        /// Gets or Sets NonScopeOwnerAdd
        /// </summary>
        [DataMember(Name="nonScopeOwnerAdd", EmitDefaultValue=false)]
        public bool? NonScopeOwnerAdd { get; set; }

        /// <summary>
        /// Gets or Sets NonScopeOwnerDelete
        /// </summary>
        [DataMember(Name="nonScopeOwnerDelete", EmitDefaultValue=false)]
        public bool? NonScopeOwnerDelete { get; set; }

        /// <summary>
        /// Gets or Sets NonScopeOwnerEdit
        /// </summary>
        [DataMember(Name="nonScopeOwnerEdit", EmitDefaultValue=false)]
        public bool? NonScopeOwnerEdit { get; set; }

        /// <summary>
        /// Gets or Sets NonScopeOwnerView
        /// </summary>
        [DataMember(Name="nonScopeOwnerView", EmitDefaultValue=false)]
        public bool? NonScopeOwnerView { get; set; }

        /// <summary>
        /// Gets or Sets RightId
        /// </summary>
        [DataMember(Name="rightId", EmitDefaultValue=false)]
        public string RightId { get; set; }

        /// <summary>
        /// Gets or Sets RightName
        /// </summary>
        [DataMember(Name="rightName", EmitDefaultValue=false)]
        public string RightName { get; set; }

        /// <summary>
        /// Gets or Sets StandardRightName
        /// </summary>
        [DataMember(Name="standardRightName", EmitDefaultValue=false)]
        public string StandardRightName { get; set; }

        /// <summary>
        /// Gets or Sets ViewRunOpen
        /// </summary>
        [DataMember(Name="viewRunOpen", EmitDefaultValue=false)]
        public bool? ViewRunOpen { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsSecurityRight {\n");
            sb.Append("  Add: ").Append(this.Add).Append("\n");
            sb.Append("  Allow: ").Append(this.Allow).Append("\n");
            sb.Append("  CategoryDescription: ").Append(this.CategoryDescription).Append("\n");
            sb.Append("  CategoryId: ").Append(this.CategoryId).Append("\n");
            sb.Append("  CategoryName: ").Append(this.CategoryName).Append("\n");
            sb.Append("  Delete: ").Append(this.Delete).Append("\n");
            sb.Append("  Edit: ").Append(this.Edit).Append("\n");
            sb.Append("  IsYesNoRight: ").Append(this.IsYesNoRight).Append("\n");
            sb.Append("  NonScopeOwnerAdd: ").Append(this.NonScopeOwnerAdd).Append("\n");
            sb.Append("  NonScopeOwnerDelete: ").Append(this.NonScopeOwnerDelete).Append("\n");
            sb.Append("  NonScopeOwnerEdit: ").Append(this.NonScopeOwnerEdit).Append("\n");
            sb.Append("  NonScopeOwnerView: ").Append(this.NonScopeOwnerView).Append("\n");
            sb.Append("  RightId: ").Append(this.RightId).Append("\n");
            sb.Append("  RightName: ").Append(this.RightName).Append("\n");
            sb.Append("  StandardRightName: ").Append(this.StandardRightName).Append("\n");
            sb.Append("  ViewRunOpen: ").Append(this.ViewRunOpen).Append("\n");
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
            return this.Equals(input as TrebuchetWebApiDataContractsSecurityRight);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsSecurityRight instances are equal
        /// </summary>
        /// <param name="input">Instance of TrebuchetWebApiDataContractsSecurityRight to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsSecurityRight input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Add == input.Add ||
                    (this.Add != null &&
                    this.Add.Equals(input.Add))
                ) && 
                (
                    this.Allow == input.Allow ||
                    (this.Allow != null &&
                    this.Allow.Equals(input.Allow))
                ) && 
                (
                    this.CategoryDescription == input.CategoryDescription ||
                    (this.CategoryDescription != null &&
                    this.CategoryDescription.Equals(input.CategoryDescription))
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
                ) && 
                (
                    this.Delete == input.Delete ||
                    (this.Delete != null &&
                    this.Delete.Equals(input.Delete))
                ) && 
                (
                    this.Edit == input.Edit ||
                    (this.Edit != null &&
                    this.Edit.Equals(input.Edit))
                ) && 
                (
                    this.IsYesNoRight == input.IsYesNoRight ||
                    (this.IsYesNoRight != null &&
                    this.IsYesNoRight.Equals(input.IsYesNoRight))
                ) && 
                (
                    this.NonScopeOwnerAdd == input.NonScopeOwnerAdd ||
                    (this.NonScopeOwnerAdd != null &&
                    this.NonScopeOwnerAdd.Equals(input.NonScopeOwnerAdd))
                ) && 
                (
                    this.NonScopeOwnerDelete == input.NonScopeOwnerDelete ||
                    (this.NonScopeOwnerDelete != null &&
                    this.NonScopeOwnerDelete.Equals(input.NonScopeOwnerDelete))
                ) && 
                (
                    this.NonScopeOwnerEdit == input.NonScopeOwnerEdit ||
                    (this.NonScopeOwnerEdit != null &&
                    this.NonScopeOwnerEdit.Equals(input.NonScopeOwnerEdit))
                ) && 
                (
                    this.NonScopeOwnerView == input.NonScopeOwnerView ||
                    (this.NonScopeOwnerView != null &&
                    this.NonScopeOwnerView.Equals(input.NonScopeOwnerView))
                ) && 
                (
                    this.RightId == input.RightId ||
                    (this.RightId != null &&
                    this.RightId.Equals(input.RightId))
                ) && 
                (
                    this.RightName == input.RightName ||
                    (this.RightName != null &&
                    this.RightName.Equals(input.RightName))
                ) && 
                (
                    this.StandardRightName == input.StandardRightName ||
                    (this.StandardRightName != null &&
                    this.StandardRightName.Equals(input.StandardRightName))
                ) && 
                (
                    this.ViewRunOpen == input.ViewRunOpen ||
                    (this.ViewRunOpen != null &&
                    this.ViewRunOpen.Equals(input.ViewRunOpen))
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
                if (this.Add != null)
                    hashCode = hashCode * 59 + this.Add.GetHashCode();
                if (this.Allow != null)
                    hashCode = hashCode * 59 + this.Allow.GetHashCode();
                if (this.CategoryDescription != null)
                    hashCode = hashCode * 59 + this.CategoryDescription.GetHashCode();
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.CategoryName != null)
                    hashCode = hashCode * 59 + this.CategoryName.GetHashCode();
                if (this.Delete != null)
                    hashCode = hashCode * 59 + this.Delete.GetHashCode();
                if (this.Edit != null)
                    hashCode = hashCode * 59 + this.Edit.GetHashCode();
                if (this.IsYesNoRight != null)
                    hashCode = hashCode * 59 + this.IsYesNoRight.GetHashCode();
                if (this.NonScopeOwnerAdd != null)
                    hashCode = hashCode * 59 + this.NonScopeOwnerAdd.GetHashCode();
                if (this.NonScopeOwnerDelete != null)
                    hashCode = hashCode * 59 + this.NonScopeOwnerDelete.GetHashCode();
                if (this.NonScopeOwnerEdit != null)
                    hashCode = hashCode * 59 + this.NonScopeOwnerEdit.GetHashCode();
                if (this.NonScopeOwnerView != null)
                    hashCode = hashCode * 59 + this.NonScopeOwnerView.GetHashCode();
                if (this.RightId != null)
                    hashCode = hashCode * 59 + this.RightId.GetHashCode();
                if (this.RightName != null)
                    hashCode = hashCode * 59 + this.RightName.GetHashCode();
                if (this.StandardRightName != null)
                    hashCode = hashCode * 59 + this.StandardRightName.GetHashCode();
                if (this.ViewRunOpen != null)
                    hashCode = hashCode * 59 + this.ViewRunOpen.GetHashCode();
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
