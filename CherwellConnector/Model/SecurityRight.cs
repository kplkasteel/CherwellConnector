
namespace CherwellConnector.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// SecurityRight
    /// </summary>
    [DataContract]
    public sealed class SecurityRight :  IEquatable<SecurityRight>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityRight" /> class.
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
        public SecurityRight(bool? add = default, bool? allow = default, string categoryDescription = default, string categoryId = default, string categoryName = default, bool? delete = default, bool? edit = default, bool? isYesNoRight = default, bool? nonScopeOwnerAdd = default, bool? nonScopeOwnerDelete = default, bool? nonScopeOwnerEdit = default, bool? nonScopeOwnerView = default, string rightId = default, string rightName = default, string standardRightName = default, bool? viewRunOpen = default)
        {
            Add = add;
            Allow = allow;
            CategoryDescription = categoryDescription;
            CategoryId = categoryId;
            CategoryName = categoryName;
            Delete = delete;
            Edit = edit;
            IsYesNoRight = isYesNoRight;
            NonScopeOwnerAdd = nonScopeOwnerAdd;
            NonScopeOwnerDelete = nonScopeOwnerDelete;
            NonScopeOwnerEdit = nonScopeOwnerEdit;
            NonScopeOwnerView = nonScopeOwnerView;
            RightId = rightId;
            RightName = rightName;
            StandardRightName = standardRightName;
            ViewRunOpen = viewRunOpen;
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
            sb.Append("class SecurityRight {\n");
            sb.Append("  Add: ").Append(Add).Append("\n");
            sb.Append("  Allow: ").Append(Allow).Append("\n");
            sb.Append("  CategoryDescription: ").Append(CategoryDescription).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
            sb.Append("  Edit: ").Append(Edit).Append("\n");
            sb.Append("  IsYesNoRight: ").Append(IsYesNoRight).Append("\n");
            sb.Append("  NonScopeOwnerAdd: ").Append(NonScopeOwnerAdd).Append("\n");
            sb.Append("  NonScopeOwnerDelete: ").Append(NonScopeOwnerDelete).Append("\n");
            sb.Append("  NonScopeOwnerEdit: ").Append(NonScopeOwnerEdit).Append("\n");
            sb.Append("  NonScopeOwnerView: ").Append(NonScopeOwnerView).Append("\n");
            sb.Append("  RightId: ").Append(RightId).Append("\n");
            sb.Append("  RightName: ").Append(RightName).Append("\n");
            sb.Append("  StandardRightName: ").Append(StandardRightName).Append("\n");
            sb.Append("  ViewRunOpen: ").Append(ViewRunOpen).Append("\n");
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
            return Equals(input as SecurityRight);
        }

        /// <summary>
        /// Returns true if SecurityRight instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityRight to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityRight input)
        {
            if (input == null)
                return false;

            return 
                (
                    Add == input.Add ||
                    (Add != null &&
                    Add.Equals(input.Add))
                ) && 
                (
                    Allow == input.Allow ||
                    (Allow != null &&
                    Allow.Equals(input.Allow))
                ) && 
                (
                    CategoryDescription == input.CategoryDescription ||
                    (CategoryDescription != null &&
                    CategoryDescription.Equals(input.CategoryDescription))
                ) && 
                (
                    CategoryId == input.CategoryId ||
                    (CategoryId != null &&
                    CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    CategoryName == input.CategoryName ||
                    (CategoryName != null &&
                    CategoryName.Equals(input.CategoryName))
                ) && 
                (
                    Delete == input.Delete ||
                    (Delete != null &&
                    Delete.Equals(input.Delete))
                ) && 
                (
                    Edit == input.Edit ||
                    (Edit != null &&
                    Edit.Equals(input.Edit))
                ) && 
                (
                    IsYesNoRight == input.IsYesNoRight ||
                    (IsYesNoRight != null &&
                    IsYesNoRight.Equals(input.IsYesNoRight))
                ) && 
                (
                    NonScopeOwnerAdd == input.NonScopeOwnerAdd ||
                    (NonScopeOwnerAdd != null &&
                    NonScopeOwnerAdd.Equals(input.NonScopeOwnerAdd))
                ) && 
                (
                    NonScopeOwnerDelete == input.NonScopeOwnerDelete ||
                    (NonScopeOwnerDelete != null &&
                    NonScopeOwnerDelete.Equals(input.NonScopeOwnerDelete))
                ) && 
                (
                    NonScopeOwnerEdit == input.NonScopeOwnerEdit ||
                    (NonScopeOwnerEdit != null &&
                    NonScopeOwnerEdit.Equals(input.NonScopeOwnerEdit))
                ) && 
                (
                    NonScopeOwnerView == input.NonScopeOwnerView ||
                    (NonScopeOwnerView != null &&
                    NonScopeOwnerView.Equals(input.NonScopeOwnerView))
                ) && 
                (
                    RightId == input.RightId ||
                    (RightId != null &&
                    RightId.Equals(input.RightId))
                ) && 
                (
                    RightName == input.RightName ||
                    (RightName != null &&
                    RightName.Equals(input.RightName))
                ) && 
                (
                    StandardRightName == input.StandardRightName ||
                    (StandardRightName != null &&
                    StandardRightName.Equals(input.StandardRightName))
                ) && 
                (
                    ViewRunOpen == input.ViewRunOpen ||
                    (ViewRunOpen != null &&
                    ViewRunOpen.Equals(input.ViewRunOpen))
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
                if (Add != null)
                    hashCode = hashCode * 59 + Add.GetHashCode();
                if (Allow != null)
                    hashCode = hashCode * 59 + Allow.GetHashCode();
                if (CategoryDescription != null)
                    hashCode = hashCode * 59 + CategoryDescription.GetHashCode();
                if (CategoryId != null)
                    hashCode = hashCode * 59 + CategoryId.GetHashCode();
                if (CategoryName != null)
                    hashCode = hashCode * 59 + CategoryName.GetHashCode();
                if (Delete != null)
                    hashCode = hashCode * 59 + Delete.GetHashCode();
                if (Edit != null)
                    hashCode = hashCode * 59 + Edit.GetHashCode();
                if (IsYesNoRight != null)
                    hashCode = hashCode * 59 + IsYesNoRight.GetHashCode();
                if (NonScopeOwnerAdd != null)
                    hashCode = hashCode * 59 + NonScopeOwnerAdd.GetHashCode();
                if (NonScopeOwnerDelete != null)
                    hashCode = hashCode * 59 + NonScopeOwnerDelete.GetHashCode();
                if (NonScopeOwnerEdit != null)
                    hashCode = hashCode * 59 + NonScopeOwnerEdit.GetHashCode();
                if (NonScopeOwnerView != null)
                    hashCode = hashCode * 59 + NonScopeOwnerView.GetHashCode();
                if (RightId != null)
                    hashCode = hashCode * 59 + RightId.GetHashCode();
                if (RightName != null)
                    hashCode = hashCode * 59 + RightName.GetHashCode();
                if (StandardRightName != null)
                    hashCode = hashCode * 59 + StandardRightName.GetHashCode();
                if (ViewRunOpen != null)
                    hashCode = hashCode * 59 + ViewRunOpen.GetHashCode();
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
